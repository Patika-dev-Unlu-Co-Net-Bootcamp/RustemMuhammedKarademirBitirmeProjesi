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

namespace UnluCo.NetBootcamp.BitirmeProjesi.Application.AuthOperations.Commands.Login
{
    public class LoginCommand
    {
        public UserForLoginModel Model { get; set; }
        private readonly FinalProjectDbContext _dbContext;
        private readonly IMailSenderService _mailSender;
        private readonly IMapper _mapper;
        private readonly ITokenHelper _tokenHelper;
        private readonly IRabbitMqProducer _rabbitMqProducer;
        private static int counter=0;
        private static string tempEmail = "";

        public LoginCommand(FinalProjectDbContext dbContext, IMapper mapper, ITokenHelper tokenHelper, IMailSenderService mailSender, IRabbitMqProducer rabbitMqProducer)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _tokenHelper = tokenHelper;
            _mailSender = mailSender;
            _rabbitMqProducer = rabbitMqProducer;

        }
        public AccessToken Handle()//UserForLoginModel userForLoginModel, string password
        {
            var user = _dbContext.Users.SingleOrDefault(x => x.Email == Model.Email);
            if (user == null)
            {
                throw new InvalidOperationException("Email sistemde kayıtlı değil!");
            }
            if (user.Status == false)
            {
                throw new InvalidOperationException("Hesap bloke edilmiş!");
            }
            if (user.Email != tempEmail) counter = 0;
            tempEmail = user.Email;
            if (!HashingHelper.VerifyPasswordHash(Model.Password, user.PasswordHash, user.PasswordSalt))
            {
                counter++;
                if (counter > 2)
                {
                    user.Status = false;
                    string message = "3 kez hatalı şifre girdiniz. Hesap bloke edildi. Sistem Yöneticisine başvurunuz.";
                    _rabbitMqProducer.QueueDeclare(new EmailModel { Email = user.Email, Body = message });
                    //_mailSender.SendEmail(message,user.Email);
                    _dbContext.SaveChanges();
                    throw new InvalidOperationException("3 kez hatalı şifre girdiniz. Hesap bloke edildi!");
                }
                throw new InvalidOperationException("Şifre hatalı!");
            }
            counter = 0;
            var claims = GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return accessToken;
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
