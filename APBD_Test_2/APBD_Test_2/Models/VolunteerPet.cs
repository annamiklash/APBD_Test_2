using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace APBD_Test_2.Models
{
    public class VolunteerPet
    {
        public DateTime DateAccepted { get; set; }
        
        public int IdPet { get; set; }
        public virtual Pet Pet { get; set; }

        public int IdVolunteer { get; set; }
        public virtual Volunteer Volunteer { get; set; }
    }
}