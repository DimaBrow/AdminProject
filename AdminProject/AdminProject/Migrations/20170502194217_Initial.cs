using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    AdminLevel = table.Column<int>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    AdminId = table.Column<int>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    FlatNumber = table.Column<string>(nullable: false),
                    HouseNumber = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    Password = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Street = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserTasks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    AdminId = table.Column<int>(nullable: true),
                    Category = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTasks_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserTasks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_AdminId",
                table: "Users",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTasks_AdminId",
                table: "UserTasks",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTasks_UserId",
                table: "UserTasks",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserTasks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Admins");
        }
    }
}
