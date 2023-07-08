using DoctorWho.API.Models;
using DoctorWhoDomain.Entities;
using FluentValidation;

public class EnemyValidator : AbstractValidator<EnemyDto>
{
    public EnemyValidator()
    {
        RuleFor(e => e.Name)
            .NotEmpty().WithMessage("Enemy name is required.")
            .MaximumLength(50).WithMessage("Enemy Name cannot exceed 50 characters.")
             .Matches("^[a-zA-Z ] *$").WithMessage("Enemy Name cannot include special charactors"); ;

        RuleFor(e => e.Description)
            .NotEmpty().WithMessage("Description is required.")
            .MaximumLength(1000).WithMessage("Description cannot exceed 1000 characters.")
            .Matches("^[a-zA-Z0-9 ] *$").WithMessage("Description can contains only charactor or numbers."); ;
    }
}
