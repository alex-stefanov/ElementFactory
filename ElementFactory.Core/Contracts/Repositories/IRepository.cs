namespace ElementFactory.Core.Contracts.Repositories
{
    /// <summary>
    /// Interface for abstract repository
    /// </summary>
    public interface IRepository<T>
    {
        /// <summary>
        /// Asynchronous method for adding an entity
        /// </summary>
        /// <param name="entity">Generic Entity</param>
        /// <returns>(void)</returns>
        public Task AddAsync(T entity);

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
        public Task<IEnumerable<T>> GetAllAsync();

        public Task<T> GetByIdAsync(int id);

        public Task UpdateAsync(int id, T entity);
    }
}
