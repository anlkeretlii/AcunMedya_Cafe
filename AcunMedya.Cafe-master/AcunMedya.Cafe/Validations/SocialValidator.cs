using AcunMedya.Cafe.Entities;
using FluentValidation;

namespace AcunMedya.Cafe.Validations
{
    public class SocialValidator : AbstractValidator<Social>
    {
        public SocialValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Sosyal Medya Başlığı boş geçilemez")
                .MinimumLength(2).WithMessage("Sosyal Medya Başlığı en az 2 karakter olmalıdır")
                .MaximumLength(30).WithMessage("Sosyal Medya Başlığı en fazla 30 karakter olabilir");

            RuleFor(x => x.AccountUrl)
                .NotEmpty().WithMessage("Sosyal Medya Linki boş geçilemez")
                .Must(BeAValidUrl).WithMessage("Geçerli bir URL giriniz");

            RuleFor(x => x.IconUrl)
                .NotEmpty().WithMessage("İkon URL'i boş geçilemez");
        }

        private bool BeAValidUrl(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out _);
        }
    }
} 