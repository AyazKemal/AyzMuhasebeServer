using MediatR;
using AyzMuhasebeServer.Presentation.Abstraction; 

namespace AyzMuhasebeServer.Presentation.Controller;

public class UserAndCompanyRelationshipsController : ApiController
{
    public UserAndCompanyRelationshipsController(IMediator mediator) : base(mediator) {}
}
