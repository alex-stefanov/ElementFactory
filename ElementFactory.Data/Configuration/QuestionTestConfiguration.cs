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
            var questionsTestsMap = this.QuestionsTests1();
            questionsTestsMap.AddRange(this.QuestionsTests2());
            questionsTestsMap.AddRange(this.QuestionsTests3());
            questionsTestsMap.AddRange(this.QuestionsTests4());

            builder.HasOne(qtm => qtm.Question)
                   .WithMany(q => q.QuestionsTests)
                   .HasForeignKey(qtm => qtm.QuestionId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(qtm => qtm.Test)
                .WithMany(t => t.QuestionsTests)
                .HasForeignKey(qtm => qtm.TestId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(questionsTestsMap);
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

        private List<QuestionTestMap> QuestionsTests2()
        {
            var questionTestMap1 = new QuestionTestMap()
            {
                QuestionId = 16,
                TestId = 2
            };

            var questionTestMap2 = new QuestionTestMap()
            {
                QuestionId = 17,
                TestId = 2
            };

            var questionTestMap3 = new QuestionTestMap()
            {
                QuestionId = 18,
                TestId = 2
            };

            var questionTestMap4 = new QuestionTestMap()
            {
                QuestionId = 19,
                TestId = 2
            };

            var questionTestMap5 = new QuestionTestMap()
            {
                QuestionId = 20,
                TestId = 2
            };

            var questionTestMap6 = new QuestionTestMap()
            {
                QuestionId = 21,
                TestId = 2
            };

            var questionTestMap7 = new QuestionTestMap()
            {
                QuestionId = 22,
                TestId = 2
            };

            var questionTestMap8 = new QuestionTestMap()
            {
                QuestionId = 23,
                TestId = 2
            };

            var questionTestMap9 = new QuestionTestMap()
            {
                QuestionId = 24,
                TestId = 2
            };

            var questionTestMap10 = new QuestionTestMap()
            {
                QuestionId = 25,
                TestId = 2
            };

            var questionTestMap11 = new QuestionTestMap()
            {
                QuestionId = 26,
                TestId = 2
            };

            var questionTestMap12 = new QuestionTestMap()
            {
                QuestionId = 27,
                TestId = 2
            };

            var questionTestMap13 = new QuestionTestMap()
            {
                QuestionId = 28,
                TestId = 2
            };

            var questionTestMap14 = new QuestionTestMap()
            {
                QuestionId = 29,
                TestId = 2
            };

            var questionTestMap15 = new QuestionTestMap()
            {
                QuestionId = 30,
                TestId = 2
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

        private List<QuestionTestMap> QuestionsTests3()
        {
            var questionTestMap1 = new QuestionTestMap()
            {
                QuestionId = 31,
                TestId = 3
            };

            var questionTestMap2 = new QuestionTestMap()
            {
                QuestionId = 32,
                TestId = 3
            };

            var questionTestMap3 = new QuestionTestMap()
            {
                QuestionId = 33,
                TestId = 3
            };

            var questionTestMap4 = new QuestionTestMap()
            {
                QuestionId = 34,
                TestId = 3
            };

            var questionTestMap5 = new QuestionTestMap()
            {
                QuestionId = 35,
                TestId = 3
            };

            var questionTestMap6 = new QuestionTestMap()
            {
                QuestionId = 36,
                TestId = 3
            };

            var questionTestMap7 = new QuestionTestMap()
            {
                QuestionId = 37,
                TestId = 3
            };

            var questionTestMap8 = new QuestionTestMap()
            {
                QuestionId = 38,
                TestId = 3
            };

            var questionTestMap9 = new QuestionTestMap()
            {
                QuestionId = 39,
                TestId = 3
            };

            var questionTestMap10 = new QuestionTestMap()
            {
                QuestionId = 40,
                TestId = 3
            };

            var questionTestMap11 = new QuestionTestMap()
            {
                QuestionId = 41,
                TestId = 3
            };

            var questionTestMap12 = new QuestionTestMap()
            {
                QuestionId = 42,
                TestId = 3
            };

            var questionTestMap13 = new QuestionTestMap()
            {
                QuestionId = 43,
                TestId = 3
            };

            var questionTestMap14 = new QuestionTestMap()
            {
                QuestionId = 44,
                TestId = 3
            };

            var questionTestMap15 = new QuestionTestMap()
            {
                QuestionId = 45,
                TestId = 3
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
        
        private List<QuestionTestMap> QuestionsTests4()
        {
            var questionTestMap1 = new QuestionTestMap()
            {
                QuestionId = 46,
                TestId = 4
            };

            var questionTestMap2 = new QuestionTestMap()
            {
                QuestionId = 47,
                TestId = 4
            };

            var questionTestMap3 = new QuestionTestMap()
            {
                QuestionId = 48,
                TestId = 4
            };

            var questionTestMap4 = new QuestionTestMap()
            {
                QuestionId = 49,
                TestId = 4
            };

            var questionTestMap5 = new QuestionTestMap()
            {
                QuestionId = 50,
                TestId = 4
            };

            var questionTestMap6 = new QuestionTestMap()
            {
                QuestionId = 51,
                TestId = 4
            };

            var questionTestMap7 = new QuestionTestMap()
            {
                QuestionId = 52,
                TestId = 4
            };

            var questionTestMap8 = new QuestionTestMap()
            {
                QuestionId = 53,
                TestId = 4
            };

            var questionTestMap9 = new QuestionTestMap()
            {
                QuestionId = 54,
                TestId = 4
            };

            var questionTestMap10 = new QuestionTestMap()
            {
                QuestionId = 55,
                TestId = 4
            };

            var questionTestMap11 = new QuestionTestMap()
            {
                QuestionId = 56,
                TestId = 4
            };

            var questionTestMap12 = new QuestionTestMap()
            {
                QuestionId = 57,
                TestId = 4
            };

            var questionTestMap13 = new QuestionTestMap()
            {
                QuestionId = 58,
                TestId = 4
            };

            var questionTestMap14 = new QuestionTestMap()
            {
                QuestionId = 59,
                TestId = 4
            };

            var questionTestMap15 = new QuestionTestMap()
            {
                QuestionId = 60,
                TestId = 4
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
