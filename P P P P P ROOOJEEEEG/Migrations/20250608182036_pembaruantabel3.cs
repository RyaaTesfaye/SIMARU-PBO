using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RUSUNAWAAA.Migrations
{
    /// <inheritdoc />
    public partial class pembaruantabel3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pengajuans_Users_NomorKTP",
                table: "Pengajuans");

            migrationBuilder.DropIndex(
                name: "IX_Pengajuans_NomorKTP",
                table: "Pengajuans");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Pengajuans_NomorKTP",
                table: "Pengajuans",
                column: "NomorKTP");

            migrationBuilder.AddForeignKey(
                name: "FK_Pengajuans_Users_NomorKTP",
                table: "Pengajuans",
                column: "NomorKTP",
                principalTable: "Users",
                principalColumn: "NomorKTP",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
