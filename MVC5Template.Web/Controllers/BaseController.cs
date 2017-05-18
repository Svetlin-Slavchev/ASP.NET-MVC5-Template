using MVC5Template.Abstraction.Data;
using System.Web.Mvc;

namespace MVC5Template.Web.Controllers
{
    public class BaseController : Controller
    {
        public BaseController(IMVC5TemplateData data)
        {
            this.Data = data;
        }

        public IMVC5TemplateData Data { get; set; }
    }
}