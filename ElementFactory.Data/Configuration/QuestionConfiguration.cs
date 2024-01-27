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
            questions.AddRange(this.Questions2());

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
                Description = "Кое от химичните съединения на Na се получава от реакция с" +
                " реактива AgNO3?",
                RightAnswer = "NaNO3",
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

        private List<Question> Questions2()
        {
            // ============================================= //
            // Test 2 //
            var question2_1 = new Question()
            {
                Id = 16,
                Description = "Какъв цвят е простото вещество на Cl?",
                RightAnswer = "Жълто-зелен",
                Answers = new List<Answer>()
            };

            var question2_2 = new Question()
            {
                Id = 17,
                Description = "Какво се получава при взаимодействието на хлор с водород?",
                RightAnswer = "HCl",
                Answers = new List<Answer>()
            };

            var question2_3 = new Question()
            {
                Id = 18,
                Description = "Кои киселини се получават при директно " +
                "взаимодействие на хлор с вода",
                RightAnswer = "HCl и HClO",
                Answers = new List<Answer>()
            };

            var question2_4 = new Question()
            {
                Id = 19,
                Description = "С кое от веществата хлорът НЕ взаимодейства?",
                RightAnswer = "NaCl",
                Answers = new List<Answer>()
            };

            var question2_5 = new Question()
            {
                Id = 20,
                Description = "Съединението NaClO се нарича:",
                RightAnswer = "Натриев хипохлорит",
                Answers = new List<Answer>()
            };

            var question2_6 = new Question()
            {
                Id = 21,
                Description = "От коя група е елементът хлор?",
                RightAnswer = "Седма А",
                Answers = new List<Answer>()
            };

            var question2_7 = new Question()
            {
                Id = 22,
                Description = "В какъв цвят се оцветява фенолфталеина при контакт с" +
                " водния разтвор на HCl?",
                RightAnswer = "Не се променя",
                Answers = new List<Answer>()
            };

            var question2_8 = new Question()
            {
                Id = 23,
                Description = "С какво име в практиката е известен NaClO?",
                RightAnswer = "Белина",
                Answers = new List<Answer>()
            };

            var question2_9 = new Question()
            {
                Id = 24,
                Description = "От колко атома се състои молекулата на хлора?",
                RightAnswer = "2",
                Answers = new List<Answer>()
            };

            var question2_10 = new Question()
            {
                Id = 25,
                Description = "В какъв йон се превръща атомът на хлора при реакция?",
                RightAnswer = "Отрицателен със заряд 1-",
                Answers = new List<Answer>()
            };

            var question2_11 = new Question()
            {
                Id = 26,
                Description = "Как се наричат солите на хлора?",
                RightAnswer = "Хлориди",
                Answers = new List<Answer>()
            };

            var question2_12 = new Question()
            {
                Id = 27,
                Description = "От коя валентност е хлорът в съединението си с водорода?",
                RightAnswer = "1",
                Answers = new List<Answer>()
            };

            var question2_13 = new Question()
            {
                Id = 28,
                Description = "Хипохлористата киселина се разлага до:",
                RightAnswer = "HCl + O",
                Answers = new List<Answer>()
            };

            var question2_14 = new Question()
            {
                Id = 29,
                Description = "Газът хлор има силен, приятен мирис",
                RightAnswer = "Грешно",
                Answers = new List<Answer>()
            };

            var question2_15 = new Question()
            {
                Id = 30,
                Description = "За какво се използва хлорът в практиката?",
                RightAnswer = "Дезинфекция на водите",
                Answers = new List<Answer>()
            };

            return new List<Question>()
            {
                question2_1,
                question2_2,
                question2_3,
                question2_4,
                question2_5,
                question2_6,
                question2_7,
                question2_8,
                question2_9,
                question2_10,
                question2_11,
                question2_12,
                question2_13,
                question2_14,
                question2_15
            };
        }
    }
}
