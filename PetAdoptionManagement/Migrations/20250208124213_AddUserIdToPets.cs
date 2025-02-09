using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoptionManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIdToPets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Pet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b581e9ef-c07c-4029-8cf8-7db1e29ccc3e", "AQAAAAIAAYagAAAAEO+HdI6mC64H3z2zOld3jCAtjK9IihDv9qxk6ES+UYp0bRrQb8wu6pyMvkhU+uuVIw==", "5feb9648-d187-442c-ae75-ab4f19eadb2d" });

            migrationBuilder.CreateIndex(
                name: "IX_Pet_UserId",
                table: "Pet",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_User_UserId",
                table: "Pet",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_User_UserId",
                table: "Pet");

            migrationBuilder.DropIndex(
                name: "IX_Pet_UserId",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Pet");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c20f0b2-3e62-4e33-885c-cec7b064a5b2", "AQAAAAIAAYagAAAAEIvDflp6igyWlIZ43SPes84oxQt1C4cP6s+yeEPlSH2SxmA78Lq5DWo1/6pdDJeMkg==", "99b12009-760e-4770-a465-c24afb0c82cf" });
        }
    }
}
