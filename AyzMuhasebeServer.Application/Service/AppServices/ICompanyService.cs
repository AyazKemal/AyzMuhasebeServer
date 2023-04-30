using AyzMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using AyzMuhasebeServer.Domain.AppEntities;

namespace AyzMuhasebeServer.Application.Service.AppServices
{
    public interface ICompanyService
    {
        Task CreateCompany(CreateCompanyCommand request, CancellationToken cancellationToken);
        Task MigrateCompanyDatabases();
        Task<Company?> GetCompanyByName(string name, CancellationToken cancellationToken);
        IQueryable<Company> GetAll();
    }
}
