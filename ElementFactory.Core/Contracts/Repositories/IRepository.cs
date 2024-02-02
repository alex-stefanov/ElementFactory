namespace ElementFactory.Core.Contracts.Repositories
{

    public interface IRepository<T>
    {
        public Task AddAsync(T entity);

        public Task SaveChangesAsync();

        public Task DeleteAsync(int id);

        public Task<IEnumerable<T>> GetAllAsync();

        public Task<T> GetByIdAsync(int id);

        public Task UpdateAsync(int id, T entity);
    }
}
