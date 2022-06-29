using CQRS_MediatR_NET_6.Models.Request;
using FluentValidation;

namespace CQRS_MediatR_NET_6.Validators;

public class GetPostByIdQueryValidator : AbstractValidator<GetPostByIdRequestModel>
{
    public GetPostByIdQueryValidator()
    {
        RuleFor(v => v.PostId)
            .NotNull()
            .NotEmpty()
            .WithMessage("PostId is null or empty.");

        RuleFor(x => x.PostId)
            .Must(ValidateGuid)
            .WithErrorCode("Not a guid");
    }

    private bool ValidateGuid(Guid arg)
    {
        return Guid.TryParse(arg.ToString(), out var result);
    }
}