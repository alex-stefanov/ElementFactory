namespace ElementFactory.Core.Implementations.Repositories
{
    using ElementFactory.Data.Models;
    using ElementFactory.Data;
    using Microsoft.EntityFrameworkCore;
    using ElementFactory.Core.Contracts.Repositories;

    public class TestRepository : ITestRepository
    {
        private readonly ApplicationDbContext context;

        public TestRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(Test entity)
        {
            await context.Tests.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await context
                .Tests
                .FirstOrDefaultAsync(q => q.Id == id)
                ?? throw new ArgumentException("Invalid id!");

            context.Tests.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Test>> GetAllAsync()
        {
            return await context
                .Tests
                .ToListAsync();
        }

        public async Task<Test> GetByIdAsync(int id)
        {
            var entity = await context.Tests
                .FirstOrDefaultAsync(q => q.Id == id);

            return entity ?? throw new ArgumentException("Invalid id!");
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, Test entity)
        {
            var entityToUpdate = await context
                .Tests
                .FirstOrDefaultAsync(q => q.Id == id)
                ?? throw new ArgumentException("Invalid id!");

            entityToUpdate.Id = entity.Id;
            entityToUpdate.QuestionsTests = entity.QuestionsTests;
            entityToUpdate.Title = entity.Title;
            entityToUpdate.Category = entity.Category;

            await context.SaveChangesAsync();
        }

        public async Task<Test?> LoadTestAsync(int id)
        {
            return await context
                .Tests
                .Include(x => x.QuestionsTests)
                .ThenInclude(x => x.Question)
                .ThenInclude(x => x.Answers)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Test>> GetByGradeAsync(string grade)
        {
            var tests = await context
                .Tests
                .Include(t => t.QuestionsTests)
                .ThenInclude(t => t.Question)
                .ThenInclude(t => t.Answers)
                .Where(x => x.Category.Contains(grade))
                .ToListAsync();

            return tests;
        }
    }
}
