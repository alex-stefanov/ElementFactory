using System.ComponentModel.DataAnnotations;

namespace ElementFactory.Data.Models
{
    public class School
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
    }
}
