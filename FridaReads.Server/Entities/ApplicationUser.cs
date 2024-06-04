using Microsoft.AspNetCore.Identity;

namespace FridaReads.Server.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public bool IsAdmin { get; set; }
    }
}
