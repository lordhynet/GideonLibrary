using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Model
{
    public class AppUser : IdentityUser<int>
    {


        [Required]
        [StringLength(15, ErrorMessage = "Must be between 3 and 15")]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Must be between 3 and 15")]
        public string FirstName { get; set; }
        public bool IsActive { get; set; }
        public Address Address { get; set; }
        public List<Photo> Photos { get; set; }
        public ICollection<FavoriteBooks> UserBooks { get; set; }
        public ICollection<AppUserRole> UserRoles { get; set; }

       


    }
}
