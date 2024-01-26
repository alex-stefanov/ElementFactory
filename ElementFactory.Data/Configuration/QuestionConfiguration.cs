namespace ElementFactory.Data.Configuration
{
    using ElementFactory.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasMany(q => q.QuestionsTests)
                   .WithOne(qtm => qtm.Question)
                   .HasForeignKey(qtm => qtm.QuestionId)
                    .OnDelete(DeleteBehavior.Cascade);

            var questions = this.Questions1();

            builder.HasData(questions);
        }

        private List<Question> Questions1()
        {
            // ============================================= //
            // Test 1 //
            var question1_1 = new Question()
            {
                Id = 1,
                Description = "В коя група е химичният елемент Na?",
                RightAnswer = "Първа А",
                Answers = new List<Answer>()
            };

            var question1_2 = new Question()
            {
                Id = 2,
                Description = "Какво по характер е простото вещество на Na?",
                RightAnswer = "Метал",
                Answers = new List<Answer>()
            };

            var question1_3 = new Question()
            {
                Id = 3,
                Description = "Натрият взаимодейства със: ",
                RightAnswer = "Неметали, киселини и вода",
                Answers = new List<Answer>()
            };

            var question1_4 = new Question()
            {
                Id = 4,
                Description = "При взаимодействие на Na с вода се получава:",
                RightAnswer = "NaOH + H2",
                Answers = new List<Answer>()
            };

            var question1_5 = new Question()
            {
                Id = 5,
                Description = "Защо простото вещество Na се държи под петрол",
                RightAnswer = "За да не взаимодейства с кислорода от въздуха",
                Answers = new List<Answer>()
            };

            var question1_6 = new Question()
            {
                Id = 6,
                Description = "Кое от химичните съединения на натрия е " +
                "по-познато в практиката като сода каустик?",
                RightAnswer = "NaOH",
                Answers = new List<Answer>()
            };

            var question1_7 = new Question()
            {
                Id = 7,
                Description = "С какъв пламък изгаря Na?",
                RightAnswer = "Жълт",
                Answers = new List<Answer>()
            };

            var question1_8 = new Question()
            {
                Id = 8,
                Description = "Кое от химичните съединения на Na се доказва с реактива AgNO3?",
                RightAnswer = "NaCl",
                Answers = new List<Answer>()
            };

            var question1_9 = new Question()
            {
                Id = 9,
                Description = "При електролитна дисоциация на NaOH се получават: ",
                RightAnswer = "Na+ и OH-",
                Answers = new List<Answer>()
            };

            var question1_10 = new Question()
            {
                Id = 10,
                Description = "От коя валентност е Na?",
                RightAnswer = "1",
                Answers = new List<Answer>()
            };

            var question1_11 = new Question()
            {
                Id = 11,
                Description = "Ако в разтвор от NaOH внесем лакмус, то той се оцветява: ",
                RightAnswer = "В синьо",
                Answers = new List<Answer>()
            };

            var question1_12 = new Question()
            {
                Id = 12,
                Description = "Кое от следните прости вещества има " +
                "по-ниска реактивоспособност от натрия?",
                RightAnswer = "Li",
                Answers = new List<Answer>()
            };

            var question1_13 = new Question()
            {
                Id = 13,
                Description = "Водният разтвор на NaOH провежда електричен ток.",
                RightAnswer = "Вярно",
                Answers = new List<Answer>()
            };

            var question1_14 = new Question()
            {
                Id = 14,
                Description = "Според UPAC химичното съединение \"NaH\" се нарича:",
                RightAnswer = "Натриев хидрид",
                Answers = new List<Answer>()
            };

            var question1_15 = new Question()
            {
                Id = 15,
                Description = "Кое е ГРЕШНОТО твърдение? Натрият / неговите съединения " +
                "се използват за:",
                RightAnswer = "Промивка след изгаряне",
                Answers = new List<Answer>()
            };

            return new List<Question>()
            {
                question1_1,
                question1_2,
                question1_3,
                question1_4,
                question1_5,
                question1_6,
                question1_7,
                question1_8,
                question1_9,
                question1_10,
                question1_11,
                question1_12,
                question1_13,
                question1_14,
                question1_15
            };
        }
    }
}
