namespace ElementFactory.Controllers
{
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
    using System.Text.Json.Serialization;

    public class QuestionController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IQuestionService questionService;
        private readonly ITestService testService;
        private readonly IAnswerService answerService;
        private readonly IQuestionTestMapService questionTestMapService;

        public QuestionController(ILogger<HomeController> logger,
            IQuestionService questionService,
            ITestService testService,
            IAnswerService answerService,
            IQuestionTestMapService questionTestMapService)
        {
            this.logger = logger;
            this.questionService = questionService;
            this.testService = testService;
            this.answerService = answerService;
            this.questionTestMapService = questionTestMapService;
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
        public IActionResult AddTestPost(TestViewModel model)
        {
            if (ModelState.IsValid)
            {
                var testModel = new AddQuestionsCurrentQuestionModel()
                {
                    TestCategory = model.Category,
                    TestTitle = model.Title,
                    NumberOfQ = model.QuestionsCounter
                };

                return RedirectToAction("ChooseAddType", testModel);
            }

            return View("AddTestGet", model);
        }

        [HttpGet]
        public async Task<IActionResult> EditTestGet(int id)
        {
            var entity = await this.testService.GetByIdAsync(id);

            if (entity == null)
            {
                return RedirectToAction("Error");
            }

            EditTestViewModel model = new EditTestViewModel()
            {
                Id = entity.Id,
                Category = entity.Category,
                Title = entity.Title,
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditTestPost(EditTestViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("EditTestGet", model);
            }

            var entity = new Test()
            {
                Id = model.Id,
                Category = model.Category,
                Title = model.Title
            };

            await this.testService.UpdateAsync(model.Id, entity);

            return RedirectToAction("TestsByGrade", new
            {
                grade = model.Category.Split(" ")[0]
            });
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
            string classCategory, int questions)
        {
            var model = new ShowTestResultViewModel()
            {
                CorrectAnswers = answers,
                ClassCategory = classCategory,
                Questions = questions
            };

            return View("ShowTestResult", model);
        }

        public IActionResult ChooseAddType(
            AddQuestionsCurrentQuestionModel entity)
        {
            return View(entity);
        }

        [HttpPost]
        public IActionResult AddQuestionsOnOwn(
            AddQuestionsCurrentQuestionModel model)
        {
            if (ModelState.IsValid)
            {
                List<Question> questions = new List<Question>();
                foreach (string json in model.QuestionsJSON)
                {
                    questions.Add(JsonSerializer.Deserialize<Question>(json,
                    new JsonSerializerOptions()
                    {
                        ReferenceHandler = ReferenceHandler.IgnoreCycles
                    }));
                }

                var question = new Question()
                {
                    RightAnswer = model.RightAnswer.Value,
                    Description = model.Description
                };

                var answer1 = new Answer()
                {
                    Question = question,
                    Value = model.Answer1.Value
                };

                var answer2 = new Answer()
                {
                    Question = question,
                    Value = model.Answer2.Value
                };

                var answer3 = new Answer()
                {
                    Question = question,
                    Value = model.Answer3.Value
                };

                var answer4 = new Answer()
                {
                    Question = question,
                    Value = model.Answer4.Value
                };

                var answers = new List<Answer>()
                    {
                          answer1,
                          answer2,
                          answer3,
                          answer4
                    };

                question.Answers = answers;
                model.Questions = questions;
                model.Questions.Add(question);

                    return View("AddQuestionsOnOwn", model);   
            }

            else
            {
                List<Question> questions = new List<Question>();
                foreach (string json in model.QuestionsJSON)
                {
                    questions.Add(JsonSerializer.Deserialize<Question>(json,
                    new JsonSerializerOptions()
                    {
                        ReferenceHandler = ReferenceHandler.IgnoreCycles
                    }));
                }

                model.Questions = questions;

                return View(model);
            }

        }

        public async Task<IActionResult> AddQuestionsOnOwnLast(
           AddQuestionsCurrentQuestionModel model)
        {
            if (ModelState.IsValid)
            {
                List<Question> questions = new List<Question>();
                foreach (string json in model.QuestionsJSON)
                {
                    questions.Add(JsonSerializer.Deserialize<Question>(json,
                    new JsonSerializerOptions()
                    {
                        ReferenceHandler = ReferenceHandler.IgnoreCycles
                    }));
                }

                var question = new Question()
                {
                    RightAnswer = model.RightAnswer.Value,
                    Description = model.Description
                };

                var answer1 = new Answer()
                {
                    Id = 0,
                    Question = question,
                    Value = model.Answer1.Value
                };

                var answer2 = new Answer()
                {
                    Id = 0,
                    Question = question,
                    Value = model.Answer2.Value
                };

                var answer3 = new Answer()
                {
                    Id = 0,
                    Question = question,
                    Value = model.Answer3.Value
                };

                var answer4 = new Answer()
                {
                    Id = 0,
                    Question = question,
                    Value = model.Answer4.Value
                };

                var answers = new List<Answer>()
            {
                answer1,
                answer2,
                answer3,
                answer4
            };

                question.Answers = answers;

                model.Questions = questions;
                model.Questions.Add(question);

                var test = new Test()
                {
                    Title = model.TestTitle,
                    Category = model.TestCategory
                };

                await this.testService.AddAsync(test);

                foreach (Question questionEntity in model.Questions)
                {
                    await this.questionService.AddAsync(questionEntity);
                    await this.questionTestMapService.AddAsync(new QuestionTestMap()
                    {
                        QuestionId = questionEntity.Id,
                        TestId = test.Id
                    });
                }

                return RedirectToAction("TestsByGrade", new
                {
                    grade = model.TestCategory.Split(" ")[0]
                });
            }

            else
            {
                List<Question> questions = new List<Question>();
                foreach (string json in model.QuestionsJSON)
                {
                    questions.Add(JsonSerializer.Deserialize<Question>(json,
                    new JsonSerializerOptions()
                    {
                        ReferenceHandler = ReferenceHandler.IgnoreCycles
                    }));
                }

                model.Questions = questions;

                return View("AddQuestionsOnOwn", model);
            }
        }

        public async Task<IActionResult> AddQuestionsChoose(
            AddQuestionsChooseModel model)
        {
            var questionsEntities = await this.questionService
                .GetByGradeAsync(model.TestCategory);

            model.Questions = questionsEntities.ToList();

            return View(model);
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
