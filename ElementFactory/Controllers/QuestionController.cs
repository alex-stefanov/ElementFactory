namespace ElementFactory.Controllers
{
    using ElementFactory.Data;
    using ElementFactory.Models.Question;
    using Microsoft.AspNetCore.Mvc;
    using ElementFactory.Models.Test;
    using ElementFactory.Models.Answer;
    using ElementFactory.Data.Models;

    public class QuestionController : Controller
    {
        private ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public QuestionController(ILogger<HomeController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Classes");
        }

        public IActionResult Classes()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TestsByGrade(string grade)
        {
            var tests = this._context.Tests
                .Where(t => t.Category == $"{grade} клас")
                .Select(t => new TestViewModel()
                {
                    Category = t.Category,

                    Title = t.Title,

                    Questions = t.QuestionsTests
                    .Select(qt =>
                        new QuestionsTestsMap()
                        {
                            CorrectAnswer = new AnswerViewModel()
                            {
                                Value = qt.Question.RightAnswer
                            },

                            Answers = qt.Question.Answers
                            .Select(a => new AnswerViewModel()
                            {
                                Value = a.Value
                            }).ToList()
                        }).ToList()
                      
                })
                .ToList();

            ViewBag.Title = $"Тестове за {grade} клас";

            return View(tests);
        }

        [HttpGet]
        public IActionResult AddTestGet()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTestPost(TestViewModel model)
        {
            if (ModelState.IsValid)
            {
                var testEntity = new Test()
                {
                    Category = model.Category,
                    Title = model.Title,
                    QuestionsTests = new List<QuestionTestMap>()
                };

                await this._context.Tests.AddAsync(testEntity);
                await this._context.SaveChangesAsync();

                return RedirectToAction("TestsByGrade", "Question", new
                {
                    grade = model.Category.Split(" ")[0]
                });
            }

            return View("AddTestGet", model);
        }

        //?
        public IActionResult Question(QuestionModel model)
        {
            // .LoadQuestionById(model.id)
            return View();
        }
    }
}
