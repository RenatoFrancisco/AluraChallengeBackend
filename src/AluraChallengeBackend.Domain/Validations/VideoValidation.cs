using AluraChallengeBackend.Domain.Entities;
using FluentValidation;

namespace AluraChallengeBackend.Domain.Validations
{
    public class VideoValidation : AbstractValidator<Video>
    {
        public VideoValidation()
        {
            RuleFor(v => v.Title)
                .NotEmpty()
                .WithMessage("The {PropertyName} field is required")
                .Length(2, 100)
                .WithMessage("The {PropertyName} field must contain between {MinLength} and {MaxLength} caracteres");

            RuleFor(v => v.Description)
                .NotEmpty()
                .WithMessage("The {PropertyName} field is required")
                .Length(2, 500)
                .WithMessage("The {PropertyName} field must contain between {MinLength} and {MaxLength} caracteres");

            RuleFor(v => v.Url)
                .NotEmpty()
                .WithMessage("The {PropertyName} field is required")
                .Length(2, 500)
                .WithMessage("The {PropertyName} field must contain between {MinLength} and {MaxLength} caracteres");
        }
    }
}