namespace ElementFactory.Core.Implementations.Services
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Core.Contracts.Service;
    using ElementFactory.Core.Implementations.Repositories;
    using ElementFactory.Data.Models;

    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository repository;

        public QuestionService(IQuestionRepository repository)
        {
            this.repository = repository;
        }

        public async Task AddAsync(Question entity)
        {
            await repository.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

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
