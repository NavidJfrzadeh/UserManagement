using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Infra.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10, 1"),
                    FullName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CreatedAt", "Email", "PasswordHash", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "navid@gmail.com", "ni2bSgiYmXE0/D7OTfP1g+IqrXZGKndFxnwxm4MFpqE=", "navid" },
                    { 2, new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin", "FYneDHnPc6gxbktrCumaF21Fn9iVrtuTg6+/74QWjtQ=", "admin" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FullName" },
                values: new object[,]
                {
                    { 10, new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "hasan@gmail.com", "hasan" },
                    { 11, new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "amir@gmail.com", "amir" },
                    { 12, new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali@gmail.com", "ali" },
                    { 13, new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "parsa@gmail.com", "parsa" },
                    { 14, new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "babak@gmail.com", "babak" },
                    { 15, new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "sara@gmail.com", "sara" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
