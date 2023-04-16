using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    public partial class ReviewSeedInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Author", "DestinationId", "ReviewBody", "Title", "starRating" },
                values: new object[] { 1, "TestPerson 1", 1, "Blah blah blah", "Beautiful Temples", 4 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Author", "DestinationId", "ReviewBody", "Title", "starRating" },
                values: new object[] { 2, "TestPerson 2", 1, "Blah de blah de blah", "Big Crowds", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);
        }
    }
}
