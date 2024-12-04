using Microsoft.AspNetCore.Identity;

namespace SpendSmart.Models
{
    public class Users:IdentityUser
    {
        public required string  FullName { get; set; }
    }
}
