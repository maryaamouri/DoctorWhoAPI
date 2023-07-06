using DoctorWho.API.Models;
using DoctorWhoDomain.Entities;
using FluentValidation;

namespace DoctorWho.API.Validators
{
    public class EpisodeValidator : AbstractValidator<EpisodeDto>
    {
        public EpisodeValidator()
        {
            RuleFor(e => e.Number.ToString())
                .NotEmpty().WithMessage("Series Number is required.")
                .Length(10).WithMessage("Series Number must be exactly 10 characters.");
            
            RuleFor(e => e.Type)
                .NotEmpty().WithMessage("Episode Type is required.")
                .Matches("^[a-zA-Z ] *$").WithMessage("Type Can contains only charactor or numbers.")
                .MaximumLength(50).WithMessage("Episode Type cannot exceed 50 characters.");

            RuleFor(e => e.Title)
                .NotEmpty().WithMessage("Title is required.")
                .Matches("^[a-zA-Z0-9 ] *$").WithMessage("Title can contains only charactor or numbers.")
                .MaximumLength(50).WithMessage("Title cannot exceed 50 characters.");

            RuleFor(e => e.EpisodeDate)
                .Must(IsValidDate).WithMessage("Invalid Episode Date.");

            RuleFor(e => e.AuthorId)
                .NotEmpty().WithMessage("Author Id is required.")
                .GreaterThan(0).WithMessage("Author Id must be greator than 0");

            RuleFor(e => e.DoctorId)
                .NotEmpty().WithMessage("Doctor Id is required.")
                .GreaterThan(0).WithMessage("Doctor Id must be greator than 0");
        }

        private bool IsValidDate(DateTime date)
        {
            return date != DateTime.MinValue && date <= DateTime.Now;
        }
    }
}