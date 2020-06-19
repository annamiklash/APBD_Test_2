using APBD_Test_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_Test_2.Configurations
{
    public class VolunteerPetConfig : IEntityTypeConfiguration<VolunteerPet>
    {
        public void Configure(EntityTypeBuilder<VolunteerPet> builder)
        {
            builder.HasKey(e => new {e.IdPet, e.IdVolunteer});
            builder.Property(e => e.IdPet);
            builder.ToTable("VolunteerPet", "apbd_test_2");

            builder.Property(e => e.IdVolunteer);

            builder.Property(x => x.DateAccepted)
                .IsRequired()
                .HasColumnType("datetime");

            builder.HasOne(x => x.Pet)
                .WithMany(x => x.VolunteerPet)
                .HasForeignKey(x => x.IdPet)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("Pet_VolunteerPet");
            
            builder.HasOne(x => x.Volunteer)
                .WithMany(x => x.VolunteerPet)
                .HasForeignKey(x => x.IdVolunteer)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("Volunteer_VolunteerPet");
        }
    }
}