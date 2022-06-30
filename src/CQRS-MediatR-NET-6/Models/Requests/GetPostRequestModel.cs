using CQRS_MediatR_NET_6.Models.Response;
using MediatR;

namespace CQRS_MediatR_NET_6.Models.Request;

public class GetPostRequestModel : IRequest<GetPostResponseModel>
{
    public Guid PostId { get; set; }
}
