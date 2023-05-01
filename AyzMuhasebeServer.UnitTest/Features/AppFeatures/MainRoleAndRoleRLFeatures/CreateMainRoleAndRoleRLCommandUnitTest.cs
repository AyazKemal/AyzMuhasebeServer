using AyzMuhasebeServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL;
using AyzMuhasebeServer.Application.Services.AppServices;
using AyzMuhasebeServer.Domain.AppEntities;
using Moq;
using Shouldly;

namespace AyzMuhasebeServer.UnitTest.Features.AppFeatures.MainRoleAndRoleRLFeatures
{
    public sealed class CreateMainRoleAndRoleRLCommandUnitTest
    {
        private readonly Mock<IMainRoleAndRoleRelationshipService> _roleRelationshipService;

        public CreateMainRoleAndRoleRLCommandUnitTest()
        {
            _roleRelationshipService = new();
        }
        [Fact]
        public async Task MainRoleAndRoleRelationshipShouldBeNull()
        {
            MainRoleAndRoleRelationship entity = await _roleRelationshipService.Object
               .GetByRoleIdAndMainRoleId(
                roleId: "66da4d5a-b366-4d5a-bfdb-cfe9127b0f69",
                mainRoleId: "6d108e90-b0ce-4f24-b28c-4bfea357e6ca",
                cancellationToken: default);
            entity.ShouldBeNull();
        }

        [Fact]
        public async Task CreateMainRoleAndRoleRLCommandResponseShouldNotBeNull()
        {

            var command = new CreateMainRoleAndRoleRLCommand(
               RoleId: "66da4d5a-b366-4d5a-bfdb-cfe9127b0f69",
               MainRoleId: "6d108e90-b0ce-4f24-b28c-4bfea357e6ca");

            var handler = new CreateMainRoleAndRoleRLHandler(_roleRelationshipService.Object);

            CreateMainRoleAndRoleRLCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
