using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.Application.AuthOperations.Commands;
using UnluCo.NetBootcamp.BitirmeProjesi.Application.AuthOperations.Commands.Login;
using UnluCo.NetBootcamp.BitirmeProjesi.Application.AuthOperations.Commands.Register;
using UnluCo.NetBootcamp.BitirmeProjesi.Application.SecurityOperations.JWT;
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;
using UnluCo.NetBootcamp.BitirmeProjesi.Models;
using UnluCo.NetBootcamp.BitirmeProjesi.Services;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly FinalProjectDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ITokenHelper _tokenHelper;
        private readonly IMailSenderService _mailSender;
        private readonly IRabbitMqProducer _rabbitMqProducer;

        public AuthController(FinalProjectDbContext dbContext, IMapper mapper, ITokenHelper tokenHelper, IMailSenderService mailSender, IRabbitMqProducer rabbitMqProducer)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _tokenHelper = tokenHelper;
            _mailSender = mailSender;
            _rabbitMqProducer = rabbitMqProducer;
        }
        [HttpPost("register")]
        public IActionResult Register([FromBody] UserForRegisterModel Model)
        {
            RegisterCommand command = new RegisterCommand(_dbContext, _mapper,_tokenHelper, _mailSender,_rabbitMqProducer);
            command.Model = Model;
            RegisterCommandValidator validator = new RegisterCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok(new ResultModel { Message="Kayıt işlemi gerçekleşti." });
        }
        [HttpPost("login")]
        public IActionResult Login([FromBody] UserForLoginModel Model)
        {
            LoginCommand command = new LoginCommand(_dbContext, _mapper, _tokenHelper, _mailSender,_rabbitMqProducer);
            command.Model = Model;
            LoginCommandValidator validator = new LoginCommandValidator();
            validator.ValidateAndThrow(command);
            var token = command.Handle();
            return Ok(token);
        }
    }
}
