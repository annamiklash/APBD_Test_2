using APBD_Test_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_Test_2.Configurations
{
    public class PetConfig : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.HasKey(x => x.IdPet)
                .HasName("Pet_pk");

            builder.ToTable("Pet", "apbd_test_2");

            builder.Property(e => e.IdPet)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(80);
            
            builder.Property(x => x.IsMale)
                .IsRequired()
                .HasColumnType("bit");
            
            builder.Property(x => x.DateRegistered)
                .IsRequired()
                .HasColumnType("datetime");
                
            builder.Property(x => x.ApproximateDateOfBirth)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(x => x.DateAdopted)
                .HasColumnType("datetime");
            

            builder.HasMany(d => d.VolunteerPet)
                .WithOne(x => x.Pet);

            builder.HasOne(x => x.BreedType)
                .WithMany(x => x.Pet)
                .HasForeignKey(x => x.IdBreedType)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("Pet_BreedType");
        }
    }
}