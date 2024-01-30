using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop.Microservice.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Balances",
                columns: new[] { "Id", "Amount", "AmountForSend", "UserId" },
                values: new object[,]
                {
                    { new Guid("3cb5940e-87f0-4b75-a820-08f17cffada1"), 20.0, 200.0, new Guid("a2a7dcb7-49fd-4ab9-bd00-b05d31a19d3e") },
                    { new Guid("c26e3c4b-a5ae-4271-968c-a1a57281b4c8"), 10.0, 100.0, new Guid("a2a7dcb7-49fd-4ab9-bd00-b05d31a12d3e") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreateAt", "OrderStatus", "UserId" },
                values: new object[] { new Guid("deb9e453-48a8-4e45-b2df-c75dc062bc18"), new DateTime(2024, 1, 29, 19, 55, 9, 690, DateTimeKind.Utc).AddTicks(7121), 0, new Guid("a2a7dcb7-49fd-4ab9-bd00-b05d31a12d3e") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "Description", "Image", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("2067e886-ec57-4592-93e6-03e4ef59fe35"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("5405b1c7-b492-4a80-8421-50ac44dea656"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("6e3e1faf-4f7f-45b4-b170-2efdb25883ca"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("8948b2a3-a264-4cb7-8345-646e5e33ca3f"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("95d9c951-486d-4dbd-b318-473e86e18795"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("970c38cd-d58b-45f8-9453-f0496b168bb8"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("9a6204f3-498e-418f-9868-99281c9899f8"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("d35d0fc0-f16f-42c2-a34a-3b6a1aec2b1e"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("d437a0dd-699f-4443-8860-33580ffcdbe4"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("f471ef19-1e1e-414a-9494-dbb80c42ed40"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" }
                });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "Id", "Count", "OrderId", "ProductId" },
                values: new object[] { new Guid("0d30ebcf-3584-4e41-97f6-2c96a8e7a21c"), 1, new Guid("deb9e453-48a8-4e45-b2df-c75dc062bc18"), new Guid("8948b2a3-a264-4cb7-8345-646e5e33ca3f") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Balances",
                keyColumn: "Id",
                keyValue: new Guid("3cb5940e-87f0-4b75-a820-08f17cffada1"));

            migrationBuilder.DeleteData(
                table: "Balances",
                keyColumn: "Id",
                keyValue: new Guid("c26e3c4b-a5ae-4271-968c-a1a57281b4c8"));

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: new Guid("0d30ebcf-3584-4e41-97f6-2c96a8e7a21c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2067e886-ec57-4592-93e6-03e4ef59fe35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5405b1c7-b492-4a80-8421-50ac44dea656"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e3e1faf-4f7f-45b4-b170-2efdb25883ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("95d9c951-486d-4dbd-b318-473e86e18795"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("970c38cd-d58b-45f8-9453-f0496b168bb8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a6204f3-498e-418f-9868-99281c9899f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d35d0fc0-f16f-42c2-a34a-3b6a1aec2b1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d437a0dd-699f-4443-8860-33580ffcdbe4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f471ef19-1e1e-414a-9494-dbb80c42ed40"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("deb9e453-48a8-4e45-b2df-c75dc062bc18"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8948b2a3-a264-4cb7-8345-646e5e33ca3f"));

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
    }
}
