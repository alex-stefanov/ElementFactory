namespace ElementFactory.Controllers
{
    using ElementFactory.Data;
    using ElementFactory.Models.Question;
    using Microsoft.AspNetCore.Mvc;
    using ElementFactory.Models.Test;
    using ElementFactory.Models.Answer;
    using ElementFactory.Data.Models;
    using ElementFactory.Models;
    using System.Diagnostics;
    using System.Text.Json;
    using ElementFactory.Models.Others;
    using ElementFactory.Core.Contracts.Service;

    public class QuestionController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IQuestionService questionService;
        private readonly ITestService testService;

        public QuestionController(ILogger<HomeController> logger,
            IQuestionService questionService,
            ITestService testService)
        {
            this.logger = logger;
            this.questionService = questionService;
            this.testService = testService;
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
        public async Task<IActionResult> TestsByGrade(string grade)
        {
            var testsEntities = 
                await this.testService.GetByGradeAsync(grade);

            var models = testsEntities
                .Select(t => new TestViewModel()
            {
                Id = t.Id,
                Category = t.Category,
                Title = t.Title,
                Questions = t.QuestionsTests
                .Select(qt => new QuestionViewModel()
                {
                    Id = qt.Question.Id,
                    Description = qt.Question.Description,
                    CorrectAnswer = new AnswerViewModel() 
                    {
                        Value = qt.Question.RightAnswer 
                    },
                    Answers = qt.Question
                    .Answers.Select(a => new AnswerViewModel()
                    {
                        Value = a.Value
                    }).ToList()
                })
                .ToList(),

            })
                .ToList();

            ViewBag.Title = $"Тестове за {grade} клас";

            return View(models);
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

                await this.testService.AddAsync(testEntity);

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
            var test = await this.testService.GetByIdAsync(id);

            var category = test.Category;

            await this.testService.DeleteAsync(id);

            return RedirectToAction("TestsByGrade", new
            {
                grade = category.Split(" ")[0]
            });
        }

        [HttpGet]
        public async Task<IActionResult> LoadTest(int id)
        {
            var model = await this.testService.LoadTestAsync(id);

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

        [ResponseCache(
            Duration = 0, 
            Location = ResponseCacheLocation.None,
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
