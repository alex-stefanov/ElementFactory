namespace ElementFactory.Models.Question
{
    using ElementFactory.Models.Answer;

    public class QuestionsTestsMap
    {
        public string Description { get; set; } = null!;

        public List<AnswerViewModel> Answers { get; set; } = 
            new List<AnswerViewModel>();

        public AnswerViewModel CorrectAnswer { get; set; } = null!;
    }
}
