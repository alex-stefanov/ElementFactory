namespace ElementFactory.Core.Implementations.Services
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Core.Contracts.Service;
    using ElementFactory.Core.Implementations.Services;
    using ElementFactory.Data.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class TestService : ITestService
    {
        private readonly ITestRepository repository;

        public TestService(ITestRepository repository)
        {
            this.repository = repository;
        }

        public async Task AddAsync(Test entity)
        {
            await repository.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Test>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<Test> GetByIdAsync(int id)
        {
            return await repository.GetByIdAsync(id);
        }

        public async Task SaveChangesAsync()
        {
            await repository.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, Test entity)
        {
            await repository.UpdateAsync(id, entity);
        }

        public async Task<Test?> LoadTestAsync(int id)
        {
            var test = await repository.LoadTestAsync(id);

            return test ?? throw new ArgumentException("Invalid test!");
        }

        public async Task<IEnumerable<Test>> GetByGradeAsync(string grade)
        {
            return await repository.GetByGradeAsync(grade);
        }
    }
}
