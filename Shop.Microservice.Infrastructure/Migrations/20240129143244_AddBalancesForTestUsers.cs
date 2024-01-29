using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop.Microservice.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddBalancesForTestUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: new Guid("ca1a589c-c910-4b05-a0c7-d9d3b0133d7d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("134e0b76-e7fa-4270-9e04-4b1ef0f457e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3479e045-1bf4-4ffb-9c89-31089731a7f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50723628-8ee8-4be4-b9e3-f886583b24d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54500673-7747-4aec-a399-d956b6d6a2c8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57e37102-d86e-454b-adde-ab7b9c04735f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad4a157e-704d-4373-886f-a3f1de02339f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae12c72c-dae1-40eb-b7b1-adebb8a56ecd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ccc3ff8b-f4a0-41d2-84ec-93035580b602"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e870e54c-8ac9-4219-9e44-8dc867640e06"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4486afc4-e675-4797-924d-c63ac228c5d3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37947963-eedf-4d80-999e-7698c7f2b399"));

            migrationBuilder.InsertData(
                table: "Balances",
                columns: new[] { "Id", "Amount", "AmountForSend", "UserId" },
                values: new object[,]
                {
                    { new Guid("40e3e3f5-be39-4db9-827b-c42c4a0ea0f4"), 20.0, 200.0, new Guid("a2a7dcb7-49fd-4ab9-bd00-b05d31a19d3e") },
                    { new Guid("97fd21fb-ebbc-4f7e-96e1-7a3f5545a19e"), 10.0, 100.0, new Guid("a2a7dcb7-49fd-4ab9-bd00-b05d31a12d3e") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreateAt", "OrderStatus", "UserId" },
                values: new object[] { new Guid("662a4810-254c-4574-acbe-8b3bc12cf1cb"), new DateTime(2024, 1, 29, 14, 32, 43, 812, DateTimeKind.Utc).AddTicks(3017), 0, new Guid("a2a7dcb7-49fd-4ab9-bd00-b05d31a12d3e") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "Description", "Image", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("12cc0a90-2e23-46f0-bf89-3392331ad1fd"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("2a8a3ff6-6ee2-4fd8-a3e9-c9eaa1011937"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("4d66d925-31eb-4ec8-8c63-14fa4a52e89d"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("640e3e8a-db87-4fa4-a245-0e9cb5d82ec4"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("6b3959f9-ad81-45ed-be1d-805568344a2a"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("989f7bcd-9459-4955-9076-2f34cb7185d6"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("c507c9d4-be90-450c-ba6a-1c76674b8f5e"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("d7d33e05-d220-4eef-b7f1-8e53c16f8347"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("e06b6537-d4a7-46d4-a1b3-c067f5929d0c"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("fa72d29a-3e6c-46e1-bcfd-7b6066d2fc0a"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" }
                });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "Id", "Count", "OrderId", "ProductId" },
                values: new object[] { new Guid("c12bbbba-6504-4d36-b12e-e0f1fa397d13"), 1, new Guid("662a4810-254c-4574-acbe-8b3bc12cf1cb"), new Guid("2a8a3ff6-6ee2-4fd8-a3e9-c9eaa1011937") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Balances",
                keyColumn: "Id",
                keyValue: new Guid("40e3e3f5-be39-4db9-827b-c42c4a0ea0f4"));

            migrationBuilder.DeleteData(
                table: "Balances",
                keyColumn: "Id",
                keyValue: new Guid("97fd21fb-ebbc-4f7e-96e1-7a3f5545a19e"));

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: new Guid("c12bbbba-6504-4d36-b12e-e0f1fa397d13"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12cc0a90-2e23-46f0-bf89-3392331ad1fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d66d925-31eb-4ec8-8c63-14fa4a52e89d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("640e3e8a-db87-4fa4-a245-0e9cb5d82ec4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b3959f9-ad81-45ed-be1d-805568344a2a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("989f7bcd-9459-4955-9076-2f34cb7185d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c507c9d4-be90-450c-ba6a-1c76674b8f5e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d7d33e05-d220-4eef-b7f1-8e53c16f8347"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e06b6537-d4a7-46d4-a1b3-c067f5929d0c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa72d29a-3e6c-46e1-bcfd-7b6066d2fc0a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("662a4810-254c-4574-acbe-8b3bc12cf1cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a8a3ff6-6ee2-4fd8-a3e9-c9eaa1011937"));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreateAt", "OrderStatus", "UserId" },
                values: new object[] { new Guid("4486afc4-e675-4797-924d-c63ac228c5d3"), new DateTime(2024, 1, 28, 19, 19, 11, 37, DateTimeKind.Utc).AddTicks(3413), 0, new Guid("a2a7dcb7-49fd-4ab9-bd00-b05d31a12d3e") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "Description", "Image", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("134e0b76-e7fa-4270-9e04-4b1ef0f457e2"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("3479e045-1bf4-4ffb-9c89-31089731a7f9"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("37947963-eedf-4d80-999e-7698c7f2b399"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("50723628-8ee8-4be4-b9e3-f886583b24d4"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("54500673-7747-4aec-a399-d956b6d6a2c8"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("57e37102-d86e-454b-adde-ab7b9c04735f"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("ad4a157e-704d-4373-886f-a3f1de02339f"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("ae12c72c-dae1-40eb-b7b1-adebb8a56ecd"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("ccc3ff8b-f4a0-41d2-84ec-93035580b602"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("e870e54c-8ac9-4219-9e44-8dc867640e06"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" }
                });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "Id", "Count", "OrderId", "ProductId" },
                values: new object[] { new Guid("ca1a589c-c910-4b05-a0c7-d9d3b0133d7d"), 1, new Guid("4486afc4-e675-4797-924d-c63ac228c5d3"), new Guid("37947963-eedf-4d80-999e-7698c7f2b399") });
        }
    }
}
