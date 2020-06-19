using System;

namespace APBD_Test_2.DTOs.Requests
{
    public class AddPetRequest
    {
        public string BreedName { get; set; }
        public string Name { get; set; }
        public string IsMale { get; set; }
        public string DateRegistered { get; set; }
        public string ApproximateDateOfBirth { get; set; }
    }
}