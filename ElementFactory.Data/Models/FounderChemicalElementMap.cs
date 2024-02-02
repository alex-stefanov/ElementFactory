﻿namespace ElementFactory.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// FounderChemicalElement class => Mapping Table Class
    /// </summary>
    [Comment("Founder Chemical Element Class")]
    public class FounderChemicalElementMap
    {
        /// <summary>
        /// Founder Id corresponding to the Founder =>
        /// Foreign Key
        /// </summary>
        [ForeignKey(nameof(Founder))]
        [Comment("Founder identificator")]
        public int FounderId { get; set; }

        /// <summary>
        /// Property for the Founder
        /// </summary>
        public virtual Founder Founder { get; set; } = null!;

        /// <summary>
        /// Chemical Element Symbol corresponding to the 
        /// Chemical Element => Foreign Key
        /// </summary>
        [ForeignKey(nameof(ChemicalElement))]
        [Comment("Chemical element symbol => PK")]
        public string ChemicalElementSymbol { get; set; } = null!;

        /// <summary>
        /// Property for the Chemical Element
        /// </summary>
        public virtual ChemicalElement ChemicalElement { get; set; }
        = null!;
    }
}
