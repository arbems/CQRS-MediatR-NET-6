using CQRS_MediatR_NET_6.Controllers;
using CQRS_MediatR_NET_6.Models.Request;
using CQRS_MediatR_NET_6.Models.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Threading;
using Xunit;

namespace CQRS_MediatR_NET_6.Tests;

public class UnitTest1
{
    private Mock<IMediator> _mediator;

    public UnitTest1()
    {
        _mediator = new Mock<IMediator>();
    }

    [Fact]
    public void AddPost_Success_Result()
    {
        _mediator.Setup(a => a.Send(It.IsAny<AddPostRequestModel>(), new CancellationToken()))
            .ReturnsAsync(new AddPostResponseModel { PostId = Guid.NewGuid() });

        var postController = new PostController(_mediator.Object);

        //Action
        var result = postController.Post(new AddPostRequestModel());

        //Assert
        Assert.IsType<OkObjectResult>(result);
    }

    [Fact]
    public void GetPostById_Success_Result()
    {
        _mediator.Setup(a => a.Send(It.IsAny<GetPostByIdRequestModel>(), new CancellationToken()))
            .ReturnsAsync(new GetPostByIdResponseModel { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), Body = "", Title = "" });

        var postController = new PostController(_mediator.Object);

        //Action
        var result = postController.Get(new GetPostByIdRequestModel());

        //Assert
        Assert.IsType<OkObjectResult>(result);
    }
}