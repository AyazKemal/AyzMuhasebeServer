﻿using AyzMuhasebeServer.Domain.AppEntities.Abstractions;
using AyzMuhasebeServer.Domain.Repositories.GenericRepositories.CompanyDbContext;
using Microsoft.EntityFrameworkCore;

namespace AyzMuhasebeServer.Persistance.Repositories.GenericRepositories.CompanyDbContext;

public class CompanyDbCommandRepository<T> : ICompanyDbCommandRepository<T> where T : Entity
{
    private static readonly Func<Context.CompanyDbContext, string, Task<T>> GetByIdCompiled = EF.CompileAsyncQuery((Context.CompanyDbContext context, string id) => context.Set<T>().FirstOrDefault(p => p.Id == id));

    private Context.CompanyDbContext _context;

    public DbSet<T> Entity { get; set; }

    public void SetDbContextInstance(DbContext context)
    {
        _context = (Context.CompanyDbContext)context;
        Entity = _context.Set<T>();
    }
    public async Task AddAsync(T entity, CancellationToken cancellationToken)
    {
        await Entity.AddAsync(entity, cancellationToken);
    }

    public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken)
    {
        await Entity.AddRangeAsync(entities, cancellationToken);
    }


    public void Remove(T entity)
    {
        Entity.Remove(entity);
    }

    public async Task RemoveById(string id)
    {
        T Entity = await GetByIdCompiled(_context, id);
        Remove(Entity);
    }

    public void RemoveRangeAsync(IEnumerable<T> entities)
    {
        Entity.RemoveRange(entities);
    }

    public void UpdateAysnc(T entity)
    {
        Entity.Update(entity);
    }

    public void UpdateRangeAsync(IEnumerable<T> entities)
    {
        Entity.UpdateRange(entities);
    }
}
