using CQRS_MediatR_NET_6.Models.Response;
using MediatR;

namespace CQRS_MediatR_NET_6.Models.Request;

public class AddPostRequestModel : IRequest<AddPostResponseModel>
{
    public Guid UserId { get; set; }

    public Guid Id { get; set; }

    public string? Title { get; set; }

    public string? Body { get; set; }
}
