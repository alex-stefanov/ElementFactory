namespace ElementFactory.Tests.RepositoryTests
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Core.Implementations.Repositories;
    using ElementFactory.Data.Models;
    using ElementFactory.Tests.UnitTests.Mocks;
    using Microsoft.EntityFrameworkCore;
    using NUnit.Framework;

    [TestFixture]
    public class AnswerRepositoryTests : UnitTestBase
    {
        private IAnswerRepository repository;

        [SetUp]
        public void SetUp()
        {
            this.context = DatabaseMock.Mock;
            this.repository = new AnswerRepository(context);
        }

        [Test]
        public async Task AddAsync_ShouldAddEntity()
        {
            await this.SeedData();

            var answer = new Answer()
            {
                QuestionId = 1,
                Value = "Answer"
            };

            var countBefore = await this.context.Answers.CountAsync();

            await this.repository.AddAsync(answer);

            var countAfter = await this.context.Answers.CountAsync();

            Assert.That(countAfter - countBefore == 1);
        }

        [Test]
        public async Task DeleteAsync_ShouldDeleteEntity()
        {
            await this.SeedData();

            var countBefore = await this.context.Answers.Where(a => a.IsActive).CountAsync();

            await this.repository.DeleteAsync(1);

            var countAfter = await this.context.Answers.Where(a => a.IsActive).CountAsync();

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

            var countBefore = await this.context.Answers.CountAsync();

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

            var updatedBefore = await this.context.Answers.FindAsync(1);
            var updatedBeforeValue = updatedBefore.Value;

            await this.repository.UpdateAsync(1, new Answer() { Value = "NewValue"});

            var updatedAfter = await this.context.Answers.FindAsync(1);
            var updatedAfterValue = updatedAfter.Value;

            Assert.That(updatedBeforeValue != updatedAfterValue);
        }

        [Test]
        public async Task SaveChangesAsync_ShouldSaveChanges()
        {
            var savedBefore = await this.context.Answers.CountAsync();

            await this.repository.SaveChangesAsync();

            var savedAfter = await this.context.Answers.CountAsync(); ;

            Assert.That(savedBefore == savedAfter);
        }

        private async Task SeedData()
        {
            var question = new Question()
            {
                Description = "Description",
                RightAnswer = "Answer1"
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

            await this.context.Questions.AddAsync(question);
            await this.context.SaveChangesAsync();  

            await this.context.Answers.AddAsync(answer1);
            await this.context.Answers.AddAsync(answer2);
            await this.context.Answers.AddAsync(answer3);
            await this.context.Answers.AddAsync(answer4);
            await this.context.SaveChangesAsync();
        }
    }
}
