using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Application.OfferOperations.Commands.CreateOffer
{
    public class CreateOfferCommandValidator : AbstractValidator<CreateOfferCommand>
    {
        public CreateOfferCommandValidator()
        {
            RuleFor(o => o.Model.ProductId).NotEmpty();
            RuleFor(o => o.Model.UserId).NotEmpty();
            RuleFor(o => o.Model.OfferedPrice).NotEmpty().GreaterThan(0);
        }
    }
}
