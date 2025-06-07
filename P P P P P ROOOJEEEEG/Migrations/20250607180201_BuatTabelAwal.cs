using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RUSUNAWAAA.Migrations
{
    /// <inheritdoc />
    public partial class BuatTabelAwal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kontaks",
                columns: table => new
                {
                    Id_Kontak = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaKontak = table.Column<string>(type: "text", nullable: false),
                    Telepon = table.Column<string>(type: "text", nullable: false),
                    Lokasi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kontaks", x => x.Id_Kontak);
                });

            migrationBuilder.CreateTable(
                name: "Laporans",
                columns: table => new
                {
                    Id_Laporan = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomorKTP = table.Column<int>(type: "integer", nullable: false),
                    Judul = table.Column<string>(type: "text", nullable: false),
                    Isi = table.Column<string>(type: "text", nullable: false),
                    Tanggal = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    PathGambar = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laporans", x => x.Id_Laporan);
                });

            migrationBuilder.CreateTable(
                name: "MediaVirtuals",
                columns: table => new
                {
                    Id_Media = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaFile = table.Column<string>(type: "text", nullable: false),
                    PathMedia = table.Column<string>(type: "text", nullable: false),
                    Keterangan = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaVirtuals", x => x.Id_Media);
                });

            migrationBuilder.CreateTable(
                name: "Notifikasis",
                columns: table => new
                {
                    Id_Notifikasi = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Judul = table.Column<string>(type: "text", nullable: false),
                    Isi = table.Column<string>(type: "text", nullable: false),
                    Tanggal = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SudahDibaca = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifikasis", x => x.Id_Notifikasi);
                });

            migrationBuilder.CreateTable(
                name: "Pembayarans",
                columns: table => new
                {
                    Id_Pembayaran = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomorKTP = table.Column<int>(type: "integer", nullable: false),
                    Tanggal = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Nominal = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pembayarans", x => x.Id_Pembayaran);
                });

            migrationBuilder.CreateTable(
                name: "PengajuanSewas",
                columns: table => new
                {
                    Id_Pengajuan = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id_Unit = table.Column<int>(type: "integer", nullable: false),
                    NomorKTP = table.Column<int>(type: "integer", nullable: false),
                    DurasiSewa = table.Column<int>(type: "integer", nullable: false),
                    EstimasiBiaya = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    TanggalPengajuan = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PathKTP = table.Column<string>(type: "text", nullable: false),
                    PathPasfoto = table.Column<string>(type: "text", nullable: false),
                    PathPembayaran = table.Column<string>(type: "text", nullable: false),
                    PathSuratPernyataan = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PengajuanSewas", x => x.Id_Pengajuan);
                });

            migrationBuilder.CreateTable(
                name: "PerpanjanganSewas",
                columns: table => new
                {
                    Id_Perpanjangan = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomorKTP = table.Column<int>(type: "integer", nullable: false),
                    TanggalPengajuan = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LamaBulan = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    Nominal = table.Column<decimal>(type: "numeric", nullable: false),
                    PathBuktiPembayaran = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerpanjanganSewas", x => x.Id_Perpanjangan);
                });

            migrationBuilder.CreateTable(
                name: "TataTertibs",
                columns: table => new
                {
                    Id_Tatatertib = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Judul = table.Column<string>(type: "text", nullable: false),
                    TanggalUpdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TataTertibs", x => x.Id_Tatatertib);
                });

            migrationBuilder.CreateTable(
                name: "Ulasans",
                columns: table => new
                {
                    Id_Ulasan = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomorKTP = table.Column<int>(type: "integer", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    Komentar = table.Column<string>(type: "text", nullable: false),
                    Tanggal = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PathGambar = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ulasans", x => x.Id_Ulasan);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id_Unit = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Lantai = table.Column<int>(type: "integer", nullable: false),
                    Luas = table.Column<float>(type: "real", nullable: false),
                    HargaSewa = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id_Unit);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    NomorKTP = table.Column<string>(type: "text", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    NamaLengkap = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false),
                    AlamatAsal = table.Column<string>(type: "text", nullable: true),
                    NomorHP = table.Column<string>(type: "text", nullable: true),
                    TanggalLahir = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Fakultas = table.Column<string>(type: "text", nullable: true),
                    Prodi = table.Column<string>(type: "text", nullable: true),
                    AsalKota = table.Column<string>(type: "text", nullable: true),
                    JenisKelamin = table.Column<string>(type: "text", nullable: true),
                    NamaOrangTua = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.NomorKTP);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kontaks");

            migrationBuilder.DropTable(
                name: "Laporans");

            migrationBuilder.DropTable(
                name: "MediaVirtuals");

            migrationBuilder.DropTable(
                name: "Notifikasis");

            migrationBuilder.DropTable(
                name: "Pembayarans");

            migrationBuilder.DropTable(
                name: "PengajuanSewas");

            migrationBuilder.DropTable(
                name: "PerpanjanganSewas");

            migrationBuilder.DropTable(
                name: "TataTertibs");

            migrationBuilder.DropTable(
                name: "Ulasans");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
