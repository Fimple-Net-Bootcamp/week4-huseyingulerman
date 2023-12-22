using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.DTOs.Create;

namespace week4_huseyingulerman.Service.Validations
{
    public class UserDTOValidator : AbstractValidator<UserCreateDTO>
    {
        public UserDTOValidator()
        {
            RuleFor(x => x.Email).EmailAddress().WithMessage("Doğru Email girişi yapınız.").NotNull().WithMessage("Email alanı boş geçilemez.").NotEmpty().WithMessage("Email alanı boş geçilemez.");

            RuleFor(x=>x.UserName).MaximumLength(50).WithMessage("UserName maksimum 50 karakter olmalıdır.")
                .NotNull().WithMessage("UserName alanı boş geçilemez.").NotEmpty().WithMessage("UserName alanı boş geçilemez.");

      
        }
    }
}
