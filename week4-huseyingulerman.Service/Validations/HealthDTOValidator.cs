using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.DTOs.Create;

namespace week4_huseyingulerman.Service.Validations
{
    public class HealthDTOValidator: AbstractValidator<HealthCreateDTO>
    {
        public HealthDTOValidator()
        {
            RuleFor(x=>x.Situation).MaximumLength(50).WithMessage("Sağlık maksimum 50 karakter olmalıdır.")
                .NotNull().WithMessage("Sağlık alanı boş geçilemez.").NotEmpty().WithMessage("Sağlık alanı boş geçilemez.");

            RuleFor(x => x.PetId)
              .NotNull().WithMessage("Evcil hayvan alanı boş geçilemez.").NotEmpty().WithMessage("Evcil hayvan alanı boş geçilemez.");
        }
    }
}
