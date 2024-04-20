namespace ElementFactory.Tests.ServiceTests
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Core.Contracts.Service;
    using ElementFactory.Core.Implementations.Services;
    using ElementFactory.Data.Models;
    using ElementFactory.Tests.UnitTests.Mocks;
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class ChemicalElementServiceTests : UnitTestBase
    {
        private IChemicalElementService service;

        private IChemicalElementRepository repository;

        private int count = 0;
        private bool updated = false;
        private bool savedChanges = false;

        [SetUp]
        public void Setup()
        {
            var repoMock = new Mock<IChemicalElementRepository>();

            this.context = DatabaseMock.Mock;

            this.count = 0;
            this.updated = false;
            this.savedChanges = false;

            repoMock.Setup(r => r.AddAsync(It.IsAny<ChemicalElement>()))
                .Callback<ChemicalElement>(a =>
                {
                    this.count++;
                });

            repoMock.Setup(r => r.DeleteAsync(It.IsAny<int>()))
                .Callback<int>(a =>
                {
                    this.count--;
                });

            IEnumerable<ChemicalElement> chemicalElements = new List<ChemicalElement>()
            {
                new ChemicalElement(){Id = 1},
                new ChemicalElement(){Id = 2},
            };

            repoMock
                .Setup(r => r.GetAllAsync())
                .Returns(Task.FromResult(chemicalElements));

            var chemicalElement = new ChemicalElement() { Id = 10 };

            repoMock.Setup(r => r.GetByIdAsync(It.IsAny<int>()))
                .Returns(Task.FromResult(chemicalElement));

            repoMock.Setup(r => r.UpdateAsync(It.IsAny<int>(), It.IsAny<ChemicalElement>()))
                .Callback(() =>
                {
                    this.updated = true;
                });

            repoMock.Setup(r => r.SaveChangesAsync())
                .Callback(() =>
                {
                    this.savedChanges = true;
                });

            this.repository = repoMock.Object;

            this.service = new ChemicalElementService(this.repository);
        }

        [Test]
        public async Task AddAsync_ShouldAddEntity()
        {
            var chemicalElement = new ChemicalElement()
            {
                Id = 1,
                AtomicMass = 1,
                AtomicNumber = 1,
                AtomicRadius = 1,
                Density = 1,
                BoilingPoint = 1,
                BulgarianState = "Bulgarian State",
                ChemicalTypeId = 1,
                Electronegativity = 1,
                EnglishName = "English Name",
                Group = 1,
                IsRadioactive = true,
                IsSynthetic = true,
                MeltingPoint = 1,
                Name = "Name",
                Period = 1,
                State = "State",
                Symbol = "S",
                YearFound = 2024
            };

            var countBefore = await this.context.ChemicalElements.CountAsync();

            await this.service.AddAsync(chemicalElement);

            var countAfter = this.count;

            Assert.That(countAfter - countBefore == 1);
        }

        [Test]
        public async Task DeleteAsync_ShouldDeleteEntity()
        {
            var countBefore = await this.context.ChemicalElements.CountAsync();

            await this.service.DeleteAsync(1);

            var countAfter = this.count;

            Assert.That(countBefore - countAfter == 1);
        }

        [Test]
        public async Task GetAllAsync_ShouldGetEntities()
        {
            var countBefore = await this.context.ChemicalElements.CountAsync();

            var all = await this.service.GetAllAsync();

            var countAfter = all.Count();

            Assert.That(countAfter - countBefore == 2);
        }

        [Test]
        public async Task GetByIdAsync_ShouldGetEntity()
        {
            var entity = await this.service.GetByIdAsync(10);

            Assert.That(entity.Id == 10);
        }

        [Test]
        public async Task UpdateAsync_ShouldUpdateEntity()
        {
            var updatedBefore = this.updated;

            await this.service.UpdateAsync(1, new ChemicalElement());

            var updatedAfter = this.updated;

            Assert.That(updatedBefore != updatedAfter);
        }

        [Test]
        public async Task SaveChangesAsync_ShouldSaveChanges()
        {
            var savedBefore = this.savedChanges;

            await this.service.SaveChangesAsync();

            var savedAfter = this.savedChanges;

            Assert.That(savedBefore != savedAfter);
        }
    }
}
