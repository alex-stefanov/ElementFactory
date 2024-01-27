﻿namespace ElementFactory.Models.Test
{
    using ElementFactory.Models.Question;
    using System.ComponentModel.DataAnnotations;

    public class TestViewModel
    {
        [Required(ErrorMessage = "Полето за заглавие е задължително!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Дължината за полето на заглавието" +
            " трябва да е между" +
            " {2} and {1} символа!")]
        public string Title { get; set; } = null!;

        public string Category { get; set; } = null!;

        public List<QuestionsTestsMap> Questions { get; set; } = 
            new List<QuestionsTestsMap>();
    }
}
