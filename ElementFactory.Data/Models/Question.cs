namespace ElementFactory.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Question class
    /// </summary>
    [Comment("Question Class")]
    public class Question
    {
        /// <summary>
        /// Question Id => Primary Key
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Question Description
        /// </summary>
        [Required]
        [MinLength(10), MaxLength(300)]
        public string Description { get; set; } = null!;

        /// <summary>
        /// Collection from question answers
        /// </summary>
        public ICollection<Answer> Answers { get; set; } = null!;

        /// <summary>
        /// Question right answer
        /// </summary>
        public string RightAnswer { get; set; } = null!;

        /// <summary>
        /// Collection from QuestionsTests
        /// </summary>
        public ICollection<QuestionTestMap> QuestionsTests { get; set; }
         = null!;
    }
}
