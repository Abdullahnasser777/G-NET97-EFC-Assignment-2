using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET97_EFC_Assignment_2.Models
{
    public class OrganizerProFile
    {
        public int OrganizerProFileId { get; set; } 
        public string? Bio { get; set; }
        public string? WebSite { get; set; }
        public string? Logo { get; set; }
        public int OrganizerId { get; set; } // Fk 
        public Organizer Organizer { get; set; } // Navigation 
    }
}
