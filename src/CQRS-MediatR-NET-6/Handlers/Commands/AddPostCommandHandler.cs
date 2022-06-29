using CQRS_MediatR_NET_6.Models.Request;
using CQRS_MediatR_NET_6.Models.Response;
using MediatR;

namespace CQRS_MediatR_NET_6.Handlers.Commands;

public class AddPostCommandHandler : IRequestHandler<AddPostRequestModel, AddPostResponseModel>
{
    public async Task<AddPostResponseModel> Handle(AddPostRequestModel request, CancellationToken cancellationToken)
    {
        // your logic add post...

        return new AddPostResponseModel()
        {
            PostId = Guid.NewGuid()
        };
    }
}