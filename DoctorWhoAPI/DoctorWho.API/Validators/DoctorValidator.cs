using DoctorWho.API.Models;
using FluentValidation;
using System.Text.RegularExpressions;

namespace DoctorWho.API.Validators
{
    public class DoctorValidator : AbstractValidator<DoctorDto>
    {
        public DoctorValidator()
        {
            RuleFor(doctor => doctor.Name)
                .NotEmpty().WithMessage("Doctor Name is required")
                .Matches("^[a-zA-Z ] *$").WithMessage("Doctor Name cannot contain special charactors")
                .MaximumLength(50).WithMessage("Too long Name");

            RuleFor(doctor => doctor.Number)
               .NotNull().WithMessage("Phone Number is required.")
               .Length(10).WithMessage("PhoneNumber is 10 characters.")
               .Matches(new Regex(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}")).WithMessage("PhoneNumber is not valid");

            RuleFor(doctor=>doctor.BirthDate) 
                .NotEmpty().WithMessage("BirthDate is required.")
                .Must(IsValidDate).WithMessage("Invalid Date")
                .Must(date => date.Date <=DateTime.Today).WithMessage("Birth date must be in the past.");

            RuleFor(doctor => doctor.FirstEpisodeDate)
                .NotEmpty().WithMessage("First Episode Date is required.")
                .Must(IsValidDate).WithMessage("Invalid Date");

            RuleFor(doctor => doctor.LastEpisodeDate)
                .NotEmpty()
                .Must(IsValidDate).WithMessage("Invalid Date")
                .GreaterThan(d => d.FirstEpisodeDate).WithMessage("Last Episode Date must be after First Episode Date");
        }
        private bool IsValidDate(DateTime date)
        {
            return !date.Equals(default(System.DateTime));
        }
    }
}
