using ElementFactory.Models.Question;
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

        public IActionResult Question(QuestionModel model)
        {
            // .LoadQuestionById(model.id)
            return View();
        }
    }
}
