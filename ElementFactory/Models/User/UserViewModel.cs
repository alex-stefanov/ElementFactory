using System.ComponentModel.DataAnnotations;

namespace ElementFactory.Models.User
{
    public class UserViewModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        [StringLength(20, MinimumLength = 5,
            ErrorMessage = "Невалидно име! Дължината на името трябва да е между {1} и {2} символа.")]
        public string UserName { get; set; } = null!;

        [Required]
        [EmailAddress(ErrorMessage ="Невалиден формат на имейл!")]
        [StringLength(60, MinimumLength = 10,
            ErrorMessage = "Невалиден имейл! Дължината на имейла трябва да е между {1} и {2} символа.")]
        public string Email { get; set; } = null!;

        [Required]
        public List<string> Roles { get; set; } = null!;

        [Required]
        [Phone]
        [RegularExpression(@"08[789]\d{7}",ErrorMessage ="Невалиден формат на телефонен номер в България!")]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [StringLength(20, MinimumLength = 5,
            ErrorMessage = "Невалидна парола! Дължината на паеолата трябва да е между {1} и {2} символа.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Compare(nameof(Password),
            ErrorMessage = "Несъвпадащи пароли!")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;
    }
}
