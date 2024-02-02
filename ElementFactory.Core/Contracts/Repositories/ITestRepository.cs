namespace ElementFactory.Core.Contracts.Repositories
{
    using ElementFactory.Data.Models;

    public interface ITestRepository : IRepository<Test>
    {
        public Task<IEnumerable<Test>> GetByGradeAsync(string grade);

        public Task<Test?> LoadTestAsync(int id);
    }
}
