using Microsoft.AspNetCore.Identity;

namespace Api.Model
{
    public class AppUserRole : IdentityUserRole<int>
    {

        public AppUser User { get; set; }


        public AppRole Role { get; set; }
    }
}
