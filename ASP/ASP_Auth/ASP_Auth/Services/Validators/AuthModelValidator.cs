using ASP_Auth.Models;
using FluentValidation;

namespace ASP_Auth.Services.Validators
{
    class AuthModelValidator : AbstractValidator<AuthModel>
    {
        public AuthModelValidator()
        {
            RuleFor(entity => entity.Password).NotNull().WithMessage("Password can not be null");
            RuleFor(entity => entity.Password).Equal(entity => entity.ConfirmPassword).WithMessage("Passwords not same");
        }
    }
}
