using Microsoft.AspNet.Identity.EntityFramework;
using MVC5Template.Abstraction.Data;
using MVC5Template.Entities;
using MVC5Template.Entities.Abstraction;
using MVC5Template.Entities.EntityFramework;
using System;
using System.Data.Entity;
using System.Linq;

namespace MVC5Template.Data.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<TestEFEntity> TestEFEntity { get; set; }
        public DbSet<TestEFEntityTwo> TestEFEntityTwo { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public override int SaveChanges()
        {
            // TODO - Applay some custom logic here.
            this.ApplyAuditInfoRules();

            return base.SaveChanges();
        }

        public void ClearDatabase()
        {
            throw new NotImplementedException();
        }

        private void ApplyAuditInfoRules()
        {
            // Approach via @julielerman: http://bit.ly/123661P
            foreach (var entry in
                this.ChangeTracker.Entries()
                    .Where(
                        e =>
                        e.Entity is IAuditInfo && ((e.State == EntityState.Added) || (e.State == EntityState.Modified))))
            {
                var entity = (IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default(DateTime))
                {
                    entity.CreatedOn = DateTime.UtcNow;
                }
                else
                {
                    entity.ModifiedOn = DateTime.UtcNow;
                }
            }
        }
    }
}
