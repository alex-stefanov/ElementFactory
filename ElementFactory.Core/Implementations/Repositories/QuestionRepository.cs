namespace ElementFactory.Core.Implementations.Repositories
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Data;
    using ElementFactory.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class QuestionRepository : IQuestionRepository
    {
        private readonly ApplicationDbContext context;

        public QuestionRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(Question entity)
        {
            await context.Questions.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await context
                .Questions
                .FirstOrDefaultAsync(q => q.Id == id)
                ?? throw new ArgumentException("Invalid id!");

            context.Questions.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Question>> GetAllAsync()
        {
            return await context
                .Questions
                .ToListAsync();
        }

        public async Task<Question> GetByIdAsync(int id)
        {
            var entity = await context.Questions
                .FirstOrDefaultAsync(q => q.Id == id);

            return entity ?? throw new ArgumentException("Invalid id!");
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, Question entity)
        {
            var entityToUpdate = await context
                .Questions
                .FirstOrDefaultAsync(q => q.Id == id)
                ?? throw new ArgumentException("Invalid id!");

            entityToUpdate.QuestionsTests = entity.QuestionsTests;
            entityToUpdate.RightAnswer = entity.RightAnswer;
            entityToUpdate.Answers = entity.Answers;
            entityToUpdate.Description = entity.Description;
            entityToUpdate.Id = entity.Id;

            await context.SaveChangesAsync();
        }
    }
}
