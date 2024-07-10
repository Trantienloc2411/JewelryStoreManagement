using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Models
{
    public partial class V901_UpdateDb_AddNullFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Promotions_PromotionCode",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("8646475a-a1f8-4376-8ab2-f62e4570be5e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("8be7cbd0-dd4d-4e6a-80cc-0d22d7da9632"));

            migrationBuilder.AlterColumn<string>(
                name: "PromotionCode",
                table: "Orders",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<double>(
                name: "Discount",
                table: "Orders",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<int>(
                name: "AccumulatedPoint",
                table: "Orders",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "OrderId",
                table: "Orders",
                type: "character varying(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "OrderId",
                table: "OrderDetails",
                type: "character varying(32)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "OrderDetailStatus",
                table: "OrderDetails",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ApprovedDate",
                table: "CustomerPolicies",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedBy",
                table: "CustomerPolicies",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "OrderId",
                table: "BuyBacks",
                type: "character varying(32)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

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

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "PaymentId", "PaymentType" },
                values: new object[,]
                {
                    { 1, "Cash" },
                    { 2, "Mobile Banking" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Promotions_PromotionCode",
                table: "Orders",
                column: "PromotionCode",
                principalTable: "Promotions",
                principalColumn: "PromotionCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Promotions_PromotionCode",
                table: "Orders");

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

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "PaymentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "PaymentId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "OrderDetailStatus",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<string>(
                name: "PromotionCode",
                table: "Orders",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Discount",
                table: "Orders",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AccumulatedPoint",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OrderId",
                table: "Orders",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(32)",
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "OrderId",
                table: "OrderDetails",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(32)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ApprovedDate",
                table: "CustomerPolicies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedBy",
                table: "CustomerPolicies",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OrderId",
                table: "BuyBacks",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(32)");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "CounterId", "Email", "EmployeeGender", "EmployeeStatus", "IsLogin", "ManagedBy", "Name", "Password", "Phone", "RoleId" },
                values: new object[,]
                {
                    { new Guid("8646475a-a1f8-4376-8ab2-f62e4570be5e"), 1, "a@gmail.com", 0, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "Nguyen Van A", "1", "0354410931", 1 },
                    { new Guid("8be7cbd0-dd4d-4e6a-80cc-0d22d7da9632"), 2, "b@gmail.com", 1, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), "Le Van B", "1", "0934425563", 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Promotions_PromotionCode",
                table: "Orders",
                column: "PromotionCode",
                principalTable: "Promotions",
                principalColumn: "PromotionCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
