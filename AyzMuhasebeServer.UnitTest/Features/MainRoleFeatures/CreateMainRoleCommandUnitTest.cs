using AyzMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using AyzMuhasebeServer.Application.Features.MainRoleFeatures.Commands.CreateMainRole;
using AyzMuhasebeServer.Application.Features.MainRoleFeatures.Commands.CreateRole;
using AyzMuhasebeServer.Application.Service.AppServices;
using AyzMuhasebeServer.Application.Service.CompanyServices;
using AyzMuhasebeServer.Domain.AppEntities;
using AyzMuhasebeServer.Domain.CompanyEntities;
using Moq;
using Shouldly;

namespace AyzMuhasebeServer.UnitTest.Features.MainFeatures;
public sealed class CreateMainRoleCommandUnitTest
{
    private readonly Mock<IMainRoleService> _mainRoleService;

    public CreateMainRoleCommandUnitTest()
    {
        _mainRoleService = new();
    }
    [Fact]
    public async Task MainRoleShouldBeNull()
    {
        MainRole mainRole = await _mainRoleService.Object.GetByTitleAndCompanyId(
            title:"Admin", companyId: "9846782b-ecff-4c09-b493-609a8712be71", default);
        mainRole.ShouldBeNull();
    }

    [Fact]
    public async Task CreateMainRoleCommandResponseShouldNotBeNull()
    {
        var command = new CreateMainRoleCommand(
            Title: "Admin",
            CompanyId: "9846782b-ecff-4c09-b493-609a8712be71");

        var handler = new CreateMainRoleCommandHandler(_mainRoleService.Object);

        CreateMainRoleCommandResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }

}
