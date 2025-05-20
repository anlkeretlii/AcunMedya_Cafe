using AcunMedya.Cafe.Entities;
using FluentValidation;

namespace AcunMedya.Cafe.Validations
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName)
                .NotEmpty().WithMessage("Ürün Adı boş geçilemez")
                .MinimumLength(3).WithMessage("Ürün Adı en az 3 karakter olmalıdır")
                .MaximumLength(50).WithMessage("Ürün Adı en fazla 50 karakter olabilir");

            RuleFor(x => x.ProductPrice)
                .NotEmpty().WithMessage("Ürün Fiyatı boş geçilemez")
                .GreaterThan(0).WithMessage("Ürün Fiyatı 0'dan büyük olmalıdır");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Ürün Açıklaması boş geçilemez")
                .MinimumLength(10).WithMessage("Ürün Açıklaması en az 10 karakter olmalıdır")
                .MaximumLength(500).WithMessage("Ürün Açıklaması en fazla 500 karakter olabilir");

            RuleFor(x => x.CategoryId)
                .NotEmpty().WithMessage("Kategori seçimi zorunludur");
        }
    }
} 