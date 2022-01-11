using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public class Address
    {
        [ForeignKey("AppUserId")]
        public string AppUserId { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
        public AppUser AppUser { get; set; }

    }
}
