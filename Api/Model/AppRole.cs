using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Api.Model
{
    public class AppRole : IdentityRole<int>
    {


        public List<AppUserRole> UserRoles { get; set; }




    }
}
