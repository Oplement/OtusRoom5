using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop.Microservice.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addCount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2abe378b-1952-48a5-afad-ff055ac05cc4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("81131536-68ff-4624-a1ba-dc3d93fb69a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("869a2674-1dbf-41e6-b964-00d9f3e7c903"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e3a0892-9d18-4ca7-be8b-f7485de149ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9cfc38b6-1d6f-4084-b2ce-bc7bf42773ee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab7ddbcb-3e0e-4979-b685-835038b6c7bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("abf270ef-cbe0-46c0-99a7-88c27afbba7c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac9e9779-82de-42a7-8556-01a1fd2705b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8771de7-edb5-4dd5-875a-08ad162cde6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1628599-5a4c-4768-b8b0-bc10c9421ede"));

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "OrderProducts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "Description", "Image", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("1de30018-b4d9-44cd-8881-74e7fb3df35f"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("2c28c8e9-b823-497c-81a6-c084dfdf93f8"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("40c4fec7-6f90-4eff-a99c-193dd87cd75a"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("50032bec-84a0-471e-a695-91cae48d4bc4"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("55e96794-83f4-4aa4-b14a-a37a73b48263"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("5a3b4a28-9acd-4a65-a229-a1ae2ed41b4d"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("7c7ce32c-a704-4ed3-acd2-60455e46c6c9"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("882d8a53-b955-4ed6-a2c1-c58eb4ea60e6"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("dbf35556-7458-4be8-b8e9-f23fe09f4bd0"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("eac1131e-2490-4319-ab98-e9669c8d946f"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1de30018-b4d9-44cd-8881-74e7fb3df35f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c28c8e9-b823-497c-81a6-c084dfdf93f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40c4fec7-6f90-4eff-a99c-193dd87cd75a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50032bec-84a0-471e-a695-91cae48d4bc4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55e96794-83f4-4aa4-b14a-a37a73b48263"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a3b4a28-9acd-4a65-a229-a1ae2ed41b4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7c7ce32c-a704-4ed3-acd2-60455e46c6c9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("882d8a53-b955-4ed6-a2c1-c58eb4ea60e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dbf35556-7458-4be8-b8e9-f23fe09f4bd0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eac1131e-2490-4319-ab98-e9669c8d946f"));

            migrationBuilder.DropColumn(
                name: "Count",
                table: "OrderProducts");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "Description", "Image", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("2abe378b-1952-48a5-afad-ff055ac05cc4"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("81131536-68ff-4624-a1ba-dc3d93fb69a0"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("869a2674-1dbf-41e6-b964-00d9f3e7c903"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("8e3a0892-9d18-4ca7-be8b-f7485de149ae"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("9cfc38b6-1d6f-4084-b2ce-bc7bf42773ee"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("ab7ddbcb-3e0e-4979-b685-835038b6c7bc"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("abf270ef-cbe0-46c0-99a7-88c27afbba7c"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("ac9e9779-82de-42a7-8556-01a1fd2705b2"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("c8771de7-edb5-4dd5-875a-08ad162cde6f"), 2, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("e1628599-5a4c-4768-b8b0-bc10c9421ede"), 5, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" }
                });
        }
    }
}
