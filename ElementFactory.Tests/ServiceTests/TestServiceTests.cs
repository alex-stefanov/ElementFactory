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
    public class TestServiceTests : UnitTestBase
    {
        private ITestService service;

        private ITestRepository repository;

        private int count = 0;
        private bool updated = false;
        private bool savedChanges = false;
        private bool loadedTest = false;
        private bool getByGrade = false;

        [SetUp]
        public void Setup()
        {
            var repoMock = new Mock<ITestRepository>();

            this.context = DatabaseMock.Mock;

            this.count = 0;
            this.updated = false;
            this.savedChanges = false;
            this.loadedTest = false;
            this.getByGrade = false;

            repoMock.Setup(r => r.AddAsync(It.IsAny<Test>()))
                .Callback<Test>(a =>
                {
                    this.count++;
                });

            repoMock.Setup(r => r.DeleteAsync(It.IsAny<int>()))
                .Callback<int>(a =>
                {
                    this.count--;
                });

            IEnumerable<Test> tests = new List<Test>()
            {
                new Test(){Id = 1},
                new Test(){Id = 2},
            };

            repoMock
                .Setup(r => r.GetAllAsync())
                .Returns(Task.FromResult(tests));

            var Test = new Test() { Id = 10 };

            repoMock.Setup(r => r.GetByIdAsync(It.IsAny<int>()))
                .Returns(Task.FromResult(Test));

            repoMock.Setup(r => r.UpdateAsync(It.IsAny<int>(), It.IsAny<Test>()))
                .Callback(() =>
                {
                    this.updated = true;
                });

            repoMock.Setup(r => r.SaveChangesAsync())
                .Callback(() =>
                {
                    this.savedChanges = true;
                });

            repoMock.Setup(r => r.LoadTestAsync(1))
               .Callback(() =>
               {
                   this.loadedTest = true;
               })
               .Returns(Task.FromResult(new Test() { Id = 1 }));

            repoMock.Setup(r => r.GetByGradeAsync(It.IsAny<string>()))
                .Callback(() =>
                {
                    this.getByGrade = true;
                });

            this.repository = repoMock.Object;

            this.service = new TestService(this.repository);
        }

        [Test]
        public async Task AddAsync_ShouldAddEntity()
        {
            var test = new Test()
            {
                Id = 1,
                Category = "Category",
                Title = "Title"
            };

            var countBefore = await this.context.Tests.CountAsync();

            await this.service.AddAsync(test);

            var countAfter = this.count;

            Assert.That(countAfter - countBefore == 1);
        }

        [Test]
        public async Task DeleteAsync_ShouldDeleteEntity()
        {
            var countBefore = await this.context.Tests.CountAsync();

            await this.service.DeleteAsync(1);

            var countAfter = this.count;

            Assert.That(countBefore - countAfter == 1);
        }

        [Test]
        public async Task GetAllAsync_ShouldGetEntities()
        {
            var countBefore = await this.context.Tests.CountAsync();

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

            await this.service.UpdateAsync(1, new Test());

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
        public async Task LoadTestAsync_ShouldLoadEntity()
        {
            var loadedTestBefore = this.loadedTest;

            await this.service.LoadTestAsync(1);

            var loadedTestAfter = this.loadedTest;

            Assert.That(loadedTestBefore != loadedTestAfter);
            Assert.ThrowsAsync<ArgumentException>(() =>
            {
                return this.service.LoadTestAsync(-1);
            });
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
