namespace ElementFactory.Controllers
{
    using ElementFactory.Data;
    using ElementFactory.Models.Question;
    using Microsoft.AspNetCore.Mvc;
    using ElementFactory.Models.Test;
    using ElementFactory.Models.Answer;
    using ElementFactory.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using ElementFactory.Models;
    using System.Diagnostics;
    using System.Text.Json;
    using ElementFactory.Models.Others;

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
                    Id = t.Id,

                    Category = t.Category,

                    Title = t.Title,

                    Questions = t.QuestionsTests
                    .Select(qt =>
                        new QuestionViewModel()
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

        [HttpPost]
        public async Task<IActionResult> DeleteTest(int id)
        {
            var test = await this._context.Tests
                .FirstOrDefaultAsync(x => x.Id == id);

            if (test == null)
            {
                return RedirectToAction("Error");
            }

            var category = test.Category;

            this._context.Tests.Remove(test);
            await this._context.SaveChangesAsync();

            return RedirectToAction("TestsByGrade", new
            {
                grade = category.Split(" ")[0]
            });
        }

        [HttpGet]
        public IActionResult LoadTest(int id)
        {
           var model = this._context.Tests
                .Include(x => x.QuestionsTests)
                .ThenInclude(x => x.Question)
                .ThenInclude(x => x.Answers)
                .FirstOrDefault(x => x.Id == id);

            if (model != null)
            {
                ViewBag.Title = "Тест - " + model.Title;

                var viewModel = new TestViewModel()
                {
                    Id = model.Id,
                    Category = model.Category,
                    Title = model.Title,

                    Questions = model.QuestionsTests
                    .Select(qt => new QuestionViewModel()
                    {
                        Description = qt.Question.Description,

                        Answers = qt.Question.Answers
                        .Select(a => new AnswerViewModel()
                        {
                            Value = a.Value
                        })
                        .ToList(),

                        CorrectAnswer = new AnswerViewModel()
                        {
                            Value = qt.Question.RightAnswer
                        }
                    })
                    .ToList()
                };

                ViewBag.JsonData = JsonSerializer.Serialize(viewModel
                    .Questions.Select(x => x.CorrectAnswer));

                return View(viewModel);
            }


            return RedirectToAction("Error");
        }

        public IActionResult ShowTestResult(string answers, 
            string classCategory)
        {
            var model = new ShowTestResultViewModel()
            {
                CorrectAnswers = answers,
                ClassCategory = classCategory
            };

            return View("ShowTestResult", model);
        }

        //?
        public IActionResult Question(QuestionModel model)
        {
            // .LoadQuestionById(model.id)
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None,
            NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ??
            HttpContext.TraceIdentifier
            });
        }
    }
}
