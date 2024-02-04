namespace ElementFactory.Core.Implementations.Services
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Core.Contracts.Service;
    using ElementFactory.Data.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Implementation for Test Service
    /// </summary>
    public class TestService : ITestService
    {
        /// <summary>
        /// Field for repository
        /// </summary>
        private readonly ITestRepository repository;

        /// <summary>
        /// Default Constructor for injection of a repository
        /// </summary>
        /// <param name="repository">Test Repository</param>
        public TestService(ITestRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Asynchronous method for adding an entity to repository
        /// </summary>
        /// <param name="entity">Test entity</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(Test entity)
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
        public async Task<IEnumerable<Test>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
