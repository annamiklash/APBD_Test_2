using System;
using System.Collections.Generic;
using APBD_Test_2.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_Test_2.Context
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var breedTypes = GenerateBreedTypes();
            var volunteers = GenerateVolunteers();
            var pets = GeneratePets();
            var volunteerPets = GenerateVolunteerPets();


            SeedBreedTypes(breedTypes, modelBuilder);
            SeedVolunteers(volunteers, modelBuilder);
            SeedPets(pets, modelBuilder);
            SeedVolunteerPets(volunteerPets, modelBuilder);
        }

      
        private static void SeedVolunteerPets(List<VolunteerPet> volunteerPets, ModelBuilder modelBuilder)
        {
            foreach (var volunteerPet in volunteerPets)
            {
                modelBuilder
                    .Entity<VolunteerPet>()
                    .HasData(volunteerPet);
            }
        }

        private static void SeedVolunteers(List<Volunteer> volunteers, ModelBuilder modelBuilder)
        {
            foreach (var volunteer in volunteers)
            {
                modelBuilder
                    .Entity<Volunteer>()
                    .HasData(volunteer);
            }
        }

        private static void SeedPets(List<Pet> pets, ModelBuilder modelBuilder)
        {
            foreach (var pet in pets)
            {
                modelBuilder
                    .Entity<Pet>()
                    .HasData(pet);
            }
        }

        private static void SeedBreedTypes(List<BreedType> breedTypes, ModelBuilder modelBuilder)
        {
            foreach (var breedType in breedTypes)
            {
                modelBuilder
                    .Entity<BreedType>()
                    .HasData(breedType);
            }
        }


        private static List<Volunteer> GenerateVolunteers()
        {
            return new List<Volunteer>
            {
                new Volunteer
                {
                    IdVolunteer = 1,
                    FirstName = "Tiger",
                    LastName = "King",
                    Phone = "666-666-666",
                    Address = "alabama",
                    Email = "tiger@king.com",
                    StartDate = DateTime.ParseExact("14.12.2000", "dd.MM.yyyy", null)
                },
                new Volunteer
                {
                    IdVolunteer = 2,
                    FirstName = "Caroll",
                    LastName = "Baskin",
                    Phone = "666-666-999",
                    Address = "luisiana",
                    Email = "cat@kitten.com",
                    StartDate = DateTime.ParseExact("13.12.2000", "dd.MM.yyyy", null)
                },
                new Volunteer
                {
                    IdVolunteer = 3,
                    FirstName = "Harry",
                    LastName = "Potter",
                    Phone = "000-000-000",
                    Address = "privet drive",
                    Email = "harry@pot.com",
                    StartDate = DateTime.ParseExact("17.04.2010", "dd.MM.yyyy", null),
                    IdSupervisor = 1
                },
                new Volunteer
                {
                    IdVolunteer = 4,
                    FirstName = "Ron",
                    LastName = "Whisley",
                    Phone = "231-321-123",
                    Address = "somewhere",
                    Email = "tiger@king.com",
                    StartDate = DateTime.ParseExact("30.06.2012", "dd.MM.yyyy", null),
                    IdSupervisor = 2
                },
                new Volunteer
                {
                    IdVolunteer = 5,
                    FirstName = "Michael",
                    LastName = "Scott",
                    Phone = "111-111-111",
                    Address = "scranton, pa",
                    Email = "dunder@mifflin.com",
                    StartDate = DateTime.ParseExact("10.01.2007", "dd.MM.yyyy", null),
                    IdSupervisor = 1
                },
                new Volunteer
                {
                    IdVolunteer = 6,
                    FirstName = "Lionel",
                    LastName = "Richie",
                    Phone = "544-444-333",
                    Address = "hello is it me",
                    Email = "heelo@lionel.com",
                    StartDate = DateTime.ParseExact("10.01.2007", "dd.MM.yyyy", null)
                }
            };
        }

        private static List<VolunteerPet> GenerateVolunteerPets()
        {
            return new List<VolunteerPet>
            {
                new VolunteerPet
                {
                    IdVolunteer = 1,
                    IdPet = 1,
                    DateAccepted = DateTime.ParseExact("10.12.2017", "dd.MM.yyyy", null)
                },
                new VolunteerPet
                {
                    IdVolunteer = 1,
                    IdPet = 2,
                    DateAccepted = DateTime.ParseExact("12.11.2016", "dd.MM.yyyy", null)
                },
                new VolunteerPet
                {
                    IdVolunteer = 2,
                    IdPet = 2,
                    DateAccepted = DateTime.ParseExact("11.11.2016", "dd.MM.yyyy", null)
                },
                new VolunteerPet
                {
                    IdVolunteer = 3,
                    IdPet = 3,
                    DateAccepted = DateTime.ParseExact("30.07.2016", "dd.MM.yyyy", null)
                },
                new VolunteerPet
                {
                    IdVolunteer = 4,
                    IdPet = 4,
                    DateAccepted = DateTime.ParseExact("14.12.2019", "dd.MM.yyyy", null)
                },
                new VolunteerPet
                {
                    IdVolunteer = 5,
                    IdPet = 5,
                    DateAccepted = DateTime.ParseExact("27.10.2016", "dd.MM.yyyy", null)
                },
                new VolunteerPet
                {
                    IdVolunteer = 5,
                    IdPet = 6,
                    DateAccepted = DateTime.ParseExact("30.12.2017", "dd.MM.yyyy", null)
                },
            };
        }


        private static List<Pet> GeneratePets()
        {
            return new List<Pet>
            {
                new Pet
                {
                    IdPet = 1,
                    IdBreedType = 1,
                    Name = "bobik",
                    IsMale = true,
                    DateRegistered = DateTime.ParseExact("10.01.2015", "dd.MM.yyyy", null),
                    ApproximateDateOfBirth = DateTime.ParseExact("15.01.2013", "dd.MM.yyyy", null)
                },
                new Pet
                {
                    IdPet = 2,
                    IdBreedType = 2,
                    Name = "lolo",
                    IsMale = false,
                    DateRegistered = DateTime.ParseExact("10.06.2016", "dd.MM.yyyy", null),
                    ApproximateDateOfBirth = DateTime.ParseExact("10.06.2015", "dd.MM.yyyy", null),
                    DateAdopted = DateTime.ParseExact("10.06.2016", "dd.MM.yyyy", null),
                },
                new Pet
                {
                    IdPet = 3,
                    IdBreedType = 2,
                    Name = "lala",
                    IsMale = false,
                    DateRegistered = DateTime.ParseExact("10.06.2016", "dd.MM.yyyy", null),
                    ApproximateDateOfBirth = DateTime.ParseExact("10.06.2015", "dd.MM.yyyy", null),
                    DateAdopted = DateTime.ParseExact("27.06.2016", "dd.MM.yyyy", null),
                },
                new Pet
                {
                    IdPet = 4,
                    IdBreedType = 3,
                    Name = "bobo",
                    IsMale = false,
                    DateRegistered = DateTime.ParseExact("11.06.2019", "dd.MM.yyyy", null),
                    ApproximateDateOfBirth = DateTime.ParseExact("17.06.2018", "dd.MM.yyyy", null),
                    DateAdopted = DateTime.ParseExact("13.06.2020", "dd.MM.yyyy", null),
                },
                new Pet
                {
                    IdPet = 5,
                    IdBreedType = 3,
                    Name = "biba",
                    IsMale = true,
                    DateRegistered = DateTime.ParseExact("30.07.2016", "dd.MM.yyyy", null),
                    ApproximateDateOfBirth = DateTime.ParseExact("15.12.2015", "dd.MM.yyyy", null)
                },
                new Pet
                {
                    IdPet = 6,
                    IdBreedType = 4,
                    Name = "bubu",
                    IsMale = true,
                    DateRegistered = DateTime.ParseExact("22.05.2017", "dd.MM.yyyy", null),
                    ApproximateDateOfBirth = DateTime.ParseExact("19.09.2015", "dd.MM.yyyy", null)
                }
            };
        }

        private static List<BreedType> GenerateBreedTypes()
        {
            return new List<BreedType>
            {
                new BreedType()
                {
                    IdBreedType = 1,
                    Name = "labrador",
                    Description = "hello description"
                },
                new BreedType
                {
                    IdBreedType = 2,
                    Name = "chichuachua",
                    Description = "good bye"
                },
                new BreedType
                {
                    IdBreedType = 3,
                    Name = "samoyed",
                },
                new BreedType()
                {
                    IdBreedType = 4,
                    Name = "puddle"
                }
            };
        }
    }
}