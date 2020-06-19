using System;
using System.Collections.Generic;
using APBD_Test_2.Models;

namespace APBD_Test_2.Wrappers
{
    public class PetWrapper
    {
        public string Name { get; set; }
        public bool IsMale { get; set; }
        public DateTime DateRegistered { get; set; }
        public DateTime ApproximateDateOfBirth { get; set; }
        public DateTime? DateAdopted { get; set; }
        public List<VolunteerWrapper> VolunteerWrappers { get; set; }
    }
}