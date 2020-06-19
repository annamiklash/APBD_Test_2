using System.Collections.Generic;
using APBD_Test_2.Wrappers;

namespace APBD_Test_2.DTOs.Responses
{
    public class AllPetsResponse
    {
        public List<PetWrapper> Pets { get; set; }
    }
}