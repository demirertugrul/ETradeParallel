using ETradeParallel.Application.ViewModel.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeParallel.Application.Validators.Products
{
    public class CreatedProductValidator : AbstractValidator<VM_Created_Product>
    {
        public CreatedProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Ürün ismi boş bırakmayınız.")
                .MaximumLength(150)
                .MinimumLength(5)
                    .WithMessage("Ürün ismi 5 karakterden büyük 150 karakterden küçük olmalıdır!");

            RuleFor(p => p.Price)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Ürün fiyatını boş bırakmayınız.")
                .Must(p=>p>=0)
                    .WithMessage("Ürün fiyatı 0 veya negatif olamaz!");

            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Ürün adedini boş bırakmayınız.")
                .Must(s => s>=0)
                    .WithMessage("Stok adedi 0 veya negatif olamaz!");
        }
    }
}
