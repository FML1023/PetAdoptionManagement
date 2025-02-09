using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoptionManagement.Migrations
{
    /// <inheritdoc />
    public partial class ReaddingMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReviewStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PetID = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReasonForAdoption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LivingSituation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherPets = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PetExperience = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Application_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Application_Pet_PetID",
                        column: x => x.PetID,
                        principalTable: "Pet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f856507-071a-4be3-b4fe-ad254ed1ee6d", "AQAAAAIAAYagAAAAEARVSe4+ptG9YSUz1t5FpgpIsZhvo5rG+wgOUEoEXh4tfmhLYsyR+o9k7lVIdi1lAA==", "81a052fd-5c44-4f93-8abf-21a2a7bc53c8" });

            migrationBuilder.CreateIndex(
                name: "IX_Application_PetID",
                table: "Application",
                column: "PetID");

            migrationBuilder.CreateIndex(
                name: "IX_Application_UserId",
                table: "Application",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7206c429-3244-487e-9681-5126f7bc229c", "AQAAAAIAAYagAAAAEOmRgt8aTXUarlZm/PRqL6L43rx6JhVOHtxr+CHoba3KivrfO3aZyiEXRLBYPiJkSw==", "218e1c7e-4df7-406b-8859-559294840195" });
        }
    }
}
