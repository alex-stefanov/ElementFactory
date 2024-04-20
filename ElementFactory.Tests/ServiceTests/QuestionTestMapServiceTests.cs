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
    public class QuestionTestMapServiceTests : UnitTestBase
    {
        private IQuestionTestMapService service;

        private IQuestionTestMapRepository repository;

        private int count = 0;
        private bool updated = false;
        private bool savedChanges = false;

        [SetUp]
        public void Setup()
        {
            var repoMock = new Mock<IQuestionTestMapRepository>();

            this.context = DatabaseMock.Mock;

            this.count = 0;
            this.updated = false;
            this.savedChanges = false;

            repoMock.Setup(r => r.AddAsync(It.IsAny<QuestionTestMap>()))
                .Callback<QuestionTestMap>(a =>
                {
                    this.count++;
                });

            repoMock.Setup(r => r.DeleteAsync(It.IsAny<int>(), It.IsAny<int>()))
                .Callback<int, int>((a, b) =>
                {
                    this.count--;
                });

            IEnumerable<QuestionTestMap> questionsTestsMap = new List<QuestionTestMap>()
            {
                new QuestionTestMap(){QuestionId = 1, TestId = 1},
                new QuestionTestMap(){QuestionId = 2, TestId = 2},
            };

            repoMock
                .Setup(r => r.GetAllAsync())
                .Returns(Task.FromResult(questionsTestsMap));

            var questionTestMap = new QuestionTestMap() {QuestionId = 10, TestId = 10 };

            repoMock.Setup(r => r.GetByIdAsync(It.IsAny<int>()))
                .Returns(Task.FromResult(questionTestMap));

            repoMock.Setup(r => r.UpdateAsync(It.IsAny<int>(), It.IsAny<QuestionTestMap>()))
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

            this.service = new QuestionTestMapService(this.repository);
        }

        [Test]
        public async Task AddAsync_ShouldAddEntity()
        {
            var chemicalElement = new QuestionTestMap()
            {
                TestId = 1,
                QuestionId = 1
            };

            var countBefore = await this.context.ChemicalElements.CountAsync();

            await this.service.AddAsync(chemicalElement);

            var countAfter = this.count;

            Assert.That(countAfter - countBefore == 1);
        }

        [Test]
        public async Task DeleteAsync_ShouldDeleteEntity()
        {
            var countBefore = await this.context.QuestionsTests.CountAsync();

            await this.service.DeleteAsync(1, 1);

            var countAfter = this.count;

            Assert.That(countBefore - countAfter == 1);
        }

        [Test]
        public async Task GetAllAsync_ShouldGetEntities()
        {
            var countBefore = await this.context.ChemicalElements.CountAsync();

            var all = await this.service.GetAllAsync();

            var countAfter = all.Count();

            Assert.That(countAfter - countBefore == 2);
        }

        [Test]
        public async Task GetByIdAsync_ShouldGetEntity()
        {
            var entity = await this.service.GetByIdAsync(1010);

            Assert.That(entity.QuestionId == 10 && entity.TestId == 10);
        }

        [Test]
        public async Task UpdateAsync_ShouldUpdateEntity()
        {
            var updatedBefore = this.updated;

            await this.service.UpdateAsync(1, new QuestionTestMap());

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
