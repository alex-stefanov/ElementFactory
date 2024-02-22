using System.ComponentModel.DataAnnotations;
using static ElementFactory.Data.Constants.FlashCardConstants;
namespace ElementFactory.Models.Flashcard
{
    public class FlashcardViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(TitleMaxLength,MinimumLength = TitleMinLength,
             ErrorMessage = "Невалиден въпрос! Дължината на въпроса трябва да е между {1} и {2} символа.")]

        public string Title { get; set; } = null!;

        [Required]
        [StringLength(ContentMaxLength, MinimumLength = ContentMinLength,
             ErrorMessage = "Невалиден отговор! Дължината на въпроса трябва да е между {1} и {2} символа.")]

        public string Content { get; set; } = null!;
    }
}
