namespace ElementFactory.Models.Others
{
    using ElementFactory.Data.Models;

    public class AddQuestionsChooseModel
    {
        public string TestTitle { get; set; } = null!;

        public string TestCategory { get; set; } = null!;

        public int QuestionsCount { get; set; }

        public List<Question> Questions { get; set; } =
            new List<Question>();
    }
}
