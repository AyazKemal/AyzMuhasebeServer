﻿using AyzMuhasebeServer.Domain.UnitOfWorks;
using AyzMuhasebeServer.Persistance.Context;

namespace AyzMuhasebeServer.Persistance.UnitOfWorks;
public sealed class AppUnitOfWork : IAppUnitOfWork
{
    private readonly AppDbContext _context;

    public AppUnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        int count = await _context.SaveChangesAsync(cancellationToken);
        return count;
    }
}
