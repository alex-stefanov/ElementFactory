namespace ElementFactory.Core.Implementations.Services
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Core.Contracts.Service;
    using ElementFactory.Data.Models;

    /// <summary>
    /// Implementation for Question Service
    /// </summary>
    public class QuestionService : IQuestionService
    {
        /// <summary>
        /// Field for repository
        /// </summary>
        private readonly IQuestionRepository repository;

        /// <summary>
        /// Default Constructor for injection of a repository
        /// </summary>
        /// <param name="repository">Question Repository</param>
        public QuestionService(IQuestionRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Asynchronous method for adding an entity to repository
        /// </summary>
        /// <param name="entity">Question entity</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(Question entity)
        {
            await repository.AddAsync(entity);
        }

        /// <summary>
        /// Asynchronous method for deleting an entity by id from repository
        /// </summary>
        /// <param name="id">Entity Id</param>
        /// <returns>(void)</returns>
        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        /// <summary>
        /// Asynchronous method for loading all entities
        /// </summary>
        /// <returns>Collection with entities</returns>
        public async Task<IEnumerable<Question>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<Question> GetByIdAsync(int id)
        {
            return await repository.GetByIdAsync(id);
        }

        public async Task SaveChangesAsync()
        {
            await repository.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, Question entity)
        {
            await repository.UpdateAsync(id, entity);
        }
    }
}
