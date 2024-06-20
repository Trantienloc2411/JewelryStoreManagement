using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class v8_PromotionStatuses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("612182a1-05ed-4f72-b5fc-0cc42997e484"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("81a5b8bd-2b8b-44e1-b59b-d85c4c5b9bd0"));

            migrationBuilder.AddColumn<int>(
                name: "PromotionStatus",
                table: "Promotions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "CounterId", "Email", "EmployeeStatus", "Gender", "IsLogin", "ManagedBy", "Name", "Password", "Phone", "RoleId" },
                values: new object[,]
                {
                    { new Guid("271d0627-dccb-47c3-bba5-76b7fd83762c"), 1, "a@gmail.com", 1, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), "Nguyen Van A", "1", "0354410931", 1 },
                    { new Guid("6556d66d-71da-453c-83ea-ab2b2e31361b"), 2, "b@gmail.com", 0, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "Le Van B", "1", "0934425563", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("271d0627-dccb-47c3-bba5-76b7fd83762c"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("6556d66d-71da-453c-83ea-ab2b2e31361b"));

            migrationBuilder.DropColumn(
                name: "PromotionStatus",
                table: "Promotions");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "CounterId", "Email", "EmployeeStatus", "Gender", "IsLogin", "ManagedBy", "Name", "Password", "Phone", "RoleId" },
                values: new object[,]
                {
                    { new Guid("612182a1-05ed-4f72-b5fc-0cc42997e484"), 1, "a@gmail.com", 1, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), "Nguyen Van A", "1", "0354410931", 1 },
                    { new Guid("81a5b8bd-2b8b-44e1-b59b-d85c4c5b9bd0"), 2, "b@gmail.com", 0, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "Le Van B", "1", "0934425563", 2 }
                });
        }
    }
}
