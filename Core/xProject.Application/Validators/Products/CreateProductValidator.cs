using FluentValidation;
using xProject.Application.ViewModels.Products;

namespace xProject.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Product name is required")
                .MaximumLength(150)
                .MinimumLength(2)
                    .WithMessage("product name must be 2 or 150 characters");
            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Stock is required")
                .Must(s => s > 0)
                    .WithMessage("Stock number cannot be less than 0.");

            RuleFor(p => p.Price)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Stock is required")
                .Must(p => p > 0)
                    .WithMessage("Stock number cannot be less than 0.");



        }
    }
}
