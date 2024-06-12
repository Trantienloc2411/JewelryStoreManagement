using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class v602_RenameStatusesOfEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("0f120e97-1b59-4c78-8e62-78991002d721"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("bd9c2b62-51b0-4088-a038-f8a47e0f220f"));

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Products",
                newName: "ProductStatus");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Employees",
                newName: "EmployeeStatus");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "CounterId", "Email", "EmployeeStatus", "Gender", "IsLogin", "ManagedBy", "Name", "Password", "Phone", "RoleId" },
                values: new object[,]
                {
                    { new Guid("b2757c7d-88de-4998-8fa3-42a75ed97ff1"), 1, "a@gmail.com", 1, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), "Nguyen Van A", "1", "0354410931", 1 },
                    { new Guid("c56febd5-e304-4ec8-b954-01ab9489d592"), 2, "b@gmail.com", 0, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "Le Van B", "1", "0934425563", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("b2757c7d-88de-4998-8fa3-42a75ed97ff1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("c56febd5-e304-4ec8-b954-01ab9489d592"));

            migrationBuilder.RenameColumn(
                name: "ProductStatus",
                table: "Products",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "EmployeeStatus",
                table: "Employees",
                newName: "Status");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "CounterId", "Email", "Gender", "IsLogin", "ManagedBy", "Name", "Password", "Phone", "RoleId", "Status" },
                values: new object[,]
                {
                    { new Guid("0f120e97-1b59-4c78-8e62-78991002d721"), 2, "b@gmail.com", 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "Le Van B", "1", "0934425563", 2, 0 },
                    { new Guid("bd9c2b62-51b0-4088-a038-f8a47e0f220f"), 1, "a@gmail.com", 0, false, new Guid("00000000-0000-0000-0000-000000000000"), "Nguyen Van A", "1", "0354410931", 1, 1 }
                });
        }
    }
}
