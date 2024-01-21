namespace ElementFactory.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Chemical Element Founder class
    /// </summary>
    [Comment("Founder Class")]
    public class Founder
    {
        /// <summary>
        /// Founder Id => Primary Key
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Founder First Name
        /// </summary>
        [Required]
        [MinLength(1), MaxLength(50)]
        public string FirstName { get; set; } = null!;

        /// <summary>
        /// Founder Last Name
        /// </summary>
        [Required]
        [MinLength(1), MaxLength(50)]
        public string LastName { get; set; } = null!;

        /// <summary>
        /// Collection from FoundersChemicalElements
        /// </summary>
        public ICollection<FounderChemicalElementMap>
           FoundersChemicalElements
        { get; set; } = null!;
    }
}
