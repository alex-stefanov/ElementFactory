namespace ElementFactory.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Chemical Type class
    /// </summary>
    [Comment("Chemical Type Class")]
    public class ChemicalType
    {
        /// <summary>
        /// Chemical Type Id => Primary Key
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Chemical Type Name
        /// </summary>
        [Required]
        [MinLength(5), MaxLength(25)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Collection from Chemical Elements
        /// </summary>
        public ICollection<ChemicalElement> ChemicalElements 
        { get; set; } = null!;
    }
}
