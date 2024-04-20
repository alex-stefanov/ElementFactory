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
    public class AnswerServiceTests : UnitTestBase
    {
        private IAnswerService service;

        private IAnswerRepository repository;

        private int count = 0;
        private bool updated = false;
        private bool savedChanges = false;

        [SetUp]
        public void Setup()
        {
            var repoMock = new Mock<IAnswerRepository>();

            this.context = DatabaseMock.Mock;

            this.count = 0;
            this.updated = false;
            this.savedChanges = false;

            repoMock.Setup(r => r.AddAsync(It.IsAny<Answer>()))
                .Callback<Answer>(a =>
                {
                    this.count++;
                });

            repoMock.Setup(r => r.DeleteAsync(It.IsAny<int>()))
                .Callback<int>(a =>
                {
                    this.count--;
                });

            IEnumerable<Answer> answers = new List<Answer>()
            {
                new Answer(){Id = 1},
                new Answer(){Id = 2},
            };

            repoMock
                .Setup(r => r.GetAllAsync())
                .Returns(Task.FromResult(answers));

            var answer = new Answer() { Id = 10 };

            repoMock.Setup(r => r.GetByIdAsync(It.IsAny<int>()))
                .Returns(Task.FromResult(answer));

            repoMock.Setup(r => r.UpdateAsync(It.IsAny<int>(), It.IsAny<Answer>()))
                .Callback(() =>
                {
                    this.updated = true;
                });

            repoMock.Setup(r => r.SaveChangesAsync())
                .Callback(() =>
                {
                    this.savedChanges = true;
                });

            this.repository = repoMock.Object;

            this.service = new AnswerService(this.repository);
        }

        [Test]
        public async Task AddAsync_ShouldAddEntity()
        {
            var answer = new Answer()
            {
                Id = 1,
                QuestionId = 1,
                Value = "Answer"
            };

            var countBefore = await this.context.Answers.CountAsync();

            await this.service.AddAsync(answer);

            var countAfter = this.count;

            Assert.That(countAfter - countBefore == 1);
        }

        [Test]
        public async Task DeleteAsync_ShouldDeleteEntity()
        {
            var countBefore = await this.context.Answers.CountAsync();

            await this.service.DeleteAsync(1);

            var countAfter = this.count;

            Assert.That(countBefore - countAfter == 1);
        }

        [Test]
        public async Task GetAllAsync_ShouldGetEntities()
        {
            var countBefore = await this.context.Answers.CountAsync();

            var all =  await this.service.GetAllAsync();

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

            await this.service.UpdateAsync(1, new Answer());

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
    }
}
