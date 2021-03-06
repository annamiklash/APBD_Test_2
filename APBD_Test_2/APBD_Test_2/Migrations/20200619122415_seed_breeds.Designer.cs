﻿// <auto-generated />
using System;
using APBD_Test_2.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APBD_Test_2.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20200619122415_seed_breeds")]
    partial class seed_breeds
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APBD_Test_2.Models.BreedType", b =>
                {
                    b.Property<int>("IdBreedType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("IdBreedType")
                        .HasName("BreedType_pk");

                    b.ToTable("BreedType","apbd_test_2");

                    b.HasData(
                        new
                        {
                            IdBreedType = 1,
                            Description = "hello description",
                            Name = "labrador"
                        },
                        new
                        {
                            IdBreedType = 2,
                            Description = "good bye",
                            Name = "chichuachua"
                        },
                        new
                        {
                            IdBreedType = 3,
                            Name = "samoyed"
                        },
                        new
                        {
                            IdBreedType = 4,
                            Name = "puddle"
                        });
                });

            modelBuilder.Entity("APBD_Test_2.Models.Pet", b =>
                {
                    b.Property<int>("IdPet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ApproximateDateOfBirth")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DateAdopted")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateRegistered")
                        .HasColumnType("datetime");

                    b.Property<int>("IdBreedType")
                        .HasColumnType("int");

                    b.Property<bool>("IsMale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.HasKey("IdPet")
                        .HasName("Pet_pk");

                    b.HasIndex("IdBreedType");

                    b.ToTable("Pet","apbd_test_2");
                });

            modelBuilder.Entity("APBD_Test_2.Models.Volunteer", b =>
                {
                    b.Property<int>("IdVolunteer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<int?>("IdSupervisor")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("VolunteerIdVolunteer")
                        .HasColumnType("int");

                    b.HasKey("IdVolunteer")
                        .HasName("Volunteer_pk");

                    b.HasIndex("IdSupervisor");

                    b.HasIndex("VolunteerIdVolunteer");

                    b.ToTable("Volunteer","apbd_test_2");
                });

            modelBuilder.Entity("APBD_Test_2.Models.VolunteerPet", b =>
                {
                    b.Property<int>("IdPet")
                        .HasColumnType("int");

                    b.Property<int>("IdVolunteer")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAccepted")
                        .HasColumnType("datetime");

                    b.HasKey("IdPet", "IdVolunteer");

                    b.HasIndex("IdVolunteer");

                    b.ToTable("VolunteerPet","apbd_test_2");
                });

            modelBuilder.Entity("APBD_Test_2.Models.Pet", b =>
                {
                    b.HasOne("APBD_Test_2.Models.BreedType", "BreedType")
                        .WithMany("Pet")
                        .HasForeignKey("IdBreedType")
                        .HasConstraintName("Pet_BreedType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("APBD_Test_2.Models.Volunteer", b =>
                {
                    b.HasOne("APBD_Test_2.Models.Volunteer", "Supervisor")
                        .WithMany()
                        .HasForeignKey("IdSupervisor");

                    b.HasOne("APBD_Test_2.Models.Volunteer", null)
                        .WithMany("Volunteers")
                        .HasForeignKey("VolunteerIdVolunteer");
                });

            modelBuilder.Entity("APBD_Test_2.Models.VolunteerPet", b =>
                {
                    b.HasOne("APBD_Test_2.Models.Pet", "Pet")
                        .WithMany("VolunteerPet")
                        .HasForeignKey("IdPet")
                        .HasConstraintName("Pet_VolunteerPet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APBD_Test_2.Models.Volunteer", "Volunteer")
                        .WithMany("VolunteerPet")
                        .HasForeignKey("IdVolunteer")
                        .HasConstraintName("Volunteer_VolunteerPet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
