using Microsoft.EntityFrameworkCore;

namespace AyzMuhasebeServer.Domain.UnitOfWorks
{
    public interface ICompanyDbUnitOfWork : IUnitOfWork
    {
        void SetDbContextInstance(DbContext context);
    }
}
