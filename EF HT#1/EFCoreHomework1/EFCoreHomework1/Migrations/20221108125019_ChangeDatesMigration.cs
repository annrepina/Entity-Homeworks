using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreHomework1.Migrations
{
    public partial class ChangeDatesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 11, 8, 15, 50, 19, 584, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 11, 8, 15, 50, 19, 584, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2022, 11, 8, 15, 50, 19, 584, DateTimeKind.Local).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2022, 11, 8, 15, 50, 19, 584, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2022, 11, 8, 15, 50, 19, 584, DateTimeKind.Local).AddTicks(3330));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: null);
        }
    }
}
