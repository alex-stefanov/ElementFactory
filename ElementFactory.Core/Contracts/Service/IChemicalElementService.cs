namespace ElementFactory.Core.Contracts.Service
{
    using ElementFactory.Data.Models;

    /// <summary>
    /// Interface for ChemicalElement Service
    /// </summary>
    public interface IChemicalElementService
    {
        /// <summary>
        /// Asynchronous method for adding an entity
        /// </summary>
        /// <param name="entity">ChemicalElement entity</param>
        /// <returns>(void)</returns>
        public Task AddAsync(ChemicalElement entity);

        public Task SaveChangesAsync();

        /// <summary>
        /// Asynchronous method for deleting an entity by id
        /// </summary>
        /// <param name="id">Entity Id</param>
        /// <returns>(void)</returns>
        public Task DeleteAsync(int id);

        /// <summary>
        /// Asynchronous method for loading all entities
        /// </summary>
        /// <returns>Collection with entities</returns>
        public Task<IEnumerable<ChemicalElement>> GetAllAsync();

        public Task<ChemicalElement> GetByIdAsync(int id);

        public Task UpdateAsync(int id, ChemicalElement entity);
    }
}
