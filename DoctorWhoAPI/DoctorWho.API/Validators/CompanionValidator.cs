using DoctorWho.API.Models;
using DoctorWhoDomain.Entities;
using FluentValidation;

public class CompanionValidator : AbstractValidator<CompanionDto>
{
    public CompanionValidator()
    {
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Companion name is required.")
            .MaximumLength(50).WithMessage("Companion name cannot exceed 50 characters.")
            .Matches("^[a-zA-Z ] *$").WithMessage("Companion Name cannot include special charactors");

        RuleFor(c => c.WhoPlayed)
            .NotEmpty().WithMessage("Actor name is required.")
            .Matches("^[a-zA-Z0-9 ] *$").WithMessage("Actor Name can only contains chars or numbers")
            .MaximumLength(50).WithMessage("Actor Name cannot exceed 50 characters.");
    }
}
