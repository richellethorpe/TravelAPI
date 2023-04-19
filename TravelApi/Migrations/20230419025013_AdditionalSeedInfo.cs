using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    public partial class AdditionalSeedInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "Author",
                value: "Bobby B");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "Author",
                value: "Shelley G");

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Author", "DestinationId", "ReviewBody", "Title", "starRating" },
                values: new object[,]
                {
                    { 3, "Alex R", 2, "We done saw that pretty church", "Very nice and pretty", 4 },
                    { 4, "Jasmine L", 3, "Fun trip to see where game of thrones was filmed", "A+ for game of thrones fans", 5 },
                    { 5, "Tucker B", 2, "We loved the catherdral and city", "Great Food", 3 },
                    { 6, "Jenny C", 1, "The weather was scortching", "Too Hot", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "Author",
                value: "TestPerson 1");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "Author",
                value: "TestPerson 2");
        }
    }
}
