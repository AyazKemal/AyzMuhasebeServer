﻿using AyzMuhasebeServer.Application.Features.CompanyFeatures.Commands.CreateCompany;
using AyzMuhasebeServer.Application.Features.CompanyFeatures.Commands.MigrateCompanyDatabases;
using AyzMuhasebeServer.Application.Features.CompanyFeatures.Queries.GetAllCompany;
using AyzMuhasebeServer.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AyzMuhasebeServer.Presentation.Controllers
{
    public class CompaniesController : ApiController
    {
        public CompaniesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateCompany(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            CreateCompanyCommandResponse response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> MigrateCompanyDatabases()
        {
            MigrateCompanyDatabasesCommand request = new();
            MigrateCompanyDatabasesCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllCompany()
        {
            GetAllCompanyQuery request = new();
            GetAllCompanyQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

    }
}
