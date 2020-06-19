using APBD_Test_2.DTOs.Requests;
using APBD_Test_2.DTOs.Responses;
using APBD_Test_2.Helpers;
using APBD_Test_2.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Test_2.Controllers
{
    [Route("api/pets")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly IPetsDbService _petsDbService;

        public PetsController(IPetsDbService petsDbService)
        {
            _petsDbService = petsDbService;
        }

        [HttpGet]
        public IActionResult ListPetsStartingFromYear(string year)
        {
            var isYearValid = ValidationHelper.IsYearValid(year);
            if (!isYearValid)
            {
                return BadRequest("YEAR MUST BE NUMERICAL");
            }
            AllPetsResponse response = new AllPetsResponse();
            if (string.IsNullOrEmpty(year))
            {
                response = _petsDbService.GetAllPets();
                return Ok(response);
            }

            response = _petsDbService.GetAllPets(year);
            return Ok(response);
        }

        [HttpPost]
        public IActionResult AddPet(AddPetRequest request)
        {
            //validate
            var errors = ValidationHelper.ValidateAddPet(request);
            if (errors.Count > 0)
            {
                return BadRequest(errors);
            }

            var response = _petsDbService.AddPet(request);
            return Ok(response);
        }
    }
}