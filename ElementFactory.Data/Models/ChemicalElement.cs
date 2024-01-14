namespace ElementFactory.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Chemical Element Class
    /// </summary>
    [Comment("Chemical Element Class")]
    public class ChemicalElement
    {
        /// <summary>
        /// Element Symbol => Primary Key
        /// </summary>
        [Key]
        [Required]
        [MinLength(1), MaxLength(2)]
        public string Symbol { get; set; } = null!;

        /// <summary>
        /// Element Name
        /// </summary>
        [MinLength(3), MaxLength(13)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Element Atomic Number
        /// </summary>
        [Required]
        [Range(1, 118)]
        public int AtomicNumber { get; set; }

        /// <summary>
        /// Element Atomic Mass
        /// </summary>
        [Required]
        public decimal AtomicMass { get; set; }

        /// <summary>
        /// Group from the Periodic Table for the Element
        /// </summary>
        [Required]
        [Range(1,18)]
        public int Group { get; set; }

        /// <summary>
        /// Period from the Periodic Table for the Element
        /// </summary>
        [Required]
        [Range(1,7)]
        public int Period { get; set; }

        /// <summary>
        /// Number of Element Electronic Layers
        /// </summary>
        [Required]
        [Range(1,7)]
        public int ElectronicLayers { get; set; }

        /// <summary>
        /// Flag for radioactivity for an Element
        /// </summary>
        [Required]
        public bool IsRadioactive { get; set; }

        /// <summary>
        /// Flag for syntheticity for an Element
        /// </summary>
        [Required]
        public bool IsSynthetic { get; set; }

        /// <summary>
        /// Id corresponding to the Chemical Type => Foreign Key
        /// </summary>
        [ForeignKey(nameof(ChemicalType))]
        [Required]
        public int ChemicalTypeId { get; set; }

        /// <summary>
        /// Boiling point for the Element
        /// </summary>
        [Required]
        public decimal BoilingPoint { get; set; }

        /// <summary>
        /// Melting point for the Element
        /// </summary>
        [Required]
        public decimal MeltingPoint { get; set; }

        /// <summary>
        /// Year when the Element was found
        /// </summary>
        [Required]
        public int YearFound { get; set; }

        /// <summary>
        /// Physical state for the Element
        /// </summary>
        [Required]
        public string? State { get; set; }

        /// <summary>
        /// Electronegativity for the Element
        /// </summary>
        [Required]
        public decimal Electronegativity { get; set; }

        /// <summary>
        /// Atomic Radius for the Element
        /// </summary>
        [Required]
        public decimal AtomicRadius { get; set; }

        /// <summary>
        /// Property for the Chemical Type
        /// </summary>
        public virtual ChemicalType ChemicalType { get; set; } 
            = null!;

        /// <summary>
        /// Collection from ChemicalElementQuestions
        /// </summary>
        public ICollection<ChemicalElementQuestion>
            ChemicalElementsQuestions { get; set; } = null!;

        /// <summary>
        /// Collection from FoundersChemicalElements
        /// </summary>
        public ICollection<FounderChemicalElement>
           FoundersChemicalElements { get; set; } = null!;
    }
}
