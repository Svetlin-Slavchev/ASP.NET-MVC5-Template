using MVC5Template.Abstraction.Data;
using MVC5Template.Entities.Abstraction;
using System;
using System.Data.Entity;
using System.Linq;

namespace MVC5Template.Data.Data
{
    public class DbRepository<T> : IDbRepository<T>
        where T : class, IAuditInfo, IDeletableEntity
    {
        public DbRepository(IApplicationDbContext context)
        {
            this.Context = context ?? throw new ArgumentException("An instance of DbContext is required to use this repository.", nameof(context));
            this.DbSet = this.Context.Set<T>();
        }

        private DbSet<T> DbSet { get; }

        private IApplicationDbContext Context { get; }

        public IQueryable<T> All()
        {
            return this.DbSet.Where(x => !x.IsDeleted);
        }

        public IQueryable<T> AllWithDeleted()
        {
            return this.DbSet;
        }

        public T GetById(object id)
        {
            var item = this.DbSet.Find(id);
            if (item.IsDeleted)
            {
                return null;
            }

            return item;
        }

        public void Add(T entity)
        {
            this.DbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            entity.IsDeleted = true;
            entity.DeletedOn = DateTime.Now;
        }

        public void HardDelete(T entity)
        {
            this.DbSet.Remove(entity);
        }

        public void Save()
        {
            this.Context.SaveChanges();
        }

        public void Dispose()
        {
            this.Context.Dispose();
        }
    }
}
