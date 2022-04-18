using Microsoft.EntityFrameworkCore.Migrations;

namespace cuahangdidong.Migrations
{
    public partial class NameFixSốLượng : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "didong");

            migrationBuilder.AlterColumn<string>(
                name: "ThểLoại",
                table: "didong",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ChứVụ",
                table: "didong",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SốLượng",
                table: "didong",
                maxLength: 5,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SốLượng",
                table: "didong");

            migrationBuilder.AlterColumn<string>(
                name: "ThểLoại",
                table: "didong",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "ChứVụ",
                table: "didong",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "didong",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
