using System;
using MVC5Template.Abstraction.Data;
using MVC5Template.Abstraction.Services;
using MVC5Template.Entities;

namespace MVC5Template.Data.Data
{
    public class MVC5TemplateData : IMVC5TemplateData
    {
        public MVC5TemplateData(IApplicationDbContext context)
        {
            this.ApplicationDbContext = context;
            this.TestEFEntitiesRepository = new DbRepository<TestEFEntity>(context);
        }

        public IApplicationDbContext ApplicationDbContext { get; set; }
        public IDbRepository<TestEFEntity> TestEFEntitiesRepository { get; set; }
    }
}
