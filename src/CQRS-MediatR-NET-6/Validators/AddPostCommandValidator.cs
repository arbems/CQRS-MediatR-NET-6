using CQRS_MediatR_NET_6.Models.Request;
using FluentValidation;

namespace CQRS_MediatR_NET_6.Validators;

public class AddPostCommandValidator : AbstractValidator<AddPostRequestModel>
{
    public AddPostCommandValidator()
    {
        RuleFor(v => v.Title)
            .MaximumLength(200)
            .NotEmpty()
            .WithMessage("Title is empty.");

        RuleFor(v => v.Body)
            .MaximumLength(1000)
            .NotEmpty()
            .WithMessage("Body is empty.");

        RuleFor(v => v.Id)
            .NotNull()
            .NotEmpty()
            .WithMessage("Id is null or empty.");

        RuleFor(v => v.UserId)
            .NotNull()
            .NotEmpty()
            .WithMessage("UserId is null or empty.");
    }
}