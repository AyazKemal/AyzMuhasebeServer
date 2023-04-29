using AyzMuhasebeServer.Application.Service.AppServices;
using AyzMuhasebeServer.Domain.AppEntities.Identity;
using Moq;

namespace AyzMuhasebeServer.UnitTest.Features.AppFeatures.AppUserFeatures.RoleFeatures.Queries;

public sealed class GetAllRolesQueryUnitTest
{
    private readonly Mock<IRoleService> _roleServiceMock;

    public GetAllRolesQueryUnitTest()
    {
        _roleServiceMock = new();
    }
    [Fact]
    public async Task GetAllRolesQueryResponseShouldNotbeNull()
    {
        _roleServiceMock.Setup(
            x => x.GetAllRolesAsync())
              .ReturnsAsync(new List<AppRole>());
    }
}
