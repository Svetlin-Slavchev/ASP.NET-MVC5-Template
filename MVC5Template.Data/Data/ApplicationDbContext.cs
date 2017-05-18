using Microsoft.AspNet.Identity.EntityFramework;
using MVC5Template.Abstraction.Data;
using MVC5Template.Entities;
using MVC5Template.Entities.EntityFramework;
using System;
using System.Data.Entity;

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

            return base.SaveChanges();
        }

        public void ClearDatabase()
        {
            throw new NotImplementedException();
        }
    }
}
