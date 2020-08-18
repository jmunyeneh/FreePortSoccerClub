using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreePortSoccer.Migrations
{
    public partial class newstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Article = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    InsertedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsHighLights = table.Column<bool>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true),
                    ImageContentType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");
        }
    }
}
