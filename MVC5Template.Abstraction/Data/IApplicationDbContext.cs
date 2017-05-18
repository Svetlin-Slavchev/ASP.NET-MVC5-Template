using MVC5Template.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace MVC5Template.Abstraction.Data
{
    public interface IApplicationDbContext : IDisposable
    {
        DbSet<TestEFEntity> TestEFEntity { get; set; }
        DbSet<TestEFEntityTwo> TestEFEntityTwo { get; set; }

        int SaveChanges();

        void ClearDatabase();

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity)
            where TEntity : class;

        DbSet<T> Set<T>()
            where T : class;
    }
}
