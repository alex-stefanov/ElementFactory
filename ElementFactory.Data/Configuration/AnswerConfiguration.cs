namespace ElementFactory.Data.Configuration
{
    using ElementFactory.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        { 
            builder
                .HasOne(a => a.Question)
                .WithMany(q => q.Answers)
                .OnDelete(DeleteBehavior.Cascade);

            var answers1 = this.Answers1();

            builder.HasData(answers1);
        }

        private List<Answer> Answers1()
        {
            // ============================================= //
            // Question 1.1 //

            var answer1_1 = new Answer()
            {
                Id = 1,
                QuestionId = 1,
                Value = "Втора А"
            };

            var answer1_2 = new Answer()
            {
                Id = 2,
                QuestionId = 1,
                Value = "Седма А"
            };

            var answer1_3 = new Answer()
            {
                Id = 3,
                QuestionId = 1,
                Value = "Първа А"
            };

            var answer1_4 = new Answer()
            {
                Id = 4,
                QuestionId = 1,
                Value = "Първа Б"
            };

            // ============================================= //
            // Question 1.2 //

            var answer2_1 = new Answer()
            {
                Id = 5,
                QuestionId = 2,
                Value = "Неметал"
            };

            var answer2_2 = new Answer()
            {
                Id = 6,
                QuestionId = 2,
                Value = "Метал"
            };

            var answer2_3 = new Answer()
            {
                Id = 7,
                QuestionId = 2,
                Value = "Нито едно от изброените"
            };

            var answer2_4 = new Answer()
            {
                Id = 8,
                QuestionId = 2,
                Value = "Алкалоземен метал"
            };

            // ============================================= //
            // Question 1.3 //

            var answer3_1 = new Answer()
            {
                Id = 9,
                QuestionId = 3,
                Value = "Неметали, киселини, вода"
            };

            var answer3_2 = new Answer()
            {
                Id = 10,
                QuestionId = 3,
                Value = "Основни оксиди, киселини, вода"
            };

            var answer3_3 = new Answer()
            {
                Id = 11,
                QuestionId = 3,
                Value = "Основи, киселини, метали"
            };

            var answer3_4 = new Answer()
            {
                Id = 12,
                QuestionId = 3,
                Value = "Киселинни оксиди, основи, соли"
            };

            // ============================================= //
            // Question 1.4 //

            var answer4_1 = new Answer()
            {
                Id = 13,
                QuestionId = 4,
                Value = "Na2O"
            };

            var answer4_2 = new Answer()
            {
                Id = 14,
                QuestionId = 4,
                Value = "Na2O + H2"
            };

            var answer4_3 = new Answer()
            {
                Id = 15,
                QuestionId = 4,
                Value = "NaOH + H2"
            };

            var answer4_4 = new Answer()
            {
                Id = 16,
                QuestionId = 4,
                Value = "NaOH + H2O"
            };

            // ============================================= //
            // Question 1.5 //

            var answer5_1 = new Answer()
            {
                Id = 17,
                QuestionId = 5,
                Value = "За да не взаимодейства с азота от въздуха"
            };

            var answer5_2 = new Answer()
            {
                Id = 18,
                QuestionId = 5,
                Value = "За да не взаимодейства с кислорода от въздуха"
            };

            var answer5_3 = new Answer()
            {
                Id = 19,
                QuestionId = 5,
                Value = "За да не отрови въздуха наоколо"
            };

            var answer5_4 = new Answer()
            {
                Id = 20,
                QuestionId = 5,
                Value = "За да не се изпари"
            };

            // ============================================= //
            // Question 1.6 //

            var answer6_1 = new Answer()
            {
                Id = 21,
                QuestionId = 6,
                Value = "NaCl"
            };

            var answer6_2 = new Answer()
            {
                Id = 22,
                QuestionId = 6,
                Value = "Na2CO3"
            };

            var answer6_3 = new Answer()
            {
                Id = 23,
                QuestionId = 6,
                Value = "Na2O2"
            };

            var answer6_4 = new Answer()
            {
                Id = 24,
                QuestionId = 6,
                Value = "NaOH"
            };

            // ============================================= //
            // Question 1.7 //

            var answer7_1 = new Answer()
            {
                Id = 25,
                QuestionId = 7,
                Value = "Син"
            };

            var answer7_2 = new Answer()
            {
                Id = 26,
                QuestionId = 7,
                Value = "Зелен"
            };

            var answer7_3 = new Answer()
            {
                Id = 27,
                QuestionId = 7,
                Value = "Жълт"
            };

            var answer7_4 = new Answer()
            {
                Id = 28,
                QuestionId = 7,
                Value = "Виолетов"
            };

            // ============================================= //
            // Question 1.8 //

            var answer8_1 = new Answer()
            {
                Id = 29,
                QuestionId = 8,
                Value = "NaOH"
            };

            var answer8_2 = new Answer()
            {
                Id = 30,
                QuestionId = 8,
                Value = "Na2O"
            };

            var answer8_3 = new Answer()
            {
                Id = 31,
                QuestionId = 8,
                Value = "NaCl"
            };

            var answer8_4 = new Answer()
            {
                Id = 32,
                QuestionId = 8,
                Value = "NaNO3"
            };


            // ============================================= //
            // Question 1.9 //

            var answer9_1 = new Answer()
            {
                Id = 33,
                QuestionId = 9,
                Value = "Na+ и OH-"
            };

            var answer9_2 = new Answer()
            {
                Id = 34,
                QuestionId = 9,
                Value = "2Na+ и OH-"
            };

            var answer9_3 = new Answer()
            {
                Id = 35,
                QuestionId = 9,
                Value = "Na+ и 2O-"
            };

            var answer9_4 = new Answer()
            {
                Id = 36,
                QuestionId = 9,
                Value = "Na+ и OH+"
            };

            // ============================================= //
            // Question 1.10 //

            var answer10_1 = new Answer()
            {
                Id = 37,
                QuestionId = 10,
                Value = "1"
            };

            var answer10_2 = new Answer()
            {
                Id = 38,
                QuestionId = 10,
                Value = "2"
            };

            var answer10_3 = new Answer()
            {
                Id = 39,
                QuestionId = 10,
                Value = "3"
            };

            var answer10_4 = new Answer()
            {
                Id = 40,
                QuestionId = 10,
                Value = "4"
            };

            // ============================================= //
            // Question 1.11 //

            var answer11_1 = new Answer()
            {
                Id = 41,
                QuestionId = 11,
                Value = "В червено"
            };

            var answer11_2 = new Answer()
            {
                Id = 42,
                QuestionId = 11,
                Value = "В малиновочервено"
            };

            var answer11_3 = new Answer()
            {
                Id = 43,
                QuestionId = 11,
                Value = "В синьо"
            };

            var answer11_4 = new Answer()
            {
                Id = 44,
                QuestionId = 11,
                Value = "В жълто"
            };

            // ============================================= //
            // Question 1.12 //

            var answer12_1 = new Answer()
            {
                Id = 45,
                QuestionId = 12,
                Value = "K"
            };

            var answer12_2 = new Answer()
            {
                Id = 46,
                QuestionId = 12,
                Value = "Li"
            };

            var answer12_3 = new Answer()
            {
                Id = 47,
                QuestionId = 12,
                Value = "Rb"
            };

            var answer12_4 = new Answer()
            {
                Id = 48,
                QuestionId = 12,
                Value = "Cs"
            };

            // ============================================= //
            // Question 1.13 //

            var answer13_1 = new Answer()
            {
                Id = 49,
                QuestionId = 13,
                Value = "Вярно"
            };

            var answer13_2 = new Answer()
            {
                Id = 50,
                QuestionId = 13,
                Value = "Грешно"
            };

            // ============================================= //
            // Question 1.14 //

            var answer14_1 = new Answer()
            {
                Id = 51,
                QuestionId = 14,
                Value = "Натриев хидрид"
            };

            var answer14_2 = new Answer()
            {
                Id = 52,
                QuestionId = 14,
                Value = "Натриев хидроксид"
            };

            var answer14_3 = new Answer()
            {
                Id = 53,
                QuestionId = 14,
                Value = "Натриев хидрат"
            };

            var answer14_4 = new Answer()
            {
                Id = 54,
                QuestionId = 14,
                Value = "Натриев хемоглобин"
            };

            // ============================================= //
            // Question 1.15 //

            var answer15_1 = new Answer()
            {
                Id = 55,
                QuestionId = 15,
                Value = "Приготвяне на физиологичен разтвор"
            };

            var answer15_2 = new Answer()
            {
                Id = 56,
                QuestionId = 15,
                Value = "Производство на сапуни"
            };

            var answer15_3 = new Answer()
            {
                Id = 57,
                QuestionId = 15,
                Value = "Промивка след изгаряне"
            };

            var answer15_4 = new Answer()
            {
                Id = 58,
                QuestionId = 15,
                Value = "Хранително-вкусова промишленост"
            };

            return new List<Answer>()
            {
                // Question 1.1
                answer1_1,
                answer1_2,
                answer1_3,
                answer1_4,

                // Question 1.2
                answer2_1,
                answer2_2,
                answer2_3,
                answer2_4,

                // Question 1.3
                answer3_1,
                answer3_2,
                answer3_3,
                answer3_4,

                // Question 1.4
                answer4_1,
                answer4_2,
                answer4_3,
                answer4_4,

                // Question 1.5
                answer5_1,
                answer5_2,
                answer5_3,
                answer5_4,

                // Question 1.6
                answer6_1,
                answer6_2,
                answer6_3,
                answer6_4,

                // Question 1.7
                answer7_1,
                answer7_2,
                answer7_3,
                answer7_4,

                // Question 1.8
                answer8_1,
                answer8_2,
                answer8_3,
                answer8_4,

                // Question 1.9
                answer9_1,
                answer9_2,
                answer9_3,
                answer9_4,

                // Question 1.10
                answer10_1,
                answer10_2,
                answer10_3,
                answer10_4,

                // Question 1.11
                answer11_1,
                answer11_2,
                answer11_3,
                answer11_4,

                // Question 1.12
                answer12_1,
                answer12_2,
                answer12_3,
                answer12_4,

                // Question 1.13
                answer13_1,
                answer13_2,

                // Question 1.14
                answer14_1,
                answer14_2,
                answer14_3,
                answer14_4,
                
                // Question 1.15
                answer15_1,
                answer15_2,
                answer15_3,
                answer15_4,
            };
        }


    }
}
