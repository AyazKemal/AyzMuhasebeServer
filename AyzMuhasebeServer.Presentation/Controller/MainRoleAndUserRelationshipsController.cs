using AyzMuhasebeServer.Presentation.Abstraction;
using MediatR;

namespace AyzMuhasebeServer.Presentation.Controller;

public class MainRoleAndUserRelationshipsController : ApiController
{
    public MainRoleAndUserRelationshipsController(IMediator mediator) : base(mediator) {}
}
