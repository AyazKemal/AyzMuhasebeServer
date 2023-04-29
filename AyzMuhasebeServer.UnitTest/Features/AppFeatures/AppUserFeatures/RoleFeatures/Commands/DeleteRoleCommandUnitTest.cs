using AyzMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole;
using AyzMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole;
using AyzMuhasebeServer.Application.Service.AppServices;
using AyzMuhasebeServer.Domain.AppEntities.Identity;
using Moq;
using Shouldly;

namespace AyzMuhasebeServer.UnitTest.Features.AppFeatures.AppUserFeatures.RoleFeatures.Commands;

public sealed class DeleteRoleCommandUnitTest
{
    private readonly Mock<IRoleService> _roleServiceMock;

    public DeleteRoleCommandUnitTest()
    {
        _roleServiceMock = new();
    }
    [Fact]
    public async Task AppRoleShouldNotBeNull()
    {
        _ = _roleServiceMock.Setup(
        x => x.GetById(It.IsAny<string>()))
        .ReturnsAsync(new AppRole());
    }

    [Fact]
    public async Task DeleteRoleCommandResponseShouldNotBeNull()
    {
        var command = new DeleteRoleCommand(
            Id: "9846782b-ecff-4c09-b493-609a8712be71");

        _ = _roleServiceMock.Setup(
       x => x.GetById(It.IsAny<string>()))
       .ReturnsAsync(new AppRole());

        var handler = new DeleteRoleCommandHandler(_roleServiceMock.Object);
        DeleteRoleCommandResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
