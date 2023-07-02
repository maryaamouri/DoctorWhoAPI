using DoctorWho.API.Models;
using DoctorWhoDomain.Entities;
using FluentValidation;

public class EpisodeValidator : AbstractValidator<EpisodeDto>
{
    public EpisodeValidator()
    {
        RuleFor(e => e.Number)
            .NotEmpty().WithMessage("Series Number is required.")
            .GreaterThan(0).WithMessage("Series Number must be greater than 0.");

        RuleFor(e => e.Type)
            .NotEmpty().WithMessage("Episode Type is required.")
            .Matches("^[a-zA-Z ] *$").WithMessage("Type Can contains only charactor or numbers.")
            .MaximumLength(50).WithMessage("Episode Type cannot exceed 50 characters.");

        RuleFor(e => e.Title)
            .NotEmpty().WithMessage("Title is required.")
            .Matches("^[a-zA-Z0-9 ] *$").WithMessage("Title can contains only charactor or numbers.")   
            .MaximumLength(50).WithMessage("Title cannot exceed 50 characters.");

        RuleFor(e => e.EpisodeDate)
            .NotEmpty().WithMessage("Episode Date is required.")
            .Must(IsValidDate).WithMessage("Invalid Episode Date.");
    }

    private bool IsValidDate(DateTime date)
    {
        return date != DateTime.MinValue && date <= DateTime.Now;
    }
}
