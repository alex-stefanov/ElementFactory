namespace ElementFactory.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// ChemicalElementQuestion class => Mapping Table Class
    /// </summary>
    [Comment("Chemical Element Question Class")]
    public class ChemicalElementQuestionMap
    {
        /// <summary>
        /// Chemical Element Symbol 
        /// corresponding to the Chemical Element => Foreign Key
        /// </summary>
        [ForeignKey(nameof(ChemicalElement))]
        public string ChemicalElementSymbol { get; set; } = null!;

        /// <summary>
        /// Property for the Chemical Element
        /// </summary>
        public virtual ChemicalElement ChemicalElement { get; set; }
        = null!;

        /// <summary>
        /// Id corresponding to the Question => Foreign Key
        /// </summary>
        [ForeignKey(nameof(Question))]
        public int QuestionId { get; set; }

        /// <summary>
        /// Property for the Question
        /// </summary>
        public virtual Question Question { get; set; }
        = null!;
    }
}
