namespace ElementFactory.Tests.RepositoryTests
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Core.Implementations.Repositories;
    using ElementFactory.Data.Models;
    using ElementFactory.Tests.UnitTests.Mocks;
    using Microsoft.EntityFrameworkCore;
    using NUnit.Framework;

    [TestFixture]
    public class QuestionRepositoryQuestions : UnitTestBase
    {
        private IQuestionRepository repository;

        [SetUp]
        public void SetUp()
        {
            this.context = DatabaseMock.Mock;
            this.repository = new QuestionRepository(context);
        }

        [Test]
        public async Task AddAsync_ShouldAddEntity()
        {
            await this.SeedData();

            var question = new Question()
            {
                RightAnswer = "RightAnswer",
                Description = "Description"
            };

            var countBefore = await this.context.Questions.CountAsync();

            await this.repository.AddAsync(question);

            var countAfter = await this.context.Questions.CountAsync();

            Assert.That(countAfter - countBefore == 1);
        }

        [Test]
        public async Task DeleteAsync_ShouldDeleteEntity()
        {
            await this.SeedData();

            var countBefore = await this.context.Questions.Where(a => a.IsActive).CountAsync();

            await this.repository.DeleteAsync(1);

            var countAfter = await this.context.Questions.Where(a => a.IsActive).CountAsync();

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

            var countBefore = await this.context.Questions.CountAsync();

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

            var updatedBefore = await this.context.Questions.FindAsync(1);
            var updatedBeforeRightAnswer = updatedBefore.RightAnswer;
            var updatedBeforeAnswers = updatedBefore.Answers;
            var updatedBeforeQT = updatedBefore.QuestionsTests;
            var updatedBeforeDescription = updatedBefore.Description;

            await this.repository.UpdateAsync(1, new Question() { RightAnswer = "NewRightAnswer", Description = "NewDescription" });

            var updatedAfter = await this.context.Questions.FindAsync(1);
            var updatedAfterRightAnswer = updatedAfter.RightAnswer;
            var updatedAfterAnswers = updatedAfter.Answers;
            var updatedAfterQT = updatedAfter.QuestionsTests;
            var updatedAfterDescription = updatedAfter.Description;

            Assert.That(updatedBeforeRightAnswer != updatedAfterRightAnswer);
            Assert.That(updatedBeforeAnswers != updatedAfterAnswers);
            Assert.That(updatedBeforeQT != updatedAfterQT);
            Assert.That(updatedBeforeDescription != updatedAfterDescription);
        }

        [Test]
        public async Task SaveChangesAsync_ShouldSaveChanges()
        {
            await this.SeedData();

            var savedBefore = await this.context.Questions.CountAsync();

            await this.repository.SaveChangesAsync();

            var savedAfter = await this.context.Questions.CountAsync(); ;

            Assert.That(savedBefore == savedAfter);
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
