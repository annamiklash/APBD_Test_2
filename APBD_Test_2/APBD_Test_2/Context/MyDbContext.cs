using APBD_Test_2.Configurations;
using APBD_Test_2.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_Test_2.Context
{
    public class MyDbContext : DbContext
    {
        public DbSet<BreedType> BreedType { get; set; }
        public DbSet<Volunteer> Volunteer { get; set; }
        public DbSet<VolunteerPet> VolunteerPet { get; set; }
        public DbSet<Pet> Pet { get; set; }
        
        
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public MyDbContext()
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BreedTypeConfig());

            modelBuilder.ApplyConfiguration(new VolunteerConfig());

            modelBuilder.ApplyConfiguration(new PetConfig());
            
            modelBuilder.ApplyConfiguration(new VolunteerPetConfig());


            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }
    }
}