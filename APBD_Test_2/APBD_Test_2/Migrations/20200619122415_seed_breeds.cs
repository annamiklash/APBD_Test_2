using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_Test_2.Migrations
{
    public partial class seed_breeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "apbd_test_2",
                table: "BreedType",
                columns: new[] { "IdBreedType", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "hello description", "labrador" },
                    { 2, "good bye", "chichuachua" },
                    { 3, null, "samoyed" },
                    { 4, null, "puddle" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "BreedType",
                keyColumn: "IdBreedType",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "BreedType",
                keyColumn: "IdBreedType",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "BreedType",
                keyColumn: "IdBreedType",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "apbd_test_2",
                table: "BreedType",
                keyColumn: "IdBreedType",
                keyValue: 4);
        }
    }
}
