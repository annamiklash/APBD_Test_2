using APBD_Test_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_Test_2.Configurations
{
    public class BreedTypeConfig : IEntityTypeConfiguration<BreedType>
    {
        public void Configure(EntityTypeBuilder<BreedType> builder)
        {
            builder.HasKey(x => x.IdBreedType)
                .HasName("BreedType_pk");

            builder.ToTable("BreedType", "apbd_test_2");

            builder.Property(e => e.IdBreedType)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Description)
                .HasMaxLength(500);

            builder.HasMany(d => d.Pet)
                .WithOne(x => x.BreedType);
        }
    }
}