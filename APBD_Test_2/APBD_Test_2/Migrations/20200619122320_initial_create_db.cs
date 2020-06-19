using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_Test_2.Migrations
{
    public partial class initial_create_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "apbd_test_2");

            migrationBuilder.CreateTable(
                name: "BreedType",
                schema: "apbd_test_2",
                columns: table => new
                {
                    IdBreedType = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("BreedType_pk", x => x.IdBreedType);
                });

            migrationBuilder.CreateTable(
                name: "Volunteer",
                schema: "apbd_test_2",
                columns: table => new
                {
                    IdVolunteer = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 80, nullable: false),
                    LastName = table.Column<string>(maxLength: 80, nullable: false),
                    Phone = table.Column<string>(maxLength: 30, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 80, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IdSupervisor = table.Column<int>(nullable: true),
                    VolunteerIdVolunteer = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Volunteer_pk", x => x.IdVolunteer);
                    table.ForeignKey(
                        name: "FK_Volunteer_Volunteer_IdSupervisor",
                        column: x => x.IdSupervisor,
                        principalSchema: "apbd_test_2",
                        principalTable: "Volunteer",
                        principalColumn: "IdVolunteer",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Volunteer_Volunteer_VolunteerIdVolunteer",
                        column: x => x.VolunteerIdVolunteer,
                        principalSchema: "apbd_test_2",
                        principalTable: "Volunteer",
                        principalColumn: "IdVolunteer",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pet",
                schema: "apbd_test_2",
                columns: table => new
                {
                    IdPet = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    IsMale = table.Column<bool>(type: "bit", nullable: false),
                    DateRegistered = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApproximateDateOfBirth = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateAdopted = table.Column<DateTime>(type: "datetime", nullable: true),
                    IdBreedType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pet_pk", x => x.IdPet);
                    table.ForeignKey(
                        name: "Pet_BreedType",
                        column: x => x.IdBreedType,
                        principalSchema: "apbd_test_2",
                        principalTable: "BreedType",
                        principalColumn: "IdBreedType",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VolunteerPet",
                schema: "apbd_test_2",
                columns: table => new
                {
                    IdPet = table.Column<int>(nullable: false),
                    IdVolunteer = table.Column<int>(nullable: false),
                    DateAccepted = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolunteerPet", x => new { x.IdPet, x.IdVolunteer });
                    table.ForeignKey(
                        name: "Pet_VolunteerPet",
                        column: x => x.IdPet,
                        principalSchema: "apbd_test_2",
                        principalTable: "Pet",
                        principalColumn: "IdPet",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "Volunteer_VolunteerPet",
                        column: x => x.IdVolunteer,
                        principalSchema: "apbd_test_2",
                        principalTable: "Volunteer",
                        principalColumn: "IdVolunteer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pet_IdBreedType",
                schema: "apbd_test_2",
                table: "Pet",
                column: "IdBreedType");

            migrationBuilder.CreateIndex(
                name: "IX_Volunteer_IdSupervisor",
                schema: "apbd_test_2",
                table: "Volunteer",
                column: "IdSupervisor");

            migrationBuilder.CreateIndex(
                name: "IX_Volunteer_VolunteerIdVolunteer",
                schema: "apbd_test_2",
                table: "Volunteer",
                column: "VolunteerIdVolunteer");

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerPet_IdVolunteer",
                schema: "apbd_test_2",
                table: "VolunteerPet",
                column: "IdVolunteer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VolunteerPet",
                schema: "apbd_test_2");

            migrationBuilder.DropTable(
                name: "Pet",
                schema: "apbd_test_2");

            migrationBuilder.DropTable(
                name: "Volunteer",
                schema: "apbd_test_2");

            migrationBuilder.DropTable(
                name: "BreedType",
                schema: "apbd_test_2");
        }
    }
}
