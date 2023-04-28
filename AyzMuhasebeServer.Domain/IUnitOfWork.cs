using Microsoft.EntityFrameworkCore;

namespace AyzMuhasebeServer.Domain
{
    public interface IUnitOfWork
    {
        void SetDbContextInstance(DbContext context);
        Task<int> SaveChangeAsync();
    }
}
