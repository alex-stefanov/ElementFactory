namespace ElementFactory.Core.Contracts.Service
{
    using ElementFactory.Data.Models;

    /// <summary>
    /// Interface for Test Service
    /// </summary>
    public interface ITestService
    {
        /// <summary>
        /// Asynchronous method for adding an entity
        /// </summary>
        /// <param name="entity">Test entity</param>
        /// <returns>(void)</returns>
        public Task AddAsync(Test entity);

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
        public Task<IEnumerable<Test>> GetAllAsync();

        public Task<Test> GetByIdAsync(int id);

        public Task UpdateAsync(int id, Test entity);

        public Task<Test?> LoadTestAsync(int id);

        public Task<IEnumerable<Test>> GetByGradeAsync(string grade);
    }
}
