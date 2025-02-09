using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoptionManagement.Migrations
{
    /// <inheritdoc />
    public partial class ApplicationAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "399fdf67-ca52-4762-b639-e795203539e6", "AQAAAAIAAYagAAAAELsZGlFguOJpo3XhauOo2SxJLlZcvvFfRbByuH0DRwQK3k6vnfRwsRuazo4Hqz7gBw==", "4a75692b-5713-4542-a6f3-4b1a08ac73af" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbc3a18b-9f77-4e3e-83fd-0f43a3f1bafe", "AQAAAAIAAYagAAAAEMviUzjzmeR+OzK5vQ28uo2tYtxakyIwXt0iKz41POaSVGYzYZjYe7HNcVSUtYKzRQ==", "395e6b37-5b50-407d-ac92-ee05648461b1" });
        }
    }
}
