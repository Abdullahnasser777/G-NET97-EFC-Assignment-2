using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET97_EFC_Assignment_2.Models
{
    public class Attendee
    {
        
        public int AttendeeId { get; set; }

        [Required]
        [MaxLength(150)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(150)]
        public string Email { get; set; }

        [Required]
        [MaxLength(150)]
        public string Street { get; set; }

        [Required]
        [MaxLength(150)]
        public string City { get; set; }

        [Required]
        [MaxLength(150)]
        public string Country { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("ZipCode")]
        public string PostalCode { get; set; }
        public Badge? Badge { get; set; } //Navigation 
    }
}
