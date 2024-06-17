using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class v8_UpdateDataTypePromotionCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
    name: "FK_Orders_Promotions_PromotionCode",
    table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "PromotionCode",
                table: "Promotions",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<string>(
                name: "PromotionCode",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Promotions_PromotionCode",
                table: "Orders",
                column: "PromotionCode",
                principalTable: "Promotions",
                principalColumn: "PromotionCode");

            // Inside Down method
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Promotions_PromotionCode",
                table: "Orders");

            migrationBuilder.AlterColumn<Guid>(
                name: "PromotionCode",
                table: "Promotions",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<Guid>(
                name: "PromotionCode",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Promotions_PromotionCode",
                table: "Orders",
                column: "PromotionCode",
                principalTable: "Promotions",
                principalColumn: "PromotionCode");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("612182a1-05ed-4f72-b5fc-0cc42997e484"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("81a5b8bd-2b8b-44e1-b59b-d85c4c5b9bd0"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Warranties",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Warranties",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "TypePrices",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDateTime",
                table: "Transactions",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpireAt",
                table: "RefreshTokens",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Promotions",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotions",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

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

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ValidTo",
                table: "CustomerPolicies",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ValidFrom",
                table: "CustomerPolicies",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ApprovedDate",
                table: "CustomerPolicies",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "CounterId", "Email", "EmployeeStatus", "Gender", "IsLogin", "ManagedBy", "Name", "Password", "Phone", "RoleId" },
                values: new object[,]
                {
                    { new Guid("12680f7f-3573-4a82-be26-7bfb542fea8b"), 2, "b@gmail.com", 0, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "Le Van B", "1", "0934425563", 2 },
                    { new Guid("84106da5-4663-4ca0-8861-398c7aa9efc8"), 1, "a@gmail.com", 1, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), "Nguyen Van A", "1", "0354410931", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
    name: "FK_Orders_Promotions_PromotionCode",
    table: "Orders");

            migrationBuilder.AlterColumn<Guid>(
                name: "PromotionCode",
                table: "Promotions",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<Guid>(
                name: "PromotionCode",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Promotions_PromotionCode",
                table: "Orders",
                column: "PromotionCode",
                principalTable: "Promotions",
                principalColumn: "PromotionCode");
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("12680f7f-3573-4a82-be26-7bfb542fea8b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("84106da5-4663-4ca0-8861-398c7aa9efc8"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Warranties",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Warranties",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "TypePrices",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDateTime",
                table: "Transactions",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpireAt",
                table: "RefreshTokens",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Promotions",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotions",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

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

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ValidTo",
                table: "CustomerPolicies",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ValidFrom",
                table: "CustomerPolicies",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ApprovedDate",
                table: "CustomerPolicies",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

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
