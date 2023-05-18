using Microsoft.AspNetCore.Identity;

namespace Online_Learning_Platform.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
