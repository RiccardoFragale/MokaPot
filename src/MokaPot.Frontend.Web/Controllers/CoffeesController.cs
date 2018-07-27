using System.Web.Mvc;
using MokaPot.Backend.Core.Features;
using MokaPot.Frontend.Common;

namespace MokaPot.Frontend.Web.Controllers
{
    public class CoffeesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MakeEspresso()
        {
            IEspressoFeature espressoFeature = new EspressoFeature();
            var isSuccess = espressoFeature.Execute();

            return RedirectToAction("Ready", new { isSuccess });
        }

        public ActionResult Ready(bool isSuccess)
        {
            return View(isSuccess);
        }
    }
}