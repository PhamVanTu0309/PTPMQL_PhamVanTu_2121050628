using Microsoft.AspNetCore.Identity;
namespace Example_Slide.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string FullName { get; set; }
    }
}