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
            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductId");

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
                column: "DateAdded",
                value: "10/28/2023 at 7:07 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "DateAdded",
                value: "10/28/2023 at 7:07 PM");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Contacts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "ProductId");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "DateAdded",
                value: "10/28/2023 at 6:50 PM");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "DateAdded",
                value: "10/28/2023 at 6:50 PM");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "DateAdded",
                value: "10/28/2023 at 6:50 PM");
        }
    }
}
