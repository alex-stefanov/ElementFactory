namespace ElementFactory.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Test class
    /// </summary>
    [Comment("Test Class")]
    public class Test
    {
        /// <summary>
        /// Test Id => Primary Key
        /// 
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Test Title
        /// </summary>
        [MinLength(3), MaxLength(150)]
        public string Title { get; set; } = null!;

        /// <summary>
        /// Test Category
        /// </summary>
        [MinLength(3), MaxLength(100)]
        public string Category { get; set; } = null!;

        /// <summary>
        /// Collection from QuestionsTests
        /// </summary>
        public ICollection<QuestionTestMap> QuestionsTests { get; set; }
        = null!;
    }
}
