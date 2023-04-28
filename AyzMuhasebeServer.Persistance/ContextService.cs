using AyzMuhasebeServer.Domain;
using AyzMuhasebeServer.Domain.AppEntities;
using AyzMuhasebeServer.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace AyzMuhasebeServer.Persistance
{
    public sealed class ContextService : IContextService
    {
        private readonly AppDbContext _appContext;

        public ContextService(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public DbContext CretaeDbContextInstance(string companyId)
        {
            Company company = _appContext.Set<Company>().Find(companyId);
            return new CompanyDbContext(company);
        }
    }
}
