using ElementFactory.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace ElementFactory.Data
{
    /// <summary>
    /// Database Application Context
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext
    {
        /// <summary>
        /// Database Application Context Constructor
        /// </summary>
        /// <param name="options">Options for the DbContext</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        /// <summary>
        /// Database Application Context ChemicalElement DbSet
        /// </summary>
        public DbSet<ChemicalElement> ChemicalElements { get; set; } = null!;

        /// <summary>
        /// Database Application Context ChemicalElementQuestion DbSet
        /// </summary>
        public DbSet<ChemicalElementQuestionMap> ChemicalElementsQuestions { get; set; } = null!;

        /// <summary>
        /// Database Application Context ChemicalType DbSet
        /// </summary>
        public DbSet<ChemicalType> ChemicalTypes { get; set; } = null!;

        /// <summary>
        /// Database Application Context Founder DbSet
        /// </summary>
        public DbSet<Founder> Founders { get; set; } = null!;

        /// <summary>
        /// Database Application Context FounderChemicalElement DbSet
        /// </summary>
        public DbSet<FounderChemicalElementMap> FoundersChemicalElements { get; set; } = null!;

        /// <summary>
        /// Database Application Context Question DbSet
        /// </summary>
        public DbSet<Question> Questions { get; set; } = null!;

        /// <summary>
        /// Database Application Context OnModelCreating method
        /// </summary>
        /// <param name="builder">ModelBuilder</param>
        protected override void OnModelCreating(ModelBuilder 
            builder)
        {
            base.OnModelCreating(builder);
            // Setting Composite Primary Key For
            // ChemicalElementQuestion
            builder
                .Entity<ChemicalElementQuestionMap>()
                .HasKey(ceq => new
                {
                    ceq.ChemicalElementSymbol,
                    ceq.QuestionId
                });

            // Setting Composite Primary Key For
            // FounderChemicalElement
            builder
                .Entity<FounderChemicalElementMap>()
                .HasKey(fce => new
                {
                    fce.FounderId,
                    fce.ChemicalElementSymbol
                });
        }
    }
}