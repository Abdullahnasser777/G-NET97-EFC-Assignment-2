using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace G_NET97_EFC_Assignment_2.Models
{
    [Table("Event_Organizer")]
    public class Organizer
    {
        public int OrganizerId { get; set; }
        [Required]
        [MaxLength(100)]
        public string name { get; set; }
        [MaxLength(150)]
        public string? CompanyName { get; set; }
        public bool IsVerified { get; set; }
        public OrganizerProFile? OrganizerProFile { get; set; } //Navigation
        public List <Event> Events { get; set; }


    }
}
