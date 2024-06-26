using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class v801_CustomerEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("271d0627-dccb-47c3-bba5-76b7fd83762c"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("6556d66d-71da-453c-83ea-ab2b2e31361b"));

            migrationBuilder.AlterColumn<string>(
                name: "PromotionCode",
                table: "Promotions",
                type: "text",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<string>(
                name: "PromotionCode",
                table: "Orders",
                type: "text",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Customers",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "CounterId", "Email", "EmployeeStatus", "Gender", "IsLogin", "ManagedBy", "Name", "Password", "Phone", "RoleId" },
                values: new object[,]
                {
                    { new Guid("7680ddda-865f-4a91-9d4f-5ce70d7e4b37"), 1, "a@gmail.com", 1, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), "Nguyen Van A", "1", "0354410931", 1 },
                    { new Guid("dfec2b28-2b40-42eb-8a51-0a74f8e257ad"), 2, "b@gmail.com", 0, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "Le Van B", "1", "0934425563", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("7680ddda-865f-4a91-9d4f-5ce70d7e4b37"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("dfec2b28-2b40-42eb-8a51-0a74f8e257ad"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Customers");

            migrationBuilder.AlterColumn<Guid>(
                name: "PromotionCode",
                table: "Promotions",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<Guid>(
                name: "PromotionCode",
                table: "Orders",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "CounterId", "Email", "EmployeeStatus", "Gender", "IsLogin", "ManagedBy", "Name", "Password", "Phone", "RoleId" },
                values: new object[,]
                {
                    { new Guid("271d0627-dccb-47c3-bba5-76b7fd83762c"), 1, "a@gmail.com", 1, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), "Nguyen Van A", "1", "0354410931", 1 },
                    { new Guid("6556d66d-71da-453c-83ea-ab2b2e31361b"), 2, "b@gmail.com", 0, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "Le Van B", "1", "0934425563", 2 }
                });
        }
    }
}
