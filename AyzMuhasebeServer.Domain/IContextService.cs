using Microsoft.EntityFrameworkCore;

namespace AyzMuhasebeServer.Domain
{
    public interface IContextService
    {
        DbContext CretaeDbContextInstance(string companyId);
    }
}
