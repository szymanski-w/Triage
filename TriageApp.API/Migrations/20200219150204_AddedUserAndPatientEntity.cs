using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TriageApp.API.Migrations
{
    public partial class AddedUserAndPatientEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RespRate = table.Column<int>(nullable: false),
                    PatientName = table.Column<string>(nullable: true),
                    IsWalking = table.Column<bool>(nullable: false),
                    IsBreathing = table.Column<bool>(nullable: false),
                    CapRecurrence = table.Column<bool>(nullable: false),
                    Consciousness = table.Column<bool>(nullable: false),
                    RescueOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
