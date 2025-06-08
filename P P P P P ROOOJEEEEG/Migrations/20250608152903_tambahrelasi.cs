using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RUSUNAWAAA.Migrations
{
    /// <inheritdoc />
    public partial class tambahrelasi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NIM",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomorKTP",
                table: "PengajuanSewas",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NIM",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "NomorKTP",
                table: "PengajuanSewas",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
