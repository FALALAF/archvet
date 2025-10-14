using Microsoft.AspNetCore.Identity;

namespace BlazorApp1.Models
{
    public class User : IdentityUser
    {
        public string? DisplayName { get; set; } 
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}