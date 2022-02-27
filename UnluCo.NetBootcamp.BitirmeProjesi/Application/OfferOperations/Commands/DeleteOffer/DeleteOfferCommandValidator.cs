using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Application.OfferOperations.Commands.DeleteOffer
{
    public class DeleteOfferCommandValidator : AbstractValidator<DeleteOfferCommand>
    {
        public DeleteOfferCommandValidator()
        {
            RuleFor(o => o.offerId).NotEmpty();
        }
    }
}
