using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreHomework1.Migrations
{
    /// <summary>
    /// Миграция, которая добавляет nullable столбец "Дата" в таблицу
    /// </summary>
    public partial class AddDateToModelMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Orders",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Orders");
        }
    }
}
