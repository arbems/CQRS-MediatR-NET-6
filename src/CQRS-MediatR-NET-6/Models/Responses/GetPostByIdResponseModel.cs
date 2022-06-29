namespace CQRS_MediatR_NET_6.Models.Response;

public class GetPostByIdResponseModel
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string? Title { get; set; }

    public string? Body { get; set; }
}