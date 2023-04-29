using AyzMuhasebeServer.Domain;
using AyzMuhasebeServer.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace AyzMuhasebeServer.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private CompanyDbContext _context;
        public void SetDbContextInstance(DbContext context)
        {
            _context = (CompanyDbContext)context;
        }

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            int count = await _context.SaveChangesAsync(cancellationToken);
            return count;
        }
    }
}
