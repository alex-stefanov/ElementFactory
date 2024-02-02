namespace ElementFactory.Core.Implementations.Repositories
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Data;
    using ElementFactory.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class ChemicalElementRepository : IChemicalElementRepository
    {
        private readonly ApplicationDbContext context;

        public ChemicalElementRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(ChemicalElement entity)
        {
            await this.context.ChemicalElements.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await context
               .ChemicalElements
               .FirstOrDefaultAsync(q => q.Id == id)
               ?? throw new ArgumentException("Invalid id!");

            context.ChemicalElements.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ChemicalElement>> GetAllAsync()
        {
            return await
                context
                .ChemicalElements
                .Include(ce => ce.ChemicalType)
                .ToListAsync();
        }

        public async Task<ChemicalElement> GetByIdAsync(int id)
        {
            var entity = await context.ChemicalElements
                .FirstOrDefaultAsync(q => q.Id == id);

            return entity ?? throw new ArgumentException("Invalid id!");
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, ChemicalElement entity)
        {
            var entityToUpdate = await context
                .ChemicalElements
                .FirstOrDefaultAsync(q => q.Id == id)
                ?? throw new ArgumentException("Invalid id!");

            entityToUpdate.State = entity.State;
            entityToUpdate.Period = entity.Period;
            entityToUpdate.Density = entity.Density;
            entityToUpdate.IsSynthetic = entity.IsSynthetic;
            entityToUpdate.Id = entity.Id;
            entityToUpdate.EnglishName = entity.EnglishName;
            entityToUpdate.AtomicMass = entity.AtomicMass;
            entityToUpdate.AtomicRadius = entity.AtomicRadius;
            entityToUpdate.AtomicNumber = entity.AtomicNumber;
            entityToUpdate.Name = entity.Name;
            entityToUpdate.ElectronicLayers = entity.ElectronicLayers;
            entityToUpdate.Symbol = entity.Symbol;
            entityToUpdate.Group = entity.Group;
            entityToUpdate.IsRadioactive = entity.IsRadioactive;
            entityToUpdate.BoilingPoint = entity.BoilingPoint;
            entityToUpdate.MeltingPoint = entity.MeltingPoint;
            entityToUpdate.YearFound = entity.YearFound;
            entityToUpdate.BulgarianState = entity.BulgarianState;
            entityToUpdate.Electronegativity = entity.Electronegativity;
            entityToUpdate.ChemicalTypeId = entity.ChemicalTypeId;

            await context.SaveChangesAsync();
        }
    }
}
