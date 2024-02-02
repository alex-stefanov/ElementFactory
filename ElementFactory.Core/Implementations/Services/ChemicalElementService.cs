namespace ElementFactory.Core.Implementations.Services
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Core.Contracts.Service;
    using ElementFactory.Data.Models;

    public class ChemicalElementService : IChemicalElementService
    {
        private readonly IChemicalElementRepository repository;

        public ChemicalElementService(IChemicalElementRepository repository)
        {
            this.repository = repository;
        }

        public async Task AddAsync(ChemicalElement entity)
        {
            await repository.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ChemicalElement>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<ChemicalElement> GetByIdAsync(int id)
        {
            return await repository.GetByIdAsync(id);
        }

        public async Task SaveChangesAsync()
        {
            await repository.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, ChemicalElement entity)
        {
            await repository.UpdateAsync(id, entity);
        }
    }
}
