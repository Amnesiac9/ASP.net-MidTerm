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
                name: "Contacts",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateAdded = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ProductId", "Code", "DateAdded", "Name", "Price", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "TRNY", "10/28/2023 at 6:50 PM", "Tournament Master 1.0", 4.99m, new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "LEAG10", "10/28/2023 at 6:50 PM", "League Scheduler 1.0", 4.99m, new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "LEAGD10", "10/28/2023 at 6:50 PM", "League Scheduler Deluxe 1.0", 4.99m, new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
