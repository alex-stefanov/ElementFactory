using Microsoft.AspNetCore.Mvc;

namespace ElementFactory.Controllers
{
    public class QuestionsController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Classes");
        }

        public IActionResult Classes()
        {
            return View();
        }
    }
}
