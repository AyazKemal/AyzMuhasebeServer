using AyzMuhasebeServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.RemoveByIdMainRoleAndRoleRL;
using AyzMuhasebeServer.Application.Services.AppServices;
using AyzMuhasebeServer.Domain.AppEntities;
using Moq;
using Shouldly;

namespace AyzMuhasebeServer.UnitTest.Features.AppFeatures.MainRoleAndRoleRLFeatures;

public sealed class RemoveByIdMainRoleAndRoleRLCommandUnitTest
{
    private readonly Mock<IMainRoleAndRoleRelationshipService> _serviceMock;

    public RemoveByIdMainRoleAndRoleRLCommandUnitTest()
    {
        _serviceMock = new();
    }

    [Fact]
    public async Task MainRoleAndRoleRelationshipShouldNotBeNull()
    {
        _serviceMock.Setup(s =>
        s.GetByIdAsync(It.IsAny<string>()))
            .ReturnsAsync(new MainRoleAndRoleRelationship());
    }

    [Fact]
    public async Task RemoveByIdMainRoleAndRoleRLCommandResponseShouldNotBeNull()
    {
        RemoveByIdMainRoleAndRoleRLCommand removeByIdMainRoleAndRoleRLCommand = new(
            Id: "58986c90-54d0-4f21-968e-c10b30bfee66");

        RemoveByIdMainRoleAndRoleRLCommandHandler handler = new(_serviceMock.Object);

        _serviceMock.Setup(s =>
       s.GetByIdAsync(It.IsAny<string>()))
           .ReturnsAsync(new MainRoleAndRoleRelationship());

        RemoveByIdMainRoleAndRoleRLCommandResponse response = await handler.Handle(removeByIdMainRoleAndRoleRLCommand, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
