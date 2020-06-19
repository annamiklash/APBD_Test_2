using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APBD_Test_2.Models
{
    public class BreedType
    {
        [Key] 
        public int IdBreedType { get; set; }
        public string Name { get; set; }
        public string Description{ get; set; }

        public virtual IEnumerable<Pet> Pet { get; set; }
    }
}