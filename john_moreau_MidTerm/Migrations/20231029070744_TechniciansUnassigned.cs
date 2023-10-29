using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace john_moreau_MidTerm.Migrations
{
    /// <inheritdoc />
    public partial class TechniciansUnassigned : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "DateAdded",
                value: "10/29/2023 at 12:07 AM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "DateAdded",
                value: "10/29/2023 at 12:07 AM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "DateAdded",
                value: "10/29/2023 at 12:07 AM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "DateAdded",
                value: "10/29/2023 at 12:07 AM");

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "Id", "DateAdded", "Email", "Name", "Phone" },
                values: new object[] { -1, "", "", "Not Assigned", "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Technicians",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "DateAdded",
                value: "10/28/2023 at 11:56 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "DateAdded",
                value: "10/28/2023 at 11:56 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "DateAdded",
                value: "10/28/2023 at 11:56 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "DateAdded",
                value: "10/28/2023 at 11:56 PM");
        }
    }
}
