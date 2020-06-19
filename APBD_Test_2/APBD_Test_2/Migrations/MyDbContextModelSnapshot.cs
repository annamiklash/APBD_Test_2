﻿// <auto-generated />
using System;
using APBD_Test_2.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APBD_Test_2.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            IdPet = 1,
                            ApproximateDateOfBirth = new DateTime(2013, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistered = new DateTime(2015, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdBreedType = 1,
                            IsMale = true,
                            Name = "bobik"
                        },
                        new
                        {
                            IdPet = 2,
                            ApproximateDateOfBirth = new DateTime(2015, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateAdopted = new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistered = new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdBreedType = 2,
                            IsMale = false,
                            Name = "lolo"
                        },
                        new
                        {
                            IdPet = 3,
                            ApproximateDateOfBirth = new DateTime(2015, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateAdopted = new DateTime(2016, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistered = new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdBreedType = 2,
                            IsMale = false,
                            Name = "lala"
                        },
                        new
                        {
                            IdPet = 4,
                            ApproximateDateOfBirth = new DateTime(2018, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateAdopted = new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistered = new DateTime(2019, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdBreedType = 3,
                            IsMale = false,
                            Name = "bobo"
                        },
                        new
                        {
                            IdPet = 5,
                            ApproximateDateOfBirth = new DateTime(2015, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistered = new DateTime(2016, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdBreedType = 3,
                            IsMale = true,
                            Name = "biba"
                        },
                        new
                        {
                            IdPet = 6,
                            ApproximateDateOfBirth = new DateTime(2015, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistered = new DateTime(2017, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdBreedType = 4,
                            IsMale = true,
                            Name = "bubu"
                        });
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

                    b.HasData(
                        new
                        {
                            IdVolunteer = 1,
                            Address = "alabama",
                            Email = "tiger@king.com",
                            FirstName = "Tiger",
                            LastName = "King",
                            Phone = "666-666-666",
                            StartDate = new DateTime(2000, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdVolunteer = 2,
                            Address = "luisiana",
                            Email = "cat@kitten.com",
                            FirstName = "Caroll",
                            LastName = "Baskin",
                            Phone = "666-666-999",
                            StartDate = new DateTime(2000, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdVolunteer = 3,
                            Address = "privet drive",
                            Email = "harry@pot.com",
                            FirstName = "Harry",
                            IdSupervisor = 1,
                            LastName = "Potter",
                            Phone = "000-000-000",
                            StartDate = new DateTime(2010, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdVolunteer = 4,
                            Address = "somewhere",
                            Email = "tiger@king.com",
                            FirstName = "Ron",
                            IdSupervisor = 2,
                            LastName = "Whisley",
                            Phone = "231-321-123",
                            StartDate = new DateTime(2012, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdVolunteer = 5,
                            Address = "scranton, pa",
                            Email = "dunder@mifflin.com",
                            FirstName = "Michael",
                            IdSupervisor = 1,
                            LastName = "Scott",
                            Phone = "111-111-111",
                            StartDate = new DateTime(2007, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdVolunteer = 6,
                            Address = "hello is it me",
                            Email = "heelo@lionel.com",
                            FirstName = "Lionel",
                            LastName = "Richie",
                            Phone = "544-444-333",
                            StartDate = new DateTime(2007, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
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

                    b.HasData(
                        new
                        {
                            IdPet = 1,
                            IdVolunteer = 1,
                            DateAccepted = new DateTime(2017, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdPet = 2,
                            IdVolunteer = 1,
                            DateAccepted = new DateTime(2016, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdPet = 2,
                            IdVolunteer = 2,
                            DateAccepted = new DateTime(2016, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdPet = 3,
                            IdVolunteer = 3,
                            DateAccepted = new DateTime(2016, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdPet = 4,
                            IdVolunteer = 4,
                            DateAccepted = new DateTime(2019, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdPet = 5,
                            IdVolunteer = 5,
                            DateAccepted = new DateTime(2016, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdPet = 6,
                            IdVolunteer = 5,
                            DateAccepted = new DateTime(2017, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
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
