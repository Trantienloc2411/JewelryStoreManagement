using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class UpdateDB_dataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("0783643c-8d76-49b0-9f40-ce8738a4c44e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("7e6b95b6-b5eb-4e43-8ff3-a15787f9d694"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("92f6cd27-f7ec-4788-804e-a26ffacc7179"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("bad1ec10-9fc0-4534-a8d4-df27bc460068"));

            migrationBuilder.UpdateData(
                table: "Counters",
                keyColumn: "CounterId",
                keyValue: 1,
                column: "CounterName",
                value: "Counter 01");

            migrationBuilder.UpdateData(
                table: "Counters",
                keyColumn: "CounterId",
                keyValue: 2,
                column: "CounterName",
                value: "Counter 02");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "CounterId", "Email", "EmployeeGender", "EmployeeStatus", "IsLogin", "ManagedBy", "Name", "Password", "Phone", "RoleId" },
                values: new object[,]
                {
                    { new Guid("17b420ed-870e-4d42-8c20-a04433f22861"), 2, "b@gmail.com", 1, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), "Le Van B", "$2a$11$Tr9OUgu.cRTTH.rb93o9QuTXxbJhLKu/KgCmxRgbU/4YT5BPQp/2W", "0934425563", 2 },
                    { new Guid("6db1c26d-675f-473a-9688-99cf3e1551e2"), 2, "sa@gmail.com", 0, 0, true, new Guid("00000000-0000-0000-0000-000000000000"), "Super Admin", "$2a$11$rvbF4Kctvp1VFftcz.cTf.iCV.Gjrw65RzPy4XsOmyx8.dea6KLN6", "0934425533", 4 },
                    { new Guid("f25db718-ef66-4ae7-b5a8-9cc70e5c7220"), 1, "a@gmail.com", 0, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "Nguyen Van A", "$2a$11$Tr9OUgu.cRTTH.rb93o9QuTXxbJhLKu/KgCmxRgbU/4YT5BPQp/2W", "0354410931", 1 },
                    { new Guid("f355d945-689e-4009-a612-f6f50b5a94e9"), 2, "admin@gmail.com", 1, 0, true, new Guid("00000000-0000-0000-0000-000000000000"), "Admin", "$2a$11$Tr9OUgu.cRTTH.rb93o9QuTXxbJhLKu/KgCmxRgbU/4YT5BPQp/2W", "0934425533", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("17b420ed-870e-4d42-8c20-a04433f22861"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("6db1c26d-675f-473a-9688-99cf3e1551e2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("f25db718-ef66-4ae7-b5a8-9cc70e5c7220"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("f355d945-689e-4009-a612-f6f50b5a94e9"));

            migrationBuilder.UpdateData(
                table: "Counters",
                keyColumn: "CounterId",
                keyValue: 1,
                column: "CounterName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Counters",
                keyColumn: "CounterId",
                keyValue: 2,
                column: "CounterName",
                value: null);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "CounterId", "Email", "EmployeeGender", "EmployeeStatus", "IsLogin", "ManagedBy", "Name", "Password", "Phone", "RoleId" },
                values: new object[,]
                {
                    { new Guid("0783643c-8d76-49b0-9f40-ce8738a4c44e"), 2, "b@gmail.com", 1, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), "Le Van B", "1", "0934425563", 2 },
                    { new Guid("7e6b95b6-b5eb-4e43-8ff3-a15787f9d694"), 1, "a@gmail.com", 0, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "Nguyen Van A", "1", "0354410931", 1 },
                    { new Guid("92f6cd27-f7ec-4788-804e-a26ffacc7179"), 2, "sa@gmail.com", 0, 0, true, new Guid("00000000-0000-0000-0000-000000000000"), "Super Admin", "sa@1", "0934425533", 4 },
                    { new Guid("bad1ec10-9fc0-4534-a8d4-df27bc460068"), 2, "admin@gmail.com", 1, 0, true, new Guid("00000000-0000-0000-0000-000000000000"), "Admin", "1", "0934425533", 3 }
                });
        }
    }
}
