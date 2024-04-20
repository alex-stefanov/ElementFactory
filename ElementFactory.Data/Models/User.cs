namespace ElementFactory.Data.Models
{
    using Microsoft.AspNetCore.Identity;

    public class User : IdentityUser
    {
        public User()
        {
        }

        public bool IsRequested { get; set; }

        public bool IsActive {  get; set; }

        public int Points { get; set; }

        public List<Flashcard> Flashcards { get; set; } =new List<Flashcard>();
    }
}
