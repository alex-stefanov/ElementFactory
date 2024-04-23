namespace ElementFactory.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations.Schema;

    public class User : IdentityUser
    {
        public User()
        {
        }

        public bool IsRequested { get; set; }

        public bool IsActive {  get; set; }

        public int Points { get; set; }

        public List<Flashcard> Flashcards { get; set; } = new List<Flashcard>();

        public School School { get; set; } = null!;

        public bool IsSchoolAccepted { get; set; }

        public List<User> Teachers { get; set; } = new List<User>();

        public List<User> Students { get; set; } = new List<User>();

        [InverseProperty("Users")]
        public ICollection<Test> Tests { get; set; }
        = new List<Test>();

        [InverseProperty("Maker")]
        public ICollection<Test> TestsMade { get; set; }
        = new List<Test>();
    }
}
