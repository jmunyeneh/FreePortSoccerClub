using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreePortSoccer.Migrations
{
    public partial class ModifiedAndInsertedDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Posi_to_play",
                table: "Players");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertedDate",
                table: "Players",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Players",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InsertedDate",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Players");

            migrationBuilder.AddColumn<string>(
                name: "Posi_to_play",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
