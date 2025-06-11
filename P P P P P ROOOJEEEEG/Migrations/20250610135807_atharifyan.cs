using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RUSUNAWAAA.Migrations
{
    /// <inheritdoc />
    public partial class atharifyan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomorKTP",
                table: "Notifikasis",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Notifikasis_NomorKTP",
                table: "Notifikasis",
                column: "NomorKTP");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifikasis_Users_NomorKTP",
                table: "Notifikasis",
                column: "NomorKTP",
                principalTable: "Users",
                principalColumn: "NomorKTP",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifikasis_Users_NomorKTP",
                table: "Notifikasis");

            migrationBuilder.DropIndex(
                name: "IX_Notifikasis_NomorKTP",
                table: "Notifikasis");

            migrationBuilder.DropColumn(
                name: "NomorKTP",
                table: "Notifikasis");
        }
    }
}
