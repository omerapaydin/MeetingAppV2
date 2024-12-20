using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MeetingApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "Id", "Description", "Location", "Name", "Time" },
                values: new object[,]
                {
                    { 1, "Technology conference in 2024", "New York", "Tech Conference", "10:00 AM" },
                    { 2, "Initial project meeting", "London", "Project Kickoff", "2:00 PM" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "IsOkey", "Name", "Phone", "Surname" },
                values: new object[,]
                {
                    { 1, "30", true, "John", "123456789", "Doe" },
                    { 2, "25", false, "Jane", "987654321", "Smith" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
