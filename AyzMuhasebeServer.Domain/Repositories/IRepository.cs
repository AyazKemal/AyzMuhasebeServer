﻿using AyzMuhasebeServer.Domain.AppEntities.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace AyzMuhasebeServer.Domain.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        void SetDbContextInstance(DbContext context);
        DbSet<T> Entity { get; set; }
    }
}