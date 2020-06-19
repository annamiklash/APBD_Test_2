using APBD_Test_2.DTOs.Requests;
using APBD_Test_2.DTOs.Responses;

namespace APBD_Test_2.Services.Interfaces
{
    public interface IPetsDbService
    {
        AllPetsResponse GetAllPets();
        AllPetsResponse GetAllPets(string year);

        AddPetResponse AddPet(AddPetRequest request);
    }
}