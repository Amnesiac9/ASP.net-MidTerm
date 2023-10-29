using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace john_moreau_MidTerm.Migrations
{
    /// <inheritdoc />
    public partial class Products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "DateAdded", "ReleaseDate" },
                values: new object[] { "10/28/2023 at 11:19 PM", new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateAdded", "ReleaseDate" },
                values: new object[] { "10/28/2023 at 11:19 PM", new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateAdded", "ReleaseDate" },
                values: new object[] { "10/28/2023 at 11:19 PM", new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "DateAdded", "ReleaseDate" },
                values: new object[] { "10/28/2023 at 11:19 PM", new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "DateAdded", "ReleaseDate" },
                values: new object[] { "10/28/2023 at 11:17 PM", new DateTime(2018, 12, 1, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateAdded", "ReleaseDate" },
                values: new object[] { "10/28/2023 at 11:17 PM", new DateTime(2019, 5, 1, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateAdded", "ReleaseDate" },
                values: new object[] { "10/28/2023 at 11:17 PM", new DateTime(2019, 8, 1, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "DateAdded", "ReleaseDate" },
                values: new object[] { "10/28/2023 at 11:17 PM", new DateTime(2020, 11, 12, 12, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
