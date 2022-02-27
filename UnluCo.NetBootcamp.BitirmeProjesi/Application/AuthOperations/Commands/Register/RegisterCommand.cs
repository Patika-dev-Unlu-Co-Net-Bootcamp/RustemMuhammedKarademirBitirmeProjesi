using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.Application.SecurityOperations.Hashing;
using UnluCo.NetBootcamp.BitirmeProjesi.Application.SecurityOperations.JWT;
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;
using UnluCo.NetBootcamp.BitirmeProjesi.Entities;
using UnluCo.NetBootcamp.BitirmeProjesi.Models;
using UnluCo.NetBootcamp.BitirmeProjesi.Services;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Application.AuthOperations.Commands.Register
{
    public class RegisterCommand
    {
        public UserForRegisterModel Model { get; set; }
        private readonly FinalProjectDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ITokenHelper _tokenHelper;
        private readonly IMailSenderService _mailSender;
        private readonly IRabbitMqProducer _rabbitMqProducer;

        public RegisterCommand(FinalProjectDbContext dbContext, IMapper mapper, ITokenHelper tokenHelper, IMailSenderService mailSender, IRabbitMqProducer rabbitMqProducer)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _tokenHelper = tokenHelper;
            _mailSender = mailSender;
            _rabbitMqProducer = rabbitMqProducer;
        }
        public void Handle()//UserForRegisterModel userForRegisterModel, string password
        {
            if (_dbContext.Users.Any(x => x.Email == Model.Email))
            {
                throw new InvalidOperationException("Bu email ile kayıtlı kullanıcı bulunmaktadır!");
            }

            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(Model.Password, out passwordHash, out passwordSalt);
            var user = _mapper.Map<User>(Model);
            user.Email = Model.Email;
            user.FirstName = Model.FirstName;
            user.LastName = Model.LastName;
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            user.Status = true;
            _dbContext.Add(user);
            var claims = GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            _dbContext.SaveChanges();
            string message = "Hoşgeldiniz,Kaydınız başarılı oldu.";
            _rabbitMqProducer.QueueDeclare(new EmailModel { Email=user.Email, Body=message });
        }
        public List<OperationClaim> GetClaims(User user)
        {
            var result = from operationClaim in _dbContext.OperationClaims
                             join userOperationClaim in _dbContext.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
            return result.ToList();
        }
    }
}
