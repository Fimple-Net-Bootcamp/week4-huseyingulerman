using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.DTOs.Create;

namespace week4_huseyingulerman.Service.Validations
{
    public class TrainingDTOValidator : AbstractValidator<TrainingCreateDTO>
    {
        public TrainingDTOValidator()
        {
            RuleFor(x=>x.Name).MaximumLength(50).WithMessage("İsim maksimum 50 karakter olmalıdır.")
                .NotNull().WithMessage("İsim alanı boş geçilemez.").NotEmpty().WithMessage("İsim alanı boş geçilemez.");
        }
    }
}
