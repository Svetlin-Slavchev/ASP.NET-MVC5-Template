using MVC5Template.Abstraction.Data;
using MVC5Template.Abstraction.Models;
using MVC5Template.Abstraction.Services;
using System.Web.Mvc;

namespace MVC5Template.Web.Controllers
{
    public class HomeController : BaseController
    {
        public IHomeService HomeService { get; set; }

        public HomeController(IMVC5TemplateData data, IHomeService homeService)
            : base(data)
        {
            this.HomeService = homeService;
        }

        public ActionResult Index()
        {
            IHomeModel model = this.HomeService.GetModel();

            // Test only.
            var forDelete = this.Data.TestEFEntitiesRepository.GetById(3);
            if (forDelete != null)
            {
                this.Data.TestEFEntitiesRepository.Delete(forDelete);
                this.Data.TestEFEntitiesRepository.Save();
            }

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}