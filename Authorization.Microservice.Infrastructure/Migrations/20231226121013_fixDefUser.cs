using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Authorization.Microservice.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDefUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb587003-9bcb-4d9d-af12-f5944a4d7a82"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImagePath", "PasswordHash", "Role", "Username" },
                values: new object[] { new Guid("a2a7dcb7-49fd-4ab9-bd00-b05d31a12d3e"), "a@mail.ru", "/content/avatars/35a44d12-42f9-4254-a7d3-2e3bf26c934c.jpg", "473287f8298dba7163a897908958f7c0eae733e25d2e027992ea2edc9bed2fa8", "user", "Andrey Glazev" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a2a7dcb7-49fd-4ab9-bd00-b05d31a12d3e"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImagePath", "PasswordHash", "Role", "Username" },
                values: new object[] { new Guid("eb587003-9bcb-4d9d-af12-f5944a4d7a82"), "a@mail.ru", "/content/avatars/35a44d12-42f9-4254-a7d3-2e3bf26c934c.jpg", "473287f8298dba7163a897908958f7c0eae733e25d2e027992ea2edc9bed2fa8", "user", "Andrey Glazev" });
        }
    }
}
