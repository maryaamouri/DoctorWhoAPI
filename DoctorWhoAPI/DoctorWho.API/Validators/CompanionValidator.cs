using DoctorWhoDomain.Entities;
using FluentValidation;

public class CompanionValidator : AbstractValidator<Companion>
{
    public CompanionValidator()
    {
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Companion name is required.")
            .MaximumLength(50).WithMessage("Companion name cannot exceed 50 characters.")
            .Matches("^[a-zA-Z ] *$").WithMessage("Companion Name cannot include special charactors");

        RuleFor(c => c.WhoPlayed)
            .NotEmpty().WithMessage("Actor name is required.")
            .MaximumLength(50).WithMessage("Actor Name cannot exceed 50 characters.");
    }
}
