namespace ElementFactory.Tests.RepositoryTests
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Core.Implementations.Repositories;
    using ElementFactory.Data.Models;
    using ElementFactory.Tests.UnitTests.Mocks;
    using Microsoft.EntityFrameworkCore;
    using NUnit.Framework;

    [TestFixture]
    public class ChemicalElementRepositoryTests : UnitTestBase
    {
        private IChemicalElementRepository repository;

        [SetUp]
        public void SetUp()
        {
            this.context = DatabaseMock.Mock;

            this.repository = new ChemicalElementRepository(context);
        }

        [Test]
        public async Task AddAsync_ShouldAddEntity()
        {
            await this.SeedData();

            var chemicalElement = new ChemicalElement()
            {
                AtomicMass = 2,
                AtomicNumber = 2,
                AtomicRadius = 2,
                BoilingPoint = 2,
                BulgarianState = "Bulgarian State2",
                Density = 2,
                ChemicalTypeId = 2,
                Electronegativity = 2,
                ElectronicLayers = 2,
                EnglishName = "English Name2",
                Group = 2,
                IsRadioactive = true,
                IsSynthetic = true,
                MeltingPoint = 2,
                Name = "Name2",
                Period = 2,
                State = "State2",
                Symbol = "Cc",
                YearFound = 2
            };

            var countBefore = await this.context.ChemicalElements.CountAsync();

            await this.repository.AddAsync(chemicalElement);

            var countAfter = await this.context.ChemicalElements.CountAsync();

            Assert.That(countAfter - countBefore == 1);
        }

        [Test]
        public async Task DeleteAsync_ShouldDeleteEntity()
        {
            await this.SeedData();

            var countBefore = await this.context.ChemicalElements.Where(a => a.IsActive).CountAsync();

            await this.repository.DeleteAsync(1);

            var countAfter = await this.context.ChemicalElements.Where(a => a.IsActive).CountAsync();

            Assert.That(countBefore - countAfter == 1);

            Assert.ThrowsAsync<ArgumentException>(() =>
            {
                return this.repository.DeleteAsync(-1);
            });
        }

        [Test]
        public async Task GetAllAsync_ShouldGetEntities()
        {
            await this.SeedData();

            var countBefore = await this.context.ChemicalElements.CountAsync();

            var all = await this.repository.GetAllAsync();

            var countAfter = all.Count();

            Assert.That(countAfter == countBefore);
        }

        [Test]
        public async Task GetByIdAsync_ShouldGetEntity()
        {
            await this.SeedData();

            var entity = await this.repository.GetByIdAsync(1);

            Assert.That(entity.Id == 1);
            Assert.ThrowsAsync<ArgumentException>(() =>
            {
                return this.repository.GetByIdAsync(-1);
            });
        }

        [Test]
        public async Task UpdateAsync_ShouldUpdateEntity()
        {
            await this.SeedData();

            var updatedBefore = await this.context.ChemicalElements.FirstAsync(x => x.Id == 1);
            var updatedBeforeState = updatedBefore.State;
            var updatedBeforePeriod = updatedBefore.Period;
            var updatedBeforeDensity = updatedBefore.Density;
            var updatedBeforeIsSynthetic = updatedBefore.IsSynthetic;
            var updatedBeforeEnglishName = updatedBefore.EnglishName;
            var updatedBeforeAtomicMass = updatedBefore.AtomicMass;
            var updatedBeforeAtomicRadius = updatedBefore.AtomicRadius;
            var updatedBeforeAtomicNumber = updatedBefore.AtomicNumber;
            var updatedBeforeName = updatedBefore.Name;
            var updatedBeforeElectronicLayers = updatedBefore.ElectronicLayers;
            var updatedBeforeSymbol = updatedBefore.Symbol;
            var updatedBeforeGroup = updatedBefore.Group;
            var updatedBeforeIsRadioactive = updatedBefore.IsRadioactive;
            var updatedBeforeBoilingPoint = updatedBefore.BoilingPoint;
            var updatedBeforeMeltingPoint = updatedBefore.MeltingPoint;
            var updatedBeforeYearFound = updatedBefore.YearFound;
            var updatedBeforeBulgarianState = updatedBefore.BulgarianState;
            var updatedBeforeElectronegativity = updatedBefore.Electronegativity;
            var updatedBeforeChemicalTypeId = updatedBefore.ChemicalTypeId;

            await this.repository.UpdateAsync(1, new ChemicalElement()
            {
                AtomicMass = 2,
                AtomicNumber = 2,
                AtomicRadius = 2,
                BoilingPoint = 2,
                BulgarianState = "Bulgarian State2",
                Density = 2,
                ChemicalTypeId = 1,
                Electronegativity = 2,
                ElectronicLayers = 2,
                EnglishName = "English Name2",
                Group = 2,
                IsRadioactive = false,
                IsSynthetic = false,
                MeltingPoint = 2,
                Name = "Name2",
                Period = 2,
                State = "State2",
                Symbol = "Ce",
                YearFound = 2
            });

            var updatedAfter = await this.context.ChemicalElements.FirstAsync(x => x.Id == 1);
            var updatedAfterState = updatedAfter.State;
            var updatedAfterPeriod = updatedAfter.Period;
            var updatedAfterDensity = updatedAfter.Density;
            var updatedAfterIsSynthetic = updatedAfter.IsSynthetic;
            var updatedAfterEnglishName = updatedAfter.EnglishName;
            var updatedAfterAtomicMass = updatedAfter.AtomicMass;
            var updatedAfterAtomicRadius = updatedAfter.AtomicRadius;
            var updatedAfterAtomicNumber = updatedAfter.AtomicNumber;
            var updatedAfterName = updatedAfter.Name;
            var updatedAfterElectronicLayers = updatedAfter.ElectronicLayers;
            var updatedAfterSymbol = updatedAfter.Symbol;
            var updatedAfterGroup = updatedAfter.Group;
            var updatedAfterIsRadioactive = updatedAfter.IsRadioactive;
            var updatedAfterBoilingPoint = updatedAfter.BoilingPoint;
            var updatedAfterMeltingPoint = updatedAfter.MeltingPoint;
            var updatedAfterYearFound = updatedAfter.YearFound;
            var updatedAfterBulgarianState = updatedAfter.BulgarianState;
            var updatedAfterElectronegativity = updatedAfter.Electronegativity;
            var updatedAfterChemicalTypeId = updatedAfter.ChemicalTypeId;

            Assert.That(updatedBeforeState != updatedAfterState);
            Assert.That(updatedBeforePeriod != updatedAfterPeriod);
            Assert.That(updatedBeforeDensity != updatedAfterDensity);
            Assert.That(updatedBeforeIsSynthetic != updatedAfterIsSynthetic);
            Assert.That(updatedBeforeEnglishName != updatedAfterEnglishName);
            Assert.That(updatedBeforeAtomicMass != updatedAfterAtomicMass);
            Assert.That(updatedBeforeAtomicRadius != updatedAfterAtomicRadius);
            Assert.That(updatedBeforeAtomicNumber != updatedAfterAtomicNumber);
            Assert.That(updatedBeforeName != updatedAfterName);
            Assert.That(updatedBeforeElectronicLayers != updatedAfterElectronicLayers);
            Assert.That(updatedBeforeSymbol == updatedAfterSymbol);
            Assert.That(updatedBeforeGroup != updatedAfterGroup);
            Assert.That(updatedBeforeIsRadioactive != updatedAfterIsRadioactive);
            Assert.That(updatedBeforeBoilingPoint != updatedAfterBoilingPoint);
            Assert.That(updatedBeforeMeltingPoint != updatedAfterMeltingPoint);
            Assert.That(updatedBeforeYearFound != updatedAfterYearFound);
            Assert.That(updatedBeforeBulgarianState != updatedAfterBulgarianState);
            Assert.That(updatedBeforeElectronegativity != updatedAfterElectronegativity);
            Assert.That(updatedBeforeChemicalTypeId == updatedAfterChemicalTypeId);
        }

        [Test]
        public async Task SaveChangesAsync_ShouldSaveChanges()
        {
            await this.SeedData();

            var savedBefore = await this.context.ChemicalElements.CountAsync();

            await this.repository.SaveChangesAsync();

            var savedAfter = await this.context.ChemicalElements.CountAsync(); ;

            Assert.That(savedBefore == savedAfter);
        }

        private async Task SeedData()
        {
            var chemicalType = new ChemicalType()
            {
                BulgarianName = "Bulgarian Name",
                Name = "Name"
            };

            var chemicalElement = new ChemicalElement()
            {
                Id = 1,
                AtomicMass = 1,
                AtomicNumber = 1,
                AtomicRadius = 1,
                BoilingPoint = 1,
                BulgarianState = "Bulgarian State",
                Density = 1,
                ChemicalTypeId = 1,
                Electronegativity = 1,
                ElectronicLayers = 1,
                EnglishName = "English Name",
                Group = 1,
                IsRadioactive = true,
                IsSynthetic = true,
                MeltingPoint = 1,
                Name = "Name",
                Period = 1,
                State = "State",
                Symbol = "Ce",
                YearFound = 1
            };

            await this.context.ChemicalTypes.AddAsync(chemicalType);
            await this.context.SaveChangesAsync();

            await this.context.ChemicalElements.AddAsync(chemicalElement);
            await this.context.SaveChangesAsync();
        }
    }
}
