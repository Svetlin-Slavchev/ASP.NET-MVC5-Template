using MVC5Template.Abstraction.Models;

namespace MVC5Template.Data.Models
{
    public class HomeModel : IHomeModel
    {
        public string Name { get; set; }
        public int Years { get; set; }
    }
}
