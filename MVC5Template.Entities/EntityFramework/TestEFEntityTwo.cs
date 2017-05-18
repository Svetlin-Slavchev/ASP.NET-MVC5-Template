using MVC5Template.Entities.Abstraction;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC5Template.Entities
{
    public class TestEFEntityTwo : BasеEntity<int>
    {
        public string Name { get; set; }

        [ForeignKey("TestEFEntity")]
        public int? TestEFEntityId { get; set; }

        public virtual TestEFEntity TestEFEntity { get; set; }
    }
}
