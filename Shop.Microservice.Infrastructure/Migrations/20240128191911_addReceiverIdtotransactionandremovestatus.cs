using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop.Microservice.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addReceiverIdtotransactionandremovestatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "TransactionStatus",
                table: "Transactions");

            migrationBuilder.AddColumn<Guid>(
                name: "ReceiverID",
                table: "Transactions",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ReceiverID",
                table: "Transactions");

            migrationBuilder.AddColumn<int>(
                name: "TransactionStatus",
                table: "Transactions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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
    }
}
