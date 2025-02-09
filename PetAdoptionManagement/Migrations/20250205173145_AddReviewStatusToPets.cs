using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoptionManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddReviewStatusToPets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReviewStatus",
                table: "Pet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c20f0b2-3e62-4e33-885c-cec7b064a5b2", "AQAAAAIAAYagAAAAEIvDflp6igyWlIZ43SPes84oxQt1C4cP6s+yeEPlSH2SxmA78Lq5DWo1/6pdDJeMkg==", "99b12009-760e-4770-a465-c24afb0c82cf" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReviewStatus",
                table: "Pet");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b652cd09-9a85-4ea5-88e9-62430a780b58", "AQAAAAIAAYagAAAAEG0ENj61QpZIRklecRLxqI/xXx+vKbG8TjKdhOuH4xw3fABvRIrUxC/KXFpC8zDeRQ==", "2cc9c6c0-e0f7-472e-9ab6-59060160c035" });
        }
    }
}
