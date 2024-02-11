namespace ElementFactory.Models.Answer
{
    using System.ComponentModel.DataAnnotations;

    public class AnswerViewModel
    {
        [Required(ErrorMessage = "Полето за отговор е задължително!")]
        public string Value { get; set; } = null!;
    }
}
