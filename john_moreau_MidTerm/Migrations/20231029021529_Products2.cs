using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace john_moreau_MidTerm.Migrations
{
    /// <inheritdoc />
    public partial class Products2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "DateAdded",
                value: "10/28/2023 at 7:15 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateAdded", "ReleaseDate" },
                values: new object[] { "10/28/2023 at 7:15 PM", new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateAdded", "Price", "ReleaseDate" },
                values: new object[] { "10/28/2023 at 7:15 PM", 7.99m, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "DateAdded",
                value: "10/28/2023 at 7:07 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateAdded", "ReleaseDate" },
                values: new object[] { "10/28/2023 at 7:07 PM", new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateAdded", "Price", "ReleaseDate" },
                values: new object[] { "10/28/2023 at 7:07 PM", 4.99m, new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
