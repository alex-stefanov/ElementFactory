namespace ElementFactory.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Answer class
    /// </summary>
    [Comment("Answer Class")]
    public class Answer
    {
        /// <summary>
        /// Answer Id => Primary Key
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Answer value
        /// </summary>
        public string Value { get; set; } = null!;

        /// <summary>
        /// Question property
        /// </summary>
        public virtual Question Question { get; set; } = null!;

        /// <summary>
        /// Question Id => Foreign Key
        /// </summary>
        [ForeignKey(nameof(Question))]
        public int QuestionId { get; set; }
    }
}
