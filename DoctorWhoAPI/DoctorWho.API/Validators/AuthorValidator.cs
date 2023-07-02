using DoctorWho.API.Models;
using FluentValidation;

namespace DoctorWho.API.Validators
{
    public class AuthorValidator : AbstractValidator<AuthorDto>
    {
        public AuthorValidator()
        {
            RuleFor(author => author.Name)
                .NotEmpty().WithMessage("Author Name is required")
                .Matches("^[a-zA-Z ] *$").WithMessage("Author Name cannot contain special charactors")
                .MaximumLength(50).WithMessage("Too long Name");
        }
    }
}
