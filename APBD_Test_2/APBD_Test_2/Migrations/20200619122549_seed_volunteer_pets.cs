using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_Test_2.Migrations
{
    public partial class seed_volunteer_pets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "apbd_test_2",
                table: "VolunteerPet",
                columns: new[] { "IdPet", "IdVolunteer", "DateAccepted" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2017, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2016, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2016, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(2016, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, new DateTime(2019, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, new DateTime(2016, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 5, new DateTime(2017, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "VolunteerPet",
                keyColumns: new[] { "IdPet", "IdVolunteer" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "VolunteerPet",
                keyColumns: new[] { "IdPet", "IdVolunteer" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "VolunteerPet",
                keyColumns: new[] { "IdPet", "IdVolunteer" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "VolunteerPet",
                keyColumns: new[] { "IdPet", "IdVolunteer" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "VolunteerPet",
                keyColumns: new[] { "IdPet", "IdVolunteer" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "VolunteerPet",
                keyColumns: new[] { "IdPet", "IdVolunteer" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "VolunteerPet",
                keyColumns: new[] { "IdPet", "IdVolunteer" },
                keyValues: new object[] { 6, 5 });
        }
    }
}
