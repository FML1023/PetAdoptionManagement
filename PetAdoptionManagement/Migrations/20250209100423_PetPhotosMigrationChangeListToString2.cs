using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoptionManagement.Migrations
{
    /// <inheritdoc />
    public partial class PetPhotosMigrationChangeListToString2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_AspNetUsers_UserId",
                table: "Pet");

            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "Pet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fa527dd-c54d-4b3d-b782-fd309bbbef69", "AQAAAAIAAYagAAAAEJT+y7EeFo2a5128ZbTjYx3Z7MlhC1/xW0Ftb2GrUJdz1iRTMjEZDyeC9hjNxH+B4A==", "76df1067-4a34-4e74-81b8-639c1b02fd3b" });

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_AspNetUsers_UserId",
                table: "Pet",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_AspNetUsers_UserId",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "Pet");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd9afc5e-7751-4fc8-9e68-fb5f979ba94c", "AQAAAAIAAYagAAAAEACpAaMHbs+6ZfwXQb49ioEbp87ieuYa7HEPNnmcqkPDZZKvAMF/A5Z5t0soG5gDGg==", "5c857586-dc8b-4159-b0c9-57f887264d2f" });

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_AspNetUsers_UserId",
                table: "Pet",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
