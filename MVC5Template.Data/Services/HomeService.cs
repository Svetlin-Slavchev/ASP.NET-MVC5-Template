using MVC5Template.Abstraction.Models;
using MVC5Template.Abstraction.Services;
using MVC5Template.Data.Models;

namespace MVC5Template.Data.Services
{
    public class HomeService : IHomeService
    {
        public IHomeModel GetModel()
        {
            return new HomeModel()
            {
                Name = "test",
                Years = 1
            };
        }
    }
}
