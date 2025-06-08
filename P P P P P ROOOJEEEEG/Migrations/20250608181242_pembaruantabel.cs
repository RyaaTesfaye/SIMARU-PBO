using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RUSUNAWAAA.Migrations
{
    /// <inheritdoc />
    public partial class pembaruantabel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "IX_Perpanjangans_UserNomorKTP",
                table: "Perpanjangans");

            migrationBuilder.DropIndex(
                name: "IX_Pengajuans_UserNomorKTP",
                table: "Pengajuans");

            migrationBuilder.DropIndex(
                name: "IX_Pembayarans_UserNomorKTP",
                table: "Pembayarans");

            migrationBuilder.DropIndex(
                name: "IX_Laporans_UserNomorKTP",
                table: "Laporans");

            migrationBuilder.DropColumn(
                name: "UserNomorKTP",
                table: "Ulasans");

            migrationBuilder.DropColumn(
                name: "UserNomorKTP",
                table: "Perpanjangans");

            migrationBuilder.DropColumn(
                name: "UserNomorKTP",
                table: "Pengajuans");

            migrationBuilder.DropColumn(
                name: "UserNomorKTP",
                table: "Pembayarans");

            migrationBuilder.DropColumn(
                name: "UserNomorKTP",
                table: "Laporans");

            migrationBuilder.AlterColumn<string>(
                name: "NomorKTP",
                table: "Ulasans",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "NomorKTP",
                table: "Perpanjangans",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "AlamatAsal",
                table: "Pengajuans",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AsalKota",
                table: "Pengajuans",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Fakultas",
                table: "Pengajuans",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "JenisKelamin",
                table: "Pengajuans",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NIM",
                table: "Pengajuans",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NamaLengkap",
                table: "Pengajuans",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NamaOrangTua",
                table: "Pengajuans",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomorHP",
                table: "Pengajuans",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Prodi",
                table: "Pengajuans",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "NomorKTP",
                table: "Pembayarans",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "NomorKTP",
                table: "Laporans",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_Ulasans_NomorKTP",
                table: "Ulasans",
                column: "NomorKTP");

            migrationBuilder.CreateIndex(
                name: "IX_Perpanjangans_NomorKTP",
                table: "Perpanjangans",
                column: "NomorKTP");

            migrationBuilder.CreateIndex(
                name: "IX_Pengajuans_NomorKTP",
                table: "Pengajuans",
                column: "NomorKTP");

            migrationBuilder.CreateIndex(
                name: "IX_Pembayarans_NomorKTP",
                table: "Pembayarans",
                column: "NomorKTP");

            migrationBuilder.CreateIndex(
                name: "IX_Laporans_NomorKTP",
                table: "Laporans",
                column: "NomorKTP");

            migrationBuilder.AddForeignKey(
                name: "FK_Laporans_Users_NomorKTP",
                table: "Laporans",
                column: "NomorKTP",
                principalTable: "Users",
                principalColumn: "NomorKTP",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pembayarans_Users_NomorKTP",
                table: "Pembayarans",
                column: "NomorKTP",
                principalTable: "Users",
                principalColumn: "NomorKTP",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pengajuans_Users_NomorKTP",
                table: "Pengajuans",
                column: "NomorKTP",
                principalTable: "Users",
                principalColumn: "NomorKTP",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Perpanjangans_Users_NomorKTP",
                table: "Perpanjangans",
                column: "NomorKTP",
                principalTable: "Users",
                principalColumn: "NomorKTP",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ulasans_Users_NomorKTP",
                table: "Ulasans",
                column: "NomorKTP",
                principalTable: "Users",
                principalColumn: "NomorKTP",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Laporans_Users_NomorKTP",
                table: "Laporans");

            migrationBuilder.DropForeignKey(
                name: "FK_Pembayarans_Users_NomorKTP",
                table: "Pembayarans");

            migrationBuilder.DropForeignKey(
                name: "FK_Pengajuans_Users_NomorKTP",
                table: "Pengajuans");

            migrationBuilder.DropForeignKey(
                name: "FK_Perpanjangans_Users_NomorKTP",
                table: "Perpanjangans");

            migrationBuilder.DropForeignKey(
                name: "FK_Ulasans_Users_NomorKTP",
                table: "Ulasans");

            migrationBuilder.DropIndex(
                name: "IX_Ulasans_NomorKTP",
                table: "Ulasans");

            migrationBuilder.DropIndex(
                name: "IX_Perpanjangans_NomorKTP",
                table: "Perpanjangans");

            migrationBuilder.DropIndex(
                name: "IX_Pengajuans_NomorKTP",
                table: "Pengajuans");

            migrationBuilder.DropIndex(
                name: "IX_Pembayarans_NomorKTP",
                table: "Pembayarans");

            migrationBuilder.DropIndex(
                name: "IX_Laporans_NomorKTP",
                table: "Laporans");

            migrationBuilder.DropColumn(
                name: "AlamatAsal",
                table: "Pengajuans");

            migrationBuilder.DropColumn(
                name: "AsalKota",
                table: "Pengajuans");

            migrationBuilder.DropColumn(
                name: "Fakultas",
                table: "Pengajuans");

            migrationBuilder.DropColumn(
                name: "JenisKelamin",
                table: "Pengajuans");

            migrationBuilder.DropColumn(
                name: "NIM",
                table: "Pengajuans");

            migrationBuilder.DropColumn(
                name: "NamaLengkap",
                table: "Pengajuans");

            migrationBuilder.DropColumn(
                name: "NamaOrangTua",
                table: "Pengajuans");

            migrationBuilder.DropColumn(
                name: "NomorHP",
                table: "Pengajuans");

            migrationBuilder.DropColumn(
                name: "Prodi",
                table: "Pengajuans");

            migrationBuilder.AlterColumn<int>(
                name: "NomorKTP",
                table: "Ulasans",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "UserNomorKTP",
                table: "Ulasans",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NomorKTP",
                table: "Perpanjangans",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

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

            migrationBuilder.AlterColumn<int>(
                name: "NomorKTP",
                table: "Pembayarans",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "UserNomorKTP",
                table: "Pembayarans",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NomorKTP",
                table: "Laporans",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "UserNomorKTP",
                table: "Laporans",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ulasans_UserNomorKTP",
                table: "Ulasans",
                column: "UserNomorKTP");

            migrationBuilder.CreateIndex(
                name: "IX_Perpanjangans_UserNomorKTP",
                table: "Perpanjangans",
                column: "UserNomorKTP");

            migrationBuilder.CreateIndex(
                name: "IX_Pengajuans_UserNomorKTP",
                table: "Pengajuans",
                column: "UserNomorKTP");

            migrationBuilder.CreateIndex(
                name: "IX_Pembayarans_UserNomorKTP",
                table: "Pembayarans",
                column: "UserNomorKTP");

            migrationBuilder.CreateIndex(
                name: "IX_Laporans_UserNomorKTP",
                table: "Laporans",
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
    }
}
