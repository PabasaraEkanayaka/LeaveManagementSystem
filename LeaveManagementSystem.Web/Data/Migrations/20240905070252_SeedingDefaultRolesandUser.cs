using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesandUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9d7e7a3-1e50-4011-83a1-c387d19d049e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff31891a-b8d1-4c47-a6cc-c27e4de4adf5");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "97c651d2-3015-4bf2-aa37-de2c72eccc86", "7853cbfa-e3dc-40a7-8966-53b7c494158a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97c651d2-3015-4bf2-aa37-de2c72eccc86");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7853cbfa-e3dc-40a7-8966-53b7c494158a");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "79411413-675d-40d4-93e5-afc5ea04fc06", null, "Administrator", "ADMINISTRATOR" },
                    { "a5526f97-f4e9-42b4-89b8-c11a2abeb837", null, "Employee", "EMPLOYEE" },
                    { "b3f56533-b26a-4235-be4c-eb8927457656", null, "Supervisor", "SUPERVISOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fa556c12-0e07-4f3a-8487-4d422c590802", 0, "28681d27-f7f1-4132-b119-c1f3eb5071f7", "admin@bitzify.com", true, false, null, "ADMIN@BITZIFY.COM", "ADMIN@BITZIFY.COM", "AQAAAAIAAYagAAAAEAaAtZPFbbn4XyxdO15nmP+Ulmg7oeBxUFrBskTX2YxpFLhVjejQgZjE7gPOJLVTEA==", null, false, "a7c28ce1-6d86-4d5d-be83-85d19c69a3f8", false, "admin@bitzify.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "79411413-675d-40d4-93e5-afc5ea04fc06", "fa556c12-0e07-4f3a-8487-4d422c590802" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5526f97-f4e9-42b4-89b8-c11a2abeb837");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3f56533-b26a-4235-be4c-eb8927457656");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "79411413-675d-40d4-93e5-afc5ea04fc06", "fa556c12-0e07-4f3a-8487-4d422c590802" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79411413-675d-40d4-93e5-afc5ea04fc06");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa556c12-0e07-4f3a-8487-4d422c590802");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "97c651d2-3015-4bf2-aa37-de2c72eccc86", null, "Administrator", "ADMINISTRATOR" },
                    { "e9d7e7a3-1e50-4011-83a1-c387d19d049e", null, "Supervisor", "SUPERVISOR" },
                    { "ff31891a-b8d1-4c47-a6cc-c27e4de4adf5", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7853cbfa-e3dc-40a7-8966-53b7c494158a", 0, "860a1848-152d-41b8-b8e8-fbf67f7af4ad", new DateOnly(1994, 11, 19), "admin@bitzify.com", true, "Default", "Admin", false, null, "ADMIN@BITZIFY.COM", "ADMIN@BITZIFY.COM", "AQAAAAIAAYagAAAAEEHTDZ0J+xKzlHLyzx482QZOaugyX9ko+esszOuMgXfrlR1erkKiNZ8EYr1kSZKxOA==", null, false, "37721bcb-1281-4543-aaea-1ac1361b8b79", false, "admin@bitzify.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "97c651d2-3015-4bf2-aa37-de2c72eccc86", "7853cbfa-e3dc-40a7-8966-53b7c494158a" });
        }
    }
}
