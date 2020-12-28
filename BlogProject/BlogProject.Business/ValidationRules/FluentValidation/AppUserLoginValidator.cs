using BlogProject.DTO.DTOs.AppUserDtos;
using FluentValidation;

namespace BlogProject.Business.ValidationRules.FluentValidation
{
    public class AppUserLoginValidator : AbstractValidator<AppUserLoginDto>
    {
        public AppUserLoginValidator()
        {
            RuleFor(I => I.UserName).NotEmpty().WithMessage("kullanıcı adı boş geçilemez");
            RuleFor(I => I.Password).NotEmpty().WithMessage("parola alanı boş geçilemez");
        }
    }
}
