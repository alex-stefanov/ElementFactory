namespace ElementFactory.Tests.RepositoryTests
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Core.Implementations.Repositories;
    using ElementFactory.Data.Models;
    using ElementFactory.Tests.UnitTests.Mocks;
    using Microsoft.EntityFrameworkCore;
    using NUnit.Framework;

    [TestFixture]
    public class TestRepositoryTests : UnitTestBase
    {
        private ITestRepository repository;

        [SetUp]
        public void SetUp()
        {
            this.context = DatabaseMock.Mock;
            this.repository = new TestRepository(context);
        }

        [Test]
        public async Task AddAsync_ShouldAddEntity()
        {
            await this.SeedData();

            var test = new Test()
            {
                Category = "NewCategory",
                Title = "NewTitle"
            };

            var countBefore = await this.context.Tests.CountAsync();

            await this.repository.AddAsync(test);

            var countAfter = await this.context.Tests.CountAsync();

            Assert.That(countAfter - countBefore == 1);
        }

        [Test]
        public async Task DeleteAsync_ShouldDeleteEntity()
        {
            await this.SeedData();

            var countBefore = await this.context.Tests.Where(a => a.IsActive).CountAsync();

            await this.repository.DeleteAsync(1);

            var countAfter = await this.context.Tests.Where(a => a.IsActive).CountAsync();

            Assert.That(countBefore - countAfter == 1);

            Assert.ThrowsAsync<ArgumentException>(() =>
            {
                return this.repository.DeleteAsync(-1);
            });
        }

        [Test]
        public async Task GetAllAsync_ShouldGetEntities()
        {
            await this.SeedData();

            var countBefore = await this.context.Tests.CountAsync();

            var all = await this.repository.GetAllAsync();

            var countAfter = all.Count();

            Assert.That(countAfter == countBefore);
        }

        [Test]
        public async Task GetByIdAsync_ShouldGetEntity()
        {
            await this.SeedData();

            var entity = await this.repository.GetByIdAsync(1);

            Assert.That(entity.Id == 1);
            Assert.ThrowsAsync<ArgumentException>(() =>
            {
                return this.repository.GetByIdAsync(-1);
            });
        }

        [Test]
        public async Task UpdateAsync_ShouldUpdateEntity()
        {
            await this.SeedData();

            var updatedBefore = await this.context.Tests.FindAsync(1);
            var updatedBeforeCategory = updatedBefore.Category;
            var updatedBeforeTitle = updatedBefore.Title;
            var updatedBeforeQT = updatedBefore.QuestionsTests;

            await this.repository.UpdateAsync(1, new Test() { Category = "NewCategory", Title = "NewTitle" });

            var updatedAfter = await this.context.Tests.FindAsync(1);
            var updatedAfterCategory = updatedAfter.Category;
            var updatedAfterTitle = updatedAfter.Title;
            var updatedAfterQT = updatedAfter.QuestionsTests;

            Assert.That(updatedBeforeCategory != updatedAfterCategory);
            Assert.That(updatedBeforeTitle != updatedAfterTitle);
            Assert.That(updatedBeforeQT != updatedAfterQT);
        }

        [Test]
        public async Task SaveChangesAsync_ShouldSaveChanges()
        {
            await this.SeedData();

            var savedBefore = await this.context.Tests.CountAsync();

            await this.repository.SaveChangesAsync();

            var savedAfter = await this.context.Tests.CountAsync(); ;

            Assert.That(savedBefore == savedAfter);
        }

        [Test]
        public async Task LoadTestAsync_ShouldLoadEntity()
        {
            await this.SeedData();

            var test = await this.repository.LoadTestAsync(1);

            Assert.That(test.Id == 1);
        }

        [Test]
        public async Task GetByGradeAsync_ShouldLoadEntity()
        {
            await this.SeedData();

            var tests = await this.repository.GetByGradeAsync("Category");

            Assert.That(tests.First().Id == 1);
        }

        private async Task SeedData()
        {
            var question = new Question()
            {
                Description = "Description",
                RightAnswer = "Test1"
            };

            var answer1 = new Answer()
            {
                QuestionId = 1,
                Value = "Answer1"
            };

            var answer2 = new Answer()
            {
                QuestionId = 1,
                Value = "Answer2"
            };

            var answer3 = new Answer()
            {
                QuestionId = 1,
                Value = "Answer3"
            };

            var answer4 = new Answer()
            {
                QuestionId = 1,
                Value = "Answer4"
            };

            var test = new Test()
            {
                Category = "Category",
                Title = "Title"
            };

            var questionTest = new QuestionTestMap()
            {
                QuestionId = 1,
                TestId = 1
            };

            await this.context.Questions.AddAsync(question);
            await this.context.SaveChangesAsync();

            await this.context.Answers.AddAsync(answer1);
            await this.context.Answers.AddAsync(answer2);
            await this.context.Answers.AddAsync(answer3);
            await this.context.Answers.AddAsync(answer4);
            await this.context.SaveChangesAsync();
            
            await this.context.Tests.AddAsync(test);
            await this.context.SaveChangesAsync();

            await this.context.QuestionsTests.AddAsync(questionTest);
            await this.context.SaveChangesAsync();
        }
    }
}
