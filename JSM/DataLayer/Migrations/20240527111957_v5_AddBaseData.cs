using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class v5_AddBaseData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Counters",
                columns: new[] { "CounterId", "Location" },
                values: new object[,]
                {
                    { 1, "Counter 01" },
                    { 2, "Counter 02" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { 1, "Staff" },
                    { 2, "Manager" },
                    { 3, "Administrator" },
                    { 4, "Super Admin" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "CounterId", "Email", "Gender", "Name", "Password", "Phone", "RoleId", "Status", "isLogin" },
                values: new object[,]
                {
                    { new Guid("40759c62-5edd-4d65-935a-b4beb3f2c8c7"), 2, "b@gmail.com", 1, "Le Van B", "1", "0934425563", 2, 0, false },
                    { new Guid("5495d287-32b4-41f9-9d08-36449fd47a8a"), 1, "a@gmail.com", 0, "Nguyen Van A", "1", "0354410931", 1, 1, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("40759c62-5edd-4d65-935a-b4beb3f2c8c7"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("5495d287-32b4-41f9-9d08-36449fd47a8a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Counters",
                keyColumn: "CounterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Counters",
                keyColumn: "CounterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2);
        }
    }
}
