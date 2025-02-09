using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoptionManagement.Migrations
{
    /// <inheritdoc />
    public partial class SpotlightClassUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spotlight_Pet_PetId1",
                table: "Spotlight");

            migrationBuilder.DropIndex(
                name: "IX_Spotlight_PetId1",
                table: "Spotlight");

            migrationBuilder.DropColumn(
                name: "PetId1",
                table: "Spotlight");

            migrationBuilder.DropColumn(
                name: "SpotlightId",
                table: "Pet");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9831756a-bfd6-4712-ae47-201a7441f447", "AQAAAAIAAYagAAAAENZLDtQoaYXQ2rUPwrPY3iXfV7J2Twahp0KAwWGLJw41EoRZI27DMp7R0bHOMxDvvw==", "465b2346-8bfa-4ddf-8c5b-829acee659c0" });

            migrationBuilder.CreateIndex(
                name: "IX_Spotlight_PetId",
                table: "Spotlight",
                column: "PetId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Spotlight_Pet_PetId",
                table: "Spotlight",
                column: "PetId",
                principalTable: "Pet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spotlight_Pet_PetId",
                table: "Spotlight");

            migrationBuilder.DropIndex(
                name: "IX_Spotlight_PetId",
                table: "Spotlight");

            migrationBuilder.AddColumn<int>(
                name: "PetId1",
                table: "Spotlight",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpotlightId",
                table: "Pet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fa527dd-c54d-4b3d-b782-fd309bbbef69", "AQAAAAIAAYagAAAAEJT+y7EeFo2a5128ZbTjYx3Z7MlhC1/xW0Ftb2GrUJdz1iRTMjEZDyeC9hjNxH+B4A==", "76df1067-4a34-4e74-81b8-639c1b02fd3b" });

            migrationBuilder.CreateIndex(
                name: "IX_Spotlight_PetId1",
                table: "Spotlight",
                column: "PetId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Spotlight_Pet_PetId1",
                table: "Spotlight",
                column: "PetId1",
                principalTable: "Pet",
                principalColumn: "Id");
        }
    }
}
