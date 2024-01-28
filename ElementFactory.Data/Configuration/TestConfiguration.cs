namespace ElementFactory.Data.Configuration
{
    using ElementFactory.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TestConfiguration : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            var tests = this.Tests7Grade();
            tests.AddRange(this.Tests8_9Grade());

            builder.HasMany(t => t.QuestionsTests)
              .WithOne(qtm => qtm.Test)
              .HasForeignKey(qtm => qtm.TestId)
              .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(tests);
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

            var test2 = new Test()
            {
                Id = 2,
                Title = "Неметали. Хлор и неговите съединения",
                Category = "7 клас",
                QuestionsTests = new List<QuestionTestMap>()
            };

            return new List<Test>()
            {
                test1,
                test2
            };
        }

        private List<Test> Tests8_9Grade()
        {
            var test1 = new Test()
            {
                Id = 3,
                Title = "Алкалоземни метали. Калций и неговите съединения",
                Category = "8-9 клас",
                QuestionsTests = new List<QuestionTestMap>()
            };

            var test2 = new Test()
            {
                Id = 4,
                Title = "Органична химия. Въглерод и неговите органични съединения",
                Category = "8-9 клас",
                QuestionsTests = new List<QuestionTestMap>()
            };

            return new List<Test>()
            {
                test1,
                test2
            };
        }

    }
}
