﻿using AyzMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using AyzMuhasebeServer.Domain.AppEntities;

namespace AyzMuhasebeServer.Application.Service.AppServices
{
    public interface ICompanyService
    {
        Task CreateCompany(CreateCompanyRequest request);
        Task MigrateCompanyDatabases();
        Task<Company?> GetCompanyByName(string name);
    }
}
