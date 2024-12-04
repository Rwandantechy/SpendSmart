using System.ComponentModel.DataAnnotations;

namespace SpendSmart.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Please Enter your email here ")]
        [EmailAddress]
        public required string Email { get; set; }
        [Required(ErrorMessage = "Please Enter your Password here ")]
        [StringLength(40, MinimumLength = 12, ErrorMessage = "The password must be between {1} and  {2} characters")]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        [Compare("ConfirmNewPassword", ErrorMessage = "Passwords don't Match")]
        public required string NewPassword { get; set; }

        [Required(ErrorMessage = "Please Confirm the  Password")]
        [StringLength(40, MinimumLength = 12)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm the new Password")]
        public required string ConfirmNewPassword { get; set; }
       
    }
  

}
