namespace ElementFactory.Models.Test
{
    using System.ComponentModel.DataAnnotations;

    public class EditTestViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Полето за заглавие е задължително!")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Дължината за полето на заглавието" +
            " трябва да е между" +
            " {2} and {1} символа!")]
        public string Title { get; set; } = null!;

        public string Category { get; set; } = null!;
    }
}
