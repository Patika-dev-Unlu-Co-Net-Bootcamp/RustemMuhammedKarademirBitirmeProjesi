using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.Entities;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Application.CategoryOperations.Commands.UpdateCategory
{
    public class UpdateCategoryCommandValidator : AbstractValidator<UpdateCategoryCommand>
    {
        public UpdateCategoryCommandValidator()
        {
            RuleFor(c => c.Model.CategoryName).MinimumLength(1).When(x => x.Model.CategoryName != string.Empty);
        }
    }
}
