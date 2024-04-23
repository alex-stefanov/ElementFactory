namespace ElementFactory.Models.Login
{
    using ElementFactory.Data.Models;
    using System.ComponentModel.DataAnnotations;

    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
