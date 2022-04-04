using System.ComponentModel.DataAnnotations;

namespace CWP.Models
{
    public class ResetPasswordModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "New password is required")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Confirm new password is required")]
        public string ConfirmNewPassword { get; set; }

        public string Token { get; set; }
    }
}
