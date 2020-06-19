using System;
using System.Collections;
using System.Collections.Generic;

namespace APBD_Test_2.Models
{
    public class Volunteer
    {
        public int IdVolunteer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime StartDate { get; set; }
        public int? IdSupervisor { get; set; }
        public virtual Volunteer Supervisor { get; set; }
        public virtual IEnumerable<Volunteer> Volunteers { get; set; }
        public virtual IEnumerable<VolunteerPet> VolunteerPet { get; set; }
    }
}