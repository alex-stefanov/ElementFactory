namespace ElementFactory.Core.Contracts.Service
{
    using ElementFactory.Data.Models;

    public interface ITestService
    {
        public Task AddAsync(Test entity);

        public Task SaveChangesAsync();

        public Task DeleteAsync(int id);

        public Task<IEnumerable<Test>> GetAllAsync();

        public Task<Test> GetByIdAsync(int id);

        public Task UpdateAsync(int id, Test entity);

        public Task<Test?> LoadTestAsync(int id);

        public Task<IEnumerable<Test>> GetByGradeAsync(string grade);
    }
}
