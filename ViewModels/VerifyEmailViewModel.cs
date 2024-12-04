using System.ComponentModel.DataAnnotations;

namespace SpendSmart.ViewModels
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = "Please Enter your email here ")]
        [EmailAddress]
        public required string Email { get; set; }

    }
}
