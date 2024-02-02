namespace ElementFactory.Core.Contracts.Service
{
    using ElementFactory.Data.Models;

    public interface IChemicalElementService
    {
        public Task AddAsync(ChemicalElement entity);

        public Task SaveChangesAsync();

        public Task DeleteAsync(int id);

        public Task<IEnumerable<ChemicalElement>> GetAllAsync();

        public Task<ChemicalElement> GetByIdAsync(int id);

        public Task UpdateAsync(int id, ChemicalElement entity);
    }
}
