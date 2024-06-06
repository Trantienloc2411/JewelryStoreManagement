using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class v601_UpdateEmployeeAndProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("3f6315cc-5119-4729-9299-98256904253d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("b58f72a5-d05c-4c6c-87cd-493ffcefd7f9"));

            migrationBuilder.AddColumn<double>(
                name: "StonePrice",
                table: "Products",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "WeightUnit",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "ManagedBy",
                table: "Employees",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "CounterId", "Email", "Gender", "IsLogin", "ManagedBy", "Name", "Password", "Phone", "RoleId", "Status" },
                values: new object[,]
                {
                    { new Guid("0f120e97-1b59-4c78-8e62-78991002d721"), 2, "b@gmail.com", 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "Le Van B", "1", "0934425563", 2, 0 },
                    { new Guid("bd9c2b62-51b0-4088-a038-f8a47e0f220f"), 1, "a@gmail.com", 0, false, new Guid("00000000-0000-0000-0000-000000000000"), "Nguyen Van A", "1", "0354410931", 1, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("0f120e97-1b59-4c78-8e62-78991002d721"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("bd9c2b62-51b0-4088-a038-f8a47e0f220f"));

            migrationBuilder.DropColumn(
                name: "StonePrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "WeightUnit",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ManagedBy",
                table: "Employees");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "CounterId", "Email", "Gender", "IsLogin", "Name", "Password", "Phone", "RoleId", "Status" },
                values: new object[,]
                {
                    { new Guid("3f6315cc-5119-4729-9299-98256904253d"), 2, "b@gmail.com", 1, false, "Le Van B", "1", "0934425563", 2, 0 },
                    { new Guid("b58f72a5-d05c-4c6c-87cd-493ffcefd7f9"), 1, "a@gmail.com", 0, false, "Nguyen Van A", "1", "0354410931", 1, 1 }
                });
        }
    }
}
