using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreHomework1.Migrations
{
    public partial class RemoveDateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 11, 8, 15, 51, 21, 413, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 11, 8, 15, 51, 21, 413, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2022, 11, 8, 15, 51, 21, 413, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2022, 11, 8, 15, 51, 21, 413, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2022, 11, 8, 15, 51, 21, 413, DateTimeKind.Local).AddTicks(5894));
        }
    }
}
