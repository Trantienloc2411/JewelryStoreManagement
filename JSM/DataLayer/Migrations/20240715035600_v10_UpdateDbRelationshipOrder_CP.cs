using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class v10_UpdateDbRelationshipOrder_CP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "CPId",
                table: "Orders",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PolicyStatus",
                table: "CustomerPolicies",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "AccumulatedPoint", "Address", "CustomerGender", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { new Guid("013547f4-1a5e-4faf-a7f0-65b5ce4747c5"), 3000, "Xã Hồng Thủy, Huyện Lệ Thủy, Quảng Bình", 0, "lamAnh@hotmail.com", "anh Lâm", "0820256734" },
                    { new Guid("3d27847c-5aaf-4697-9ce3-0f7ee58428b0"), 0, "Phường Cửa Nam, Quận Hoàn Kiếm, Hà Nội", 0, "ducpham@yahoo.com", "Phạm Văn Đức", "0909876543" },
                    { new Guid("9f5d0345-0266-4213-8544-3a8b062dd65f"), 0, "Phường Tân Phú, Quận 7, Thành phố Hồ Chí Minh", 1, "hoanguyen@outlook.com", "Nguyễn Thị Hoa", "0987654321" },
                    { new Guid("f776ed8d-5c50-4e4f-be3c-b9633f7532bf"), 2500, "Phường Cầu Diễn, Quận Nam Từ Liêm, Hà Nội", 1, "minhTran@gmail.com", "Trần Minh", "0912345678" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "CounterId", "Email", "EmployeeGender", "EmployeeStatus", "IsLogin", "ManagedBy", "Name", "Password", "Phone", "RoleId" },
                values: new object[,]
                {
                    { new Guid("31023a3a-96a4-4803-ac2b-5b4cebadc3ca"), 1, "a@gmail.com", 0, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "Nguyen Van A", "$2a$11$Tr9OUgu.cRTTH.rb93o9QuTXxbJhLKu/KgCmxRgbU/4YT5BPQp/2W", "0354410931", 1 },
                    { new Guid("5b1293f4-54a1-4580-826e-f48106600d88"), 2, "admin@gmail.com", 1, 0, true, new Guid("00000000-0000-0000-0000-000000000000"), "Admin", "$2a$11$Tr9OUgu.cRTTH.rb93o9QuTXxbJhLKu/KgCmxRgbU/4YT5BPQp/2W", "0934425533", 3 },
                    { new Guid("e8cc4ead-e3ea-49c3-92dc-4a704e7c5547"), 2, "b@gmail.com", 1, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), "Le Van B", "$2a$11$Tr9OUgu.cRTTH.rb93o9QuTXxbJhLKu/KgCmxRgbU/4YT5BPQp/2W", "0934425563", 2 },
                    { new Guid("f758d1e1-37a6-415f-bb1d-36181ab71fc3"), 2, "sa@gmail.com", 0, 0, true, new Guid("00000000-0000-0000-0000-000000000000"), "Super Admin", "$2a$11$rvbF4Kctvp1VFftcz.cTf.iCV.Gjrw65RzPy4XsOmyx8.dea6KLN6", "0934425533", 4 }
                });

            migrationBuilder.InsertData(
                table: "Gifts",
                columns: new[] { "GiftId", "GiftName", "PointRequired" },
                values: new object[,]
                {
                    { new Guid("11d623d3-97ed-4e9b-ba91-d9115358ef8e"), "Lịch vạn niên 2025", 6000 },
                    { new Guid("44251df8-dc2b-46b4-bfd6-1b20b66e1203"), "Bộ bàn ghế gỗ", 14000 },
                    { new Guid("d4c78d1d-f2b6-467f-b00d-cd4ac7eb406c"), "Áo mưa", 3500 }
                });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "PromotionCode", "Description", "DiscountPercentage", "EndDate", "FixedDiscountAmount", "PromotionStatus", "StartDate" },
                values: new object[,]
                {
                    { "Promotion 01", "This is the promtion super hot", 10.0, new DateTime(2024, 7, 25, 3, 55, 59, 400, DateTimeKind.Utc).AddTicks(6610), null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "Promotion 02", "This is the promtion super hot", 10.0, new DateTime(2024, 7, 5, 3, 55, 59, 400, DateTimeKind.Utc).AddTicks(6630), null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "Promotion 03", "This is the promtion super hot", 10.0, new DateTime(2024, 7, 5, 3, 55, 59, 400, DateTimeKind.Utc).AddTicks(6640), null, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TypePrices",
                columns: new[] { "TypeId", "BuyPricePerGram", "DateUpdated", "SellPricePerGram", "TypeName" },
                values: new object[,]
                {
                    { 1, 500000.0, new DateTime(2024, 7, 15, 3, 55, 59, 400, DateTimeKind.Utc).AddTicks(4580), 750000.0, "Gold" },
                    { 2, 5000000.0, new DateTime(2024, 7, 15, 3, 55, 59, 400, DateTimeKind.Utc).AddTicks(4600), 7500000.0, "Diamond" },
                    { 3, 2000000.0, new DateTime(2024, 7, 15, 3, 55, 59, 400, DateTimeKind.Utc).AddTicks(4610), 3000000.0, "Jewel" },
                    { 4, 0.0, new DateTime(2024, 7, 15, 3, 55, 59, 400, DateTimeKind.Utc).AddTicks(4620), 0.0, "Vàng SJC 1 chỉ" },
                    { 5, 0.0, new DateTime(2024, 7, 15, 3, 55, 59, 400, DateTimeKind.Utc).AddTicks(4630), 0.0, "Vàng SJC 1 lượng" },
                    { 6, 0.0, new DateTime(2024, 7, 15, 3, 55, 59, 400, DateTimeKind.Utc).AddTicks(4640), 0.0, "Nhẫn 1 chỉ SJC" },
                    { 7, 0.0, new DateTime(2024, 7, 15, 3, 55, 59, 400, DateTimeKind.Utc).AddTicks(4650), 0.0, "Trang sức 49 SJC" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Barcode", "CertificateUrl", "CounterId", "Description", "Img", "ManufactureCost", "MarkupRate", "Name", "Price", "ProductStatus", "Quantity", "StonePrice", "TypeId", "Weight", "WeightUnit" },
                values: new object[,]
                {
                    { new Guid("000cbf32-abea-44db-be3d-2155c06d59d6"), "GOLD0027", null, 1, "Gold product description 27", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 1027000.0, 0.5, "Gold Product 27", 1527000.0, 0, 37, 885000.0, 1, 77.0, 0 },
                    { new Guid("000eabfb-a482-4740-ad3f-03b1b9b02cc3"), "GOLD0013", null, 1, "Gold product description 13", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F14.jpg?alt=media&token=f9685ad2-52ff-4c5b-b27d-af7e82831126", 1013000.0, 0.5, "Gold Product 13", 1513000.0, 0, 23, 815000.0, 1, 63.0, 0 },
                    { new Guid("0537a665-f951-41f8-a37c-2c0fab1d9085"), "DIAMOND002", null, 1, "Diamond product description 2", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F3.jpg?alt=media&token=f255817b-bc8f-405c-91f8-a5c733b20a16", 5010000.0, 0.59999999999999998, "Diamond Product 2", 7510000.0, 0, 7, 15010000.0, 2, 12.0, 0 },
                    { new Guid("0ac7c3f9-34ba-4a0e-89e1-31975752e523"), "DIAMOND0015", null, 1, "Diamond product description 15", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F1.jpg?alt=media&token=edd76054-7ffd-4726-9f57-3a5abe125c10", 5075000.0, 0.59999999999999998, "Diamond Product 15", 7575000.0, 0, 20, 15075000.0, 2, 25.0, 0 },
                    { new Guid("0d4f7d2b-2b33-4467-966a-a68c135ca205"), "DIAMOND0030", null, 1, "Diamond product description 30", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F1.jpg?alt=media&token=edd76054-7ffd-4726-9f57-3a5abe125c10", 5150000.0, 0.59999999999999998, "Diamond Product 30", 7650000.0, 0, 35, 15150000.0, 2, 40.0, 0 },
                    { new Guid("0d8a81a5-86ad-4cb9-855f-856d14d72809"), "JEWEL0022", null, 1, "Jewel product description 22", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F8.jpg?alt=media&token=bbe17db6-2209-42ad-86dd-ee2422be3d56", 2044000.0, 0.55000000000000004, "Jewel Product 22", 3044000.0, 0, 37, 5044000.0, 3, 42.0, 0 },
                    { new Guid("105ebc10-5186-46c9-88e7-b3d4010df604"), "GOLD009", null, 1, "Gold product description 9", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F10.jpg?alt=media&token=55a92de8-ee5c-42c9-9abe-878a240dd0f1", 1009000.0, 0.5, "Gold Product 9", 1509000.0, 0, 19, 795000.0, 1, 59.0, 0 },
                    { new Guid("1071e6d6-7868-4022-be3b-c779c4b293c1"), "DIAMOND007", null, 1, "Diamond product description 7", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F8.jpg?alt=media&token=bbe17db6-2209-42ad-86dd-ee2422be3d56", 5035000.0, 0.59999999999999998, "Diamond Product 7", 7535000.0, 0, 12, 15035000.0, 2, 17.0, 0 },
                    { new Guid("108ec182-5999-496e-969c-63c3b6d66f77"), "GOLD0022", null, 1, "Gold product description 22", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F8.jpg?alt=media&token=bbe17db6-2209-42ad-86dd-ee2422be3d56", 1022000.0, 0.5, "Gold Product 22", 1522000.0, 0, 32, 860000.0, 1, 72.0, 0 },
                    { new Guid("1c3c4b22-bd06-40c0-9f68-05f19d1688f0"), "JEWEL0026", null, 1, "Jewel product description 26", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 2052000.0, 0.55000000000000004, "Jewel Product 26", 3052000.0, 0, 41, 5052000.0, 3, 46.0, 0 },
                    { new Guid("1db26988-7562-4a2f-a94e-98877d1d1ae9"), "GOLD006", null, 1, "Gold product description 6", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F7.jpg?alt=media&token=5b91fa57-76a5-4911-820b-86f9b11ebbf9", 1006000.0, 0.5, "Gold Product 6", 1506000.0, 0, 16, 780000.0, 1, 56.0, 0 },
                    { new Guid("1ea13acf-3b9d-42c6-ba60-3aba19f7c45d"), "DIAMOND001", null, 1, "Diamond product description 1", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F2.jpg?alt=media&token=54f08c6f-e41e-4cde-b6c6-1e40194320a5", 5005000.0, 0.59999999999999998, "Diamond Product 1", 7505000.0, 0, 6, 15005000.0, 2, 11.0, 0 },
                    { new Guid("22060e2a-82b6-498b-b2c3-e3b263d812a6"), "DIAMOND0027", null, 1, "Diamond product description 27", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 5135000.0, 0.59999999999999998, "Diamond Product 27", 7635000.0, 0, 32, 15135000.0, 2, 37.0, 0 },
                    { new Guid("22c95a5a-e4a2-4526-bb12-7c24c7e4c754"), "GOLD0024", null, 1, "Gold product description 24", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F10.jpg?alt=media&token=55a92de8-ee5c-42c9-9abe-878a240dd0f1", 1024000.0, 0.5, "Gold Product 24", 1524000.0, 0, 34, 870000.0, 1, 74.0, 0 },
                    { new Guid("24e380a4-8263-4d60-8a08-d975cacaa3cc"), "DIAMOND0020", null, 1, "Diamond product description 20", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2FDayChuyenBac.jpg?alt=media&token=4badf84f-4a3c-489a-bf3b-59bd3517dd8a", 5100000.0, 0.59999999999999998, "Diamond Product 20", 7600000.0, 0, 25, 15100000.0, 2, 30.0, 0 },
                    { new Guid("2c08588b-25a0-453b-a329-27533035e8cd"), "JEWEL001", null, 1, "Jewel product description 1", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F2.jpg?alt=media&token=54f08c6f-e41e-4cde-b6c6-1e40194320a5", 2002000.0, 0.55000000000000004, "Jewel Product 1", 3002000.0, 0, 16, 5002000.0, 3, 21.0, 0 },
                    { new Guid("3791978f-8952-44b5-864f-99e0325023ae"), "JEWEL0030", null, 1, "Jewel product description 30", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F1.jpg?alt=media&token=edd76054-7ffd-4726-9f57-3a5abe125c10", 2060000.0, 0.55000000000000004, "Jewel Product 30", 3060000.0, 0, 45, 5060000.0, 3, 50.0, 0 },
                    { new Guid("37e3469a-838e-419b-8ec1-b7a74f3cb756"), "JEWEL0020", null, 1, "Jewel product description 20", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2FDayChuyenBac.jpg?alt=media&token=4badf84f-4a3c-489a-bf3b-59bd3517dd8a", 2040000.0, 0.55000000000000004, "Jewel Product 20", 3040000.0, 0, 35, 5040000.0, 3, 40.0, 0 },
                    { new Guid("38bffdfa-ed10-4597-86ab-3ed2cc5abe31"), "JEWEL007", null, 1, "Jewel product description 7", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F8.jpg?alt=media&token=bbe17db6-2209-42ad-86dd-ee2422be3d56", 2014000.0, 0.55000000000000004, "Jewel Product 7", 3014000.0, 0, 22, 5014000.0, 3, 27.0, 0 },
                    { new Guid("3c1d70e7-ed24-4af3-97ab-072f925a67d1"), "GOLD0026", null, 1, "Gold product description 26", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 1026000.0, 0.5, "Gold Product 26", 1526000.0, 0, 36, 880000.0, 1, 76.0, 0 },
                    { new Guid("3d199a3f-8880-43ac-a76c-b3d25dfc2314"), "JEWEL002", null, 1, "Jewel product description 2", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F3.jpg?alt=media&token=f255817b-bc8f-405c-91f8-a5c733b20a16", 2004000.0, 0.55000000000000004, "Jewel Product 2", 3004000.0, 0, 17, 5004000.0, 3, 22.0, 0 },
                    { new Guid("3fc57e43-1697-4efc-8d58-7bdd3114267c"), "GOLD002", null, 1, "Gold product description 2", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F3.jpg?alt=media&token=f255817b-bc8f-405c-91f8-a5c733b20a16", 1002000.0, 0.5, "Gold Product 2", 1502000.0, 0, 12, 760000.0, 1, 52.0, 0 },
                    { new Guid("3fecb191-4301-46a3-a485-6c90881c6045"), "JEWEL0010", null, 1, "Jewel product description 10", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F11.jpg?alt=media&token=7afc835a-dc04-491f-a922-14f97c05ad47", 2020000.0, 0.55000000000000004, "Jewel Product 10", 3020000.0, 0, 25, 5020000.0, 3, 30.0, 0 },
                    { new Guid("40a8fd37-cd81-4a46-b4dc-9cfb9f90b099"), "JEWEL0024", null, 1, "Jewel product description 24", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F10.jpg?alt=media&token=55a92de8-ee5c-42c9-9abe-878a240dd0f1", 2048000.0, 0.55000000000000004, "Jewel Product 24", 3048000.0, 0, 39, 5048000.0, 3, 44.0, 0 },
                    { new Guid("458cd034-e599-483d-9260-b39f8f3a3d69"), "JEWEL0027", null, 1, "Jewel product description 27", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 2054000.0, 0.55000000000000004, "Jewel Product 27", 3054000.0, 0, 42, 5054000.0, 3, 47.0, 0 },
                    { new Guid("45a77b6b-a25d-4eac-9dba-6edd2e1d6797"), "JEWEL0013", null, 1, "Jewel product description 13", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F14.jpg?alt=media&token=f9685ad2-52ff-4c5b-b27d-af7e82831126", 2026000.0, 0.55000000000000004, "Jewel Product 13", 3026000.0, 0, 28, 5026000.0, 3, 33.0, 0 },
                    { new Guid("45bcea7e-01fa-49bf-b1df-d9771b69cc97"), "DIAMOND0028", null, 1, "Diamond product description 28", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F14.jpg?alt=media&token=f9685ad2-52ff-4c5b-b27d-af7e82831126", 5140000.0, 0.59999999999999998, "Diamond Product 28", 7640000.0, 0, 33, 15140000.0, 2, 38.0, 0 },
                    { new Guid("475c6813-2231-498a-b53b-fb37fcd40d84"), "GOLD0029", null, 1, "Gold product description 29", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F15.jpg?alt=media&token=54605a2e-243b-471a-95be-1636963e915a", 1029000.0, 0.5, "Gold Product 29", 1529000.0, 0, 39, 895000.0, 1, 79.0, 0 },
                    { new Guid("4e3938e7-73c9-4316-b430-acf9238f6234"), "DIAMOND0019", null, 1, "Diamond product description 19", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F5.jpg?alt=media&token=d0f7a320-2176-4b9c-b6b3-df74cbf36baa", 5095000.0, 0.59999999999999998, "Diamond Product 19", 7595000.0, 0, 24, 15095000.0, 2, 29.0, 0 },
                    { new Guid("4e7d2495-c454-4eb6-bb89-644be3eb8d66"), "DIAMOND003", null, 1, "Diamond product description 3", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F4.jpg?alt=media&token=d87d662c-f2ff-4dec-ac0a-8da9fb426585", 5015000.0, 0.59999999999999998, "Diamond Product 3", 7515000.0, 0, 8, 15015000.0, 2, 13.0, 0 },
                    { new Guid("4f7ac7c6-c7e5-44c1-97a2-18eafc8d73e3"), "GOLD001", null, 1, "Gold product description 1", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F2.jpg?alt=media&token=54f08c6f-e41e-4cde-b6c6-1e40194320a5", 1001000.0, 0.5, "Gold Product 1", 1501000.0, 0, 11, 755000.0, 1, 51.0, 0 },
                    { new Guid("4fa09148-6b29-4342-83e0-6fc65569b60f"), "JEWEL003", null, 1, "Jewel product description 3", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F4.jpg?alt=media&token=d87d662c-f2ff-4dec-ac0a-8da9fb426585", 2006000.0, 0.55000000000000004, "Jewel Product 3", 3006000.0, 0, 18, 5006000.0, 3, 23.0, 0 },
                    { new Guid("5080311d-9e09-4c24-853d-49030de91759"), "GOLD0011", null, 1, "Gold product description 11", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 1011000.0, 0.5, "Gold Product 11", 1511000.0, 0, 21, 805000.0, 1, 61.0, 0 },
                    { new Guid("584a959b-de8a-4e80-bd05-936b3f02ca51"), "DIAMOND0012", null, 1, "Diamond product description 12", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 5060000.0, 0.59999999999999998, "Diamond Product 12", 7560000.0, 0, 17, 15060000.0, 2, 22.0, 0 },
                    { new Guid("5a5d2f70-5a2a-499c-893c-d722f1f9e23d"), "DIAMOND0017", null, 1, "Diamond product description 17", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F3.jpg?alt=media&token=f255817b-bc8f-405c-91f8-a5c733b20a16", 5085000.0, 0.59999999999999998, "Diamond Product 17", 7585000.0, 0, 22, 15085000.0, 2, 27.0, 0 },
                    { new Guid("5b932ce5-3a81-4849-bafe-209ec5c54009"), "JEWEL0014", null, 1, "Jewel product description 14", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F15.jpg?alt=media&token=54605a2e-243b-471a-95be-1636963e915a", 2028000.0, 0.55000000000000004, "Jewel Product 14", 3028000.0, 0, 29, 5028000.0, 3, 34.0, 0 },
                    { new Guid("5fbd5d28-37b8-4f8f-92c0-470182962115"), "JEWEL0015", null, 1, "Jewel product description 15", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F1.jpg?alt=media&token=edd76054-7ffd-4726-9f57-3a5abe125c10", 2030000.0, 0.55000000000000004, "Jewel Product 15", 3030000.0, 0, 30, 5030000.0, 3, 35.0, 0 },
                    { new Guid("6a3871f2-f05f-4d48-8342-ac4e993f6a11"), "JEWEL0025", null, 1, "Jewel product description 25", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F11.jpg?alt=media&token=7afc835a-dc04-491f-a922-14f97c05ad47", 2050000.0, 0.55000000000000004, "Jewel Product 25", 3050000.0, 0, 40, 5050000.0, 3, 45.0, 0 },
                    { new Guid("6c01a36f-9d4a-42af-b1e3-c17aed6a48d4"), "JEWEL0018", null, 1, "Jewel product description 18", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F4.jpg?alt=media&token=d87d662c-f2ff-4dec-ac0a-8da9fb426585", 2036000.0, 0.55000000000000004, "Jewel Product 18", 3036000.0, 0, 33, 5036000.0, 3, 38.0, 0 },
                    { new Guid("74ee5bbc-21ce-4172-9a7b-18897c8503b9"), "JEWEL0017", null, 1, "Jewel product description 17", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F3.jpg?alt=media&token=f255817b-bc8f-405c-91f8-a5c733b20a16", 2034000.0, 0.55000000000000004, "Jewel Product 17", 3034000.0, 0, 32, 5034000.0, 3, 37.0, 0 },
                    { new Guid("8456ee3a-2592-49cd-a868-a072d999ea5a"), "GOLD007", null, 1, "Gold product description 7", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F8.jpg?alt=media&token=bbe17db6-2209-42ad-86dd-ee2422be3d56", 1007000.0, 0.5, "Gold Product 7", 1507000.0, 0, 17, 785000.0, 1, 57.0, 0 },
                    { new Guid("89bcb683-e65d-401c-a25a-2c7c36dd1208"), "DIAMOND005", null, 1, "Diamond product description 5", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2FDayChuyenBac.jpg?alt=media&token=4badf84f-4a3c-489a-bf3b-59bd3517dd8a", 5025000.0, 0.59999999999999998, "Diamond Product 5", 7525000.0, 0, 10, 15025000.0, 2, 15.0, 0 },
                    { new Guid("8cf252c0-75c6-4bcc-95ef-e51557088e49"), "GOLD0012", null, 1, "Gold product description 12", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 1012000.0, 0.5, "Gold Product 12", 1512000.0, 0, 22, 810000.0, 1, 62.0, 0 },
                    { new Guid("944540fe-638a-496d-8b3c-75371ac517b9"), "DIAMOND0010", null, 1, "Diamond product description 10", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F11.jpg?alt=media&token=7afc835a-dc04-491f-a922-14f97c05ad47", 5050000.0, 0.59999999999999998, "Diamond Product 10", 7550000.0, 0, 15, 15050000.0, 2, 20.0, 0 },
                    { new Guid("97245d49-bcec-4e9d-a3dc-21b184720fd1"), "DIAMOND008", null, 1, "Diamond product description 8", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F9.jpg?alt=media&token=0f4b2e0c-ecf4-4ea8-9047-efe08d5b4e71", 5040000.0, 0.59999999999999998, "Diamond Product 8", 7540000.0, 0, 13, 15040000.0, 2, 18.0, 0 },
                    { new Guid("9c59bdb4-eebe-4039-9807-ceae6f7c7ceb"), "DIAMOND0013", null, 1, "Diamond product description 13", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F14.jpg?alt=media&token=f9685ad2-52ff-4c5b-b27d-af7e82831126", 5065000.0, 0.59999999999999998, "Diamond Product 13", 7565000.0, 0, 18, 15065000.0, 2, 23.0, 0 },
                    { new Guid("9ebba22c-c0f4-4914-9cb6-ca48aa7b8c5d"), "GOLD008", null, 1, "Gold product description 8", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F9.jpg?alt=media&token=0f4b2e0c-ecf4-4ea8-9047-efe08d5b4e71", 1008000.0, 0.5, "Gold Product 8", 1508000.0, 0, 18, 790000.0, 1, 58.0, 0 },
                    { new Guid("9efdec6e-9924-47ed-8d5f-4d62f0b7687d"), "GOLD0016", null, 1, "Gold product description 16", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F2.jpg?alt=media&token=54f08c6f-e41e-4cde-b6c6-1e40194320a5", 1016000.0, 0.5, "Gold Product 16", 1516000.0, 0, 26, 830000.0, 1, 66.0, 0 },
                    { new Guid("a0383574-6e32-4af8-929f-e90168b74aef"), "GOLD0019", null, 1, "Gold product description 19", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F5.jpg?alt=media&token=d0f7a320-2176-4b9c-b6b3-df74cbf36baa", 1019000.0, 0.5, "Gold Product 19", 1519000.0, 0, 29, 845000.0, 1, 69.0, 0 },
                    { new Guid("a092c366-5a32-4906-9b8f-32003c7cdc0f"), "DIAMOND0029", null, 1, "Diamond product description 29", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F15.jpg?alt=media&token=54605a2e-243b-471a-95be-1636963e915a", 5145000.0, 0.59999999999999998, "Diamond Product 29", 7645000.0, 0, 34, 15145000.0, 2, 39.0, 0 },
                    { new Guid("a1cf7983-9a92-4d1e-95b2-06f23f2300da"), "GOLD0018", null, 1, "Gold product description 18", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F4.jpg?alt=media&token=d87d662c-f2ff-4dec-ac0a-8da9fb426585", 1018000.0, 0.5, "Gold Product 18", 1518000.0, 0, 28, 840000.0, 1, 68.0, 0 },
                    { new Guid("a496ca5d-bf1f-4a49-bfd6-a70dc0472995"), "DIAMOND0021", null, 1, "Diamond product description 21", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F7.jpg?alt=media&token=5b91fa57-76a5-4911-820b-86f9b11ebbf9", 5105000.0, 0.59999999999999998, "Diamond Product 21", 7605000.0, 0, 26, 15105000.0, 2, 31.0, 0 },
                    { new Guid("a654ffff-9e1e-453a-ba3c-4e240acd3e6a"), "GOLD0021", null, 1, "Gold product description 21", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F7.jpg?alt=media&token=5b91fa57-76a5-4911-820b-86f9b11ebbf9", 1021000.0, 0.5, "Gold Product 21", 1521000.0, 0, 31, 855000.0, 1, 71.0, 0 },
                    { new Guid("aac25b5e-82b1-4e32-8474-922453cddf5a"), "JEWEL004", null, 1, "Jewel product description 4", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F5.jpg?alt=media&token=d0f7a320-2176-4b9c-b6b3-df74cbf36baa", 2008000.0, 0.55000000000000004, "Jewel Product 4", 3008000.0, 0, 19, 5008000.0, 3, 24.0, 0 },
                    { new Guid("aba343bb-f921-4ccc-8d15-aec4adc1ccc8"), "JEWEL009", null, 1, "Jewel product description 9", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F10.jpg?alt=media&token=55a92de8-ee5c-42c9-9abe-878a240dd0f1", 2018000.0, 0.55000000000000004, "Jewel Product 9", 3018000.0, 0, 24, 5018000.0, 3, 29.0, 0 },
                    { new Guid("b0712973-8d43-482a-bda9-0e54955ae233"), "DIAMOND0025", null, 1, "Diamond product description 25", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F11.jpg?alt=media&token=7afc835a-dc04-491f-a922-14f97c05ad47", 5125000.0, 0.59999999999999998, "Diamond Product 25", 7625000.0, 0, 30, 15125000.0, 2, 35.0, 0 },
                    { new Guid("b486fdd7-f854-4bd2-bdd3-ad92555f46ce"), "GOLD0015", null, 1, "Gold product description 15", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F1.jpg?alt=media&token=edd76054-7ffd-4726-9f57-3a5abe125c10", 1015000.0, 0.5, "Gold Product 15", 1515000.0, 0, 25, 825000.0, 1, 65.0, 0 },
                    { new Guid("b63784e5-05ff-4f52-be85-5a5efff7f9dd"), "JEWEL008", null, 1, "Jewel product description 8", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F9.jpg?alt=media&token=0f4b2e0c-ecf4-4ea8-9047-efe08d5b4e71", 2016000.0, 0.55000000000000004, "Jewel Product 8", 3016000.0, 0, 23, 5016000.0, 3, 28.0, 0 },
                    { new Guid("b829de1b-2465-49a3-8915-d8843cfbf251"), "DIAMOND0023", null, 1, "Diamond product description 23", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F9.jpg?alt=media&token=0f4b2e0c-ecf4-4ea8-9047-efe08d5b4e71", 5115000.0, 0.59999999999999998, "Diamond Product 23", 7615000.0, 0, 28, 15115000.0, 2, 33.0, 0 },
                    { new Guid("b867afdf-65d2-4e65-8f7b-52952a73b105"), "JEWEL0023", null, 1, "Jewel product description 23", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F9.jpg?alt=media&token=0f4b2e0c-ecf4-4ea8-9047-efe08d5b4e71", 2046000.0, 0.55000000000000004, "Jewel Product 23", 3046000.0, 0, 38, 5046000.0, 3, 43.0, 0 },
                    { new Guid("b946343a-47c1-40c9-8c5a-e0ae09572a1e"), "DIAMOND004", null, 1, "Diamond product description 4", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F5.jpg?alt=media&token=d0f7a320-2176-4b9c-b6b3-df74cbf36baa", 5020000.0, 0.59999999999999998, "Diamond Product 4", 7520000.0, 0, 9, 15020000.0, 2, 14.0, 0 },
                    { new Guid("ba778455-a06b-4746-9fdf-b39821548624"), "GOLD0030", null, 1, "Gold product description 30", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F1.jpg?alt=media&token=edd76054-7ffd-4726-9f57-3a5abe125c10", 1030000.0, 0.5, "Gold Product 30", 1530000.0, 0, 40, 900000.0, 1, 80.0, 0 },
                    { new Guid("bab3b868-9830-4804-9ac3-805d3dc12c53"), "JEWEL0021", null, 1, "Jewel product description 21", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F7.jpg?alt=media&token=5b91fa57-76a5-4911-820b-86f9b11ebbf9", 2042000.0, 0.55000000000000004, "Jewel Product 21", 3042000.0, 0, 36, 5042000.0, 3, 41.0, 0 },
                    { new Guid("bbb3f379-de71-4d83-842b-1f6e1f225d9d"), "JEWEL0028", null, 1, "Jewel product description 28", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F14.jpg?alt=media&token=f9685ad2-52ff-4c5b-b27d-af7e82831126", 2056000.0, 0.55000000000000004, "Jewel Product 28", 3056000.0, 0, 43, 5056000.0, 3, 48.0, 0 },
                    { new Guid("bdde4d4c-5dc8-482e-9a8d-1cb2beb682d3"), "DIAMOND006", null, 1, "Diamond product description 6", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F7.jpg?alt=media&token=5b91fa57-76a5-4911-820b-86f9b11ebbf9", 5030000.0, 0.59999999999999998, "Diamond Product 6", 7530000.0, 0, 11, 15030000.0, 2, 16.0, 0 },
                    { new Guid("be860e91-a6eb-4d72-b1a0-e58d7848b9bb"), "GOLD0028", null, 1, "Gold product description 28", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F14.jpg?alt=media&token=f9685ad2-52ff-4c5b-b27d-af7e82831126", 1028000.0, 0.5, "Gold Product 28", 1528000.0, 0, 38, 890000.0, 1, 78.0, 0 },
                    { new Guid("bf4d6378-c746-4c08-93e7-caaf109ce4ed"), "JEWEL005", null, 1, "Jewel product description 5", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2FDayChuyenBac.jpg?alt=media&token=4badf84f-4a3c-489a-bf3b-59bd3517dd8a", 2010000.0, 0.55000000000000004, "Jewel Product 5", 3010000.0, 0, 20, 5010000.0, 3, 25.0, 0 },
                    { new Guid("bf803140-4ca3-414a-b3f7-7a9967e85d08"), "GOLD0020", null, 1, "Gold product description 20", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2FDayChuyenBac.jpg?alt=media&token=4badf84f-4a3c-489a-bf3b-59bd3517dd8a", 1020000.0, 0.5, "Gold Product 20", 1520000.0, 0, 30, 850000.0, 1, 70.0, 0 },
                    { new Guid("c05e0a69-a00c-4b70-9d69-46f1e4488640"), "GOLD0017", null, 1, "Gold product description 17", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F3.jpg?alt=media&token=f255817b-bc8f-405c-91f8-a5c733b20a16", 1017000.0, 0.5, "Gold Product 17", 1517000.0, 0, 27, 835000.0, 1, 67.0, 0 },
                    { new Guid("c5bb6400-2396-4e5d-aad4-8b7b3dd78f65"), "GOLD005", null, 1, "Gold product description 5", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2FDayChuyenBac.jpg?alt=media&token=4badf84f-4a3c-489a-bf3b-59bd3517dd8a", 1005000.0, 0.5, "Gold Product 5", 1505000.0, 0, 15, 775000.0, 1, 55.0, 0 },
                    { new Guid("ca9aeef9-9dd3-4913-bca5-822883e01bdd"), "DIAMOND0024", null, 1, "Diamond product description 24", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F10.jpg?alt=media&token=55a92de8-ee5c-42c9-9abe-878a240dd0f1", 5120000.0, 0.59999999999999998, "Diamond Product 24", 7620000.0, 0, 29, 15120000.0, 2, 34.0, 0 },
                    { new Guid("cd2a8026-a077-4d01-b8e3-9fb25ce5cf20"), "JEWEL006", null, 1, "Jewel product description 6", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F7.jpg?alt=media&token=5b91fa57-76a5-4911-820b-86f9b11ebbf9", 2012000.0, 0.55000000000000004, "Jewel Product 6", 3012000.0, 0, 21, 5012000.0, 3, 26.0, 0 },
                    { new Guid("cebb4da5-d5c5-4c50-948b-e873bcdb72e4"), "JEWEL0011", null, 1, "Jewel product description 11", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 2022000.0, 0.55000000000000004, "Jewel Product 11", 3022000.0, 0, 26, 5022000.0, 3, 31.0, 0 },
                    { new Guid("d48d7699-27d2-4e03-a085-7dac1e542ba9"), "GOLD003", null, 1, "Gold product description 3", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F4.jpg?alt=media&token=d87d662c-f2ff-4dec-ac0a-8da9fb426585", 1003000.0, 0.5, "Gold Product 3", 1503000.0, 0, 13, 765000.0, 1, 53.0, 0 },
                    { new Guid("d69ac406-6a9a-4196-bfca-b522850e345c"), "JEWEL0012", null, 1, "Jewel product description 12", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 2024000.0, 0.55000000000000004, "Jewel Product 12", 3024000.0, 0, 27, 5024000.0, 3, 32.0, 0 },
                    { new Guid("d88c4f8d-2289-414c-8137-589551e211dc"), "DIAMOND0022", null, 1, "Diamond product description 22", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F8.jpg?alt=media&token=bbe17db6-2209-42ad-86dd-ee2422be3d56", 5110000.0, 0.59999999999999998, "Diamond Product 22", 7610000.0, 0, 27, 15110000.0, 2, 32.0, 0 },
                    { new Guid("dfcabede-71c5-4877-a391-5250c44cc1c4"), "JEWEL0019", null, 1, "Jewel product description 19", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F5.jpg?alt=media&token=d0f7a320-2176-4b9c-b6b3-df74cbf36baa", 2038000.0, 0.55000000000000004, "Jewel Product 19", 3038000.0, 0, 34, 5038000.0, 3, 39.0, 0 },
                    { new Guid("e28e254b-9de7-4137-b0b5-170bc91bd67a"), "GOLD004", null, 1, "Gold product description 4", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F5.jpg?alt=media&token=d0f7a320-2176-4b9c-b6b3-df74cbf36baa", 1004000.0, 0.5, "Gold Product 4", 1504000.0, 0, 14, 770000.0, 1, 54.0, 0 },
                    { new Guid("e4681a1c-ab9a-4bb1-85f8-b6b3d59b520c"), "GOLD0025", null, 1, "Gold product description 25", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F11.jpg?alt=media&token=7afc835a-dc04-491f-a922-14f97c05ad47", 1025000.0, 0.5, "Gold Product 25", 1525000.0, 0, 35, 875000.0, 1, 75.0, 0 },
                    { new Guid("e70e9116-63da-46db-9d2e-448687786138"), "DIAMOND0026", null, 1, "Diamond product description 26", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 5130000.0, 0.59999999999999998, "Diamond Product 26", 7630000.0, 0, 31, 15130000.0, 2, 36.0, 0 },
                    { new Guid("e7d4d79a-a4f5-44d7-82a6-6dd56f2416a3"), "DIAMOND0014", null, 1, "Diamond product description 14", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F15.jpg?alt=media&token=54605a2e-243b-471a-95be-1636963e915a", 5070000.0, 0.59999999999999998, "Diamond Product 14", 7570000.0, 0, 19, 15070000.0, 2, 24.0, 0 },
                    { new Guid("eb35cdf7-b288-4f70-bb91-4faccc3ff0e6"), "JEWEL0016", null, 1, "Jewel product description 16", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F2.jpg?alt=media&token=54f08c6f-e41e-4cde-b6c6-1e40194320a5", 2032000.0, 0.55000000000000004, "Jewel Product 16", 3032000.0, 0, 31, 5032000.0, 3, 36.0, 0 },
                    { new Guid("ef0b8490-563a-4518-a0b4-e6f84564fe46"), "DIAMOND0016", null, 1, "Diamond product description 16", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F2.jpg?alt=media&token=54f08c6f-e41e-4cde-b6c6-1e40194320a5", 5080000.0, 0.59999999999999998, "Diamond Product 16", 7580000.0, 0, 21, 15080000.0, 2, 26.0, 0 },
                    { new Guid("f1c1914d-6527-4106-ab00-b801755fefcd"), "GOLD0023", null, 1, "Gold product description 23", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F9.jpg?alt=media&token=0f4b2e0c-ecf4-4ea8-9047-efe08d5b4e71", 1023000.0, 0.5, "Gold Product 23", 1523000.0, 0, 33, 865000.0, 1, 73.0, 0 },
                    { new Guid("f28cf969-79ff-48fd-81de-08789cda41c4"), "GOLD0014", null, 1, "Gold product description 14", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F15.jpg?alt=media&token=54605a2e-243b-471a-95be-1636963e915a", 1014000.0, 0.5, "Gold Product 14", 1514000.0, 0, 24, 820000.0, 1, 64.0, 0 },
                    { new Guid("f47b0dcb-f449-400d-a60c-ed0ea2d5f112"), "DIAMOND0011", null, 1, "Diamond product description 11", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 5055000.0, 0.59999999999999998, "Diamond Product 11", 7555000.0, 0, 16, 15055000.0, 2, 21.0, 0 },
                    { new Guid("f577ce14-63a1-450d-8a17-3eb2e841ba0d"), "DIAMOND009", null, 1, "Diamond product description 9", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F10.jpg?alt=media&token=55a92de8-ee5c-42c9-9abe-878a240dd0f1", 5045000.0, 0.59999999999999998, "Diamond Product 9", 7545000.0, 0, 14, 15045000.0, 2, 19.0, 0 },
                    { new Guid("f75a4c4f-1c49-48c5-bf9a-eac99426322d"), "JEWEL0029", null, 1, "Jewel product description 29", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F15.jpg?alt=media&token=54605a2e-243b-471a-95be-1636963e915a", 2058000.0, 0.55000000000000004, "Jewel Product 29", 3058000.0, 0, 44, 5058000.0, 3, 49.0, 0 },
                    { new Guid("fa8dd5cd-e91a-4e11-88dd-d575de808f66"), "GOLD0010", null, 1, "Gold product description 10", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F11.jpg?alt=media&token=7afc835a-dc04-491f-a922-14f97c05ad47", 1010000.0, 0.5, "Gold Product 10", 1510000.0, 0, 20, 800000.0, 1, 60.0, 0 },
                    { new Guid("fc18ad8e-4f46-4e33-ac74-25fb434236ff"), "DIAMOND0018", null, 1, "Diamond product description 18", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F4.jpg?alt=media&token=d87d662c-f2ff-4dec-ac0a-8da9fb426585", 5090000.0, 0.59999999999999998, "Diamond Product 18", 7590000.0, 0, 23, 15090000.0, 2, 28.0, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CPId",
                table: "Orders",
                column: "CPId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_CustomerPolicies_CPId",
                table: "Orders",
                column: "CPId",
                principalTable: "CustomerPolicies",
                principalColumn: "CPId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_CustomerPolicies_CPId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CPId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("013547f4-1a5e-4faf-a7f0-65b5ce4747c5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3d27847c-5aaf-4697-9ce3-0f7ee58428b0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("9f5d0345-0266-4213-8544-3a8b062dd65f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f776ed8d-5c50-4e4f-be3c-b9633f7532bf"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("31023a3a-96a4-4803-ac2b-5b4cebadc3ca"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("5b1293f4-54a1-4580-826e-f48106600d88"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("e8cc4ead-e3ea-49c3-92dc-4a704e7c5547"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("f758d1e1-37a6-415f-bb1d-36181ab71fc3"));

            migrationBuilder.DeleteData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: new Guid("11d623d3-97ed-4e9b-ba91-d9115358ef8e"));

            migrationBuilder.DeleteData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: new Guid("44251df8-dc2b-46b4-bfd6-1b20b66e1203"));

            migrationBuilder.DeleteData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: new Guid("d4c78d1d-f2b6-467f-b00d-cd4ac7eb406c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("000cbf32-abea-44db-be3d-2155c06d59d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("000eabfb-a482-4740-ad3f-03b1b9b02cc3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0537a665-f951-41f8-a37c-2c0fab1d9085"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0ac7c3f9-34ba-4a0e-89e1-31975752e523"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0d4f7d2b-2b33-4467-966a-a68c135ca205"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0d8a81a5-86ad-4cb9-855f-856d14d72809"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("105ebc10-5186-46c9-88e7-b3d4010df604"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1071e6d6-7868-4022-be3b-c779c4b293c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("108ec182-5999-496e-969c-63c3b6d66f77"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1c3c4b22-bd06-40c0-9f68-05f19d1688f0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1db26988-7562-4a2f-a94e-98877d1d1ae9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1ea13acf-3b9d-42c6-ba60-3aba19f7c45d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("22060e2a-82b6-498b-b2c3-e3b263d812a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("22c95a5a-e4a2-4526-bb12-7c24c7e4c754"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("24e380a4-8263-4d60-8a08-d975cacaa3cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2c08588b-25a0-453b-a329-27533035e8cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3791978f-8952-44b5-864f-99e0325023ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("37e3469a-838e-419b-8ec1-b7a74f3cb756"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("38bffdfa-ed10-4597-86ab-3ed2cc5abe31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3c1d70e7-ed24-4af3-97ab-072f925a67d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3d199a3f-8880-43ac-a76c-b3d25dfc2314"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3fc57e43-1697-4efc-8d58-7bdd3114267c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3fecb191-4301-46a3-a485-6c90881c6045"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("40a8fd37-cd81-4a46-b4dc-9cfb9f90b099"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("458cd034-e599-483d-9260-b39f8f3a3d69"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("45a77b6b-a25d-4eac-9dba-6edd2e1d6797"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("45bcea7e-01fa-49bf-b1df-d9771b69cc97"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("475c6813-2231-498a-b53b-fb37fcd40d84"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4e3938e7-73c9-4316-b430-acf9238f6234"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4e7d2495-c454-4eb6-bb89-644be3eb8d66"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f7ac7c6-c7e5-44c1-97a2-18eafc8d73e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4fa09148-6b29-4342-83e0-6fc65569b60f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5080311d-9e09-4c24-853d-49030de91759"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("584a959b-de8a-4e80-bd05-936b3f02ca51"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5a5d2f70-5a2a-499c-893c-d722f1f9e23d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5b932ce5-3a81-4849-bafe-209ec5c54009"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5fbd5d28-37b8-4f8f-92c0-470182962115"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6a3871f2-f05f-4d48-8342-ac4e993f6a11"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6c01a36f-9d4a-42af-b1e3-c17aed6a48d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("74ee5bbc-21ce-4172-9a7b-18897c8503b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8456ee3a-2592-49cd-a868-a072d999ea5a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("89bcb683-e65d-401c-a25a-2c7c36dd1208"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8cf252c0-75c6-4bcc-95ef-e51557088e49"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("944540fe-638a-496d-8b3c-75371ac517b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("97245d49-bcec-4e9d-a3dc-21b184720fd1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9c59bdb4-eebe-4039-9807-ceae6f7c7ceb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9ebba22c-c0f4-4914-9cb6-ca48aa7b8c5d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9efdec6e-9924-47ed-8d5f-4d62f0b7687d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a0383574-6e32-4af8-929f-e90168b74aef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a092c366-5a32-4906-9b8f-32003c7cdc0f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a1cf7983-9a92-4d1e-95b2-06f23f2300da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a496ca5d-bf1f-4a49-bfd6-a70dc0472995"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a654ffff-9e1e-453a-ba3c-4e240acd3e6a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("aac25b5e-82b1-4e32-8474-922453cddf5a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("aba343bb-f921-4ccc-8d15-aec4adc1ccc8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b0712973-8d43-482a-bda9-0e54955ae233"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b486fdd7-f854-4bd2-bdd3-ad92555f46ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b63784e5-05ff-4f52-be85-5a5efff7f9dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b829de1b-2465-49a3-8915-d8843cfbf251"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b867afdf-65d2-4e65-8f7b-52952a73b105"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b946343a-47c1-40c9-8c5a-e0ae09572a1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ba778455-a06b-4746-9fdf-b39821548624"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bab3b868-9830-4804-9ac3-805d3dc12c53"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bbb3f379-de71-4d83-842b-1f6e1f225d9d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bdde4d4c-5dc8-482e-9a8d-1cb2beb682d3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("be860e91-a6eb-4d72-b1a0-e58d7848b9bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bf4d6378-c746-4c08-93e7-caaf109ce4ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bf803140-4ca3-414a-b3f7-7a9967e85d08"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c05e0a69-a00c-4b70-9d69-46f1e4488640"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c5bb6400-2396-4e5d-aad4-8b7b3dd78f65"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ca9aeef9-9dd3-4913-bca5-822883e01bdd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cd2a8026-a077-4d01-b8e3-9fb25ce5cf20"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cebb4da5-d5c5-4c50-948b-e873bcdb72e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d48d7699-27d2-4e03-a085-7dac1e542ba9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d69ac406-6a9a-4196-bfca-b522850e345c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d88c4f8d-2289-414c-8137-589551e211dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dfcabede-71c5-4877-a391-5250c44cc1c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e28e254b-9de7-4137-b0b5-170bc91bd67a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e4681a1c-ab9a-4bb1-85f8-b6b3d59b520c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e70e9116-63da-46db-9d2e-448687786138"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e7d4d79a-a4f5-44d7-82a6-6dd56f2416a3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("eb35cdf7-b288-4f70-bb91-4faccc3ff0e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ef0b8490-563a-4518-a0b4-e6f84564fe46"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f1c1914d-6527-4106-ab00-b801755fefcd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f28cf969-79ff-48fd-81de-08789cda41c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f47b0dcb-f449-400d-a60c-ed0ea2d5f112"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f577ce14-63a1-450d-8a17-3eb2e841ba0d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f75a4c4f-1c49-48c5-bf9a-eac99426322d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fa8dd5cd-e91a-4e11-88dd-d575de808f66"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fc18ad8e-4f46-4e33-ac74-25fb434236ff"));

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromotionCode",
                keyValue: "Promotion 01");

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromotionCode",
                keyValue: "Promotion 02");

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromotionCode",
                keyValue: "Promotion 03");

            migrationBuilder.DeleteData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "CPId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PolicyStatus",
                table: "CustomerPolicies");

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
    }
}
