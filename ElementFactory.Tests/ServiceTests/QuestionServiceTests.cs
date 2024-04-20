namespace ElementFactory.Tests.ServiceTests
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Core.Contracts.Service;
    using ElementFactory.Core.Implementations.Services;
    using ElementFactory.Data.Models;
    using ElementFactory.Tests.UnitTests.Mocks;
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class QuestionServiceTests : UnitTestBase
    {
        private IQuestionService service;

        private IQuestionRepository repository;

        private int count = 0;
        private bool updated = false;
        private bool savedChanges = false;
        private bool getByGrade = false;

        [SetUp]
        public void Setup()
        {
            var repoMock = new Mock<IQuestionRepository>();

            this.context = DatabaseMock.Mock;

            this.count = 0;
            this.updated = false;
            this.savedChanges = false;
            this.getByGrade = false;

            repoMock.Setup(r => r.AddAsync(It.IsAny<Question>()))
                .Callback<Question>(a =>
                {
                    this.count++;
                });

            repoMock.Setup(r => r.DeleteAsync(It.IsAny<int>()))
                .Callback<int>(a =>
                {
                    this.count--;
                });

            IEnumerable<Question> questions = new List<Question>()
            {
                new Question(){Id = 1},
                new Question(){Id = 2},
            };

            repoMock
                .Setup(r => r.GetAllAsync())
                .Returns(Task.FromResult(questions));

            var Question = new Question() { Id = 10 };

            repoMock.Setup(r => r.GetByIdAsync(It.IsAny<int>()))
                .Returns(Task.FromResult(Question));

            repoMock.Setup(r => r.UpdateAsync(It.IsAny<int>(), It.IsAny<Question>()))
                .Callback(() =>
                {
                    this.updated = true;
                });

            repoMock.Setup(r => r.SaveChangesAsync())
                .Callback(() =>
                {
                    this.savedChanges = true;
                });

            repoMock.Setup(r => r.GetByGradeAsync(It.IsAny<string>()))
                .Callback(() =>
                {
                    this.getByGrade = true;
                });

            this.repository = repoMock.Object;

            this.service = new QuestionService(this.repository);
        }

        [Test]
        public async Task AddAsync_ShouldAddEntity()
        {
            var question = new Question()
            {
                Id = 1,
                RightAnswer = "RightAnswer",
                Description = "Description"
            };

            var countBefore = await this.context.Questions.CountAsync();

            await this.service.AddAsync(question);

            var countAfter = this.count;

            Assert.That(countAfter - countBefore == 1);
        }

        [Test]
        public async Task DeleteAsync_ShouldDeleteEntity()
        {
            var countBefore = await this.context.Questions.CountAsync();

            await this.service.DeleteAsync(1);

            var countAfter = this.count;

            Assert.That(countBefore - countAfter == 1);
        }

        [Test]
        public async Task GetAllAsync_ShouldGetEntities()
        {
            var countBefore = await this.context.Questions.CountAsync();

            var all = await this.service.GetAllAsync();

            var countAfter = all.Count();

            Assert.That(countAfter - countBefore == 2);
        }

        [Test]
        public async Task GetByIdAsync_ShouldGetEntity()
        {
            var entity = await this.service.GetByIdAsync(10);

            Assert.That(entity.Id == 10);
        }

        [Test]
        public async Task UpdateAsync_ShouldUpdateEntity()
        {
            var updatedBefore = this.updated;

            await this.service.UpdateAsync(1, new Question());

            var updatedAfter = this.updated;

            Assert.That(updatedBefore != updatedAfter);
        }

        [Test]
        public async Task SaveChangesAsync_ShouldSaveChanges()
        {
            var savedBefore = this.savedChanges;

            await this.service.SaveChangesAsync();

            var savedAfter = this.savedChanges;

            Assert.That(savedBefore != savedAfter);
        }

        [Test]
        public async Task GetByGradeAsync_ShouldGetEntity()
        {
            var getByGradeBefore = this.getByGrade;

            await this.service.GetByGradeAsync("Grade");

            var getByGradeAfter = this.getByGrade;

            Assert.That(getByGradeBefore != getByGradeAfter);
        }
    }
}
