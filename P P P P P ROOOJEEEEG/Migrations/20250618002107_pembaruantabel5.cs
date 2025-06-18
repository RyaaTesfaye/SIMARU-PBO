using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RUSUNAWAAA.Migrations
{
    /// <inheritdoc />
    public partial class pembaruantabel5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifikasis");

            migrationBuilder.DropTable(
                name: "Pembayarans");

            migrationBuilder.DropTable(
                name: "Units");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifikasis",
                columns: table => new
                {
                    Id_Notifikasi = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomorKTP = table.Column<string>(type: "text", nullable: false),
                    Isi = table.Column<string>(type: "text", nullable: false),
                    Judul = table.Column<string>(type: "text", nullable: false),
                    SudahDibaca = table.Column<bool>(type: "boolean", nullable: false),
                    Tanggal = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifikasis", x => x.Id_Notifikasi);
                    table.ForeignKey(
                        name: "FK_Notifikasis_Users_NomorKTP",
                        column: x => x.NomorKTP,
                        principalTable: "Users",
                        principalColumn: "NomorKTP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pembayarans",
                columns: table => new
                {
                    Id_Pembayaran = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomorKTP = table.Column<string>(type: "text", nullable: false),
                    Nominal = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    Tanggal = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pembayarans", x => x.Id_Pembayaran);
                    table.ForeignKey(
                        name: "FK_Pembayarans_Users_NomorKTP",
                        column: x => x.NomorKTP,
                        principalTable: "Users",
                        principalColumn: "NomorKTP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id_Unit = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HargaSewa = table.Column<decimal>(type: "numeric", nullable: false),
                    Lantai = table.Column<int>(type: "integer", nullable: false),
                    Luas = table.Column<float>(type: "real", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id_Unit);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notifikasis_NomorKTP",
                table: "Notifikasis",
                column: "NomorKTP");

            migrationBuilder.CreateIndex(
                name: "IX_Pembayarans_NomorKTP",
                table: "Pembayarans",
                column: "NomorKTP");
        }
    }
}
