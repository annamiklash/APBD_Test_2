using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APBD_Test_2.Models
{
    public class Pet
    {
        [Key] public int IdPet { get; set; }
        public string Name { get; set; }
        public bool IsMale { get; set; }
        public DateTime DateRegistered { get; set; }
        public DateTime ApproximateDateOfBirth { get; set; }
        public DateTime? DateAdopted { get; set; }

        public int IdBreedType { get; set; }
        public virtual BreedType BreedType { get; set; }

        public virtual IEnumerable<VolunteerPet> VolunteerPet { get; set; }
    }
}