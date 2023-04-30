using AyzMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using AyzMuhasebeServer.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AyzMuhasebeServer.Presentation.Controllers
{
    public sealed class UCAFsController : ApiController
    {
        public UCAFsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateUCAF(CreateUCAFCommand request, CancellationToken cancellationToken)
        {
            CreateUCAFCommandResponse response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
