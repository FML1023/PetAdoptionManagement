using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoptionManagement.Migrations
{
    /// <inheritdoc />
    public partial class PetPhotosMigrationChangeListToString1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_AspNetUsers_UserId",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "Photos",
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
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_AspNetUsers_UserId",
                table: "Pet");

            migrationBuilder.AddColumn<string>(
                name: "Photos",
                table: "Pet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f856507-071a-4be3-b4fe-ad254ed1ee6d", "AQAAAAIAAYagAAAAEARVSe4+ptG9YSUz1t5FpgpIsZhvo5rG+wgOUEoEXh4tfmhLYsyR+o9k7lVIdi1lAA==", "81a052fd-5c44-4f93-8abf-21a2a7bc53c8" });

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_AspNetUsers_UserId",
                table: "Pet",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
