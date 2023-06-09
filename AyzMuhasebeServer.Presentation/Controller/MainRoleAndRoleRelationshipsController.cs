using MediatR;
using AyzMuhasebeServer.Presentation.Abstraction;
using Microsoft.AspNetCore.Mvc;
using Azure.Core;
using System.Threading;
using AyzMuhasebeServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL;
using AyzMuhasebeServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.RemoveByIdMainRoleAndRoleRL;
using AyzMuhasebeServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Queries;

namespace AyzMuhasebeServer.Presentation.Controller;

public class MainRoleAndRoleRelationshipsController : ApiController
{
    public MainRoleAndRoleRelationshipsController(IMediator mediator) : base(mediator) { }

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateMainRole(CreateMainRoleAndRoleRLCommand request, CancellationToken cancellationToken)
    {
        CreateMainRoleAndRoleRLCommandResponse response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> RemoveByIdMainRoleAndRole(RemoveByIdMainRoleAndRoleRLCommand request)
    {
        RemoveByIdMainRoleAndRoleRLCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> GetAllMainRoleAndRole()
    {
        GetAllMainRoleAndRoleRLQuery request = new();
        GetAllMainRoleAndRoleRLQueryResponse response = await _mediator.Send(request);

        return Ok(response);
    }


}
