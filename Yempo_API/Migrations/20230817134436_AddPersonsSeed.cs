using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yempo_API.Migrations
{
    public partial class AddPersonsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Age", "Firstname", "Lastname" },
                values: new object[] { 1, 38, "John", "Doe" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Age", "Firstname", "Lastname" },
                values: new object[] { 2, 24, "Jenny", "Doe" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Age", "Firstname", "Lastname" },
                values: new object[] { 3, 22, "Mark", "Smith" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
