using MVC5Template.Abstraction.Services;
using MVC5Template.Entities;

namespace MVC5Template.Abstraction.Data
{
    public interface IMVC5TemplateData
    {
        IApplicationDbContext ApplicationDbContext { get; set; }
        IDbRepository<TestEFEntity> TestEFEntitiesRepository { get; set; }
    }
}
