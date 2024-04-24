using ElementFactory.Models.Api;
using Microsoft.AspNetCore.Mvc;

namespace ElementFactory.Controllers
{
    public class AnimationsController : Controller
    {
        public AnimationsController()
        {
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RedirectInfoToView(AtomicReactionModel model)
        {   
            return View(model);
        }

        public IActionResult DisplayInfoToView(AtomicReactionModel model)
        {
            return View(model);
        }
    }
}
