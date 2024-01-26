namespace ElementFactory.Data.Configuration
{
    using ElementFactory.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TestConfiguration : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            var tests1 = this.Tests7Grade();

            builder.HasMany(t => t.QuestionsTests)
              .WithOne(qtm => qtm.Test)
              .HasForeignKey(qtm => qtm.TestId)
              .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(tests1);
        }

        private List<Test> Tests7Grade()
        {
            var test1 = new Test()
            {
                Id = 1,
                Title = "Метали. Натрий и неговите съединения",
                Category = "7 клас",
                QuestionsTests = new List<QuestionTestMap>()
            };

            return new List<Test>()
            {
                test1
            };
        }
    }
}
