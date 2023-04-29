using AyzMuhasebeServer.Domain.AppEntities.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace AyzMuhasebeServer.Domain.Repositories.GenericRepositories;

public interface IRepository<T> where T : Entity
{
    DbSet<T> Entity { get; set; }
}
