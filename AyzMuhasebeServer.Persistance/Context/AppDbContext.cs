﻿using AyzMuhasebeServer.Domain.AppEntities;
using AyzMuhasebeServer.Domain.AppEntities.Abstractions;
using AyzMuhasebeServer.Domain.AppEntities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AyzMuhasebeServer.Persistance.Context
{
    public sealed class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<MainRole> MainRoles { get; set; }
        public DbSet<MainRoleAndRoleRelationship> MainRoleAndRoleRelationships { get; set; }
        public DbSet<UserAndCompanyRelationship> UserAndCompanyRelationships { get; set; }
        public DbSet<MainRoleAndUserRelationship> MainRoleAndUserRelationships { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<AyzMuhasebeServer.Domain.AppEntities.Abstractions.Entity>();

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    //entry.Property(p => p.Id).CurrentValue = Guid.NewGuid().ToString();
                    entry.Property(p => p.CreatedDate).CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property(p => p.UpdateDate).CurrentValue = DateTime.Now;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Ignore<IdentityUserLogin<string>>();
            builder.Ignore<IdentityUserRole<string>>();
            builder.Ignore<IdentityUserClaim<string>>();
            builder.Ignore<IdentityUserToken<string>>();
            builder.Ignore<IdentityRoleClaim<string>>();
        }

        public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
        {
            public AppDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder();
                var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AyzMuhasebeMasterDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                optionsBuilder.UseSqlServer(connectionString);
                return new AppDbContext(optionsBuilder.Options);
            }
        }
    }
}
