using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotPortfolio.Web.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    EmployDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreationDate", "EmployDate", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 24, 11, 5, 39, 416, DateTimeKind.Local).AddTicks(3935), new DateTime(2022, 11, 24, 11, 5, 39, 416, DateTimeKind.Local).AddTicks(3923), "Nomad", null },
                    { 2, new DateTime(2022, 11, 24, 11, 5, 39, 416, DateTimeKind.Local).AddTicks(3937), new DateTime(2022, 11, 24, 11, 5, 39, 416, DateTimeKind.Local).AddTicks(3936), "Nopal", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
