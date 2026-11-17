using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET97_EFC_Assignment_2.Models
{
    public class Badge
    {
        public int BadgeId { get; set; }
        public int BadgeNUmber { get; set; }
        public DateTime IssuedDate { get; set; }
        public BadgeTier Tier { get; set; }
        public int AttendeeId { get; set; } // Fk 
        public Attendee Attendee { get; set; } //Navigation
    }
}
