using System.ComponentModel.DataAnnotations;

namespace CWP.Models
{
    public class ChangePasswordModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Current password is required")]
        public string CurrentPassword { get; set; }

        [Required(ErrorMessage = "New password is required")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Confirm new password is required")]
        public string ConfirmNewPassword { get; set; }

    }
}
