namespace ElementFactory.Models.Others
{
    using ElementFactory.Models.Answer;
    using ElementFactory.Data.Models;

    public class AddQuestionsCurrentQuestionModel
    {
        public string Description { get; set; } = string.Empty;

        public AnswerViewModel Answer1 { get; set; } = null!;
        
        public AnswerViewModel Answer2 { get; set; } = null!;

        public AnswerViewModel Answer3 { get; set; } = null!;

        public AnswerViewModel Answer4 { get; set; } = null!;

        public AnswerViewModel RightAnswer { get; set; } = null!;

        public int NumberOfQ { get; set; }

        public string TestTitle { get; set; } = string.Empty;

        public string TestCategory { get; set; } = string.Empty;

        public IList<Question> Questions { get; set; } =
            new List<Question>();

        public List<string> QuestionsJSON { get; set; } = new List<string>();
    }
}
