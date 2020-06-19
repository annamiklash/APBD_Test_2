using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_Test_2.Migrations
{
    public partial class seed_pets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "apbd_test_2",
                table: "Pet",
                columns: new[] { "IdPet", "ApproximateDateOfBirth", "DateAdopted", "DateRegistered", "IdBreedType", "IsMale", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2013, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2015, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "bobik" },
                    { 2, new DateTime(2015, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "lolo" },
                    { 3, new DateTime(2015, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "lala" },
                    { 4, new DateTime(2018, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "bobo" },
                    { 5, new DateTime(2015, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2016, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "biba" },
                    { 6, new DateTime(2015, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true, "bubu" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "Pet",
                keyColumn: "IdPet",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "Pet",
                keyColumn: "IdPet",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "Pet",
                keyColumn: "IdPet",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "Pet",
                keyColumn: "IdPet",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "Pet",
                keyColumn: "IdPet",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "Pet",
                keyColumn: "IdPet",
                keyValue: 6);
        }
    }
}
