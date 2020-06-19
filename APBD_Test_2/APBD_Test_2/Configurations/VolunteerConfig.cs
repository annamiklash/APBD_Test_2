using APBD_Test_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_Test_2.Configurations
{
    public class VolunteerConfig : IEntityTypeConfiguration<Volunteer>
    {
        public void Configure(EntityTypeBuilder<Volunteer> builder)
        {  
         builder.HasKey(x => x.IdVolunteer)
                .HasName("Volunteer_pk");

            builder.ToTable("Volunteer", "apbd_test_2");

            builder.Property(e => e.IdVolunteer).ValueGeneratedOnAdd();

            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(80);

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(80);

            builder.Property(x => x.Phone)
                .IsRequired()
                .HasMaxLength(30);
            
            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(80);
            
            builder.Property(x => x.Address)
                .IsRequired()
                .HasMaxLength(100);
            
            builder.Property(x => x.StartDate)
                .IsRequired()
                .HasColumnType("datetime");

            builder.HasMany(d => d.VolunteerPet)
                .WithOne(x => x.Volunteer);

            builder.HasOne(x => x.Supervisor)
                .WithMany()
                .HasForeignKey(x => x.IdSupervisor);

        }
    }
}