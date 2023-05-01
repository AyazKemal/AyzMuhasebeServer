using MediatR;
using AyzMuhasebeServer.Presentation.Abstraction;
using AyzMuhasebeServer.Application.Features.AppFeatures.UserAndCompanyRLFeatures.Commands.RemoveByIdUserAndCompanyRL;
using Microsoft.AspNetCore.Mvc;
using AyzMuhasebeServer.Application.Features.AppFeatures.UserAndCompanyRLFeatures.Commands.CreateUserAndCompanyRL;

namespace AyzMuhasebeServer.Presentation.Controller;
public class UserAndCompanyRelationshipsController : ApiController
{
    public UserAndCompanyRelationshipsController(IMediator mediator) : base(mediator) {}

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateUserAndCompany(CreateUserAndCompanyRLCommand request, CancellationToken cancellationToken)
    {
        CreateUserAndCompanyRLCommandResponse response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> RemoveByIdUserAndCompany(RemoveByIdUserAndCompanyRLCommand request)
    {
        RemoveByIdUserAndCompanyRLCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }
}
