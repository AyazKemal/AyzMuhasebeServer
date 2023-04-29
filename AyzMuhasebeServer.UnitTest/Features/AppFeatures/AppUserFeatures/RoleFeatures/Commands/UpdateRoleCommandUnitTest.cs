using AyzMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole;
using AyzMuhasebeServer.Application.Service.AppServices;
using AyzMuhasebeServer.Domain.AppEntities.Identity;
using Moq;
using Shouldly;

namespace AyzMuhasebeServer.UnitTest.Features.AppFeatures.AppUserFeatures.RoleFeatures.Commands;

public sealed class UpdateRoleCommandUnitTest
{
    private readonly Mock<IRoleService> _roleServiceMock;

    public UpdateRoleCommandUnitTest()
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
    public async Task AppRoleCodeShouldBeUnique()
    {
        AppRole checkRoleCode = await _roleServiceMock.Object.GetByCode("UCAF.Create");
        checkRoleCode.ShouldBeNull();
    }

    [Fact]
    public async Task UpdateRoleCommandResponseSholdNotBeNull()
    {
        var command = new UpdateRoleCommand(
            Id: "9846782b-ecff-4c09-b493-609a8712be71",
            Code: "UCAF.Create",
            Name: "Hesap Planı Kayıt Ekleme");

        _ = _roleServiceMock.Setup(
            x => x.GetById(It.IsAny<string>()))
            .ReturnsAsync(new AppRole());

        var handler = new UpdateRoleCommandHandler(_roleServiceMock.Object);
        UpdateRoleCommandResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
