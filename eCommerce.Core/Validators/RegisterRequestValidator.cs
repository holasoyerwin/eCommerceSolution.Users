

using eCommerce.Core.DTO;
using FluentValidation;

namespace eCommerce.Core.Validators
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            //Email
            RuleFor(temp => temp.Email)
              .NotEmpty().WithMessage("Email is required")
              .EmailAddress().WithMessage("Invalid email address format")
              ;

            //Password
            RuleFor(temp => temp.Password)
              .NotEmpty().WithMessage("Password is required")
              .MinimumLength(5).WithMessage("The minimium nuber of character is 5")
              ;

            //PersonName
            RuleFor(temp => temp.PersonName)
              .NotEmpty().WithMessage("PersonName is required")
              .Length(1, 50).WithMessage("The minimium nuber of character is 1 and the maxinum is 50 characters")
              ;

            // Validate the Gender property.
            RuleFor(request => request.Gender)
                .IsInEnum().WithMessage("Invalid gender option");
        }
    }
}
