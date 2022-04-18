using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cuahangdidong.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "didong",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChứVụ = table.Column<string>(nullable: true),
                    NgàyPhátHành = table.Column<DateTime>(nullable: false),
                    ThểLoại = table.Column<string>(nullable: true),
                    GíaBán = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_didong", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "didong");
        }
    }
}
