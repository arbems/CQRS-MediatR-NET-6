using CQRS_MediatR_NET_6.Models.Response;
using MediatR;

namespace CQRS_MediatR_NET_6.Models.Request;

public class GetPostByIdRequestModel : IRequest<GetPostByIdResponseModel>
{
    public Guid PostId { get; set; }
}
