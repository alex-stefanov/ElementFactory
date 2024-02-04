namespace ElementFactory.Core.Implementations.Repositories
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Data;
    using ElementFactory.Data.Models;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Implementation for Question Repository
    /// </summary>
    public class QuestionRepository : IQuestionRepository
    {
        /// <summary>
        /// Field for ApplicationDbContext - our DB Context
        /// </summary>
        private readonly ApplicationDbContext context;

        /// <summary>
        /// Default Constructor for injection of a DB Context
        /// </summary>
        /// <param name="context">Db Context</param>
        public QuestionRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Asynchronous method for adding an entity to context
        /// </summary>
        /// <param name="entity">Question entity</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(Question entity)
        {
            await context.Questions.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Asynchronous method for deleting an entity by id from context
        /// </summary>
        /// <param name="id">Entity Id</param>
        /// <returns>(void)</returns>
        public async Task DeleteAsync(int id)
        {
            var entity = await context
                .Questions
                .FirstOrDefaultAsync(q => q.Id == id)
                ?? throw new ArgumentException("Invalid id!");

            context.Questions.Remove(entity);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Asynchronous method for loading all entities
        /// </summary>
        /// <returns>Collection with entities</returns>
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
