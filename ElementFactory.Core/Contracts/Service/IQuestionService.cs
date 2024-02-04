namespace ElementFactory.Core.Contracts.Service
{
    using ElementFactory.Data.Models;

    /// <summary>
    /// Interface for Question Service
    /// </summary>
    public interface IQuestionService
    {
        /// <summary>
        /// Asynchronous method for adding an entity
        /// </summary>
        /// <param name="entity">Question entity</param>
        /// <returns>(void)</returns>
        public Task AddAsync(Question entity);

        public Task SaveChangesAsync();

        /// <summary>
        /// Asynchronous method for deleting an entity by id
        /// </summary>
        /// <param name="id">Entity Id</param>
        /// <returns>(void)</returns>
        public Task DeleteAsync(int id);

        /// <summary>
        /// Asynchronous method for loading all entities
        /// </summary>
        /// <returns>Collection with entities</returns>
        public Task<IEnumerable<Question>> GetAllAsync();

        public Task<Question> GetByIdAsync(int id);

        public Task UpdateAsync(int id, Question entity);
    }
}
