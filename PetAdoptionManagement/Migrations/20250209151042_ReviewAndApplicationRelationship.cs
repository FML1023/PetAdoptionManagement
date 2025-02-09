using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoptionManagement.Migrations
{
    /// <inheritdoc />
    public partial class ReviewAndApplicationRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApplicationId",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9192e230-c818-4204-b99c-c298eafcf3ed", "AQAAAAIAAYagAAAAEOha3d2bJIMvhSpxbyqRcWM/jqQo9WYmOa2kuoOIsxp42l+2NNhOVcdydD/nFoYEhg==", "ebd6ef89-90df-4ddb-91b7-a2013dca3f4c" });

            migrationBuilder.CreateIndex(
                name: "IX_Review_ApplicationId",
                table: "Review",
                column: "ApplicationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Application_ApplicationId",
                table: "Review",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Application_ApplicationId",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_ApplicationId",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "Review");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4eb38f0a-44dd-44cb-a679-8d8649e22482", "AQAAAAIAAYagAAAAEEGG3KHDyQvfo5oOn1TU9pTD2nY5wRTZKorH9JbO7nYF4GHjtdXDohGIYfDEhhn9yw==", "e6928844-661f-4a41-972a-e5ca6cf35a15" });
        }
    }
}
