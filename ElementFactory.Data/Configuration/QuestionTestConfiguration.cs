namespace ElementFactory.Data.Configuration
{
    using ElementFactory.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class QuestionTestConfiguration :
        IEntityTypeConfiguration<QuestionTestMap>
    {
        public void Configure(EntityTypeBuilder<QuestionTestMap> builder)
        {
            var questionsTestsMap1 = this.QuestionsTests1();

            builder.HasOne(qtm => qtm.Question)
                   .WithMany(q => q.QuestionsTests)
                   .HasForeignKey(qtm => qtm.QuestionId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(qtm => qtm.Test)
                .WithMany(t => t.QuestionsTests)
                .HasForeignKey(qtm => qtm.TestId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(questionsTestsMap1);
        }

        private List<QuestionTestMap> QuestionsTests1()
        {
            var questionTestMap1 = new QuestionTestMap()
            {
                QuestionId = 1,
                TestId = 1
            };

            var questionTestMap2 = new QuestionTestMap()
            {
                QuestionId = 2,
                TestId = 1
            };

            var questionTestMap3 = new QuestionTestMap()
            {
                QuestionId = 3,
                TestId = 1
            };

            var questionTestMap4 = new QuestionTestMap()
            {
                QuestionId = 4,
                TestId = 1
            };

            var questionTestMap5 = new QuestionTestMap()
            {
                QuestionId = 5,
                TestId = 1
            };

            var questionTestMap6 = new QuestionTestMap()
            {
                QuestionId = 6,
                TestId = 1
            };

            var questionTestMap7 = new QuestionTestMap()
            {
                QuestionId = 7,
                TestId = 1
            };

            var questionTestMap8 = new QuestionTestMap()
            {
                QuestionId = 8,
                TestId = 1
            };

            var questionTestMap9 = new QuestionTestMap()
            {
                QuestionId = 9,
                TestId = 1
            };

            var questionTestMap10 = new QuestionTestMap()
            {
                QuestionId = 10,
                TestId = 1
            };

            var questionTestMap11 = new QuestionTestMap()
            {
                QuestionId = 11,
                TestId = 1
            };

            var questionTestMap12 = new QuestionTestMap()
            {
                QuestionId = 12,
                TestId = 1
            };

            var questionTestMap13 = new QuestionTestMap()
            {
                QuestionId = 13,
                TestId = 1
            };

            var questionTestMap14 = new QuestionTestMap()
            {
                QuestionId = 14,
                TestId = 1
            };

            var questionTestMap15 = new QuestionTestMap()
            {
                QuestionId = 15,
                TestId = 1
            };


            return new List<QuestionTestMap>()
            {
                questionTestMap1,
                questionTestMap2,
                questionTestMap3,
                questionTestMap4,
                questionTestMap5,
                questionTestMap6,
                questionTestMap7,
                questionTestMap8,
                questionTestMap9,
                questionTestMap10,
                questionTestMap11,
                questionTestMap12,
                questionTestMap13,
                questionTestMap14,
                questionTestMap15
            };
        }
    }
}
