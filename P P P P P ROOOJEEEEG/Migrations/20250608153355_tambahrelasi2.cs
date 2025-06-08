using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RUSUNAWAAA.Migrations
{
    /// <inheritdoc />
    public partial class tambahrelasi2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PerpanjanganSewas",
                table: "PerpanjanganSewas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PengajuanSewas",
                table: "PengajuanSewas");

            migrationBuilder.RenameTable(
                name: "PerpanjanganSewas",
                newName: "Perpanjangans");

            migrationBuilder.RenameTable(
                name: "PengajuanSewas",
                newName: "Pengajuans");

            migrationBuilder.AddColumn<string>(
                name: "UserNomorKTP",
                table: "Ulasans",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserNomorKTP",
                table: "Pembayarans",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserNomorKTP",
                table: "Laporans",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserNomorKTP",
                table: "Perpanjangans",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserNomorKTP",
                table: "Pengajuans",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Perpanjangans",
                table: "Perpanjangans",
                column: "Id_Perpanjangan");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pengajuans",
                table: "Pengajuans",
                column: "Id_Pengajuan");

            migrationBuilder.CreateIndex(
                name: "IX_Ulasans_UserNomorKTP",
                table: "Ulasans",
                column: "UserNomorKTP");

            migrationBuilder.CreateIndex(
                name: "IX_Pembayarans_UserNomorKTP",
                table: "Pembayarans",
                column: "UserNomorKTP");

            migrationBuilder.CreateIndex(
                name: "IX_Laporans_UserNomorKTP",
                table: "Laporans",
                column: "UserNomorKTP");

            migrationBuilder.CreateIndex(
                name: "IX_Perpanjangans_UserNomorKTP",
                table: "Perpanjangans",
                column: "UserNomorKTP");

            migrationBuilder.CreateIndex(
                name: "IX_Pengajuans_UserNomorKTP",
                table: "Pengajuans",
                column: "UserNomorKTP");

            migrationBuilder.AddForeignKey(
                name: "FK_Laporans_Users_UserNomorKTP",
                table: "Laporans",
                column: "UserNomorKTP",
                principalTable: "Users",
                principalColumn: "NomorKTP");

            migrationBuilder.AddForeignKey(
                name: "FK_Pembayarans_Users_UserNomorKTP",
                table: "Pembayarans",
                column: "UserNomorKTP",
                principalTable: "Users",
                principalColumn: "NomorKTP");

            migrationBuilder.AddForeignKey(
                name: "FK_Pengajuans_Users_UserNomorKTP",
                table: "Pengajuans",
                column: "UserNomorKTP",
                principalTable: "Users",
                principalColumn: "NomorKTP");

            migrationBuilder.AddForeignKey(
                name: "FK_Perpanjangans_Users_UserNomorKTP",
                table: "Perpanjangans",
                column: "UserNomorKTP",
                principalTable: "Users",
                principalColumn: "NomorKTP");

            migrationBuilder.AddForeignKey(
                name: "FK_Ulasans_Users_UserNomorKTP",
                table: "Ulasans",
                column: "UserNomorKTP",
                principalTable: "Users",
                principalColumn: "NomorKTP");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Laporans_Users_UserNomorKTP",
                table: "Laporans");

            migrationBuilder.DropForeignKey(
                name: "FK_Pembayarans_Users_UserNomorKTP",
                table: "Pembayarans");

            migrationBuilder.DropForeignKey(
                name: "FK_Pengajuans_Users_UserNomorKTP",
                table: "Pengajuans");

            migrationBuilder.DropForeignKey(
                name: "FK_Perpanjangans_Users_UserNomorKTP",
                table: "Perpanjangans");

            migrationBuilder.DropForeignKey(
                name: "FK_Ulasans_Users_UserNomorKTP",
                table: "Ulasans");

            migrationBuilder.DropIndex(
                name: "IX_Ulasans_UserNomorKTP",
                table: "Ulasans");

            migrationBuilder.DropIndex(
                name: "IX_Pembayarans_UserNomorKTP",
                table: "Pembayarans");

            migrationBuilder.DropIndex(
                name: "IX_Laporans_UserNomorKTP",
                table: "Laporans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Perpanjangans",
                table: "Perpanjangans");

            migrationBuilder.DropIndex(
                name: "IX_Perpanjangans_UserNomorKTP",
                table: "Perpanjangans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pengajuans",
                table: "Pengajuans");

            migrationBuilder.DropIndex(
                name: "IX_Pengajuans_UserNomorKTP",
                table: "Pengajuans");

            migrationBuilder.DropColumn(
                name: "UserNomorKTP",
                table: "Ulasans");

            migrationBuilder.DropColumn(
                name: "UserNomorKTP",
                table: "Pembayarans");

            migrationBuilder.DropColumn(
                name: "UserNomorKTP",
                table: "Laporans");

            migrationBuilder.DropColumn(
                name: "UserNomorKTP",
                table: "Perpanjangans");

            migrationBuilder.DropColumn(
                name: "UserNomorKTP",
                table: "Pengajuans");

            migrationBuilder.RenameTable(
                name: "Perpanjangans",
                newName: "PerpanjanganSewas");

            migrationBuilder.RenameTable(
                name: "Pengajuans",
                newName: "PengajuanSewas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerpanjanganSewas",
                table: "PerpanjanganSewas",
                column: "Id_Perpanjangan");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PengajuanSewas",
                table: "PengajuanSewas",
                column: "Id_Pengajuan");
        }
    }
}
