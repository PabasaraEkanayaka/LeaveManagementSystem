using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa556c12-0e07-4f3a-8487-4d422c590802",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79e3b01b-0fde-4d68-b1a0-fd2e8f27a492", new DateOnly(1998, 4, 20), "Default", "Admin", "AQAAAAIAAYagAAAAECm0dYIi1PlTuxHpcw8FJVgg7NBwvNXHQDRji47JcGoNqGqQrjNh6yvx/aHYnnGjpg==", "f30eba1c-4cf7-48ac-bce3-e517093c9704" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa556c12-0e07-4f3a-8487-4d422c590802",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28681d27-f7f1-4132-b119-c1f3eb5071f7", "AQAAAAIAAYagAAAAEAaAtZPFbbn4XyxdO15nmP+Ulmg7oeBxUFrBskTX2YxpFLhVjejQgZjE7gPOJLVTEA==", "a7c28ce1-6d86-4d5d-be83-85d19c69a3f8" });
        }
    }
}
