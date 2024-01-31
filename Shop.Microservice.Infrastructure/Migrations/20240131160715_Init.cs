using System;
using Microsoft.EntityFrameworkCore.Migrations;
using static System.Net.WebRequestMethods;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop.Microservice.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Balances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Amount = table.Column<double>(type: "double precision", nullable: false),
                    AmountForSend = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Balances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderStatus = table.Column<int>(type: "integer", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SenderID = table.Column<Guid>(type: "uuid", nullable: false),
                    ReceiverID = table.Column<Guid>(type: "uuid", nullable: false),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Balances",
                columns: new[] { "Id", "Amount", "AmountForSend", "UserId" },
                values: new object[,]
                {
                    { new Guid("487f7e43-9fbb-42c8-b8e7-a56ccf572bcc"), 10.0, 100.0, new Guid("a2a7dcb7-49fd-4ab9-bd00-b05d31a12d3e") },
                    { new Guid("bcd0b45e-569e-4ade-a45e-2286db67dfbd"), 20.0, 200.0, new Guid("a2a7dcb7-49fd-4ab9-bd00-b05d31a19d3e") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreateAt", "OrderStatus", "UserId" },
                values: new object[] { new Guid("f18e8fa6-1bb2-46c5-8e79-c8264603633c"), new DateTime(2024, 1, 31, 16, 7, 15, 69, DateTimeKind.Utc).AddTicks(7471), 0, new Guid("a2a7dcb7-49fd-4ab9-bd00-b05d31a12d3e") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "Description", "Image", "Price", "Title" },
            values: new object[,]
                {
                    { new Guid("0562856a-47de-4597-870b-0f1a6b213ee6"), 55, "10000мАч", "https://galagraffity.ru/image/cache/catalog/XML341ae4b41effce6e99b3170a951e6dc7/futbolki/IMGec5d5e1c4a114ecba74c0557231a0d43-767x767.jpg", 899, "Футболка" },
                    { new Guid("3159a88c-d0fa-4ff0-b9c6-b03abac79c33"), 34, "Хороший рюкзак", "https://illan-gifts.ru/api/images/riukzak-molti-base-seryj-818385.jpeg", 2399, "Рюкзак" },
                    { new Guid("4ff2c5a6-f9a9-40fa-ae10-525ddb3abb7b"), 15, "Размеры S,M,L", "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg", 5999, "Худи" },
                    { new Guid("81563215-874f-4da2-b171-30da3713d8af"), 75, "10000мАч", "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg", 2399, "ПоверБанк" },
                    { new Guid("89c77a2b-52a9-4c53-8757-39802504062f"), 75, "Флешка на 64 гб", "https://chel.sp-computer.ru/upload/iblock/dd0/dd0d7bdff13a3c31afd2f39080d7f0a2.jpg", 799, "Флешка 64gb" },
                    { new Guid("99fbb82c-554c-48e6-9f62-ee189c5e874f"), 12, "Овечья шерсть", "https://paters.ru/files/catalog/o_3545.jpg", 5999, "Плед красный" },
                    { new Guid("9bcfc253-0654-4d95-a5b9-e58a9cb9345b"), 34, "Отличный подарок", "https://praktika-reklama.ru/images/stories/virtuemart/product/3146.40_1_tif_1000x1000.jpg", 1999, "Термокружка" },
                    { new Guid("a46b9246-7e14-4709-9d15-0e8d3534f130"), 52, "Зимние перчатки", "https://a.allegroimg.com/original/115466/f37055214459bfdcb1252f470363/Rekawice-meskie-polarowe-zimowe-rekawiczki-L-XL", 1199, "Перчатки" },
                    { new Guid("ae16ea54-6493-4360-b4bb-86ab94b7431c"), 55, "Шарф", "https://bis-souvenir.ru/wp-content/uploads/2021/01/6901992-th-img.jpg", 799, "Шарф" },
                    { new Guid("d1435cfd-b383-4924-8e28-ab3131894a38"), 21, "Размеры S,M,L", "https://cdn1.ozone.ru/s3/multimedia-g/6049217164.jpg", 599, "Носки" }
                });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "Id", "Count", "OrderId", "ProductId" },
                values: new object[] { new Guid("f31503f2-e602-4a5f-826e-ce128357ed1a"), 1, new Guid("f18e8fa6-1bb2-46c5-8e79-c8264603633c"), new Guid("4ff2c5a6-f9a9-40fa-ae10-525ddb3abb7b") });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_OrderId",
                table: "OrderProducts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_ProductId",
                table: "OrderProducts",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Balances");

            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
