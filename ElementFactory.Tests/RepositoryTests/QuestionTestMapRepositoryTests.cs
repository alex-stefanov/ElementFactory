namespace ElementFactory.Tests.RepositoryTests
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Core.Implementations.Repositories;
    using ElementFactory.Data.Models;
    using ElementFactory.Tests.UnitTests.Mocks;
    using Microsoft.EntityFrameworkCore;
    using NUnit.Framework;

    [TestFixture]
    public class QuestionTestMapRepositoryTests : UnitTestBase
    {
        private IQuestionTestMapRepository repository;

        [SetUp]
        public void SetUp()
        {
            this.context = DatabaseMock.Mock;

            this.repository = new QuestionTestMapRepository(context);
        }

        [Test]
        public async Task AddAsync_ShouldAddEntity()
        {
            await this.SeedData();

            var question = new QuestionTestMap()
            {
                TestId = 2,
                QuestionId = 2
            };

            var countBefore = await this.context.QuestionsTests.CountAsync();

            await this.repository.AddAsync(question);

            var countAfter = await this.context.QuestionsTests.CountAsync();

            Assert.That(countAfter - countBefore == 1);
        }

        [Test]
        public async Task DeleteAsync_ShouldDeleteEntity()
        {
            await this.SeedData();

            var countBefore = await this.context.QuestionsTests.Where(a => a.IsActive).CountAsync();

            await this.repository.DeleteAsync(1, 1);

            var countAfter = await this.context.QuestionsTests.Where(a => a.IsActive).CountAsync();

            Assert.That(countBefore - countAfter == 1);

            Assert.ThrowsAsync<ArgumentException>(() =>
            {
                return this.repository.DeleteAsync(-1, -1);
            });
        }

        [Test]
        public void DeleteAsync_ShouldThrowException()
        {
            Assert.ThrowsAsync<NotSupportedException>(() =>
            {
                return this.repository.DeleteAsync(1);
            });
        }

        [Test]
        public async Task GetAllAsync_ShouldGetEntities()
        {
            await this.SeedData();

            var countBefore = await this.context.QuestionsTests.CountAsync();

            var all = await this.repository.GetAllAsync();

            var countAfter = all.Count();

            Assert.That(countAfter == countBefore);
        }

        [Test]
        public async Task GetByIdAsync_ShouldGetEntity()
        {
            await this.SeedData();

            var entity = await this.repository.GetByIdAsync(11);

            Assert.That(entity.TestId == 1 && entity.QuestionId == 1);
            Assert.ThrowsAsync<ArgumentException>(() =>
            {
                return this.repository.GetByIdAsync(-1);
            });
        }

        [Test]
        public async Task UpdateAsync_ShouldUpdateEntity()
        {
            await this.SeedData();

            var updatedBefore = await this.context.QuestionsTests.FindAsync(1, 1);
            var updatedBeforeTestId = updatedBefore.TestId;
            var updatedBeforeQuestionId = updatedBefore.QuestionId;

            await this.repository.UpdateAsync(11, new QuestionTestMap() { TestId = 1, QuestionId = 1 });

            var updatedAfter = await this.context.QuestionsTests.FindAsync(1, 1);
            var updatedAfterTestId = updatedAfter.TestId;
            var updatedAfterQuestionId = updatedAfter.QuestionId;

            Assert.That(updatedBeforeTestId == updatedAfterTestId);
            Assert.That(updatedBeforeQuestionId == updatedAfterQuestionId);
        }

        [Test]
        public async Task SaveChangesAsync_ShouldSaveChanges()
        {
            await this.SeedData();

            var savedBefore = await this.context.QuestionsTests.CountAsync();

            await this.repository.SaveChangesAsync();

            var savedAfter = await this.context.QuestionsTests.CountAsync(); ;

            Assert.That(savedBefore == savedAfter);
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
