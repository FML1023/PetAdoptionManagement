using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoptionManagement.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Species = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    SpotlightId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spotlight",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    PetId = table.Column<int>(type: "int", nullable: false),
                    PetId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spotlight", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spotlight_Pet_PetId1",
                        column: x => x.PetId1,
                        principalTable: "Pet",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Adopter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LivingSituation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherPets = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PetExperience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewStatus = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adopter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adopter_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Applicant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewStatus = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applicant_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReviewStatus = table.Column<int>(type: "int", nullable: false),
                    PetID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    AdopterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Request_Adopter_AdopterId",
                        column: x => x.AdopterId,
                        principalTable: "Adopter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Request_Pet_PetID",
                        column: x => x.PetID,
                        principalTable: "Pet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Request_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ApplicantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Application_Applicant_ApplicantId",
                        column: x => x.ApplicantId,
                        principalTable: "Applicant",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adopter_UserId",
                table: "Adopter",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Applicant_UserId",
                table: "Applicant",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_ApplicantId",
                table: "Application",
                column: "ApplicantId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_AdopterId",
                table: "Request",
                column: "AdopterId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_PetID",
                table: "Request",
                column: "PetID");

            migrationBuilder.CreateIndex(
                name: "IX_Request_UserID",
                table: "Request",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Spotlight_PetId1",
                table: "Spotlight",
                column: "PetId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.DropTable(
                name: "Request");

            migrationBuilder.DropTable(
                name: "Spotlight");

            migrationBuilder.DropTable(
                name: "Applicant");

            migrationBuilder.DropTable(
                name: "Adopter");

            migrationBuilder.DropTable(
                name: "Pet");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
