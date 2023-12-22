using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.DTOs.Create;
using week4_huseyingulerman.Core.Entities;

namespace week4_huseyingulerman.Service.Validations
{
    public class PetDTOValidator:AbstractValidator<PetCreateDTO>
    {
        public PetDTOValidator()
        {
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("İsim maksimum 50 karakter olmalıdır.").NotNull().WithMessage("İsim alanı boş geçilemez.").NotEmpty().WithMessage("İsim alanı boş geçilemez.");
            RuleFor(x=>x.AppUserId).NotNull().WithMessage("Kullanıcı alanı boş geçilemez.").NotEmpty().WithMessage("Kullanıcı alanı boş geçilemez.");
        }
    }
}
