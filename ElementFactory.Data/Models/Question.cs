namespace ElementFactory.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;

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
        public int Id { get; set; }

        /// <summary>
        /// Question Description
        /// </summary>
        [Required]
        [MinLength(10), MaxLength(300)]
        public string Description { get; set; } = null!;

        /// <summary>
        /// Collection from ChemicalElementsQuestions
        /// </summary>
        public ICollection<ChemicalElementQuestionMap>
            ChemicalElementsQuestions { get; set; } = null!;


    }
}
