using AyzMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using AyzMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using AyzMuhasebeServer.Application.Service.AppServices;
using AyzMuhasebeServer.Domain.AppEntities.Identity;
using AyzMuhasebeServer.Persistance.Services.AppServices;
using Moq;
using Shouldly;

namespace AyzMuhasebeServer.UnitTest.Features.AppFeatures.AppUserFeatures.RoleFeatures.Commands;

public sealed class CreateRoleCommandUnitTest
{
    private readonly Mock<IRoleService> _roleServiceMock;

    public CreateRoleCommandUnitTest()
    {
        _roleServiceMock = new();
    }

    [Fact]
    public async Task AppRoleShouldBeNull()
    {
        AppRole appRole = await _roleServiceMock.Object.GetByCode("UCAF.Create");
        appRole.ShouldBeNull();
    }

    [Fact]
    public async Task CreateRoleCommandResponseSholdNotBeNull()
    {
        var command = new CreateRoleCommand(
            Code: "UCAF.Create",
            Name: "Hesap Planı Kayıt Ekleme");

        var handler = new CreateRoleCommandHandler(_roleServiceMock.Object);
        CreateRoleCommandResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
