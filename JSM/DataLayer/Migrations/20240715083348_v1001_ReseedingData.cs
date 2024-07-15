using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class v1001_ReseedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "AccumulatedPoint", "Address", "CustomerGender", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { new Guid("106bb060-7216-49a3-9a2a-b5dd277e2f00"), 0, "Phường Tân Phú, Quận 7, Thành phố Hồ Chí Minh", 1, "hoanguyen@outlook.com", "Nguyễn Thị Hoa", "0987654321" },
                    { new Guid("50e47e43-3920-4410-8c2e-8f4b2057a6e4"), 3000, "Xã Hồng Thủy, Huyện Lệ Thủy, Quảng Bình", 0, "lamAnh@hotmail.com", "anh Lâm", "0820256734" },
                    { new Guid("9c55d35a-952d-465e-a61a-4cd29c228ee9"), 2500, "Phường Cầu Diễn, Quận Nam Từ Liêm, Hà Nội", 1, "minhTran@gmail.com", "Trần Minh", "0912345678" },
                    { new Guid("ba478046-1203-448a-accc-dc05379fa38d"), 0, "Phường Cửa Nam, Quận Hoàn Kiếm, Hà Nội", 0, "ducpham@yahoo.com", "Phạm Văn Đức", "0909876543" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "CounterId", "Email", "EmployeeGender", "EmployeeStatus", "IsLogin", "ManagedBy", "Name", "Password", "Phone", "RoleId" },
                values: new object[,]
                {
                    { new Guid("63c01856-a5b5-4361-8daf-2ffbfe173ddd"), 2, "admin@gmail.com", 1, 0, true, new Guid("00000000-0000-0000-0000-000000000000"), "Admin", "$2a$11$Tr9OUgu.cRTTH.rb93o9QuTXxbJhLKu/KgCmxRgbU/4YT5BPQp/2W", "0934425533", 3 },
                    { new Guid("7116fb6e-d97e-4265-b8fe-03ae772b7903"), 1, "a@gmail.com", 0, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "Nguyen Van A", "$2a$11$Tr9OUgu.cRTTH.rb93o9QuTXxbJhLKu/KgCmxRgbU/4YT5BPQp/2W", "0354410931", 1 },
                    { new Guid("a41e1289-d7e4-4bf7-8709-009498b73f43"), 2, "b@gmail.com", 1, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), "Le Van B", "$2a$11$Tr9OUgu.cRTTH.rb93o9QuTXxbJhLKu/KgCmxRgbU/4YT5BPQp/2W", "0934425563", 2 },
                    { new Guid("d28230fc-2771-4565-927c-0b4d933ba598"), 2, "sa@gmail.com", 0, 0, true, new Guid("00000000-0000-0000-0000-000000000000"), "Super Admin", "$2a$11$rvbF4Kctvp1VFftcz.cTf.iCV.Gjrw65RzPy4XsOmyx8.dea6KLN6", "0934425533", 4 }
                });

            migrationBuilder.InsertData(
                table: "Gifts",
                columns: new[] { "GiftId", "GiftName", "PointRequired" },
                values: new object[,]
                {
                    { new Guid("165cdb54-48d1-479f-b60e-f76bc785de8c"), "Lịch vạn niên 2025", 6000 },
                    { new Guid("3521f378-14fe-430c-9021-0760b74759ed"), "Áo mưa", 3500 },
                    { new Guid("4376f2bc-ccee-45c9-a206-ce10ac730d63"), "Bộ bàn ghế gỗ", 14000 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Barcode", "CertificateUrl", "CounterId", "Description", "Img", "ManufactureCost", "MarkupRate", "Name", "Price", "ProductStatus", "Quantity", "StonePrice", "TypeId", "Weight", "WeightUnit" },
                values: new object[,]
                {
                    { new Guid("00791dce-9449-489c-9e0d-22b3ebcb1d77"), "DIAMOND0021", null, 1, "Diamond product description 21", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F7.jpg?alt=media&token=5b91fa57-76a5-4911-820b-86f9b11ebbf9", 5105000.0, 0.59999999999999998, "Diamond Product 21", 7605000.0, 0, 26, 15105000.0, 2, 31.0, 0 },
                    { new Guid("1358afa9-ca8f-49a7-866f-8c62504311c2"), "JEWEL0027", null, 1, "Jewel product description 27", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 2054000.0, 0.55000000000000004, "Jewel Product 27", 3054000.0, 0, 42, 5054000.0, 3, 47.0, 0 },
                    { new Guid("148fcd0e-4a7e-43cf-968a-0b71a2fcd097"), "JEWEL007", null, 1, "Jewel product description 7", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F8.jpg?alt=media&token=bbe17db6-2209-42ad-86dd-ee2422be3d56", 2014000.0, 0.55000000000000004, "Jewel Product 7", 3014000.0, 0, 22, 5014000.0, 3, 27.0, 0 },
                    { new Guid("179547d5-b37a-4f83-95f6-bd998398b29f"), "GOLD0010", null, 1, "Gold product description 10", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F11.jpg?alt=media&token=7afc835a-dc04-491f-a922-14f97c05ad47", 1010000.0, 0.5, "Gold Product 10", 1510000.0, 0, 20, 800000.0, 1, 60.0, 0 },
                    { new Guid("1d10a1ea-864b-49cb-97ea-d658fe9822d4"), "DIAMOND0010", null, 1, "Diamond product description 10", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F11.jpg?alt=media&token=7afc835a-dc04-491f-a922-14f97c05ad47", 5050000.0, 0.59999999999999998, "Diamond Product 10", 7550000.0, 0, 15, 15050000.0, 2, 20.0, 0 },
                    { new Guid("21f39ce3-613f-47e0-9a7c-7dbb45749a76"), "DIAMOND005", null, 1, "Diamond product description 5", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2FDayChuyenBac.jpg?alt=media&token=4badf84f-4a3c-489a-bf3b-59bd3517dd8a", 5025000.0, 0.59999999999999998, "Diamond Product 5", 7525000.0, 0, 10, 15025000.0, 2, 15.0, 0 },
                    { new Guid("242aac4a-e67e-4720-859b-b85dd908877d"), "DIAMOND0029", null, 1, "Diamond product description 29", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F15.jpg?alt=media&token=54605a2e-243b-471a-95be-1636963e915a", 5145000.0, 0.59999999999999998, "Diamond Product 29", 7645000.0, 0, 34, 15145000.0, 2, 39.0, 0 },
                    { new Guid("24742873-f787-4f76-b6fc-acd101667033"), "DIAMOND0011", null, 1, "Diamond product description 11", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 5055000.0, 0.59999999999999998, "Diamond Product 11", 7555000.0, 0, 16, 15055000.0, 2, 21.0, 0 },
                    { new Guid("27f356a6-f6c6-4084-a2e7-074b4814c3bb"), "JEWEL003", null, 1, "Jewel product description 3", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F4.jpg?alt=media&token=d87d662c-f2ff-4dec-ac0a-8da9fb426585", 2006000.0, 0.55000000000000004, "Jewel Product 3", 3006000.0, 0, 18, 5006000.0, 3, 23.0, 0 },
                    { new Guid("302b1dde-9abf-4aad-afc6-3a9508a04169"), "GOLD0026", null, 1, "Gold product description 26", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 1026000.0, 0.5, "Gold Product 26", 1526000.0, 0, 36, 880000.0, 1, 76.0, 0 },
                    { new Guid("31c63c64-ad74-4f6e-b26e-c1dc27e8564e"), "JEWEL009", null, 1, "Jewel product description 9", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F10.jpg?alt=media&token=55a92de8-ee5c-42c9-9abe-878a240dd0f1", 2018000.0, 0.55000000000000004, "Jewel Product 9", 3018000.0, 0, 24, 5018000.0, 3, 29.0, 0 },
                    { new Guid("3644579e-a2c2-4b1a-b89f-c09ca842c5e2"), "JEWEL0015", null, 1, "Jewel product description 15", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F1.jpg?alt=media&token=edd76054-7ffd-4726-9f57-3a5abe125c10", 2030000.0, 0.55000000000000004, "Jewel Product 15", 3030000.0, 0, 30, 5030000.0, 3, 35.0, 0 },
                    { new Guid("38d0ec54-9366-4707-8ee1-8b94ce390f35"), "JEWEL0012", null, 1, "Jewel product description 12", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 2024000.0, 0.55000000000000004, "Jewel Product 12", 3024000.0, 0, 27, 5024000.0, 3, 32.0, 0 },
                    { new Guid("392b947c-e86b-4c3b-88c7-24d5dbca07d9"), "DIAMOND0025", null, 1, "Diamond product description 25", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F11.jpg?alt=media&token=7afc835a-dc04-491f-a922-14f97c05ad47", 5125000.0, 0.59999999999999998, "Diamond Product 25", 7625000.0, 0, 30, 15125000.0, 2, 35.0, 0 },
                    { new Guid("39f5f1c1-4f6b-4934-995a-099ec3a34942"), "DIAMOND0028", null, 1, "Diamond product description 28", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F14.jpg?alt=media&token=f9685ad2-52ff-4c5b-b27d-af7e82831126", 5140000.0, 0.59999999999999998, "Diamond Product 28", 7640000.0, 0, 33, 15140000.0, 2, 38.0, 0 },
                    { new Guid("3a5d542d-b232-4049-9f6f-e62657f36649"), "JEWEL0020", null, 1, "Jewel product description 20", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2FDayChuyenBac.jpg?alt=media&token=4badf84f-4a3c-489a-bf3b-59bd3517dd8a", 2040000.0, 0.55000000000000004, "Jewel Product 20", 3040000.0, 0, 35, 5040000.0, 3, 40.0, 0 },
                    { new Guid("3b70efec-b8de-4866-967d-d0c0e9ba6eca"), "GOLD004", null, 1, "Gold product description 4", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F5.jpg?alt=media&token=d0f7a320-2176-4b9c-b6b3-df74cbf36baa", 1004000.0, 0.5, "Gold Product 4", 1504000.0, 0, 14, 770000.0, 1, 54.0, 0 },
                    { new Guid("3cf073f5-7835-40be-92eb-545e1e093555"), "DIAMOND001", null, 1, "Diamond product description 1", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F2.jpg?alt=media&token=54f08c6f-e41e-4cde-b6c6-1e40194320a5", 5005000.0, 0.59999999999999998, "Diamond Product 1", 7505000.0, 0, 6, 15005000.0, 2, 11.0, 0 },
                    { new Guid("3f480a9b-e078-4dd2-911a-d699a05c3fe3"), "DIAMOND0016", null, 1, "Diamond product description 16", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F2.jpg?alt=media&token=54f08c6f-e41e-4cde-b6c6-1e40194320a5", 5080000.0, 0.59999999999999998, "Diamond Product 16", 7580000.0, 0, 21, 15080000.0, 2, 26.0, 0 },
                    { new Guid("42d48c93-edf7-4598-ba7b-2a84f9946618"), "JEWEL0021", null, 1, "Jewel product description 21", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F7.jpg?alt=media&token=5b91fa57-76a5-4911-820b-86f9b11ebbf9", 2042000.0, 0.55000000000000004, "Jewel Product 21", 3042000.0, 0, 36, 5042000.0, 3, 41.0, 0 },
                    { new Guid("4345658c-15ee-4997-952f-142a238e2d9a"), "DIAMOND006", null, 1, "Diamond product description 6", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F7.jpg?alt=media&token=5b91fa57-76a5-4911-820b-86f9b11ebbf9", 5030000.0, 0.59999999999999998, "Diamond Product 6", 7530000.0, 0, 11, 15030000.0, 2, 16.0, 0 },
                    { new Guid("44caeea7-969e-42b9-b536-4a5974d9db4e"), "JEWEL0017", null, 1, "Jewel product description 17", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F3.jpg?alt=media&token=f255817b-bc8f-405c-91f8-a5c733b20a16", 2034000.0, 0.55000000000000004, "Jewel Product 17", 3034000.0, 0, 32, 5034000.0, 3, 37.0, 0 },
                    { new Guid("45c0ed4a-2de1-43cd-a634-90f8e7115d71"), "DIAMOND0019", null, 1, "Diamond product description 19", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F5.jpg?alt=media&token=d0f7a320-2176-4b9c-b6b3-df74cbf36baa", 5095000.0, 0.59999999999999998, "Diamond Product 19", 7595000.0, 0, 24, 15095000.0, 2, 29.0, 0 },
                    { new Guid("48a35665-944b-4143-9813-daa984454aed"), "JEWEL001", null, 1, "Jewel product description 1", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F2.jpg?alt=media&token=54f08c6f-e41e-4cde-b6c6-1e40194320a5", 2002000.0, 0.55000000000000004, "Jewel Product 1", 3002000.0, 0, 16, 5002000.0, 3, 21.0, 0 },
                    { new Guid("4c08b875-01c4-4281-8e0d-35d0f22fa7ac"), "DIAMOND009", null, 1, "Diamond product description 9", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F10.jpg?alt=media&token=55a92de8-ee5c-42c9-9abe-878a240dd0f1", 5045000.0, 0.59999999999999998, "Diamond Product 9", 7545000.0, 0, 14, 15045000.0, 2, 19.0, 0 },
                    { new Guid("4cdd551a-a5fd-4fe3-a998-4755f03c22cd"), "JEWEL005", null, 1, "Jewel product description 5", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2FDayChuyenBac.jpg?alt=media&token=4badf84f-4a3c-489a-bf3b-59bd3517dd8a", 2010000.0, 0.55000000000000004, "Jewel Product 5", 3010000.0, 0, 20, 5010000.0, 3, 25.0, 0 },
                    { new Guid("4f326d1d-8419-4af6-a91f-0aba6238f40e"), "GOLD0029", null, 1, "Gold product description 29", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F15.jpg?alt=media&token=54605a2e-243b-471a-95be-1636963e915a", 1029000.0, 0.5, "Gold Product 29", 1529000.0, 0, 39, 895000.0, 1, 79.0, 0 },
                    { new Guid("51ac2b26-77ae-4157-8cee-2f7af0ce7834"), "GOLD005", null, 1, "Gold product description 5", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2FDayChuyenBac.jpg?alt=media&token=4badf84f-4a3c-489a-bf3b-59bd3517dd8a", 1005000.0, 0.5, "Gold Product 5", 1505000.0, 0, 15, 775000.0, 1, 55.0, 0 },
                    { new Guid("51d83d7d-b619-41d3-a286-5ac4f53978bf"), "DIAMOND0023", null, 1, "Diamond product description 23", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F9.jpg?alt=media&token=0f4b2e0c-ecf4-4ea8-9047-efe08d5b4e71", 5115000.0, 0.59999999999999998, "Diamond Product 23", 7615000.0, 0, 28, 15115000.0, 2, 33.0, 0 },
                    { new Guid("552b4945-b31b-49ee-b4ef-4eaa905039cb"), "GOLD0024", null, 1, "Gold product description 24", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F10.jpg?alt=media&token=55a92de8-ee5c-42c9-9abe-878a240dd0f1", 1024000.0, 0.5, "Gold Product 24", 1524000.0, 0, 34, 870000.0, 1, 74.0, 0 },
                    { new Guid("5da5ca63-0157-4647-9a0c-614b5b0e1c7f"), "JEWEL0013", null, 1, "Jewel product description 13", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F14.jpg?alt=media&token=f9685ad2-52ff-4c5b-b27d-af7e82831126", 2026000.0, 0.55000000000000004, "Jewel Product 13", 3026000.0, 0, 28, 5026000.0, 3, 33.0, 0 },
                    { new Guid("61aa3e14-6369-442a-9653-f693c737a3b7"), "DIAMOND008", null, 1, "Diamond product description 8", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F9.jpg?alt=media&token=0f4b2e0c-ecf4-4ea8-9047-efe08d5b4e71", 5040000.0, 0.59999999999999998, "Diamond Product 8", 7540000.0, 0, 13, 15040000.0, 2, 18.0, 0 },
                    { new Guid("61f10616-c32f-4ea2-bcd3-0b980ed446bd"), "JEWEL0024", null, 1, "Jewel product description 24", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F10.jpg?alt=media&token=55a92de8-ee5c-42c9-9abe-878a240dd0f1", 2048000.0, 0.55000000000000004, "Jewel Product 24", 3048000.0, 0, 39, 5048000.0, 3, 44.0, 0 },
                    { new Guid("696416c8-0b1d-466d-a6e1-1e3b86da456e"), "DIAMOND0030", null, 1, "Diamond product description 30", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F1.jpg?alt=media&token=edd76054-7ffd-4726-9f57-3a5abe125c10", 5150000.0, 0.59999999999999998, "Diamond Product 30", 7650000.0, 0, 35, 15150000.0, 2, 40.0, 0 },
                    { new Guid("6d7cf018-bc43-4c30-8e93-d4f854f99d03"), "GOLD003", null, 1, "Gold product description 3", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F4.jpg?alt=media&token=d87d662c-f2ff-4dec-ac0a-8da9fb426585", 1003000.0, 0.5, "Gold Product 3", 1503000.0, 0, 13, 765000.0, 1, 53.0, 0 },
                    { new Guid("6db5d553-0b9f-4f03-9ebe-c5942bb63850"), "GOLD006", null, 1, "Gold product description 6", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F7.jpg?alt=media&token=5b91fa57-76a5-4911-820b-86f9b11ebbf9", 1006000.0, 0.5, "Gold Product 6", 1506000.0, 0, 16, 780000.0, 1, 56.0, 0 },
                    { new Guid("70c1662f-1862-4e20-8c81-a587c69902b3"), "DIAMOND0017", null, 1, "Diamond product description 17", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F3.jpg?alt=media&token=f255817b-bc8f-405c-91f8-a5c733b20a16", 5085000.0, 0.59999999999999998, "Diamond Product 17", 7585000.0, 0, 22, 15085000.0, 2, 27.0, 0 },
                    { new Guid("731918db-b643-4bc4-869c-4c8225845cc9"), "JEWEL004", null, 1, "Jewel product description 4", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F5.jpg?alt=media&token=d0f7a320-2176-4b9c-b6b3-df74cbf36baa", 2008000.0, 0.55000000000000004, "Jewel Product 4", 3008000.0, 0, 19, 5008000.0, 3, 24.0, 0 },
                    { new Guid("75a7092c-0134-40a9-908b-a5cefb837c52"), "JEWEL0022", null, 1, "Jewel product description 22", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F8.jpg?alt=media&token=bbe17db6-2209-42ad-86dd-ee2422be3d56", 2044000.0, 0.55000000000000004, "Jewel Product 22", 3044000.0, 0, 37, 5044000.0, 3, 42.0, 0 },
                    { new Guid("75ba1eac-7900-4f58-8332-fcacec3b1b1b"), "GOLD0022", null, 1, "Gold product description 22", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F8.jpg?alt=media&token=bbe17db6-2209-42ad-86dd-ee2422be3d56", 1022000.0, 0.5, "Gold Product 22", 1522000.0, 0, 32, 860000.0, 1, 72.0, 0 },
                    { new Guid("76ec22f3-5b89-445c-a811-6dcb90906f54"), "GOLD0014", null, 1, "Gold product description 14", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F15.jpg?alt=media&token=54605a2e-243b-471a-95be-1636963e915a", 1014000.0, 0.5, "Gold Product 14", 1514000.0, 0, 24, 820000.0, 1, 64.0, 0 },
                    { new Guid("7a380f67-1b8a-4942-8339-81744a45c868"), "JEWEL002", null, 1, "Jewel product description 2", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F3.jpg?alt=media&token=f255817b-bc8f-405c-91f8-a5c733b20a16", 2004000.0, 0.55000000000000004, "Jewel Product 2", 3004000.0, 0, 17, 5004000.0, 3, 22.0, 0 },
                    { new Guid("7c015d32-34ef-4b6e-ac89-5a38a52f3314"), "JEWEL006", null, 1, "Jewel product description 6", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F7.jpg?alt=media&token=5b91fa57-76a5-4911-820b-86f9b11ebbf9", 2012000.0, 0.55000000000000004, "Jewel Product 6", 3012000.0, 0, 21, 5012000.0, 3, 26.0, 0 },
                    { new Guid("7e14cead-4b63-46e3-9986-52c7e951cf38"), "GOLD0015", null, 1, "Gold product description 15", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F1.jpg?alt=media&token=edd76054-7ffd-4726-9f57-3a5abe125c10", 1015000.0, 0.5, "Gold Product 15", 1515000.0, 0, 25, 825000.0, 1, 65.0, 0 },
                    { new Guid("7e6746bb-0fc8-4240-80e9-753c90ff8377"), "JEWEL0016", null, 1, "Jewel product description 16", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F2.jpg?alt=media&token=54f08c6f-e41e-4cde-b6c6-1e40194320a5", 2032000.0, 0.55000000000000004, "Jewel Product 16", 3032000.0, 0, 31, 5032000.0, 3, 36.0, 0 },
                    { new Guid("7ed5a346-c858-4b5a-bff0-e032d90b92d4"), "DIAMOND007", null, 1, "Diamond product description 7", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F8.jpg?alt=media&token=bbe17db6-2209-42ad-86dd-ee2422be3d56", 5035000.0, 0.59999999999999998, "Diamond Product 7", 7535000.0, 0, 12, 15035000.0, 2, 17.0, 0 },
                    { new Guid("81442bb3-eede-452f-81c2-0be31a9e933c"), "JEWEL0014", null, 1, "Jewel product description 14", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F15.jpg?alt=media&token=54605a2e-243b-471a-95be-1636963e915a", 2028000.0, 0.55000000000000004, "Jewel Product 14", 3028000.0, 0, 29, 5028000.0, 3, 34.0, 0 },
                    { new Guid("820a8c79-a6e4-4cc5-9fe1-5abae56bc8aa"), "GOLD001", null, 1, "Gold product description 1", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F2.jpg?alt=media&token=54f08c6f-e41e-4cde-b6c6-1e40194320a5", 1001000.0, 0.5, "Gold Product 1", 1501000.0, 0, 11, 755000.0, 1, 51.0, 0 },
                    { new Guid("834ba31b-cef4-4611-9321-a7c7f459a9fc"), "DIAMOND0014", null, 1, "Diamond product description 14", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F15.jpg?alt=media&token=54605a2e-243b-471a-95be-1636963e915a", 5070000.0, 0.59999999999999998, "Diamond Product 14", 7570000.0, 0, 19, 15070000.0, 2, 24.0, 0 },
                    { new Guid("83b64d25-6c50-4498-a8aa-ac4c34f7b087"), "GOLD0011", null, 1, "Gold product description 11", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 1011000.0, 0.5, "Gold Product 11", 1511000.0, 0, 21, 805000.0, 1, 61.0, 0 },
                    { new Guid("83d2f190-96d9-4069-8770-ab2fed2ce5e3"), "GOLD0020", null, 1, "Gold product description 20", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2FDayChuyenBac.jpg?alt=media&token=4badf84f-4a3c-489a-bf3b-59bd3517dd8a", 1020000.0, 0.5, "Gold Product 20", 1520000.0, 0, 30, 850000.0, 1, 70.0, 0 },
                    { new Guid("8661991d-7743-4a91-b4bc-120af5a540d0"), "DIAMOND004", null, 1, "Diamond product description 4", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F5.jpg?alt=media&token=d0f7a320-2176-4b9c-b6b3-df74cbf36baa", 5020000.0, 0.59999999999999998, "Diamond Product 4", 7520000.0, 0, 9, 15020000.0, 2, 14.0, 0 },
                    { new Guid("88788702-0485-4867-b421-44adbf728fa8"), "GOLD002", null, 1, "Gold product description 2", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F3.jpg?alt=media&token=f255817b-bc8f-405c-91f8-a5c733b20a16", 1002000.0, 0.5, "Gold Product 2", 1502000.0, 0, 12, 760000.0, 1, 52.0, 0 },
                    { new Guid("9177912e-9107-4925-8a18-1d48c4d16bf6"), "JEWEL0029", null, 1, "Jewel product description 29", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F15.jpg?alt=media&token=54605a2e-243b-471a-95be-1636963e915a", 2058000.0, 0.55000000000000004, "Jewel Product 29", 3058000.0, 0, 44, 5058000.0, 3, 49.0, 0 },
                    { new Guid("99e27373-6015-4956-bda9-a0ad99bbede1"), "GOLD007", null, 1, "Gold product description 7", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F8.jpg?alt=media&token=bbe17db6-2209-42ad-86dd-ee2422be3d56", 1007000.0, 0.5, "Gold Product 7", 1507000.0, 0, 17, 785000.0, 1, 57.0, 0 },
                    { new Guid("9ba0b6e7-ba5e-45d5-bf0b-2e89a70b68c8"), "DIAMOND002", null, 1, "Diamond product description 2", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F3.jpg?alt=media&token=f255817b-bc8f-405c-91f8-a5c733b20a16", 5010000.0, 0.59999999999999998, "Diamond Product 2", 7510000.0, 0, 7, 15010000.0, 2, 12.0, 0 },
                    { new Guid("9d5cdbc3-98bb-4229-9e6d-2758f605d454"), "GOLD0012", null, 1, "Gold product description 12", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 1012000.0, 0.5, "Gold Product 12", 1512000.0, 0, 22, 810000.0, 1, 62.0, 0 },
                    { new Guid("9dcd63a8-f5bc-4ee7-a027-8ceae6d28a28"), "GOLD0019", null, 1, "Gold product description 19", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F5.jpg?alt=media&token=d0f7a320-2176-4b9c-b6b3-df74cbf36baa", 1019000.0, 0.5, "Gold Product 19", 1519000.0, 0, 29, 845000.0, 1, 69.0, 0 },
                    { new Guid("a143677e-a0e7-491d-a37c-dbac24144649"), "DIAMOND0026", null, 1, "Diamond product description 26", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 5130000.0, 0.59999999999999998, "Diamond Product 26", 7630000.0, 0, 31, 15130000.0, 2, 36.0, 0 },
                    { new Guid("ab93e336-a8df-4b35-b8d7-dd068f476f79"), "DIAMOND0024", null, 1, "Diamond product description 24", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F10.jpg?alt=media&token=55a92de8-ee5c-42c9-9abe-878a240dd0f1", 5120000.0, 0.59999999999999998, "Diamond Product 24", 7620000.0, 0, 29, 15120000.0, 2, 34.0, 0 },
                    { new Guid("ada33166-20fd-45ba-a0a3-b9fefb75dbf0"), "GOLD0017", null, 1, "Gold product description 17", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F3.jpg?alt=media&token=f255817b-bc8f-405c-91f8-a5c733b20a16", 1017000.0, 0.5, "Gold Product 17", 1517000.0, 0, 27, 835000.0, 1, 67.0, 0 },
                    { new Guid("b280a02a-ea23-4cce-93e7-c83a239fcc40"), "GOLD0021", null, 1, "Gold product description 21", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F7.jpg?alt=media&token=5b91fa57-76a5-4911-820b-86f9b11ebbf9", 1021000.0, 0.5, "Gold Product 21", 1521000.0, 0, 31, 855000.0, 1, 71.0, 0 },
                    { new Guid("b299e670-5004-4a89-9e61-8b8d99221602"), "DIAMOND0020", null, 1, "Diamond product description 20", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2FDayChuyenBac.jpg?alt=media&token=4badf84f-4a3c-489a-bf3b-59bd3517dd8a", 5100000.0, 0.59999999999999998, "Diamond Product 20", 7600000.0, 0, 25, 15100000.0, 2, 30.0, 0 },
                    { new Guid("b4021e09-d847-44b9-9f4b-7d518850db56"), "GOLD0028", null, 1, "Gold product description 28", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F14.jpg?alt=media&token=f9685ad2-52ff-4c5b-b27d-af7e82831126", 1028000.0, 0.5, "Gold Product 28", 1528000.0, 0, 38, 890000.0, 1, 78.0, 0 },
                    { new Guid("bdbce0c9-2a78-4b9f-8cd5-1a685082e724"), "GOLD0016", null, 1, "Gold product description 16", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F2.jpg?alt=media&token=54f08c6f-e41e-4cde-b6c6-1e40194320a5", 1016000.0, 0.5, "Gold Product 16", 1516000.0, 0, 26, 830000.0, 1, 66.0, 0 },
                    { new Guid("bf312650-b452-417f-b1ec-96c48845441e"), "JEWEL0019", null, 1, "Jewel product description 19", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F5.jpg?alt=media&token=d0f7a320-2176-4b9c-b6b3-df74cbf36baa", 2038000.0, 0.55000000000000004, "Jewel Product 19", 3038000.0, 0, 34, 5038000.0, 3, 39.0, 0 },
                    { new Guid("c09ab8f2-c3b2-4e4b-9661-fa50de6850dd"), "JEWEL008", null, 1, "Jewel product description 8", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F9.jpg?alt=media&token=0f4b2e0c-ecf4-4ea8-9047-efe08d5b4e71", 2016000.0, 0.55000000000000004, "Jewel Product 8", 3016000.0, 0, 23, 5016000.0, 3, 28.0, 0 },
                    { new Guid("c33713b4-8204-4060-ac6b-f99c9bede697"), "GOLD0027", null, 1, "Gold product description 27", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 1027000.0, 0.5, "Gold Product 27", 1527000.0, 0, 37, 885000.0, 1, 77.0, 0 },
                    { new Guid("c55ff7b9-904e-4f7c-a83d-a7fc8fbdb5eb"), "JEWEL0010", null, 1, "Jewel product description 10", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F11.jpg?alt=media&token=7afc835a-dc04-491f-a922-14f97c05ad47", 2020000.0, 0.55000000000000004, "Jewel Product 10", 3020000.0, 0, 25, 5020000.0, 3, 30.0, 0 },
                    { new Guid("c6540a8a-b078-4b60-ae82-bb04a435c847"), "JEWEL0025", null, 1, "Jewel product description 25", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F11.jpg?alt=media&token=7afc835a-dc04-491f-a922-14f97c05ad47", 2050000.0, 0.55000000000000004, "Jewel Product 25", 3050000.0, 0, 40, 5050000.0, 3, 45.0, 0 },
                    { new Guid("c8f046eb-b837-424b-9b3a-1ae080a7f907"), "DIAMOND0015", null, 1, "Diamond product description 15", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F1.jpg?alt=media&token=edd76054-7ffd-4726-9f57-3a5abe125c10", 5075000.0, 0.59999999999999998, "Diamond Product 15", 7575000.0, 0, 20, 15075000.0, 2, 25.0, 0 },
                    { new Guid("cb67c597-27cc-4e24-b0be-ed15854bb31f"), "GOLD008", null, 1, "Gold product description 8", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F9.jpg?alt=media&token=0f4b2e0c-ecf4-4ea8-9047-efe08d5b4e71", 1008000.0, 0.5, "Gold Product 8", 1508000.0, 0, 18, 790000.0, 1, 58.0, 0 },
                    { new Guid("cd5aa324-5c30-49af-99e4-0713eb5926a8"), "DIAMOND0018", null, 1, "Diamond product description 18", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F4.jpg?alt=media&token=d87d662c-f2ff-4dec-ac0a-8da9fb426585", 5090000.0, 0.59999999999999998, "Diamond Product 18", 7590000.0, 0, 23, 15090000.0, 2, 28.0, 0 },
                    { new Guid("d139a88e-d471-49dd-9b6c-2c6c42b882fa"), "GOLD0030", null, 1, "Gold product description 30", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F1.jpg?alt=media&token=edd76054-7ffd-4726-9f57-3a5abe125c10", 1030000.0, 0.5, "Gold Product 30", 1530000.0, 0, 40, 900000.0, 1, 80.0, 0 },
                    { new Guid("d2b67426-61b6-476c-876d-00e59673af35"), "JEWEL0011", null, 1, "Jewel product description 11", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 2022000.0, 0.55000000000000004, "Jewel Product 11", 3022000.0, 0, 26, 5022000.0, 3, 31.0, 0 },
                    { new Guid("d4852069-fb6f-4b39-964c-71b0d16797a3"), "JEWEL0030", null, 1, "Jewel product description 30", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F1.jpg?alt=media&token=edd76054-7ffd-4726-9f57-3a5abe125c10", 2060000.0, 0.55000000000000004, "Jewel Product 30", 3060000.0, 0, 45, 5060000.0, 3, 50.0, 0 },
                    { new Guid("d671c688-1a3d-457f-8a8b-8d334361eaa9"), "JEWEL0023", null, 1, "Jewel product description 23", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F9.jpg?alt=media&token=0f4b2e0c-ecf4-4ea8-9047-efe08d5b4e71", 2046000.0, 0.55000000000000004, "Jewel Product 23", 3046000.0, 0, 38, 5046000.0, 3, 43.0, 0 },
                    { new Guid("da051611-f093-45af-8df2-1931a4c74902"), "JEWEL0028", null, 1, "Jewel product description 28", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F14.jpg?alt=media&token=f9685ad2-52ff-4c5b-b27d-af7e82831126", 2056000.0, 0.55000000000000004, "Jewel Product 28", 3056000.0, 0, 43, 5056000.0, 3, 48.0, 0 },
                    { new Guid("da44cf1f-e119-4589-a32e-01770b9bbfb7"), "DIAMOND0022", null, 1, "Diamond product description 22", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F8.jpg?alt=media&token=bbe17db6-2209-42ad-86dd-ee2422be3d56", 5110000.0, 0.59999999999999998, "Diamond Product 22", 7610000.0, 0, 27, 15110000.0, 2, 32.0, 0 },
                    { new Guid("dafe4d3c-b554-4e08-ace4-2b9bf3201ce8"), "GOLD0018", null, 1, "Gold product description 18", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F4.jpg?alt=media&token=d87d662c-f2ff-4dec-ac0a-8da9fb426585", 1018000.0, 0.5, "Gold Product 18", 1518000.0, 0, 28, 840000.0, 1, 68.0, 0 },
                    { new Guid("e2a25696-5e47-46df-8fba-47a15a4f08d0"), "DIAMOND0012", null, 1, "Diamond product description 12", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 5060000.0, 0.59999999999999998, "Diamond Product 12", 7560000.0, 0, 17, 15060000.0, 2, 22.0, 0 },
                    { new Guid("e3664577-7e60-4dbf-8db7-19fe73771d53"), "DIAMOND003", null, 1, "Diamond product description 3", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F4.jpg?alt=media&token=d87d662c-f2ff-4dec-ac0a-8da9fb426585", 5015000.0, 0.59999999999999998, "Diamond Product 3", 7515000.0, 0, 8, 15015000.0, 2, 13.0, 0 },
                    { new Guid("e3933d73-8886-4c95-add6-7a26ee7831e0"), "GOLD009", null, 1, "Gold product description 9", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F10.jpg?alt=media&token=55a92de8-ee5c-42c9-9abe-878a240dd0f1", 1009000.0, 0.5, "Gold Product 9", 1509000.0, 0, 19, 795000.0, 1, 59.0, 0 },
                    { new Guid("e94e5071-104e-4331-9f9f-f836ff592331"), "DIAMOND0013", null, 1, "Diamond product description 13", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F14.jpg?alt=media&token=f9685ad2-52ff-4c5b-b27d-af7e82831126", 5065000.0, 0.59999999999999998, "Diamond Product 13", 7565000.0, 0, 18, 15065000.0, 2, 23.0, 0 },
                    { new Guid("f95d5004-26b8-4a3b-993c-d5fccc5f9343"), "JEWEL0026", null, 1, "Jewel product description 26", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 2052000.0, 0.55000000000000004, "Jewel Product 26", 3052000.0, 0, 41, 5052000.0, 3, 46.0, 0 },
                    { new Guid("fb48c29a-32ad-43a6-bfad-06668a73f49d"), "JEWEL0018", null, 1, "Jewel product description 18", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F4.jpg?alt=media&token=d87d662c-f2ff-4dec-ac0a-8da9fb426585", 2036000.0, 0.55000000000000004, "Jewel Product 18", 3036000.0, 0, 33, 5036000.0, 3, 38.0, 0 },
                    { new Guid("fb58fcf0-3fd5-4e04-9d77-e8487d374042"), "GOLD0013", null, 1, "Gold product description 13", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F14.jpg?alt=media&token=f9685ad2-52ff-4c5b-b27d-af7e82831126", 1013000.0, 0.5, "Gold Product 13", 1513000.0, 0, 23, 815000.0, 1, 63.0, 0 },
                    { new Guid("fc73f121-6eab-45c4-99b1-ee6bfbb71ea8"), "DIAMOND0027", null, 1, "Diamond product description 27", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd", 5135000.0, 0.59999999999999998, "Diamond Product 27", 7635000.0, 0, 32, 15135000.0, 2, 37.0, 0 },
                    { new Guid("fc839d64-3248-4e87-86e9-3b9474993b15"), "GOLD0023", null, 1, "Gold product description 23", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F9.jpg?alt=media&token=0f4b2e0c-ecf4-4ea8-9047-efe08d5b4e71", 1023000.0, 0.5, "Gold Product 23", 1523000.0, 0, 33, 865000.0, 1, 73.0, 0 },
                    { new Guid("fe697019-fe38-4b1b-9fdb-236ae48a852e"), "GOLD0025", null, 1, "Gold product description 25", "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F11.jpg?alt=media&token=7afc835a-dc04-491f-a922-14f97c05ad47", 1025000.0, 0.5, "Gold Product 25", 1525000.0, 0, 35, 875000.0, 1, 75.0, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionCode",
                keyValue: "Promotion 01",
                column: "EndDate",
                value: new DateTime(2024, 7, 25, 8, 33, 46, 661, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionCode",
                keyValue: "Promotion 02",
                column: "EndDate",
                value: new DateTime(2024, 7, 5, 8, 33, 46, 661, DateTimeKind.Utc).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionCode",
                keyValue: "Promotion 03",
                column: "EndDate",
                value: new DateTime(2024, 7, 5, 8, 33, 46, 661, DateTimeKind.Utc).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2024, 7, 15, 8, 33, 46, 661, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2024, 7, 15, 8, 33, 46, 661, DateTimeKind.Utc).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2024, 7, 15, 8, 33, 46, 661, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 4,
                columns: new[] { "DateUpdated", "TypeName" },
                values: new object[] { new DateTime(2024, 7, 15, 8, 33, 46, 661, DateTimeKind.Utc).AddTicks(4040), "Vàng nhẫn SJC 99,99 1 chỉ, 2 chỉ, 5 chỉ" });

            migrationBuilder.UpdateData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 5,
                columns: new[] { "DateUpdated", "TypeName" },
                values: new object[] { new DateTime(2024, 7, 15, 8, 33, 46, 661, DateTimeKind.Utc).AddTicks(4050), "Vàng nhẫn SJC 99,99 0,3 chỉ, 0,5 chỉ" });

            migrationBuilder.UpdateData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 6,
                columns: new[] { "DateUpdated", "TypeName" },
                values: new object[] { new DateTime(2024, 7, 15, 8, 33, 46, 661, DateTimeKind.Utc).AddTicks(4060), "Vàng nữ trang 99,99%" });

            migrationBuilder.UpdateData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 7,
                columns: new[] { "DateUpdated", "TypeName" },
                values: new object[] { new DateTime(2024, 7, 15, 8, 33, 46, 661, DateTimeKind.Utc).AddTicks(4060), "Vàng nữ trang 99%" });

            migrationBuilder.InsertData(
                table: "TypePrices",
                columns: new[] { "TypeId", "BuyPricePerGram", "DateUpdated", "SellPricePerGram", "TypeName" },
                values: new object[,]
                {
                    { 8, 0.0, new DateTime(2024, 7, 15, 8, 33, 46, 661, DateTimeKind.Utc).AddTicks(4070), 0.0, "Vàng nữ trang 75%" },
                    { 9, 0.0, new DateTime(2024, 7, 15, 8, 33, 46, 661, DateTimeKind.Utc).AddTicks(4080), 0.0, "Vàng nữ trang 58,3%" },
                    { 10, 0.0, new DateTime(2024, 7, 15, 8, 33, 46, 661, DateTimeKind.Utc).AddTicks(4090), 0.0, "Vàng nữ trang 41,7%" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("106bb060-7216-49a3-9a2a-b5dd277e2f00"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("50e47e43-3920-4410-8c2e-8f4b2057a6e4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("9c55d35a-952d-465e-a61a-4cd29c228ee9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ba478046-1203-448a-accc-dc05379fa38d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("63c01856-a5b5-4361-8daf-2ffbfe173ddd"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("7116fb6e-d97e-4265-b8fe-03ae772b7903"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("a41e1289-d7e4-4bf7-8709-009498b73f43"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("d28230fc-2771-4565-927c-0b4d933ba598"));

            migrationBuilder.DeleteData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: new Guid("165cdb54-48d1-479f-b60e-f76bc785de8c"));

            migrationBuilder.DeleteData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: new Guid("3521f378-14fe-430c-9021-0760b74759ed"));

            migrationBuilder.DeleteData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: new Guid("4376f2bc-ccee-45c9-a206-ce10ac730d63"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("00791dce-9449-489c-9e0d-22b3ebcb1d77"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1358afa9-ca8f-49a7-866f-8c62504311c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("148fcd0e-4a7e-43cf-968a-0b71a2fcd097"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("179547d5-b37a-4f83-95f6-bd998398b29f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1d10a1ea-864b-49cb-97ea-d658fe9822d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("21f39ce3-613f-47e0-9a7c-7dbb45749a76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("242aac4a-e67e-4720-859b-b85dd908877d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("24742873-f787-4f76-b6fc-acd101667033"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("27f356a6-f6c6-4084-a2e7-074b4814c3bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("302b1dde-9abf-4aad-afc6-3a9508a04169"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("31c63c64-ad74-4f6e-b26e-c1dc27e8564e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3644579e-a2c2-4b1a-b89f-c09ca842c5e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("38d0ec54-9366-4707-8ee1-8b94ce390f35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("392b947c-e86b-4c3b-88c7-24d5dbca07d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("39f5f1c1-4f6b-4934-995a-099ec3a34942"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3a5d542d-b232-4049-9f6f-e62657f36649"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3b70efec-b8de-4866-967d-d0c0e9ba6eca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3cf073f5-7835-40be-92eb-545e1e093555"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3f480a9b-e078-4dd2-911a-d699a05c3fe3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("42d48c93-edf7-4598-ba7b-2a84f9946618"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4345658c-15ee-4997-952f-142a238e2d9a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("44caeea7-969e-42b9-b536-4a5974d9db4e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("45c0ed4a-2de1-43cd-a634-90f8e7115d71"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("48a35665-944b-4143-9813-daa984454aed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4c08b875-01c4-4281-8e0d-35d0f22fa7ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4cdd551a-a5fd-4fe3-a998-4755f03c22cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f326d1d-8419-4af6-a91f-0aba6238f40e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("51ac2b26-77ae-4157-8cee-2f7af0ce7834"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("51d83d7d-b619-41d3-a286-5ac4f53978bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("552b4945-b31b-49ee-b4ef-4eaa905039cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5da5ca63-0157-4647-9a0c-614b5b0e1c7f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("61aa3e14-6369-442a-9653-f693c737a3b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("61f10616-c32f-4ea2-bcd3-0b980ed446bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("696416c8-0b1d-466d-a6e1-1e3b86da456e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6d7cf018-bc43-4c30-8e93-d4f854f99d03"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6db5d553-0b9f-4f03-9ebe-c5942bb63850"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("70c1662f-1862-4e20-8c81-a587c69902b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("731918db-b643-4bc4-869c-4c8225845cc9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("75a7092c-0134-40a9-908b-a5cefb837c52"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("75ba1eac-7900-4f58-8332-fcacec3b1b1b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("76ec22f3-5b89-445c-a811-6dcb90906f54"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7a380f67-1b8a-4942-8339-81744a45c868"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7c015d32-34ef-4b6e-ac89-5a38a52f3314"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7e14cead-4b63-46e3-9986-52c7e951cf38"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7e6746bb-0fc8-4240-80e9-753c90ff8377"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7ed5a346-c858-4b5a-bff0-e032d90b92d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("81442bb3-eede-452f-81c2-0be31a9e933c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("820a8c79-a6e4-4cc5-9fe1-5abae56bc8aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("834ba31b-cef4-4611-9321-a7c7f459a9fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("83b64d25-6c50-4498-a8aa-ac4c34f7b087"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("83d2f190-96d9-4069-8770-ab2fed2ce5e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8661991d-7743-4a91-b4bc-120af5a540d0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("88788702-0485-4867-b421-44adbf728fa8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9177912e-9107-4925-8a18-1d48c4d16bf6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("99e27373-6015-4956-bda9-a0ad99bbede1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9ba0b6e7-ba5e-45d5-bf0b-2e89a70b68c8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9d5cdbc3-98bb-4229-9e6d-2758f605d454"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9dcd63a8-f5bc-4ee7-a027-8ceae6d28a28"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a143677e-a0e7-491d-a37c-dbac24144649"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ab93e336-a8df-4b35-b8d7-dd068f476f79"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ada33166-20fd-45ba-a0a3-b9fefb75dbf0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b280a02a-ea23-4cce-93e7-c83a239fcc40"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b299e670-5004-4a89-9e61-8b8d99221602"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b4021e09-d847-44b9-9f4b-7d518850db56"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bdbce0c9-2a78-4b9f-8cd5-1a685082e724"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bf312650-b452-417f-b1ec-96c48845441e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c09ab8f2-c3b2-4e4b-9661-fa50de6850dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c33713b4-8204-4060-ac6b-f99c9bede697"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c55ff7b9-904e-4f7c-a83d-a7fc8fbdb5eb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c6540a8a-b078-4b60-ae82-bb04a435c847"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c8f046eb-b837-424b-9b3a-1ae080a7f907"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cb67c597-27cc-4e24-b0be-ed15854bb31f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cd5aa324-5c30-49af-99e4-0713eb5926a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d139a88e-d471-49dd-9b6c-2c6c42b882fa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d2b67426-61b6-476c-876d-00e59673af35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d4852069-fb6f-4b39-964c-71b0d16797a3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d671c688-1a3d-457f-8a8b-8d334361eaa9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("da051611-f093-45af-8df2-1931a4c74902"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("da44cf1f-e119-4589-a32e-01770b9bbfb7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dafe4d3c-b554-4e08-ace4-2b9bf3201ce8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e2a25696-5e47-46df-8fba-47a15a4f08d0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e3664577-7e60-4dbf-8db7-19fe73771d53"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e3933d73-8886-4c95-add6-7a26ee7831e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e94e5071-104e-4331-9f9f-f836ff592331"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f95d5004-26b8-4a3b-993c-d5fccc5f9343"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fb48c29a-32ad-43a6-bfad-06668a73f49d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fb58fcf0-3fd5-4e04-9d77-e8487d374042"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fc73f121-6eab-45c4-99b1-ee6bfbb71ea8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fc839d64-3248-4e87-86e9-3b9474993b15"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fe697019-fe38-4b1b-9fdb-236ae48a852e"));

            migrationBuilder.DeleteData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 10);

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

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionCode",
                keyValue: "Promotion 01",
                column: "EndDate",
                value: new DateTime(2024, 7, 25, 3, 55, 59, 400, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionCode",
                keyValue: "Promotion 02",
                column: "EndDate",
                value: new DateTime(2024, 7, 5, 3, 55, 59, 400, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionCode",
                keyValue: "Promotion 03",
                column: "EndDate",
                value: new DateTime(2024, 7, 5, 3, 55, 59, 400, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2024, 7, 15, 3, 55, 59, 400, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2024, 7, 15, 3, 55, 59, 400, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2024, 7, 15, 3, 55, 59, 400, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 4,
                columns: new[] { "DateUpdated", "TypeName" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 55, 59, 400, DateTimeKind.Utc).AddTicks(4620), "Vàng SJC 1 chỉ" });

            migrationBuilder.UpdateData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 5,
                columns: new[] { "DateUpdated", "TypeName" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 55, 59, 400, DateTimeKind.Utc).AddTicks(4630), "Vàng SJC 1 lượng" });

            migrationBuilder.UpdateData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 6,
                columns: new[] { "DateUpdated", "TypeName" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 55, 59, 400, DateTimeKind.Utc).AddTicks(4640), "Nhẫn 1 chỉ SJC" });

            migrationBuilder.UpdateData(
                table: "TypePrices",
                keyColumn: "TypeId",
                keyValue: 7,
                columns: new[] { "DateUpdated", "TypeName" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 55, 59, 400, DateTimeKind.Utc).AddTicks(4650), "Trang sức 49 SJC" });
        }
    }
}
