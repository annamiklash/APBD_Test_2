using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using APBD_Test_2.Context;
using APBD_Test_2.DTOs.Requests;
using APBD_Test_2.DTOs.Responses;
using APBD_Test_2.Models;
using APBD_Test_2.Services.Interfaces;
using APBD_Test_2.Wrappers;
using Microsoft.EntityFrameworkCore.Internal;

namespace APBD_Test_2.Services.Impls
{
    public class PetsDbService : IPetsDbService
    {
        private readonly MyDbContext _context;

        public PetsDbService(MyDbContext context)
        {
            _context = context;
        }


        public AllPetsResponse GetAllPets(string year)
        {
            int yearInt = Convert.ToInt32(year);
            var pets = _context.Pet.Where(pet => Convert.ToInt32(pet.DateRegistered.Year.ToString()) >= yearInt)
                .ToList();
            var volunteerPets = _context.VolunteerPet.ToList();
            var volunteers = _context.Volunteer.ToList();

            List<PetWrapper> petsWrappers = new List<PetWrapper>();

            foreach (var pet in pets)
            {
                AddToPetsWrapper(pet, petsWrappers, volunteerPets);
            }

            petsWrappers = petsWrappers.OrderBy(wrapper => wrapper.DateRegistered).ToList();
            return new AllPetsResponse
            {
                Pets = petsWrappers
            };
        }

        public AddPetResponse AddPet(AddPetRequest request)
        {
            var response = new AddPetResponse();
            bool breedExists = BreedExists(request.BreedName);
            if (!breedExists)
            {
                AddBreed(request.BreedName);
                return new AddPetResponse
                {
                    IdPet = CreatePet(request)
                };
                 
            }
            return new AddPetResponse
            {
                IdPet = CreatePet(request)
            };
        }

        private int CreatePet(AddPetRequest request)
        {
            var breedId = GetBreedId(request.BreedName);
            Pet pet = new Pet
            {
                Name = request.Name,
                IdBreedType = breedId,
                IsMale = ParseIsMale(request.IsMale),
                DateRegistered = DateTime.ParseExact(request.DateRegistered, "yyyy-MM-dd HH:mm:ss", null),
                ApproximateDateOfBirth =
                    DateTime.ParseExact(request.ApproximateDateOfBirth, "yyyy-MM-dd HH:mm:ss", null)
            };
            _context.Pet.Add(pet);
            _context.SaveChanges();
            return pet.IdPet;
        }

        private bool ParseIsMale(string isMale)
        {
            if (isMale == "0")
            {
                return false;
            }

            if (isMale == "1")
            {
                return true;
            }

            return false;
        }

        private int GetBreedId(string breedName)
        {
            return _context.BreedType.First(type => type.Name == breedName).IdBreedType;
        }

        private void AddBreed(string breedName)
        {
            BreedType breedType = new BreedType
            {
                Name = breedName
            };
            _context.BreedType.Add(breedType);
            _context.SaveChanges();
        }

        private bool BreedExists(string requestBreedName)
        {
            return _context.BreedType.Any(type => type.Name == requestBreedName);
        }


        public AllPetsResponse GetAllPets()
        {
            var pets = _context.Pet.ToList();
            var volunteerPets = _context.VolunteerPet.ToList();
            var volunteers = _context.Volunteer.ToList();

            List<PetWrapper> petsWrappers = new List<PetWrapper>();

            foreach (var pet in pets)
            {
                AddToPetsWrapper(pet, petsWrappers, volunteerPets);
            }

            petsWrappers = petsWrappers.OrderBy(wrapper => wrapper.DateRegistered).ToList();
            return new AllPetsResponse
            {
                Pets = petsWrappers
            };
        }

        private void AddToPetsWrapper(Pet pet, List<PetWrapper> petsWrappers, List<VolunteerPet> volunteerPets)
        {
            var ids = GetVolunteersIds(volunteerPets, pet.IdPet);
            var volunteerWrappers = GetVolunteers(ids);
            petsWrappers.Add(new PetWrapper
            {
                Name = pet.Name,
                IsMale = pet.IsMale,
                DateRegistered = pet.DateRegistered,
                ApproximateDateOfBirth = pet.ApproximateDateOfBirth,
                DateAdopted = pet.DateAdopted,
                VolunteerWrappers = volunteerWrappers
            });
        }

        private List<int> GetVolunteersIds(List<VolunteerPet> volunteerPets, int idPet)
        {
            return volunteerPets.Where(vp => vp.IdPet == idPet)
                .Select(vp => vp.IdVolunteer)
                .ToList();
        }

        private List<VolunteerWrapper> GetVolunteers(List<int> volunteerIds)
        {
            List<VolunteerWrapper> volunteers = new List<VolunteerWrapper>();
            foreach (var volunteerId in volunteerIds)
            {
                volunteers.Add(GetVolunteerById(volunteerId));
            }

            return volunteers;
        }

        private VolunteerWrapper GetVolunteerById(int volunteerId)
        {
            var volunteer = _context.Volunteer.First(volunteer => volunteer.IdVolunteer == volunteerId);
            return new VolunteerWrapper
            {
                FirstName = volunteer.FirstName,
                LastName = volunteer.LastName,
                PhoneNumber = volunteer.Phone
            };
        }
    }
}