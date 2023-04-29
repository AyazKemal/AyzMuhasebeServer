using AyzMuhasebeServer.Domain;
using AyzMuhasebeServer.Domain.UnitOfWorks;
using AyzMuhasebeServer.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace AyzMuhasebeServer.Persistance.UnitOfWorks
{
    public class CompanyUnitOfWork : ICompanyDbUnitOfWork
    {
        private CompanyDbContext _context;
        public void SetDbContextInstance(DbContext context)
        {
            _context = (CompanyDbContext)context;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            int count = await _context.SaveChangesAsync(cancellationToken);
            return count;
        }

    }
}
