using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_Test_2.Migrations
{
    public partial class seed_volunteers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "apbd_test_2",
                table: "Volunteer",
                columns: new[] { "IdVolunteer", "Address", "Email", "FirstName", "IdSupervisor", "LastName", "Phone", "StartDate", "VolunteerIdVolunteer" },
                values: new object[] { 1, "alabama", "tiger@king.com", "Tiger", null, "King", "666-666-666", new DateTime(2000, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                schema: "apbd_test_2",
                table: "Volunteer",
                columns: new[] { "IdVolunteer", "Address", "Email", "FirstName", "IdSupervisor", "LastName", "Phone", "StartDate", "VolunteerIdVolunteer" },
                values: new object[] { 2, "luisiana", "cat@kitten.com", "Caroll", null, "Baskin", "666-666-999", new DateTime(2000, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                schema: "apbd_test_2",
                table: "Volunteer",
                columns: new[] { "IdVolunteer", "Address", "Email", "FirstName", "IdSupervisor", "LastName", "Phone", "StartDate", "VolunteerIdVolunteer" },
                values: new object[] { 6, "hello is it me", "heelo@lionel.com", "Lionel", null, "Richie", "544-444-333", new DateTime(2007, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                schema: "apbd_test_2",
                table: "Volunteer",
                columns: new[] { "IdVolunteer", "Address", "Email", "FirstName", "IdSupervisor", "LastName", "Phone", "StartDate", "VolunteerIdVolunteer" },
                values: new object[] { 3, "privet drive", "harry@pot.com", "Harry", 1, "Potter", "000-000-000", new DateTime(2010, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                schema: "apbd_test_2",
                table: "Volunteer",
                columns: new[] { "IdVolunteer", "Address", "Email", "FirstName", "IdSupervisor", "LastName", "Phone", "StartDate", "VolunteerIdVolunteer" },
                values: new object[] { 5, "scranton, pa", "dunder@mifflin.com", "Michael", 1, "Scott", "111-111-111", new DateTime(2007, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                schema: "apbd_test_2",
                table: "Volunteer",
                columns: new[] { "IdVolunteer", "Address", "Email", "FirstName", "IdSupervisor", "LastName", "Phone", "StartDate", "VolunteerIdVolunteer" },
                values: new object[] { 4, "somewhere", "tiger@king.com", "Ron", 2, "Whisley", "231-321-123", new DateTime(2012, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "Volunteer",
                keyColumn: "IdVolunteer",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "Volunteer",
                keyColumn: "IdVolunteer",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "Volunteer",
                keyColumn: "IdVolunteer",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "Volunteer",
                keyColumn: "IdVolunteer",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "Volunteer",
                keyColumn: "IdVolunteer",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "Volunteer",
                keyColumn: "IdVolunteer",
                keyValue: 2);
        }
    }
}
