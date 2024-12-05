using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class updateImageUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrL" },
                values: new object[] { new DateTime(2024, 12, 5, 12, 30, 23, 299, DateTimeKind.Local).AddTicks(8540), "https://placehold.co/600x401" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrL",
                value: "https://placehold.co/600x402");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrL",
                value: "https://placehold.co/600x403");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrL",
                value: "https://placehold.co/600x404");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrL",
                value: "https://placehold.co/600x405");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrL" },
                values: new object[] { new DateTime(2024, 12, 5, 11, 50, 11, 492, DateTimeKind.Local).AddTicks(6578), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrL",
                value: "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrL",
                value: "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrL",
                value: "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrL",
                value: "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg");
        }
    }
}
