using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.Entities;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Application.ProductOperations.Commands.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(p => p.Model.BrandId).NotEmpty();
            RuleFor(p => p.Model.ColorId).NotEmpty();
            RuleFor(p => p.Model.CategoryId).NotEmpty();
            RuleFor(p => p.Model.ProductName).NotEmpty().MaximumLength(100);
            RuleFor(p => p.Model.Description).NotEmpty().MaximumLength(500);
            RuleFor(p => p.Model.UseStateId).NotEmpty();
            RuleFor(p => p.Model.Price).NotEmpty();
        }
    }
}
