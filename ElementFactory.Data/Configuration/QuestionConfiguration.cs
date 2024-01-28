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
            questions.AddRange(this.Questions3());
            questions.AddRange(this.Questions4());

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

        private List<Question> Questions3()
        {
            // ============================================= //
            // Test 3 //
            var question3_1 = new Question()
            {
                Id = 31,
                Description = "Простото вещество Ca е:",
                RightAnswer = "Алкалоземен метал",
                Answers = new List<Answer>()
            };

            var question3_2 = new Question()
            {
                Id = 32,
                Description = "С какъв строеж е простото вещество Ca?",
                RightAnswer = "Кристален",
                Answers = new List<Answer>()
            };

            var question3_3 = new Question()
            {
                Id = 33,
                Description = "С каква валентност участва в съединенията си Ca?",
                RightAnswer = "2",
                Answers = new List<Answer>()
            };

            var question3_4 = new Question()
            {
                Id = 34,
                Description = "Под какво име е известно съединението CaO?",
                RightAnswer = "Негасена вар",
                Answers = new List<Answer>()
            };

            var question3_5 = new Question()
            {
                Id = 35,
                Description = "В коя група е Ca?",
                RightAnswer = "Втора А",
                Answers = new List<Answer>()
            };

            var question3_6 = new Question()
            {
                Id = 36,
                Description = "При взаимодействието на Ca с кислород се получава:",
                RightAnswer = "CaO",
                Answers = new List<Answer>()
            };

            var question3_7 = new Question()
            {
                Id = 37,
                Description = "Реакцията \"Гасене на вар\" е ракция на CaO с вода, при коята се получава/т:",
                RightAnswer = "Ca(OH)2",
                Answers = new List<Answer>()
            };

            var question3_8 = new Question()
            {
                Id = 38,
                Description = "При взаимодействие на Ca с халогеноводородна киселина се получава:",
                RightAnswer = "Сол",
                Answers = new List<Answer>()
            };

            var question3_9 = new Question()
            {
                Id = 39,
                Description = "Простото вещество Ca е газ с метален блясък и висока електропроводимост.",
                RightAnswer = "Грешно",
                Answers = new List<Answer>()
            };

            var question3_10 = new Question()
            {
                Id = 40,
                Description = "Какъв характер проявява водният разтвор на калциевия дихидроксид?",
                RightAnswer = "Основен",
                Answers = new List<Answer>()
            };

            var question3_11 = new Question()
            {
                Id = 41,
                Description = "Кое от следните уравнения за Ca и неговите съединения е изравнено вярно?",
                RightAnswer = "Ca + 2H2O => Ca(OH)2+H2",
                Answers = new List<Answer>()
            };

            var question3_12 = new Question()
            {
                Id = 42,
                Description = "Ca се съхранява по петрол или инертен газ",
                RightAnswer = "Вярно",
                Answers = new List<Answer>()
            };

            var question3_13 = new Question()
            {
                Id = 43,
                Description = "Какъв е цвета на пламъка при гореното на Ca?",
                RightAnswer = "Керемиденочервен",
                Answers = new List<Answer>()
            };

            var question3_14 = new Question()
            {
                Id = 44,
                Description = "Реакцията \"Шумяща проба\" се наблюдава при взаимодействието на:",
                RightAnswer = "CaCO3 с киселина",
                Answers = new List<Answer>()
            };

            var question3_15 = new Question()
            {
                Id = 45,
                Description = "Разтоворът на Ca(OH)2 е с pH:",
                RightAnswer = "11",
                Answers = new List<Answer>()
            };

            return new List<Question>()
            {
                question3_1,
                question3_2,
                question3_3,
                question3_4,
                question3_5,
                question3_6,
                question3_7,
                question3_8,
                question3_9,
                question3_10,
                question3_11,
                question3_12,
                question3_13,
                question3_14,
                question3_15
            };
        }

        private List<Question> Questions4()
        {
            // ============================================= //
            // Test 4 //
            var question4_1 = new Question()
            {
                Id = 46,
                Description = "В кой от редовете са посочени само неорганични съединения:",
                RightAnswer = "CO, CO2, H2CO3, Na2CO3",
                Answers = new List<Answer>()
            };

            var question4_2 = new Question()
            {
                Id = 47,
                Description = "Каква валентност проявява C в неговите ОС?",
                RightAnswer = "4",
                Answers = new List<Answer>()
            };

            var question4_3 = new Question()
            {
                Id = 48,
                Description = "Кое е най-точното определение за ароматните ВВ?",
                RightAnswer = "ВВ с по-сложен строеж, които са циклични",
                Answers = new List<Answer>()
            };

            var question4_4 = new Question()
            {
                Id = 49,
                Description = "Кое от посочените съединения е известно под името \"Газ гризу\":",
                RightAnswer = "CH4",
                Answers = new List<Answer>()
            };

            var question4_5 = new Question()
            {
                Id = 50,
                Description = "\"Халогенирането\" на метан е заместителна реакция.",
                RightAnswer = "Вярно",
                Answers = new List<Answer>()
            };

            var question4_6 = new Question()
            {
                Id = 51,
                Description = "Всяко ОС при взаимодействие с кислород(горене) се разлага до въглероден диоксид и вода",
                RightAnswer = "Вярно",
                Answers = new List<Answer>()
            };
            
            var question4_7 = new Question()
            {
                Id = 52,
                Description = "Кое от от следните съединения е нонан",
                RightAnswer = "C9H20",
                Answers = new List<Answer>()
            };

            var question4_8 = new Question()
            {
                Id = 53,
                Description = "Каква е общата молекулна формула на алкените",
                RightAnswer = "CnH2n",
                Answers = new List<Answer>()
            };

            var question4_9 = new Question()
            {
                Id = 54,
                Description = "Характерни за алкените са заместителните реакции, поради наличието на сложната двойна връзка",
                RightAnswer = "Грешно",
                Answers = new List<Answer>()
            };

            var question4_10 = new Question()
            {
                Id = 55,
                Description = "\"Хидрирането\" на алкени протична при наличието на:",
                RightAnswer = "И трите изброени",
                Answers = new List<Answer>()
            };

            var question4_11 = new Question()
            {
                Id = 56,
                Description = "Наличието на какво се доказва с разтвор на KMnO4?",
                RightAnswer = "Сложни връзки",
                Answers = new List<Answer>()
            };

            var question4_12 = new Question()
            {
                Id = 57,
                Description = "При присъединяването на полярни H-съдържащи молекули към молекули на несиметрияни алкени се спазва правилото на:",
                RightAnswer = "Марковников",
                Answers = new List<Answer>()
            };

            var question4_13 = new Question()
            {
                Id = 58,
                Description = "За да се спре реакцията на \"Хидриране\" на алкините, така че от алкин да се получи алкен, се използва катализатор:",
                RightAnswer = "Pb(CH3COO)2",
                Answers = new List<Answer>()
            };

            var question4_14 = new Question()
            {
                Id = 59,
                Description = "2,4,6-тринитро толуен(TNT) се получава при взаимодействието на:",
                RightAnswer = "Толуен и HNO3 в излишък",
                Answers = new List<Answer>()
            };

            var question4_15 = new Question()
            {
                Id = 60,
                Description = "При взаимодействието на фенол и натрий се получава:",
                RightAnswer = "Натриев феноксид и 1/2 H2",
                Answers = new List<Answer>()
            };

            return new List<Question>()
            {
                question4_1,
                question4_2,
                question4_3,
                question4_4,
                question4_5,
                question4_6,
                question4_7,
                question4_8,
                question4_9,
                question4_10,
                question4_11,
                question4_12,
                question4_13,
                question4_14,
                question4_15
            };
        }
    }
}
