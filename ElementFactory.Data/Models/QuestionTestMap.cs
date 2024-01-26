﻿namespace ElementFactory.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class QuestionTestMap
    {
        /// <summary>
        /// Question Id corresponding to the Question => Foreign Key
        /// </summary>
        [ForeignKey(nameof(Question))]
        public int QuestionId { get; set; }

        /// <summary>
        /// Property for the Question
        /// </summary>
        public virtual Question Question { get; set; } = null!;

        /// <summary> 
        /// Test ID corresponding to the Test => Foreign Key
        /// </summary>
        [ForeignKey(nameof(Test))]
        public int TestId { get; set; }

        /// <summary>
        /// Property for the Test
        /// </summary>
        public virtual Test Test { get; set; }
        = null!;
    }
}