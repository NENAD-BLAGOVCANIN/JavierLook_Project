using System.ComponentModel.DataAnnotations;

namespace JavierLook.Models
{
    public class UserRegistrationModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; } = string.Empty;

    }
}
