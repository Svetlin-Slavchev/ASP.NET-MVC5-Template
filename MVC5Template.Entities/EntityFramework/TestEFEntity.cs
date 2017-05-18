using MVC5Template.Entities.Abstraction;
using System.ComponentModel.DataAnnotations;

namespace MVC5Template.Entities
{
    public class TestEFEntity : BasеEntity<int>
    {
        public string Name { get; set; }

        public string Value { get; set; }
    }
}
