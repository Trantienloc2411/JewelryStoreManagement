using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class v9_ChangeGender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("7680ddda-865f-4a91-9d4f-5ce70d7e4b37"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("dfec2b28-2b40-42eb-8a51-0a74f8e257ad"));

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Employees",
                newName: "EmployeeGender");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Customers",
                newName: "CustomerGender");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "CounterId", "Email", "EmployeeGender", "EmployeeStatus", "IsLogin", "ManagedBy", "Name", "Password", "Phone", "RoleId" },
                values: new object[,]
                {
                    { new Guid("8646475a-a1f8-4376-8ab2-f62e4570be5e"), 1, "a@gmail.com", 0, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "Nguyen Van A", "1", "0354410931", 1 },
                    { new Guid("8be7cbd0-dd4d-4e6a-80cc-0d22d7da9632"), 2, "b@gmail.com", 1, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), "Le Van B", "1", "0934425563", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("8646475a-a1f8-4376-8ab2-f62e4570be5e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("8be7cbd0-dd4d-4e6a-80cc-0d22d7da9632"));

            migrationBuilder.RenameColumn(
                name: "EmployeeGender",
                table: "Employees",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "CustomerGender",
                table: "Customers",
                newName: "Gender");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "CounterId", "Email", "EmployeeStatus", "Gender", "IsLogin", "ManagedBy", "Name", "Password", "Phone", "RoleId" },
                values: new object[,]
                {
                    { new Guid("7680ddda-865f-4a91-9d4f-5ce70d7e4b37"), 1, "a@gmail.com", 1, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), "Nguyen Van A", "1", "0354410931", 1 },
                    { new Guid("dfec2b28-2b40-42eb-8a51-0a74f8e257ad"), 2, "b@gmail.com", 0, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "Le Van B", "1", "0934425563", 2 }
                });
        }
    }
}
