namespace ElementFactory.Core.Contracts.Service
{
    using ElementFactory.Data.Models;

    public interface IQuestionService
    {
        public Task AddAsync(Question entity);

        public Task SaveChangesAsync();

        public Task DeleteAsync(int id);

        public Task<IEnumerable<Question>> GetAllAsync();

        public Task<Question> GetByIdAsync(int id);

        public Task UpdateAsync(int id, Question entity);
    }
}
