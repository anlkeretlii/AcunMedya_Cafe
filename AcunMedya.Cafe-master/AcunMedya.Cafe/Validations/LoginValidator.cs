using AcunMedya.Cafe.Entities;
using FluentValidation;

namespace AcunMedya.Cafe.Validations
{
    public class LoginValidator : AbstractValidator<User>
    {
        public LoginValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı boş geçilemez").
            MinimumLength(3).WithMessage("Kullanıcı Adı en az 3 karakter olmalıdır");     
            
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez").
            MinimumLength(6).WithMessage("Şifre en az 3 karakter olmalıdır");



        }
    }
}