using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Application.AuthOperations.Commands.Login
{
    public class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandValidator()
        {
            RuleFor(command => command.Model.Email).NotEmpty().EmailAddress().WithMessage("Email alanı boş geçilemez!");
            RuleFor(command => command.Model.Password).MinimumLength(8).MaximumLength(20).WithMessage("Şifre en az 8 en fazla 20 karakter olmalı!");
        }
    }
}
