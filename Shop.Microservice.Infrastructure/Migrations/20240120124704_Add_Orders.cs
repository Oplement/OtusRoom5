using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop.Microservice.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add_Orders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: new Guid("d015340e-c4f6-4811-ad3d-f1ebaf34e045"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3dc00c51-b4d1-4125-9ecb-3654e7999c42"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("499b48f1-96c9-403a-ac4f-1904f0c18373"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6414ec27-a655-4a17-a881-9ede558f3ce2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("675ab91b-452b-4884-8295-b84833cad7b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b72e8668-3216-49cf-bc61-068a5642337a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1aaf73b-78f7-4fd8-8efd-b93afbfc4783"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3b33a56-3055-4397-9d2f-2cc8576dd9bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e20b1320-7797-4805-b810-3b44dea1bfc0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e4aeea7e-c6ba-4eaf-883f-75a17ccdc640"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b26a145c-31d4-4675-9cf9-a427ad7eedd7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0bbe3279-c760-452c-bf13-71e45fcddb3b"));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreateAt", "OrderStatus", "UserId" },
                values: new object[] { new Guid("e146cf70-b4c4-4091-b5d1-b419734d6ab6"), new DateTime(2024, 1, 20, 12, 47, 4, 449, DateTimeKind.Utc).AddTicks(8567), 0, new Guid("a2a7dcb7-49fd-4ab9-bd00-b05d31a12d3e") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "Description", "Image", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("1bfe8d6e-a4d6-4866-b3ac-49d64ac35891"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("29b0a017-066c-4401-a10b-31b85bec04c4"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("36a924f9-f2d7-4d76-9899-4149c71796a5"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("4b3303fe-c54b-4a57-98ae-f3ace1f0e526"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("4f756387-efaf-486c-96f6-b155bb8d9123"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("51396119-054d-4444-9386-7ec3e0ab06bb"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("bca78a38-49c6-44b1-90ab-6d60afdb52b0"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("d194050b-e905-49e4-a62f-30d99d484a66"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("dcb97a79-459c-4d31-b884-6acd8ef7f874"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("f5f45321-6d1b-4f20-b0ad-b9406a84d94d"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" }
                });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "Id", "Count", "OrderId", "ProductId" },
                values: new object[] { new Guid("1d5f42cb-1f8a-4087-9830-cd05a6688daf"), 1, new Guid("e146cf70-b4c4-4091-b5d1-b419734d6ab6"), new Guid("dcb97a79-459c-4d31-b884-6acd8ef7f874") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: new Guid("1d5f42cb-1f8a-4087-9830-cd05a6688daf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1bfe8d6e-a4d6-4866-b3ac-49d64ac35891"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("29b0a017-066c-4401-a10b-31b85bec04c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36a924f9-f2d7-4d76-9899-4149c71796a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b3303fe-c54b-4a57-98ae-f3ace1f0e526"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f756387-efaf-486c-96f6-b155bb8d9123"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51396119-054d-4444-9386-7ec3e0ab06bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bca78a38-49c6-44b1-90ab-6d60afdb52b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d194050b-e905-49e4-a62f-30d99d484a66"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5f45321-6d1b-4f20-b0ad-b9406a84d94d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e146cf70-b4c4-4091-b5d1-b419734d6ab6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcb97a79-459c-4d31-b884-6acd8ef7f874"));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreateAt", "OrderStatus", "UserId" },
                values: new object[] { new Guid("b26a145c-31d4-4675-9cf9-a427ad7eedd7"), new DateTime(2024, 1, 20, 15, 43, 15, 976, DateTimeKind.Local).AddTicks(9241), 0, new Guid("a2a7dcb7-49fd-4ab9-bd00-b05d31a12d3e") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "Description", "Image", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("0bbe3279-c760-452c-bf13-71e45fcddb3b"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("3dc00c51-b4d1-4125-9ecb-3654e7999c42"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("499b48f1-96c9-403a-ac4f-1904f0c18373"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("6414ec27-a655-4a17-a881-9ede558f3ce2"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("675ab91b-452b-4884-8295-b84833cad7b3"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("b72e8668-3216-49cf-bc61-068a5642337a"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("c1aaf73b-78f7-4fd8-8efd-b93afbfc4783"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("d3b33a56-3055-4397-9d2f-2cc8576dd9bc"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("e20b1320-7797-4805-b810-3b44dea1bfc0"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("e4aeea7e-c6ba-4eaf-883f-75a17ccdc640"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" }
                });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "Id", "Count", "OrderId", "ProductId" },
                values: new object[] { new Guid("d015340e-c4f6-4811-ad3d-f1ebaf34e045"), 1, new Guid("b26a145c-31d4-4675-9cf9-a427ad7eedd7"), new Guid("0bbe3279-c760-452c-bf13-71e45fcddb3b") });
        }
    }
}
