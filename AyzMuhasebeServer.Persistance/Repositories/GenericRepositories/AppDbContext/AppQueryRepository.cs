﻿using AyzMuhasebeServer.Domain.AppEntities.Abstractions;
using AyzMuhasebeServer.Domain.Repositories.GenericRepositories.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AyzMuhasebeServer.Persistance.Repositories.GenericRepositories.AppDbContext;

public class AppQueryRepository<T> : IAppQueryRepository<T> where T : Entity
{
    private static readonly Func<Context.AppDbContext, string, bool, Task<T>> GetByIdCompiled = EF.CompileAsyncQuery((Context.AppDbContext context, string id, bool isTracking) =>
        context.Set<T>().FirstOrDefault(p => p.Id == id));

    private static readonly Func<Context.AppDbContext, bool, Task<T>> GetFirstCompiled = EF.CompileAsyncQuery((Context.AppDbContext context, bool isTracking) =>
            context.Set<T>().FirstOrDefault());


    
    private Context.AppDbContext _context;

    public AppQueryRepository(Context.AppDbContext context)
    {
        _context = context;
        Entity = _context.Set<T>();
    }
    public DbSet<T> Entity { get; set; }
    public IQueryable<T> GetAll(bool isTracking = true)
    {
        var result = Entity.AsQueryable();
        if (!isTracking)
            result = result.AsNoTracking();
        return result;
    }

    public async Task<T> GetById(string id, bool isTracking = true)
    {
        return await GetByIdCompiled(_context, id, isTracking);
    }

    public async Task<T> GetFirst(bool isTracking = true)
    {
        return await GetFirstCompiled(_context, isTracking);
    }

    public async Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression, CancellationToken cancellationToken, bool isTracking = true)
    {
        T entity = null;
        if(!isTracking)
            await Entity.AsNoTracking().Where(expression).FirstOrDefaultAsync(cancellationToken);
        else
            await Entity.Where(expression).FirstOrDefaultAsync(cancellationToken);
        return entity;
    }

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool isTracking = true)
    {
        var result = Entity.AsQueryable().Where(expression);
        if (!isTracking)
            result = result.AsNoTracking();
        return result;
    }
}
