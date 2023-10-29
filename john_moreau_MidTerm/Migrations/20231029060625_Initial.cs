using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace john_moreau_MidTerm.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateAdded = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Code", "DateAdded", "Name", "Price", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "TRNY", "10/28/2023 at 11:06 PM", "Tournament Master 1.0", 4.99m, new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(7915) },
                    { 2, "LEAG10", "10/28/2023 at 11:06 PM", "League Scheduler 1.0", 4.99m, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(7915) },
                    { 3, "LEAGD10", "10/28/2023 at 11:06 PM", "League Scheduler Deluxe 1.0", 7.99m, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(7915) },
                    { 4, "PS5", "10/28/2023 at 11:06 PM", "Play Station 5", 699.99m, new DateTime(2023, 10, 28, 23, 6, 25, 63, DateTimeKind.Local).AddTicks(8439) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
