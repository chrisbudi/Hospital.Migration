using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Wincare.Core.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "M_AntrianCounter",
                columns: table => new
                {
                    IdCounter = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Kdcounter = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    Counter = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    Kdlokasi = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    Kdlayanan = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_AntrianCounter", x => x.IdCounter);
                });

            migrationBuilder.CreateTable(
                name: "M_AntrianCounterAudio",
                columns: table => new
                {
                    IdCounterAudio = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KdCounter = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    Counter = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    KdLokasi = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    KdLayanan = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    File = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Nomor = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_AntrianCounterAudio", x => x.IdCounterAudio);
                });

            migrationBuilder.CreateTable(
                name: "M_AntrianLayanan",
                columns: table => new
                {
                    IdLayanan = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KdLayanan = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    Layanan = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    Inisial = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    KdLokasi = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_AntrianLayanan", x => x.IdLayanan);
                });

            migrationBuilder.CreateTable(
                name: "M_AntrianLokasi",
                columns: table => new
                {
                    Kdlokasi = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    IdLokasi = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Lokasi = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    Action = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_AntrianLokasi", x => x.Kdlokasi);
                });

            migrationBuilder.CreateTable(
                name: "M_AsalGroup",
                columns: table => new
                {
                    IdAsalGroup = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaGroupAsal = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_AsalGroup", x => x.IdAsalGroup);
                });

            migrationBuilder.CreateTable(
                name: "M_AturanPakai",
                columns: table => new
                {
                    IdAturanpakai = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdAturanPakai = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    NamaAturanpakai = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    KetAturanpakai = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_AturanPakai", x => x.IdAturanpakai);
                });

            migrationBuilder.CreateTable(
                name: "M_Bank",
                columns: table => new
                {
                    IdBank = table.Column<Guid>(type: "uuid", nullable: false),
                    OldIdBank = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Kdbank = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    NmBank = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Cabang = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Alamat = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Kota = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Telepon = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: false),
                    NomorRekening = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    KdAkun = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Bank", x => x.IdBank);
                });

            migrationBuilder.CreateTable(
                name: "M_BarangAturanpakai",
                columns: table => new
                {
                    IdAturanpakai = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdAturanPakai = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    NmAturanPakai = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    KetAturanPakai = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_BarangAturanpakai", x => x.IdAturanpakai);
                });

            migrationBuilder.CreateTable(
                name: "M_CoaGolongan",
                columns: table => new
                {
                    IdGolongan = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    NmGolongan = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_CoaGolongan", x => x.IdGolongan);
                });

            migrationBuilder.CreateTable(
                name: "M_CountTraffic",
                columns: table => new
                {
                    IdCountTraffic = table.Column<Guid>(type: "uuid", nullable: false),
                    OldIdCountTraffic = table.Column<decimal>(type: "numeric", nullable: false),
                    Tanggal = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    jam = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Menu = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    SubMenu = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    By = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_CountTraffic", x => x.IdCountTraffic);
                });

            migrationBuilder.CreateTable(
                name: "M_Department",
                columns: table => new
                {
                    IdDepartment = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    NamaDepartemen = table.Column<string>(type: "character varying(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Department", x => x.IdDepartment);
                });

            migrationBuilder.CreateTable(
                name: "M_Diagnosa",
                columns: table => new
                {
                    IdDiagnosa = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdDiagnosa = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    NmDiagnosa = table.Column<string>(type: "character varying(300)", unicode: false, maxLength: 300, nullable: false),
                    Ispenyakit = table.Column<bool>(type: "boolean", nullable: true),
                    kdDTD = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Diagnosa", x => x.IdDiagnosa);
                });

            migrationBuilder.CreateTable(
                name: "M_DiagnosaMatrix",
                columns: table => new
                {
                    IdMatrixDiagnosa = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    IdRuangan = table.Column<decimal>(type: "numeric", nullable: false),
                    KodeRuangan = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    IdDiagnosa = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    KdDiagnosa = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_DiagnosaMatrix", x => x.IdMatrixDiagnosa);
                });

            migrationBuilder.CreateTable(
                name: "M_DokterHonor",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric", nullable: false),
                    KdDokter = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    NmDokter = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    Tarif = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    JasaMedis = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    JasaRS = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Ket = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_DokterHonor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_DokterNote",
                columns: table => new
                {
                    IdDokterNote = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IdDokter = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdDokter = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    Keterangan = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    By = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    TglInput = table.Column<DateTime>(type: "TIMESTAMP", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_DokterNote", x => x.IdDokterNote);
                });

            migrationBuilder.CreateTable(
                name: "M_DTD",
                columns: table => new
                {
                    IdDTD = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdDTD = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    NmDTD = table.Column<string>(type: "character varying(200)", unicode: false, maxLength: 200, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_DTD", x => x.IdDTD);
                });

            migrationBuilder.CreateTable(
                name: "M_Farmakoterapi",
                columns: table => new
                {
                    IdFarmakoterapi = table.Column<decimal>(type: "numeric", nullable: false),
                    Nmfarmakoterapi = table.Column<string>(type: "character varying(200)", unicode: false, maxLength: 200, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Farmakoterapi", x => x.IdFarmakoterapi);
                });

            migrationBuilder.CreateTable(
                name: "M_Gizi",
                columns: table => new
                {
                    IdGizi = table.Column<Guid>(type: "uuid", nullable: false),
                    OldIdGizi = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Kdmakanan = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    Nmmakanan = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    Group = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "character varying(200)", unicode: false, maxLength: 200, nullable: false),
                    Kandungan = table.Column<string>(type: "character varying(200)", unicode: false, maxLength: 200, nullable: false),
                    Energi = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Protein = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Lemak = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Kh = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Calsium = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Fosfor = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Fe = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Vita = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Vitb1 = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Vitc = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Air = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Bdd = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Gizi", x => x.IdGizi);
                });

            migrationBuilder.CreateTable(
                name: "M_Gudang",
                columns: table => new
                {
                    IdGudangObat = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KodeInventory = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    NamaGudangObat = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    IsRequest = table.Column<bool>(type: "boolean", nullable: true),
                    IsListropp = table.Column<bool>(type: "boolean", nullable: true),
                    IsTipebarang = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    IsPaketbhp = table.Column<bool>(type: "boolean", nullable: true),
                    IsReturbhp = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Gudang", x => x.IdGudangObat);
                });

            migrationBuilder.CreateTable(
                name: "M_Hargakamar",
                columns: table => new
                {
                    IdHargakamar = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Kelas = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    By = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Hargakamar", x => x.IdHargakamar);
                });

            migrationBuilder.CreateTable(
                name: "M_KamarinapRekanan",
                columns: table => new
                {
                    IdKamarinaprek = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdTmpTidur = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    RekananId = table.Column<Guid>(type: "uuid", nullable: false),
                    OldRekananId = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_KamarinapRekanan", x => x.IdKamarinaprek);
                });

            migrationBuilder.CreateTable(
                name: "M_KelompokBarang",
                columns: table => new
                {
                    KelompokId = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Kode = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    Nama = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Margin = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Note = table.Column<string>(type: "character varying(500)", unicode: false, maxLength: 500, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    IdGroupTarif = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_KelompokBarang", x => x.KelompokId);
                });

            migrationBuilder.CreateTable(
                name: "M_Kodepos",
                columns: table => new
                {
                    IdKodepos = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KdKodePos = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    Kelurahan = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Kecamatan = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Kabupaten = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Provinsi = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IS_AKTIF = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Kodepos", x => x.IdKodepos);
                });

            migrationBuilder.CreateTable(
                name: "M_LaboratoriumGroup",
                columns: table => new
                {
                    IdGroup = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Nmgroup = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    IdGrouptarif = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    IsPk = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_LaboratoriumGroup", x => x.IdGroup);
                });

            migrationBuilder.CreateTable(
                name: "M_MasterPaketH",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OldId = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IdMasterPemeriksaan = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    NmPemeriksaan = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    KdPemeriksaan = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Harga = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Penunjang = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IdGroupTarif = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_MasterPaketH", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_MasterTnd",
                columns: table => new
                {
                    IdGroupTarif = table.Column<double>(type: "double precision", nullable: false),
                    NmgroupTarif = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    KdTarifDetail = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    NmTarifDetail = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Kelas = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Harga = table.Column<double>(type: "double precision", nullable: true),
                    IsAktif = table.Column<double>(type: "double precision", nullable: true),
                    HargaBpjs = table.Column<double>(type: "double precision", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_MasterTnd", x => x.IdGroupTarif);
                });

            migrationBuilder.CreateTable(
                name: "M_Module",
                columns: table => new
                {
                    IdModule = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nmmodule = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Module", x => x.IdModule);
                });

            migrationBuilder.CreateTable(
                name: "M_ObatUnit",
                columns: table => new
                {
                    IdObatUnit = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    BarangId = table.Column<Guid>(type: "uuid", nullable: true),
                    OldBarangId = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    KdObat = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    NmObat = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    KodeInventory = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    ExpiredDate = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    StokMin = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    StokMax = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    StokNow = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Rod = table.Column<bool>(type: "boolean", nullable: true),
                    By = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_ObatUnit", x => x.IdObatUnit);
                });

            migrationBuilder.CreateTable(
                name: "M_PaketDetail",
                columns: table => new
                {
                    IdPaketdetail = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdPaketDetail = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    NmPaketDetail = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Group = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Tipe = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Harga = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Rekanan = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PaketDetail", x => x.IdPaketdetail);
                });

            migrationBuilder.CreateTable(
                name: "M_PaketHarga",
                columns: table => new
                {
                    IdPaketkelas = table.Column<Guid>(type: "uuid", nullable: false),
                    OldIdPaketkelas = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IdMasterPemeriksaanPenunjang = table.Column<Guid>(type: "uuid", nullable: false),
                    OldIdMasterPemeriksaanPenunjang = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IdPenunjangDetail = table.Column<Guid>(type: "uuid", nullable: true),
                    OldIdPenunjangDetail = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    RekananId = table.Column<Guid>(type: "uuid", nullable: false),
                    OldRekananid = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Kelas = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Jumlah = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Harga = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Cito = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Penyulit = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    SecondTnd = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Adm = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Diskon = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Subtotal = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Beapasien = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Bearekanan = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Jasamedis = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Jasamedis2 = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Jasamedis3 = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Jasamedis4 = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Jasamedis5 = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    JasaRS = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    BahanAlkes = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    TglAwal = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    TglAkhir = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    By = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PaketHarga", x => x.IdPaketkelas);
                });

            migrationBuilder.CreateTable(
                name: "M_PaketHargaBaru",
                columns: table => new
                {
                    IdPaketkelas = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IdMasterPemeriksaanPenunjang = table.Column<Guid>(type: "uuid", nullable: false),
                    OldIdMasterPemeriksaanPenunjang = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IdPenunjangDetail = table.Column<Guid>(type: "uuid", nullable: true),
                    OldIdPenunjangDetail = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    RekananId = table.Column<Guid>(type: "uuid", nullable: false),
                    OldRekananId = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Kelas = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Jumlah = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Harga = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Cito = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Penyulit = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    SecondTnd = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Adm = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Diskon = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Subtotal = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Beapasien = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Bearekanan = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Jasamedis = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Jasamedis2 = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Jasamedis3 = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Jasamedis4 = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Jasamedis5 = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    JasaRS = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Bahanalkes = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Tglawal = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Tglakhir = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Lastupdate = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    By = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PaketHargaBaru", x => x.IdPaketkelas);
                });

            migrationBuilder.CreateTable(
                name: "M_PaketMatrix",
                columns: table => new
                {
                    IdPaketMatrix = table.Column<Guid>(type: "uuid", nullable: false),
                    OldIdPaketmatrix = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IdMasterpemeriksaanpenunjang = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Koderuangan = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PaketMatrix", x => x.IdPaketMatrix);
                });

            migrationBuilder.CreateTable(
                name: "M_PaketRekanan",
                columns: table => new
                {
                    IdPaketRekanan = table.Column<Guid>(type: "uuid", nullable: false),
                    OldIdPaketRekanan = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IdMasterPemeriksaanPenunjang = table.Column<Guid>(type: "uuid", nullable: false),
                    OldIdMasterPemeriksaanPenunjang = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    RekananId = table.Column<Guid>(type: "uuid", nullable: false),
                    OldRekananId = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PaketRekanan", x => x.IdPaketRekanan);
                });

            migrationBuilder.CreateTable(
                name: "M_PemeriksaanPenunjang",
                columns: table => new
                {
                    IdMasterPemeriksaanPenunjang = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdPemeriksaan = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    NmPemeriksaan = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    Harga = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    BeaPasien = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    BeaRekanan = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Penunjang = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    RekananId = table.Column<Guid>(type: "uuid", nullable: false),
                    OldRekananId = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    By = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    IdGroupTarif = table.Column<Guid>(type: "uuid", nullable: false),
                    OldIdGroupTarif = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PemeriksaanPenunjang", x => x.IdMasterPemeriksaanPenunjang);
                });

            migrationBuilder.CreateTable(
                name: "M_RadiologiGroup",
                columns: table => new
                {
                    IdGroup = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Nmgroup = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    IdGrouptarif = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_RadiologiGroup", x => x.IdGroup);
                });

            migrationBuilder.CreateTable(
                name: "M_Rekanan",
                columns: table => new
                {
                    IdRekanan = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    NmRekanan = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    Alamat = table.Column<string>(type: "character varying(200)", unicode: false, maxLength: 200, nullable: false),
                    Kota = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Telp = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    Alias = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    KdAkun = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    IsPaketBHP = table.Column<bool>(type: "boolean", nullable: true),
                    IsTarif = table.Column<bool>(type: "boolean", nullable: true),
                    IsTarifNonMed = table.Column<bool>(type: "boolean", nullable: true),
                    IsCob = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Rekanan", x => x.IdRekanan);
                });

            migrationBuilder.CreateTable(
                name: "M_SettingAdm",
                columns: table => new
                {
                    IdSettingAdm = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    RekananId = table.Column<Guid>(type: "uuid", nullable: false),
                    OldRekananId = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Kategori = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Biaya = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Percent = table.Column<decimal>(type: "numeric(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SettingAdm", x => x.IdSettingAdm);
                });

            migrationBuilder.CreateTable(
                name: "M_SettingBayar",
                columns: table => new
                {
                    IdSettingBayar = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CaraBayar = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    KdAkun = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SettingBayar", x => x.IdSettingBayar);
                });

            migrationBuilder.CreateTable(
                name: "M_SettingDaftar",
                columns: table => new
                {
                    IdSettingdaftar = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NmUnitDaftar = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Koderuangan = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    Tujuan = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsTampil = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SettingDaftar", x => x.IdSettingdaftar);
                });

            migrationBuilder.CreateTable(
                name: "M_SettingKomputerAntrian",
                columns: table => new
                {
                    IdSettingKomp = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NmKomputer = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    KdLokasi = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    KdJenisLayanan = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    KdCounter = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    Tanggal = table.Column<DateTime>(type: "TIMESTAMP", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SettingKomputerAntrian", x => x.IdSettingKomp);
                });

            migrationBuilder.CreateTable(
                name: "M_SettingPemeriksaan",
                columns: table => new
                {
                    IdSettingPeriksaan = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NmPemeriksaan = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Group = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    IsTampil = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SettingPemeriksaan", x => x.IdSettingPeriksaan);
                });

            migrationBuilder.CreateTable(
                name: "M_Smf",
                columns: table => new
                {
                    IdSmf = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Kdsmf = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    Nmsmf = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Smf", x => x.IdSmf);
                });

            migrationBuilder.CreateTable(
                name: "M_StandartfieldGroup",
                columns: table => new
                {
                    IdFieldgroup = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Nmfieldgroup = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    DTanggal = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    VKeterangan = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_StandartfieldGroup", x => x.IdFieldgroup);
                });

            migrationBuilder.CreateTable(
                name: "M_Status",
                columns: table => new
                {
                    IdStatus = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VStatus = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Status", x => x.IdStatus);
                });

            migrationBuilder.CreateTable(
                name: "M_Supplier",
                columns: table => new
                {
                    SupplierId = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    NamaSupplier = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Alamat = table.Column<string>(type: "character varying(500)", unicode: false, maxLength: 500, nullable: false),
                    Cp = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Fax = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Kota = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Telpon = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "character varying(500)", unicode: false, maxLength: 500, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    KdAkun = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Supplier", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "M_TarifGroup",
                columns: table => new
                {
                    IdGroupTarif = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NmGroupTarif = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    Aliasgroup = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    KdAkun = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TarifGroup", x => x.IdGroupTarif);
                });

            migrationBuilder.CreateTable(
                name: "M_TarifHarga",
                columns: table => new
                {
                    IdTarifkelas = table.Column<Guid>(type: "uuid", nullable: false),
                    OldIdTarifkelas = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Kdtarifdetail = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    RekananId = table.Column<Guid>(type: "uuid", nullable: true),
                    OldRekananId = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Kelas = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Harga = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Cito = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Penyulit = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    SecondTnd = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Adm = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Diskon = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Beapasien = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Bearekanan = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Jasamedis = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Jasamedis2 = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Jasamedis3 = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Jasamedis4 = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Jasamedis5 = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Jasars = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Bahanalkes = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Tglawal = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Tglakhir = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    By = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    Lastupdate = table.Column<DateTime>(type: "TIMESTAMP", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TarifHarga", x => x.IdTarifkelas);
                });

            migrationBuilder.CreateTable(
                name: "M_TarifMatrix",
                columns: table => new
                {
                    IdTarifmatrix = table.Column<Guid>(type: "uuid", nullable: false),
                    OldIdTarifmatrix = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IdTarifdetail = table.Column<Guid>(type: "uuid", nullable: false),
                    Kdtarifdetail = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IdRuang = table.Column<Guid>(type: "uuid", nullable: false),
                    Koderuangan = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TarifMatrix", x => x.IdTarifmatrix);
                });

            migrationBuilder.CreateTable(
                name: "M_TarifnonmedisGroup",
                columns: table => new
                {
                    IdGroupNonMedis = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nmgroupnonmedis = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Kdakun = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TarifnonmedisGroup", x => x.IdGroupNonMedis);
                });

            migrationBuilder.CreateTable(
                name: "M_TarifPelayanan",
                columns: table => new
                {
                    IdTariflayan = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KodeTarifLayan = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    NamaTarifLayan = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TarifPelayanan", x => x.IdTariflayan);
                });

            migrationBuilder.CreateTable(
                name: "M_TarifRekanan",
                columns: table => new
                {
                    IdTarifRekanan = table.Column<Guid>(type: "uuid", nullable: false),
                    OldIdTarifRekanan = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdTarifDetail = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    RekananId = table.Column<Guid>(type: "uuid", nullable: false),
                    OldRekananId = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TarifRekanan", x => x.IdTarifRekanan);
                });

            migrationBuilder.CreateTable(
                name: "M_TarifRekananSub",
                columns: table => new
                {
                    IdTarifrekanansub = table.Column<Guid>(type: "uuid", nullable: false),
                    IdTarifRekananSub = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    RekananIdHd = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    RekananidDt = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TarifRekananSub", x => x.IdTarifrekanansub);
                });

            migrationBuilder.CreateTable(
                name: "M_Tennant",
                columns: table => new
                {
                    IdTenant = table.Column<Guid>(type: "uuid", nullable: false),
                    OldIdTenant = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    TenantCode = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    TenantName = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    TenantAddress = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Website = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Logo = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    CodeLogo = table.Column<string>(type: "text", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ExpiredDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SubscriptionCode = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Tennant", x => x.IdTenant);
                });

            migrationBuilder.CreateTable(
                name: "M_Tindakan",
                columns: table => new
                {
                    IdTindakan = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdTindakan = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    NmTindakan = table.Column<string>(type: "character varying(200)", unicode: false, maxLength: 200, nullable: false),
                    NmPendek = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    IS_AKTIF = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Tindakan", x => x.IdTindakan);
                });

            migrationBuilder.CreateTable(
                name: "M_UserGroup",
                columns: table => new
                {
                    IdGroupUser = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    NmGroupUser = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_UserGroup", x => x.IdGroupUser);
                });

            migrationBuilder.CreateTable(
                name: "M_Asal",
                columns: table => new
                {
                    IdAsal = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdAsalGroup = table.Column<int>(type: "integer", nullable: true),
                    Kdasal = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    NmAsal = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Asal", x => x.IdAsal);
                    table.ForeignKey(
                        name: "FK_M_ASAL_M_ASAL_GROUP",
                        column: x => x.IdAsalGroup,
                        principalTable: "M_AsalGroup",
                        principalColumn: "IdAsalGroup");
                });

            migrationBuilder.CreateTable(
                name: "M_CoaKlasifikasi",
                columns: table => new
                {
                    IdKlasifikasi = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    NmKlasifikasi = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Urut = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    IdGolongan = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_CoaKlasifikasi", x => x.IdKlasifikasi);
                    table.ForeignKey(
                        name: "FK_M_COA_KLASIFIKASI_M_COA_GOLONGAN",
                        column: x => x.IdGolongan,
                        principalTable: "M_CoaGolongan",
                        principalColumn: "IdGolongan");
                });

            migrationBuilder.CreateTable(
                name: "M_Morfologi",
                columns: table => new
                {
                    IdMorfologi = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdMorfologi = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    NmMorfologi = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    KdDiagnosa = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    IdDiagnosa = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Morfologi", x => x.IdMorfologi);
                    table.ForeignKey(
                        name: "FK_M_MORFOLOGI_M_DIAGNOSA",
                        column: x => x.IdDiagnosa,
                        principalTable: "M_Diagnosa",
                        principalColumn: "IdDiagnosa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "M_FarmakoterapiSub",
                columns: table => new
                {
                    IdSubFarmakoterapi = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    NmSubFarmakoterapi = table.Column<string>(type: "character varying(200)", unicode: false, maxLength: 200, nullable: false),
                    IdFarmakoterapi = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_FarmakoterapiSub", x => x.IdSubFarmakoterapi);
                    table.ForeignKey(
                        name: "FK_M_FARMAKOTERAPI_SUB_M_FARMAKOTERAPI",
                        column: x => x.IdFarmakoterapi,
                        principalTable: "M_Farmakoterapi",
                        principalColumn: "IdFarmakoterapi");
                });

            migrationBuilder.CreateTable(
                name: "M_Ruang",
                columns: table => new
                {
                    IdRuang = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KodeRuangan = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    Nama = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    NoRuang = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    Kelompok = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    Kamar = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    KodeInventory = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    KodeInventoryGudangObat = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    KodeRequestObat = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    KodeRequestGudangObat = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    KodeTarif = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    IsTarif = table.Column<bool>(type: "boolean", nullable: true),
                    GdgPaket = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    GdgRetur = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    GdgPenerimaan = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    KdInhealth = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    LynInhealth = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Ruang", x => x.IdRuang);
                    table.ForeignKey(
                        name: "FK_M_RUANG_M_GUDANG2_(requestobat)",
                        column: x => x.KodeRequestGudangObat,
                        principalTable: "M_Gudang",
                        principalColumn: "IdGudangObat");
                    table.ForeignKey(
                        name: "FK_M_RUANG_M_GUDANG_(kdinventory)",
                        column: x => x.KodeInventoryGudangObat,
                        principalTable: "M_Gudang",
                        principalColumn: "IdGudangObat");
                });

            migrationBuilder.CreateTable(
                name: "M_Laboratorium",
                columns: table => new
                {
                    IdPemeriksaanLab = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdPemeriksaanLab = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    NmPemeriksaanLab = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    IdGroup = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Laboratorium", x => x.IdPemeriksaanLab);
                    table.ForeignKey(
                        name: "FK_M_LABORATORIUM_M_LABORATORIUM_GROUP",
                        column: x => x.IdGroup,
                        principalTable: "M_LaboratoriumGroup",
                        principalColumn: "IdGroup");
                });

            migrationBuilder.CreateTable(
                name: "M_ModuleDetail",
                columns: table => new
                {
                    IdModuleDetail = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdModule = table.Column<int>(type: "integer", nullable: true),
                    NmModulDetail = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    NmModuleDetailSub = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Urut = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_ModuleDetail", x => x.IdModuleDetail);
                    table.ForeignKey(
                        name: "FK_M_MODULE_DETAIL_M_MODULE",
                        column: x => x.IdModule,
                        principalTable: "M_Module",
                        principalColumn: "IdModule");
                });

            migrationBuilder.CreateTable(
                name: "M_PemeriksaanPenunjangDetail",
                columns: table => new
                {
                    IdPenunjangDetail = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IdMasterPemeriksaanPenunjang = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    KdPemeriksaan = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    KdDetail = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    NmDetail = table.Column<string>(type: "character varying(200)", unicode: false, maxLength: 200, nullable: false),
                    Group = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Tipe = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Jumlah = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Harga = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    BeaPasien = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    BeaRekanan = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    KodeTarif = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PemeriksaanPenunjangDetail", x => x.IdPenunjangDetail);
                    table.ForeignKey(
                        name: "FK_M_PEMERIKSAANPENUNJANGDETAIL_M_PEMERIKSAANPENUNJANG",
                        column: x => x.IdMasterPemeriksaanPenunjang,
                        principalTable: "M_PemeriksaanPenunjang",
                        principalColumn: "IdMasterPemeriksaanPenunjang");
                });

            migrationBuilder.CreateTable(
                name: "M_Radiologi",
                columns: table => new
                {
                    IdPemeriksaanRad = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdPemeriksaanRad = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    NmPemeriksaanRad = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    IdGroup = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Radiologi", x => x.IdPemeriksaanRad);
                    table.ForeignKey(
                        name: "FK_M_RADIOLOGI_M_RADIOLOGI_GROUP",
                        column: x => x.IdGroup,
                        principalTable: "M_RadiologiGroup",
                        principalColumn: "IdGroup");
                });

            migrationBuilder.CreateTable(
                name: "M_Pasien",
                columns: table => new
                {
                    IdPasien = table.Column<Guid>(type: "uuid", nullable: false),
                    OldIdPasien = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    PasienNo = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    NamaPasien = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    NamaKelPasien = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Kelaminpasien = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Tmptlahirpasien = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Tgllahirpasien = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    AgamaPasien = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    StatusKWNPasien = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    PendidikanPasien = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    PekerjaanPasien = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    AlamatPekerjaan = table.Column<string>(type: "character varying(200)", unicode: false, maxLength: 200, nullable: false),
                    TelpPekerjaan = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    Noktpsimpasien = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    JenisIdentitas = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    NoPenjamin = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    AlamatPasien = table.Column<string>(type: "character varying(200)", unicode: false, maxLength: 200, nullable: false),
                    KotaPasien = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    TelpPasien = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    HpPasien = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    AlergiPasien = table.Column<string>(type: "character varying(200)", unicode: false, maxLength: 200, nullable: false),
                    CatKhusPasien = table.Column<string>(type: "character varying(200)", unicode: false, maxLength: 200, nullable: false),
                    AyahPasien = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    IbuPasien = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    PasanganPasien = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    NamaPenanggung = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    AlamatPenanggung = table.Column<string>(type: "character varying(200)", unicode: false, maxLength: 200, nullable: false),
                    TelpPenanggung = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    Kodepos = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    Petugas = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Rhesus = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    Goldarah = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    Tgldaftar = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Iscetakkartu = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    Warganegara = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Jenispasien = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    RekananId = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    By = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    Suku = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Perusahaan = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    Provinsi = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    IsBlacklist = table.Column<bool>(type: "boolean", nullable: true),
                    IsKunjungan = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Pasien", x => x.IdPasien);
                    table.ForeignKey(
                        name: "FK_M_PASIEN_M_REKANAN_(rekananid)",
                        column: x => x.RekananId,
                        principalTable: "M_Rekanan",
                        principalColumn: "IdRekanan");
                });

            migrationBuilder.CreateTable(
                name: "M_Standartfield",
                columns: table => new
                {
                    IdField = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IdFieldgroup = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    KodeField = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    VDeskfield = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    Keterangan = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Standartfield", x => x.IdField);
                    table.ForeignKey(
                        name: "FK_M_STANDARTFIELD_M_STANDARTFIELD_GROUP",
                        column: x => x.IdFieldgroup,
                        principalTable: "M_StandartfieldGroup",
                        principalColumn: "IdFieldgroup");
                });

            migrationBuilder.CreateTable(
                name: "M_TarifNonMedis",
                columns: table => new
                {
                    IdNonMedis = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdTarif = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    Nmtarif = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    IdGroupNonMedis = table.Column<int>(type: "integer", nullable: true),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TarifNonMedis", x => x.IdNonMedis);
                    table.ForeignKey(
                        name: "FK_M_TarifNonMedis_M_TarifnonmedisGroup_IdGroupNonMedis",
                        column: x => x.IdGroupNonMedis,
                        principalTable: "M_TarifnonmedisGroup",
                        principalColumn: "IdGroupNonMedis");
                });

            migrationBuilder.CreateTable(
                name: "M_TarifDetail",
                columns: table => new
                {
                    IdTarifdetail = table.Column<Guid>(type: "uuid", nullable: false),
                    OldIdTarifdetail = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KodeTarifLayan = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    KdTarifDetail = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    NmTarifDetail = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    IdGroupTarif = table.Column<int>(type: "integer", nullable: true),
                    Kodetariflayan = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TarifDetail", x => x.IdTarifdetail);
                    table.ForeignKey(
                        name: "FK_M_TARIFDETAIL_M_TARIF_GROUP",
                        column: x => x.IdGroupTarif,
                        principalTable: "M_TarifGroup",
                        principalColumn: "IdGroupTarif");
                    table.ForeignKey(
                        name: "FK_M_TARIFDETAIL_M_TARIF_PELAYANAN",
                        column: x => x.Kodetariflayan,
                        principalTable: "M_TarifPelayanan",
                        principalColumn: "IdTariflayan",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "M_CoaSubKlasifikasi",
                columns: table => new
                {
                    IdSubKlasifikasi = table.Column<Guid>(type: "uuid", nullable: false),
                    OldIdSubKlasifikasi = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdSubKlasifikasi = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    NmSubKlasifikasi = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Urut = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    DC = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    IdKlasifikasi = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_CoaSubKlasifikasi", x => x.IdSubKlasifikasi);
                    table.ForeignKey(
                        name: "FK_M_COA_SUBKLASIFIKASI_M_COA_KLASIFIKASI",
                        column: x => x.IdKlasifikasi,
                        principalTable: "M_CoaKlasifikasi",
                        principalColumn: "IdKlasifikasi");
                });

            migrationBuilder.CreateTable(
                name: "M_Barang",
                columns: table => new
                {
                    barangId = table.Column<Guid>(type: "uuid", nullable: false),
                    OldBarangId = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KelompokId = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    kode = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    Nama = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    Satuan = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Merk = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Ukuran = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    Jenis = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    ExpiredDate = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Etiket = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Isi = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Kandungan = table.Column<string>(type: "character varying(200)", unicode: false, maxLength: 200, nullable: false),
                    Kemasan = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Pabrik = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    TipeBarang = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    Note = table.Column<string>(type: "character varying(500)", unicode: false, maxLength: 500, nullable: false),
                    Farmakoterapi = table.Column<string>(type: "character varying(200)", unicode: false, maxLength: 200, nullable: false),
                    SubFarmakoterapi = table.Column<string>(type: "character varying(200)", unicode: false, maxLength: 200, nullable: false),
                    IdFarmakoterapi = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    IdSubFarmakoterapi = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    HargaBeli = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    DiskonOn = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    HargaJual = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    DiskonOff = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    StokMin = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    StokMax = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    StokNow = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    NoBatch = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Timestamp = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: true),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    IsFormularium = table.Column<bool>(type: "boolean", nullable: true),
                    EtiketQty = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Barang", x => x.barangId);
                    table.ForeignKey(
                        name: "FK_M_BARANG_M_FARMAKOTERAPI",
                        column: x => x.IdFarmakoterapi,
                        principalTable: "M_Farmakoterapi",
                        principalColumn: "IdFarmakoterapi");
                    table.ForeignKey(
                        name: "FK_M_BARANG_M_FARMAKOTERAPI_SUB",
                        column: x => x.IdSubFarmakoterapi,
                        principalTable: "M_FarmakoterapiSub",
                        principalColumn: "IdSubFarmakoterapi");
                    table.ForeignKey(
                        name: "FK_M_BARANG_M_KELOMPOKBARANG2",
                        column: x => x.KelompokId,
                        principalTable: "M_KelompokBarang",
                        principalColumn: "KelompokId");
                });

            migrationBuilder.CreateTable(
                name: "M_Map",
                columns: table => new
                {
                    IdMapid = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    NmMap = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    KodeRuangan = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    IdRuang = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Note = table.Column<string>(type: "character varying(200)", unicode: false, maxLength: 200, nullable: false),
                    Image = table.Column<byte[]>(type: "BYTEA", nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Map", x => x.IdMapid);
                    table.ForeignKey(
                        name: "FK_M_MAP_M_RUANG",
                        column: x => x.IdRuang,
                        principalTable: "M_Ruang",
                        principalColumn: "IdRuang");
                });

            migrationBuilder.CreateTable(
                name: "M_LaboratoriumHarga",
                columns: table => new
                {
                    IdLabharga = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdPemeriksaanLab = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    IdPemeriksaanLab = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    RekananId = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Kelas = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    IdHargakamar = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Harga = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Beapasien = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Bearekanan = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Jasamedis = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Jasars = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Bahanalkes = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Diskon = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Cito = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Penyulit = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    SecondTnd = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Adm = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Tglawal = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Tglakhir = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    By = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "TIMESTAMP", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_LaboratoriumHarga", x => x.IdLabharga);
                    table.ForeignKey(
                        name: "FK_M_LABORATORIUM_HARGA_M_HARGAKAMAR",
                        column: x => x.IdHargakamar,
                        principalTable: "M_Hargakamar",
                        principalColumn: "IdHargakamar");
                    table.ForeignKey(
                        name: "FK_M_LABORATORIUM_HARGA_M_LABORATORIUM",
                        column: x => x.IdPemeriksaanLab,
                        principalTable: "M_Laboratorium",
                        principalColumn: "IdPemeriksaanLab");
                    table.ForeignKey(
                        name: "FK_M_LABORATORIUM_HARGA_M_REKANAN",
                        column: x => x.RekananId,
                        principalTable: "M_Rekanan",
                        principalColumn: "IdRekanan");
                });

            migrationBuilder.CreateTable(
                name: "M_LaboratoriumRekanan",
                columns: table => new
                {
                    IdLabrekanan = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdPemeriksaanLab = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    IdPemeriksaanLab = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    RekananId = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_LaboratoriumRekanan", x => x.IdLabrekanan);
                    table.ForeignKey(
                        name: "FK_M_LABORATORIUM_REKANAN_M_LABORATORIUM",
                        column: x => x.IdPemeriksaanLab,
                        principalTable: "M_Laboratorium",
                        principalColumn: "IdPemeriksaanLab");
                    table.ForeignKey(
                        name: "FK_M_LABORATORIUM_REKANAN_M_REKANAN",
                        column: x => x.RekananId,
                        principalTable: "M_Rekanan",
                        principalColumn: "IdRekanan");
                });

            migrationBuilder.CreateTable(
                name: "M_RadiologiHarga",
                columns: table => new
                {
                    IdRadHarga = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdPemeriksaanRad = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    IdPemeriksaanRad = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    RekananId = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Kelas = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    IdHargakamar = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Harga = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    BeaPasien = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    BeaRekanan = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    JasaMedis = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    JasaRS = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    BahanAlkes = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Diskon = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Cito = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Penyulit = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    SecondTnd = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Adm = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Tglawal = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Tglakhir = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    By = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    Lastupdate = table.Column<DateTime>(type: "TIMESTAMP", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_RadiologiHarga", x => x.IdRadHarga);
                    table.ForeignKey(
                        name: "FK_M_RADIOLOGI_HARGA_M_HARGAKAMAR",
                        column: x => x.IdHargakamar,
                        principalTable: "M_Hargakamar",
                        principalColumn: "IdHargakamar");
                    table.ForeignKey(
                        name: "FK_M_RADIOLOGI_HARGA_M_RADIOLOGI",
                        column: x => x.IdPemeriksaanRad,
                        principalTable: "M_Radiologi",
                        principalColumn: "IdPemeriksaanRad");
                    table.ForeignKey(
                        name: "FK_M_RADIOLOGI_HARGA_M_REKANAN",
                        column: x => x.RekananId,
                        principalTable: "M_Rekanan",
                        principalColumn: "IdRekanan");
                });

            migrationBuilder.CreateTable(
                name: "M_RadiologiRekanan",
                columns: table => new
                {
                    IdRadrekanan = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdPemeriksaanRad = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    IdPemeriksaanRad = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    RekananId = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_RadiologiRekanan", x => x.IdRadrekanan);
                    table.ForeignKey(
                        name: "FK_M_RADIOLOGI_REKANAN_M_RADIOLOGI",
                        column: x => x.IdPemeriksaanRad,
                        principalTable: "M_Radiologi",
                        principalColumn: "IdPemeriksaanRad");
                    table.ForeignKey(
                        name: "FK_M_RADIOLOGI_REKANAN_M_REKANAN",
                        column: x => x.RekananId,
                        principalTable: "M_Rekanan",
                        principalColumn: "IdRekanan");
                });

            migrationBuilder.CreateTable(
                name: "M_TarifnonmedisHarga",
                columns: table => new
                {
                    IdNonmedishrg = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Kdtarif = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    IdTarifNon = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Harga = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Beapasien = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Bearekanan = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    OldRekananId = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    RekananId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TarifnonmedisHarga", x => x.IdNonmedishrg);
                    table.ForeignKey(
                        name: "FK_M_TARIFNONMEDIS_HARGA_M_TARIFNONMEDIS",
                        column: x => x.IdTarifNon,
                        principalTable: "M_TarifNonMedis",
                        principalColumn: "IdNonMedis");
                });

            migrationBuilder.CreateTable(
                name: "M_TarifnonmedisMatrix",
                columns: table => new
                {
                    IdNonMedisMatrix = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdTarif = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    IdNonMedis = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KodeRuangan = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TarifnonmedisMatrix", x => x.IdNonMedisMatrix);
                    table.ForeignKey(
                        name: "FK_M_TARIFNONMEDIS_MATRIX_M_TARIFNONMEDIS",
                        column: x => x.IdNonMedis,
                        principalTable: "M_TarifNonMedis",
                        principalColumn: "IdNonMedis");
                });

            migrationBuilder.CreateTable(
                name: "M_TarifnonmedisRekanan",
                columns: table => new
                {
                    IdNonMedRek = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KdTarif = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    IdTarifNon = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    OldIdRekanan = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    IdRekanan = table.Column<Guid>(type: "uuid", nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TarifnonmedisRekanan", x => x.IdNonMedRek);
                    table.ForeignKey(
                        name: "FK_M_TARIFNONMEDIS_REKANAN_M_TARIFNONMEDIS",
                        column: x => x.IdTarifNon,
                        principalTable: "M_TarifNonMedis",
                        principalColumn: "IdNonMedis",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "M_Coa",
                columns: table => new
                {
                    IdCoa = table.Column<Guid>(type: "uuid", nullable: false),
                    OldIdCoa = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Kdakun = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    NmAkun = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    NmAkunAlias = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    DC = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    TglSaldoAwal = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    SaldoAwal = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Subklasifikasi = table.Column<Guid>(type: "uuid", nullable: true),
                    OldSubklasifikasi = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Coa", x => x.IdCoa);
                    table.ForeignKey(
                        name: "FK_M_COA_M_COA_SUBKLASIFIKASI",
                        column: x => x.Subklasifikasi,
                        principalTable: "M_CoaSubKlasifikasi",
                        principalColumn: "IdSubKlasifikasi");
                });

            migrationBuilder.CreateTable(
                name: "M_HargaBarang",
                columns: table => new
                {
                    IdHargaBeli = table.Column<Guid>(type: "uuid", nullable: false),
                    OldIdHargaBeli = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    BarangId = table.Column<Guid>(type: "uuid", nullable: true),
                    OldBarangId = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    SupplierId = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Harga = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    InputBy = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    DiskonOn = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    DiskonOff = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    PPN = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_HargaBarang", x => x.IdHargaBeli);
                    table.ForeignKey(
                        name: "FK_M_HARGABARANG_M_BARANG",
                        column: x => x.BarangId,
                        principalTable: "M_Barang",
                        principalColumn: "barangId");
                    table.ForeignKey(
                        name: "FK_M_HARGABARANG_M_SUPPLIER",
                        column: x => x.SupplierId,
                        principalTable: "M_Supplier",
                        principalColumn: "SupplierId");
                });

            migrationBuilder.CreateTable(
                name: "M_HargaRekanan",
                columns: table => new
                {
                    IdHargaRekanan = table.Column<Guid>(type: "uuid", nullable: false),
                    OldIdHargaRekanan = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    OldBarangId = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    BarangId = table.Column<Guid>(type: "uuid", nullable: true),
                    RekananId = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Harga = table.Column<decimal>(type: "numeric(19,2)", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    InpuBy = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Margin = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Diskon = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Ppn = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Hargajual = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_HargaRekanan", x => x.IdHargaRekanan);
                    table.ForeignKey(
                        name: "FK_M_HARGAREKANAN_M_BARANG",
                        column: x => x.BarangId,
                        principalTable: "M_Barang",
                        principalColumn: "barangId");
                    table.ForeignKey(
                        name: "FK_M_HARGAREKANAN_M_REKANAN",
                        column: x => x.RekananId,
                        principalTable: "M_Rekanan",
                        principalColumn: "IdRekanan");
                });

            migrationBuilder.CreateTable(
                name: "M_Kamarinap",
                columns: table => new
                {
                    IdKamarInap = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdTmpTidur = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    Kelas = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    IdHargakamar = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Lantai = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    Nokamar = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    KodeTarif = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    KodeRuangan = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    Isi = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    IX = table.Column<int>(type: "integer", nullable: true),
                    IY = table.Column<int>(type: "integer", nullable: true),
                    IdMapid = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Kamarinap", x => x.IdKamarInap);
                    table.ForeignKey(
                        name: "FK_M_KAMARINAP_M_HARGAKAMAR",
                        column: x => x.IdHargakamar,
                        principalTable: "M_Hargakamar",
                        principalColumn: "IdHargakamar");
                    table.ForeignKey(
                        name: "FK_M_KAMARINAP_M_MAP",
                        column: x => x.IdMapid,
                        principalTable: "M_Map",
                        principalColumn: "IdMapid");
                });

            migrationBuilder.CreateTable(
                name: "M_Dokter",
                columns: table => new
                {
                    IdDokter = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdDokter = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    NmDokter = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    SpesialisasiDokter = table.Column<string>(type: "character varying(60)", unicode: false, maxLength: 60, nullable: false),
                    AlamatDokter = table.Column<string>(type: "character varying(200)", unicode: false, maxLength: 200, nullable: false),
                    TelpDokter = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    AlamatPraktek = table.Column<string>(type: "character varying(200)", unicode: false, maxLength: 200, nullable: false),
                    Telppraktek = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true),
                    ImgFotodokter = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    KodeTarif = table.Column<string>(type: "character(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    KdAkun = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    IdCoa = table.Column<Guid>(type: "uuid", nullable: false),
                    By = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsTtd = table.Column<string>(type: "text", nullable: false),
                    Pin = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    NoSip = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Dokter", x => x.IdDokter);
                    table.ForeignKey(
                        name: "FK_M_DOKTER_M_COA",
                        column: x => x.IdCoa,
                        principalTable: "M_Coa",
                        principalColumn: "IdCoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "M_KamarinapHarga",
                columns: table => new
                {
                    IdKamarInapHarga = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdTmpTidur = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    IdKamarInap = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    RekananId = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Harga = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    BeaPasien = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    BeaRekanan = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    JasaMedis = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    JasaRS = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Bahanalkes = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Diskon = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    DCito = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    DPenyulit = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    SecondTnd = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Adm = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Tglawal = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Tglakhir = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    By = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_KamarinapHarga", x => x.IdKamarInapHarga);
                    table.ForeignKey(
                        name: "FK_M_KAMARINAP_HARGA_M_KAMARINAP",
                        column: x => x.IdKamarInap,
                        principalTable: "M_Kamarinap",
                        principalColumn: "IdKamarInap",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "M_JadwalDokter",
                columns: table => new
                {
                    IdJadwal = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KdDokter = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    IdDokter = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Hari = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    JamStart = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    JamFinish = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    KodeRuangan = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    IdRuangan = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    NamaKlinik = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    ServisTime = table.Column<int>(type: "integer", nullable: true),
                    IsAktif = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_JadwalDokter", x => x.IdJadwal);
                    table.ForeignKey(
                        name: "FK_M_JADWALDOKTER_M_DOKTER_(kddokter)",
                        column: x => x.IdDokter,
                        principalTable: "M_Dokter",
                        principalColumn: "IdDokter",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_M_JADWALDOKTER_M_RUANG_(kdruangan)",
                        column: x => x.IdRuangan,
                        principalTable: "M_Ruang",
                        principalColumn: "IdRuang");
                });

            migrationBuilder.CreateTable(
                name: "M_User",
                columns: table => new
                {
                    IdUser = table.Column<Guid>(type: "uuid", nullable: false),
                    OldIdUser = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    KodeRuangan = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    IdRuang = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Namalengkap = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Nmuser = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    KdDokter = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    IdDokter = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IsUser = table.Column<bool>(type: "boolean", nullable: true),
                    IsManager = table.Column<bool>(type: "boolean", nullable: true),
                    IsAdmin = table.Column<bool>(type: "boolean", nullable: true),
                    IsMod = table.Column<bool>(type: "boolean", nullable: true),
                    IsDokter = table.Column<bool>(type: "boolean", nullable: true),
                    IsMemo = table.Column<bool>(type: "boolean", nullable: true),
                    IdGroupUser = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Ttd = table.Column<string>(type: "text", nullable: false),
                    Isaktif = table.Column<bool>(type: "boolean", nullable: true),
                    Id = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Transmigrated = table.Column<bool>(type: "boolean", nullable: true),
                    IdKaryawan = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    PIN = table.Column<decimal>(type: "numeric(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_User", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_M_USER_M_DOKTER",
                        column: x => x.IdDokter,
                        principalTable: "M_Dokter",
                        principalColumn: "IdDokter",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_M_USER_M_RUANG",
                        column: x => x.IdRuang,
                        principalTable: "M_Ruang",
                        principalColumn: "IdRuang");
                    table.ForeignKey(
                        name: "FK_M_USER_M_USER_GROUP",
                        column: x => x.IdGroupUser,
                        principalTable: "M_UserGroup",
                        principalColumn: "IdGroupUser");
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_AntrianCounter_idcounter",
                table: "M_AntrianCounter",
                column: "IdCounter");

            migrationBuilder.CreateIndex(
                name: "IX_M_AntrianCounter_isaktif",
                table: "M_AntrianCounter",
                column: "IsAktif");

            migrationBuilder.CreateIndex(
                name: "IX_M_AntrianCounter_vkdcounter",
                table: "M_AntrianCounter",
                column: "Kdcounter");

            migrationBuilder.CreateIndex(
                name: "IX_M_AntrianCounter_vnmcounter",
                table: "M_AntrianCounter",
                column: "Counter");

            migrationBuilder.CreateIndex(
                name: "IX_M_AntrianCounterAudio__kdlayanan",
                table: "M_AntrianCounterAudio",
                column: "KdLayanan");

            migrationBuilder.CreateIndex(
                name: "IX_M_AntrianCounterAudio__kdlokasi",
                table: "M_AntrianCounterAudio",
                column: "KdLokasi");

            migrationBuilder.CreateIndex(
                name: "IX_M_AntrianCounterAudio_counter",
                table: "M_AntrianCounterAudio",
                column: "Counter");

            migrationBuilder.CreateIndex(
                name: "IX_M_AntrianCounterAudio_file",
                table: "M_AntrianCounterAudio",
                column: "File");

            migrationBuilder.CreateIndex(
                name: "IX_M_AntrianCounterAudio_idcounteraudio",
                table: "M_AntrianCounterAudio",
                column: "IdCounterAudio");

            migrationBuilder.CreateIndex(
                name: "IX_M_AntrianCounterAudio_isaktif",
                table: "M_AntrianCounterAudio",
                column: "IsAktif");

            migrationBuilder.CreateIndex(
                name: "IX_M_AntrianCounterAudio_kdcounter",
                table: "M_AntrianCounterAudio",
                column: "KdCounter");

            migrationBuilder.CreateIndex(
                name: "IX_M_AntrianCounterAudio_nomor",
                table: "M_AntrianCounterAudio",
                column: "Nomor");

            migrationBuilder.CreateIndex(
                name: "IX_M_AntrianLayanan_idlayanan",
                table: "M_AntrianLayanan",
                column: "IdLayanan");

            migrationBuilder.CreateIndex(
                name: "IX_M_AntrianLayanan_inisial",
                table: "M_AntrianLayanan",
                column: "Inisial");

            migrationBuilder.CreateIndex(
                name: "IX_M_AntrianLayanan_isaktif",
                table: "M_AntrianLayanan",
                column: "IsAktif");

            migrationBuilder.CreateIndex(
                name: "IX_M_AntrianLayanan_vkdlayan",
                table: "M_AntrianLayanan",
                column: "KdLayanan");

            migrationBuilder.CreateIndex(
                name: "IX_M_AntrianLayanan_vlayanan",
                table: "M_AntrianLayanan",
                column: "Layanan");

            migrationBuilder.CreateIndex(
                name: "IX_M_AntrianLokasi_action",
                table: "M_AntrianLokasi",
                column: "Action");

            migrationBuilder.CreateIndex(
                name: "IX_M_AntrianLokasi_idlokasi",
                table: "M_AntrianLokasi",
                column: "IdLokasi");

            migrationBuilder.CreateIndex(
                name: "IX_M_AntrianLokasi_isaktif",
                table: "M_AntrianLokasi",
                column: "IsAktif");

            migrationBuilder.CreateIndex(
                name: "IX_M_AntrianLokasi_vkdlokasi",
                table: "M_AntrianLokasi",
                column: "Kdlokasi");

            migrationBuilder.CreateIndex(
                name: "IX_M_AntrianLokasi_vlokasi",
                table: "M_AntrianLokasi",
                column: "Lokasi");

            migrationBuilder.CreateIndex(
                name: "IX_M_Asal_IdAsal",
                table: "M_Asal",
                column: "IdAsal");

            migrationBuilder.CreateIndex(
                name: "IX_M_Asal_IdAsalgroup",
                table: "M_Asal",
                column: "IdAsalGroup");

            migrationBuilder.CreateIndex(
                name: "IX_M_Asal_IsAktif",
                table: "M_Asal",
                column: "IsAktif");

            migrationBuilder.CreateIndex(
                name: "IX_M_Asal_Kdasal",
                table: "M_Asal",
                column: "Kdasal");

            migrationBuilder.CreateIndex(
                name: "IX_M_Asal_Nmasal",
                table: "M_Asal",
                column: "NmAsal");

            migrationBuilder.CreateIndex(
                name: "IX_M_AsalGroup_IdAsalGroup",
                table: "M_AsalGroup",
                column: "IdAsalGroup");

            migrationBuilder.CreateIndex(
                name: "IX_M_AsalGroup_IS_Aktif",
                table: "M_AsalGroup",
                column: "IsAktif");

            migrationBuilder.CreateIndex(
                name: "IX_M_AsalGroup_NamaGroupAsal",
                table: "M_AsalGroup",
                column: "NamaGroupAsal");

            migrationBuilder.CreateIndex(
                name: "IX_M_AturanPakai_IdAturanPakai",
                table: "M_AturanPakai",
                column: "IdAturanpakai");

            migrationBuilder.CreateIndex(
                name: "IX_M_AturanPakai_IsAktif",
                table: "M_AturanPakai",
                column: "IsAktif");

            migrationBuilder.CreateIndex(
                name: "IX_M_AturanPakai_KdAturanPakai",
                table: "M_AturanPakai",
                column: "KdAturanPakai");

            migrationBuilder.CreateIndex(
                name: "IX_M_AturanPakai_KetAturanPakai",
                table: "M_AturanPakai",
                column: "KetAturanpakai");

            migrationBuilder.CreateIndex(
                name: "IX_M_AturanPakai_NmAturanPakai",
                table: "M_AturanPakai",
                column: "NamaAturanpakai");

            migrationBuilder.CreateIndex(
                name: "IX_M_Barang_Etiket",
                table: "M_Barang",
                column: "Etiket");

            migrationBuilder.CreateIndex(
                name: "IX_M_Barang_Farmakoterapi",
                table: "M_Barang",
                column: "Farmakoterapi");

            migrationBuilder.CreateIndex(
                name: "IX_M_Barang_IdBarang",
                table: "M_Barang",
                column: "barangId");

            migrationBuilder.CreateIndex(
                name: "IX_M_Barang_IdFarmakoterapi",
                table: "M_Barang",
                column: "IdFarmakoterapi");

            migrationBuilder.CreateIndex(
                name: "IX_M_Barang_IdSubFarmakoterapi",
                table: "M_Barang",
                column: "IdSubFarmakoterapi");

            migrationBuilder.CreateIndex(
                name: "IX_M_Barang_IsAktif",
                table: "M_Barang",
                column: "IsAktif");

            migrationBuilder.CreateIndex(
                name: "IX_M_Barang_Isi",
                table: "M_Barang",
                column: "Isi");

            migrationBuilder.CreateIndex(
                name: "IX_M_Barang_Jenis",
                table: "M_Barang",
                column: "Jenis");

            migrationBuilder.CreateIndex(
                name: "IX_M_Barang_Kandungan",
                table: "M_Barang",
                column: "Kandungan");

            migrationBuilder.CreateIndex(
                name: "IX_M_Barang_kelompokId",
                table: "M_Barang",
                column: "KelompokId");

            migrationBuilder.CreateIndex(
                name: "IX_M_Barang_Kemasan",
                table: "M_Barang",
                column: "Kemasan");

            migrationBuilder.CreateIndex(
                name: "IX_M_Barang_Kode",
                table: "M_Barang",
                column: "kode");

            migrationBuilder.CreateIndex(
                name: "IX_M_Barang_Merk",
                table: "M_Barang",
                column: "Merk");

            migrationBuilder.CreateIndex(
                name: "IX_M_Barang_Nama",
                table: "M_Barang",
                column: "Nama");

            migrationBuilder.CreateIndex(
                name: "IX_M_Barang_Pabrik",
                table: "M_Barang",
                column: "Pabrik");

            migrationBuilder.CreateIndex(
                name: "IX_M_Barang_Satuan",
                table: "M_Barang",
                column: "Satuan");

            migrationBuilder.CreateIndex(
                name: "IX_M_Barang_SubFarmakoterapi",
                table: "M_Barang",
                column: "SubFarmakoterapi");

            migrationBuilder.CreateIndex(
                name: "IX_M_Barang_TipeBarang",
                table: "M_Barang",
                column: "TipeBarang");

            migrationBuilder.CreateIndex(
                name: "IX_M_Barang_Ukuran",
                table: "M_Barang",
                column: "Ukuran");

            migrationBuilder.CreateIndex(
                name: "IX_M_Coa_ISAKTIF",
                table: "M_Coa",
                column: "IsAktif");

            migrationBuilder.CreateIndex(
                name: "IX_M_Coa_SALDO",
                table: "M_Coa",
                column: "SaldoAwal");

            migrationBuilder.CreateIndex(
                name: "IX_M_Coa_Subklasifikasi",
                table: "M_Coa",
                column: "Subklasifikasi");

            migrationBuilder.CreateIndex(
                name: "IX_M_Coa_VDC",
                table: "M_Coa",
                column: "DC");

            migrationBuilder.CreateIndex(
                name: "IX_M_Coa_VKDAKUN",
                table: "M_Coa",
                column: "Kdakun");

            migrationBuilder.CreateIndex(
                name: "IX_M_Coa_VNMAKUN",
                table: "M_Coa",
                column: "NmAkun");

            migrationBuilder.CreateIndex(
                name: "IX_M_CoaGolongan_IsAktif",
                table: "M_CoaGolongan",
                column: "IsAktif");

            migrationBuilder.CreateIndex(
                name: "IX_M_CoaGolongan_NmGolo",
                table: "M_CoaGolongan",
                column: "NmGolongan");

            migrationBuilder.CreateIndex(
                name: "IX_M_CoaKlasifikasi_IdGolongan",
                table: "M_CoaKlasifikasi",
                column: "IdGolongan");

            migrationBuilder.CreateIndex(
                name: "IX_M_CoaKlasifikasi_IsAktif",
                table: "M_CoaKlasifikasi",
                column: "IsAktif");

            migrationBuilder.CreateIndex(
                name: "IX_M_CoaKlasifikasi_NmKlasifikasi",
                table: "M_CoaKlasifikasi",
                column: "NmKlasifikasi");

            migrationBuilder.CreateIndex(
                name: "IX_M_CoaSubKlasifikasi_DC",
                table: "M_CoaSubKlasifikasi",
                column: "DC");

            migrationBuilder.CreateIndex(
                name: "IX_M_CoaSubKlasifikasi_IdKlasifikasi",
                table: "M_CoaSubKlasifikasi",
                column: "IdKlasifikasi");

            migrationBuilder.CreateIndex(
                name: "IX_M_CoaSubKlasifikasi_ISAKTIF",
                table: "M_CoaSubKlasifikasi",
                column: "IsAktif");

            migrationBuilder.CreateIndex(
                name: "IX_M_CoaSubKlasifikasi_Kdsub",
                table: "M_CoaSubKlasifikasi",
                column: "KdSubKlasifikasi");

            migrationBuilder.CreateIndex(
                name: "IX_M_CoaSubKlasifikasi_Nmsub",
                table: "M_CoaSubKlasifikasi",
                column: "NmSubKlasifikasi");

            migrationBuilder.CreateIndex(
                name: "IX_M_Diagnosa_KdDiagnosa",
                table: "M_Diagnosa",
                column: "KdDiagnosa");

            migrationBuilder.CreateIndex(
                name: "IX_M_Diagnosa_NmDiagnosa",
                table: "M_Diagnosa",
                column: "NmDiagnosa");

            migrationBuilder.CreateIndex(
                name: "IX_M_Dokter_IdCoa",
                table: "M_Dokter",
                column: "IdCoa");

            migrationBuilder.CreateIndex(
                name: "IX_M_Dokter_KdDokter",
                table: "M_Dokter",
                column: "KdDokter");

            migrationBuilder.CreateIndex(
                name: "IX_M_Dokter_NmDokter",
                table: "M_Dokter",
                column: "NmDokter");

            migrationBuilder.CreateIndex(
                name: "IX_M_FarmakoterapiSub_IdFarmakoterapi",
                table: "M_FarmakoterapiSub",
                column: "IdFarmakoterapi");

            migrationBuilder.CreateIndex(
                name: "IX_M_Gudang_IsAktif",
                table: "M_Gudang",
                column: "IsAktif");

            migrationBuilder.CreateIndex(
                name: "IX_M_Gudang_Isrequest",
                table: "M_Gudang",
                column: "IsRequest");

            migrationBuilder.CreateIndex(
                name: "IX_M_GudangKdinv",
                table: "M_Gudang",
                column: "KodeInventory");

            migrationBuilder.CreateIndex(
                name: "IX_M_GudangLisrop",
                table: "M_Gudang",
                column: "IsListropp");

            migrationBuilder.CreateIndex(
                name: "IX_M_GudangNamagudang",
                table: "M_Gudang",
                column: "NamaGudangObat");

            migrationBuilder.CreateIndex(
                name: "IX_M_HargaBarang_barangId",
                table: "M_HargaBarang",
                column: "BarangId");

            migrationBuilder.CreateIndex(
                name: "IX_M_HargaBarang_diskonOff",
                table: "M_HargaBarang",
                column: "DiskonOff");

            migrationBuilder.CreateIndex(
                name: "IX_M_HargaBarang_diskonOn",
                table: "M_HargaBarang",
                column: "DiskonOn");

            migrationBuilder.CreateIndex(
                name: "IX_M_HargaBarang_harga",
                table: "M_HargaBarang",
                column: "Harga");

            migrationBuilder.CreateIndex(
                name: "IX_M_HargaBarang_IsAktif",
                table: "M_HargaBarang",
                column: "IsAktif");

            migrationBuilder.CreateIndex(
                name: "IX_M_HargaBarang_lastupdate",
                table: "M_HargaBarang",
                column: "LastUpdate");

            migrationBuilder.CreateIndex(
                name: "IX_M_HargaBarang_ppn",
                table: "M_HargaBarang",
                column: "PPN");

            migrationBuilder.CreateIndex(
                name: "IX_M_HargaBarang_supplierId",
                table: "M_HargaBarang",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_M_HargaRekanan_barangId",
                table: "M_HargaRekanan",
                column: "BarangId");

            migrationBuilder.CreateIndex(
                name: "IX_M_HargaRekanan_harga",
                table: "M_HargaRekanan",
                column: "Harga");

            migrationBuilder.CreateIndex(
                name: "IX_M_HargaRekanan_hargaJual",
                table: "M_HargaRekanan",
                column: "Hargajual");

            migrationBuilder.CreateIndex(
                name: "IX_M_HargaRekanan_idHargaRekanan",
                table: "M_HargaRekanan",
                column: "IdHargaRekanan");

            migrationBuilder.CreateIndex(
                name: "IX_M_HargaRekanan_isAktif",
                table: "M_HargaRekanan",
                column: "IsAktif");

            migrationBuilder.CreateIndex(
                name: "IX_M_HargaRekanan_lastUpdate",
                table: "M_HargaRekanan",
                column: "LastUpdate");

            migrationBuilder.CreateIndex(
                name: "IX_M_HargaRekanan_rekananId",
                table: "M_HargaRekanan",
                column: "RekananId");

            migrationBuilder.CreateIndex(
                name: "IX_M_JadwalDokter_Hari",
                table: "M_JadwalDokter",
                column: "Hari");

            migrationBuilder.CreateIndex(
                name: "IX_M_JadwalDokter_IdDokter",
                table: "M_JadwalDokter",
                column: "IdDokter");

            migrationBuilder.CreateIndex(
                name: "IX_M_JadwalDokter_IdJadwal",
                table: "M_JadwalDokter",
                column: "IdJadwal");

            migrationBuilder.CreateIndex(
                name: "IX_M_JadwalDokter_IdRuangan",
                table: "M_JadwalDokter",
                column: "IdRuangan");

            migrationBuilder.CreateIndex(
                name: "IX_M_JadwalDokter_IsAktif",
                table: "M_JadwalDokter",
                column: "IsAktif");

            migrationBuilder.CreateIndex(
                name: "IX_M_JadwalDokter_JamFinish",
                table: "M_JadwalDokter",
                column: "JamFinish");

            migrationBuilder.CreateIndex(
                name: "IX_M_JadwalDokter_JamStart",
                table: "M_JadwalDokter",
                column: "JamStart");

            migrationBuilder.CreateIndex(
                name: "IX_M_JadwalDokter_KdDokter",
                table: "M_JadwalDokter",
                column: "KdDokter");

            migrationBuilder.CreateIndex(
                name: "IX_M_JadwalDokter_KdRuangan",
                table: "M_JadwalDokter",
                column: "KodeRuangan");

            migrationBuilder.CreateIndex(
                name: "IX_M_JadwalDokter_NamaKlinik",
                table: "M_JadwalDokter",
                column: "NamaKlinik");

            migrationBuilder.CreateIndex(
                name: "IX_M_Kamarinap_IdHargakamar",
                table: "M_Kamarinap",
                column: "IdHargakamar");

            migrationBuilder.CreateIndex(
                name: "IX_M_Kamarinap_IdMapid",
                table: "M_Kamarinap",
                column: "IdMapid");

            migrationBuilder.CreateIndex(
                name: "IX_TM_KAMARINAP_kdtmptidur",
                table: "M_Kamarinap",
                column: "KdTmpTidur");

            migrationBuilder.CreateIndex(
                name: "IX_TM_KAMARINAP_lantai",
                table: "M_Kamarinap",
                column: "Lantai");

            migrationBuilder.CreateIndex(
                name: "IX_M_KamarinapHarga_IdKamarInap",
                table: "M_KamarinapHarga",
                column: "IdKamarInap");

            migrationBuilder.CreateIndex(
                name: "IX_M_KelompokBarang_IDGROUP",
                table: "M_KelompokBarang",
                column: "IdGroupTarif");

            migrationBuilder.CreateIndex(
                name: "IX_M_KelompokBarang_ISAKTIF",
                table: "M_KelompokBarang",
                column: "IsAktif");

            migrationBuilder.CreateIndex(
                name: "IX_M_KelompokBarang_KELOMPOKID",
                table: "M_KelompokBarang",
                column: "KelompokId");

            migrationBuilder.CreateIndex(
                name: "IX_M_KelompokBarang_KODE",
                table: "M_KelompokBarang",
                column: "Kode");

            migrationBuilder.CreateIndex(
                name: "IX_M_KelompokBarang_NAMA",
                table: "M_KelompokBarang",
                column: "Nama");

            migrationBuilder.CreateIndex(
                name: "IX_M_Laboratorium_IdGroup",
                table: "M_Laboratorium",
                column: "IdGroup");

            migrationBuilder.CreateIndex(
                name: "IX_M_LaboratoriumHarga_IdHargakamar",
                table: "M_LaboratoriumHarga",
                column: "IdHargakamar");

            migrationBuilder.CreateIndex(
                name: "IX_M_LaboratoriumHarga_IdPemeriksaanLab",
                table: "M_LaboratoriumHarga",
                column: "IdPemeriksaanLab");

            migrationBuilder.CreateIndex(
                name: "IX_M_LaboratoriumHarga_RekananId",
                table: "M_LaboratoriumHarga",
                column: "RekananId");

            migrationBuilder.CreateIndex(
                name: "IX_M_LaboratoriumRekanan_IdPemeriksaanLab",
                table: "M_LaboratoriumRekanan",
                column: "IdPemeriksaanLab");

            migrationBuilder.CreateIndex(
                name: "IX_M_LaboratoriumRekanan_RekananId",
                table: "M_LaboratoriumRekanan",
                column: "RekananId");

            migrationBuilder.CreateIndex(
                name: "IX_M_Map_IdRuang",
                table: "M_Map",
                column: "IdRuang");

            migrationBuilder.CreateIndex(
                name: "IX_M_ModuleDetail_IdModule",
                table: "M_ModuleDetail",
                column: "IdModule");

            migrationBuilder.CreateIndex(
                name: "IX_M_Morfologi_IdDiagnosa",
                table: "M_Morfologi",
                column: "IdDiagnosa");

            migrationBuilder.CreateIndex(
                name: "IX_M_ObatUnit_barangid",
                table: "M_ObatUnit",
                column: "BarangId");

            migrationBuilder.CreateIndex(
                name: "IX_M_ObatUnit_d_expireddate",
                table: "M_ObatUnit",
                column: "ExpiredDate");

            migrationBuilder.CreateIndex(
                name: "IX_M_ObatUnit_d_stokmax",
                table: "M_ObatUnit",
                column: "StokMax");

            migrationBuilder.CreateIndex(
                name: "IX_M_ObatUnit_d_stokmin",
                table: "M_ObatUnit",
                column: "StokMin");

            migrationBuilder.CreateIndex(
                name: "IX_M_ObatUnit_d_stoknow",
                table: "M_ObatUnit",
                column: "StokNow");

            migrationBuilder.CreateIndex(
                name: "IX_M_ObatUnit_id_obatunit",
                table: "M_ObatUnit",
                column: "IdObatUnit");

            migrationBuilder.CreateIndex(
                name: "IX_M_ObatUnit_is_aktif",
                table: "M_ObatUnit",
                column: "IsAktif");

            migrationBuilder.CreateIndex(
                name: "IX_M_ObatUnit_v_kdinventory",
                table: "M_ObatUnit",
                column: "KodeInventory");

            migrationBuilder.CreateIndex(
                name: "IX_M_ObatUnit_v_kdobat",
                table: "M_ObatUnit",
                column: "KdObat");

            migrationBuilder.CreateIndex(
                name: "IX_M_ObatUnit_v_rod",
                table: "M_ObatUnit",
                column: "Rod");

            migrationBuilder.CreateIndex(
                name: "IX_M_ObatUnit_vnmobat",
                table: "M_ObatUnit",
                column: "NmObat");

            migrationBuilder.CreateIndex(
                name: "IX_M_Pasien_agama",
                table: "M_Pasien",
                column: "AgamaPasien");

            migrationBuilder.CreateIndex(
                name: "IX_M_Pasien_alamat",
                table: "M_Pasien",
                column: "AlamatPasien");

            migrationBuilder.CreateIndex(
                name: "IX_M_Pasien_blacklist",
                table: "M_Pasien",
                column: "IsBlacklist");

            migrationBuilder.CreateIndex(
                name: "IX_M_Pasien_hp",
                table: "M_Pasien",
                column: "HpPasien");

            migrationBuilder.CreateIndex(
                name: "IX_M_Pasien_idpasien",
                table: "M_Pasien",
                column: "IdPasien");

            migrationBuilder.CreateIndex(
                name: "IX_M_Pasien_isaktif",
                table: "M_Pasien",
                column: "IsAktif");

            migrationBuilder.CreateIndex(
                name: "IX_M_Pasien_kelamin",
                table: "M_Pasien",
                column: "Kelaminpasien");

            migrationBuilder.CreateIndex(
                name: "IX_M_Pasien_kota",
                table: "M_Pasien",
                column: "KotaPasien");

            migrationBuilder.CreateIndex(
                name: "IX_M_Pasien_namapasien",
                table: "M_Pasien",
                column: "NamaPasien");

            migrationBuilder.CreateIndex(
                name: "IX_M_Pasien_noktp",
                table: "M_Pasien",
                column: "Noktpsimpasien");

            migrationBuilder.CreateIndex(
                name: "IX_M_Pasien_nopenjamin",
                table: "M_Pasien",
                column: "NoPenjamin");

            migrationBuilder.CreateIndex(
                name: "IX_M_Pasien_pekerjaan",
                table: "M_Pasien",
                column: "PekerjaanPasien");

            migrationBuilder.CreateIndex(
                name: "IX_M_Pasien_RekananId",
                table: "M_Pasien",
                column: "RekananId");

            migrationBuilder.CreateIndex(
                name: "IX_M_Pasien_statuskawin",
                table: "M_Pasien",
                column: "StatusKWNPasien");

            migrationBuilder.CreateIndex(
                name: "IX_M_Pasien_telp",
                table: "M_Pasien",
                column: "TelpPasien");

            migrationBuilder.CreateIndex(
                name: "IX_M_Pasien_tempatlahir",
                table: "M_Pasien",
                column: "Tmptlahirpasien");

            migrationBuilder.CreateIndex(
                name: "IX_M_Pasien_tgllahir",
                table: "M_Pasien",
                column: "Tgllahirpasien");

            migrationBuilder.CreateIndex(
                name: "IX_M_PemeriksaanPenunjangDetail_IdMasterPemeriksaanPenunjang",
                table: "M_PemeriksaanPenunjangDetail",
                column: "IdMasterPemeriksaanPenunjang");

            migrationBuilder.CreateIndex(
                name: "IX_M_Radiologi_IdGroup",
                table: "M_Radiologi",
                column: "IdGroup");

            migrationBuilder.CreateIndex(
                name: "IX_M_RadiologiHarga_IdHargakamar",
                table: "M_RadiologiHarga",
                column: "IdHargakamar");

            migrationBuilder.CreateIndex(
                name: "IX_M_RadiologiHarga_IdPemeriksaanRad",
                table: "M_RadiologiHarga",
                column: "IdPemeriksaanRad");

            migrationBuilder.CreateIndex(
                name: "IX_M_RadiologiHarga_RekananId",
                table: "M_RadiologiHarga",
                column: "RekananId");

            migrationBuilder.CreateIndex(
                name: "IX_M_RadiologiRekanan_IdPemeriksaanRad",
                table: "M_RadiologiRekanan",
                column: "IdPemeriksaanRad");

            migrationBuilder.CreateIndex(
                name: "IX_M_RadiologiRekanan_RekananId",
                table: "M_RadiologiRekanan",
                column: "RekananId");

            migrationBuilder.CreateIndex(
                name: "IX_M_Rekanan_Alias",
                table: "M_Rekanan",
                column: "Alias");

            migrationBuilder.CreateIndex(
                name: "IX_M_Rekanan_IdRekanan",
                table: "M_Rekanan",
                column: "IdRekanan");

            migrationBuilder.CreateIndex(
                name: "IX_M_Rekanan_IsAktif",
                table: "M_Rekanan",
                column: "IsAktif");

            migrationBuilder.CreateIndex(
                name: "IX_M_Rekanan_NmRekanan",
                table: "M_Rekanan",
                column: "NmRekanan");

            migrationBuilder.CreateIndex(
                name: "IX_M_Ruang",
                table: "M_Ruang",
                column: "KodeRuangan");

            migrationBuilder.CreateIndex(
                name: "IX_M_Ruang_1",
                table: "M_Ruang",
                column: "Nama");

            migrationBuilder.CreateIndex(
                name: "IX_M_Ruang_2",
                table: "M_Ruang",
                column: "Kamar");

            migrationBuilder.CreateIndex(
                name: "IX_M_Ruang_3",
                table: "M_Ruang",
                column: "KodeInventoryGudangObat");

            migrationBuilder.CreateIndex(
                name: "IX_M_Ruang_4",
                table: "M_Ruang",
                column: "KodeRequestGudangObat");

            migrationBuilder.CreateIndex(
                name: "IX_M_Ruang_5",
                table: "M_Ruang",
                column: "KodeTarif");

            migrationBuilder.CreateIndex(
                name: "IX_M_Ruang_6",
                table: "M_Ruang",
                column: "IsAktif");

            migrationBuilder.CreateIndex(
                name: "IX_M_Ruang_7",
                table: "M_Ruang",
                column: "IdRuang");

            migrationBuilder.CreateIndex(
                name: "IX_V_KDINHEALTH",
                table: "M_Ruang",
                column: "KdInhealth");

            migrationBuilder.CreateIndex(
                name: "IX_V_LYNINHEALTH",
                table: "M_Ruang",
                column: "LynInhealth");

            migrationBuilder.CreateIndex(
                name: "IX_M_SettingKomputerAntrian_idsettingkomp",
                table: "M_SettingKomputerAntrian",
                column: "IdSettingKomp");

            migrationBuilder.CreateIndex(
                name: "IX_M_SettingKomputerAntrian_vkdcounter",
                table: "M_SettingKomputerAntrian",
                column: "KdCounter");

            migrationBuilder.CreateIndex(
                name: "IX_M_SettingKomputerAntrian_vkdlayanan",
                table: "M_SettingKomputerAntrian",
                column: "KdJenisLayanan");

            migrationBuilder.CreateIndex(
                name: "IX_M_SettingKomputerAntrian_vkdlokasi",
                table: "M_SettingKomputerAntrian",
                column: "KdLokasi");

            migrationBuilder.CreateIndex(
                name: "IX_M_SettingKomputerAntrian_vnmkomp",
                table: "M_SettingKomputerAntrian",
                column: "NmKomputer");

            migrationBuilder.CreateIndex(
                name: "IX_M_Standartfield_IdFieldgroup",
                table: "M_Standartfield",
                column: "IdFieldgroup");

            migrationBuilder.CreateIndex(
                name: "IX_M_Status",
                table: "M_Status",
                column: "VStatus");

            migrationBuilder.CreateIndex(
                name: "IX_M_Status_1",
                table: "M_Status",
                column: "IdStatus");

            migrationBuilder.CreateIndex(
                name: "IX_M_Supplier_ALAMAT",
                table: "M_Supplier",
                column: "Alamat");

            migrationBuilder.CreateIndex(
                name: "IX_M_Supplier_ISAKTIF",
                table: "M_Supplier",
                column: "IsAktif");

            migrationBuilder.CreateIndex(
                name: "IX_M_Supplier_NAMA",
                table: "M_Supplier",
                column: "NamaSupplier");

            migrationBuilder.CreateIndex(
                name: "IX_M_Supplier_SUPPLIERID",
                table: "M_Supplier",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_M_Supplier_V_KDAKUN",
                table: "M_Supplier",
                column: "KdAkun");

            migrationBuilder.CreateIndex(
                name: "IX_M_TarifDetail_IdGroupTarif",
                table: "M_TarifDetail",
                column: "IdGroupTarif");

            migrationBuilder.CreateIndex(
                name: "IX_M_TarifDetail_Kodetariflayan",
                table: "M_TarifDetail",
                column: "Kodetariflayan");

            migrationBuilder.CreateIndex(
                name: "IX_M_TarifNonMedis_IdGroupNonMedis",
                table: "M_TarifNonMedis",
                column: "IdGroupNonMedis");

            migrationBuilder.CreateIndex(
                name: "IX_TmTarifNonMedis_KdTarif",
                table: "M_TarifNonMedis",
                column: "KdTarif",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_M_TarifnonmedisHarga_IdTarifNon",
                table: "M_TarifnonmedisHarga",
                column: "IdTarifNon");

            migrationBuilder.CreateIndex(
                name: "IX_M_TarifnonmedisMatrix_IdNonMedis",
                table: "M_TarifnonmedisMatrix",
                column: "IdNonMedis");

            migrationBuilder.CreateIndex(
                name: "IX_M_TarifnonmedisRekanan_IdTarifNon",
                table: "M_TarifnonmedisRekanan",
                column: "IdTarifNon");

            migrationBuilder.CreateIndex(
                name: "IX_M_SettingKomputerAntrian_vnmkomp1",
                table: "M_TarifPelayanan",
                column: "KodeTarifLayan",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_M_User_IdDokter",
                table: "M_User",
                column: "IdDokter");

            migrationBuilder.CreateIndex(
                name: "IX_M_User_IdGroupUser",
                table: "M_User",
                column: "IdGroupUser");

            migrationBuilder.CreateIndex(
                name: "IX_M_User_IdRuang",
                table: "M_User",
                column: "IdRuang");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_AntrianCounter");

            migrationBuilder.DropTable(
                name: "M_AntrianCounterAudio");

            migrationBuilder.DropTable(
                name: "M_AntrianLayanan");

            migrationBuilder.DropTable(
                name: "M_AntrianLokasi");

            migrationBuilder.DropTable(
                name: "M_Asal");

            migrationBuilder.DropTable(
                name: "M_AturanPakai");

            migrationBuilder.DropTable(
                name: "M_Bank");

            migrationBuilder.DropTable(
                name: "M_BarangAturanpakai");

            migrationBuilder.DropTable(
                name: "M_CountTraffic");

            migrationBuilder.DropTable(
                name: "M_Department");

            migrationBuilder.DropTable(
                name: "M_DiagnosaMatrix");

            migrationBuilder.DropTable(
                name: "M_DokterHonor");

            migrationBuilder.DropTable(
                name: "M_DokterNote");

            migrationBuilder.DropTable(
                name: "M_DTD");

            migrationBuilder.DropTable(
                name: "M_Gizi");

            migrationBuilder.DropTable(
                name: "M_HargaBarang");

            migrationBuilder.DropTable(
                name: "M_HargaRekanan");

            migrationBuilder.DropTable(
                name: "M_JadwalDokter");

            migrationBuilder.DropTable(
                name: "M_KamarinapHarga");

            migrationBuilder.DropTable(
                name: "M_KamarinapRekanan");

            migrationBuilder.DropTable(
                name: "M_Kodepos");

            migrationBuilder.DropTable(
                name: "M_LaboratoriumHarga");

            migrationBuilder.DropTable(
                name: "M_LaboratoriumRekanan");

            migrationBuilder.DropTable(
                name: "M_MasterPaketH");

            migrationBuilder.DropTable(
                name: "M_MasterTnd");

            migrationBuilder.DropTable(
                name: "M_ModuleDetail");

            migrationBuilder.DropTable(
                name: "M_Morfologi");

            migrationBuilder.DropTable(
                name: "M_ObatUnit");

            migrationBuilder.DropTable(
                name: "M_PaketDetail");

            migrationBuilder.DropTable(
                name: "M_PaketHarga");

            migrationBuilder.DropTable(
                name: "M_PaketHargaBaru");

            migrationBuilder.DropTable(
                name: "M_PaketMatrix");

            migrationBuilder.DropTable(
                name: "M_PaketRekanan");

            migrationBuilder.DropTable(
                name: "M_Pasien");

            migrationBuilder.DropTable(
                name: "M_PemeriksaanPenunjangDetail");

            migrationBuilder.DropTable(
                name: "M_RadiologiHarga");

            migrationBuilder.DropTable(
                name: "M_RadiologiRekanan");

            migrationBuilder.DropTable(
                name: "M_SettingAdm");

            migrationBuilder.DropTable(
                name: "M_SettingBayar");

            migrationBuilder.DropTable(
                name: "M_SettingDaftar");

            migrationBuilder.DropTable(
                name: "M_SettingKomputerAntrian");

            migrationBuilder.DropTable(
                name: "M_SettingPemeriksaan");

            migrationBuilder.DropTable(
                name: "M_Smf");

            migrationBuilder.DropTable(
                name: "M_Standartfield");

            migrationBuilder.DropTable(
                name: "M_Status");

            migrationBuilder.DropTable(
                name: "M_TarifDetail");

            migrationBuilder.DropTable(
                name: "M_TarifHarga");

            migrationBuilder.DropTable(
                name: "M_TarifMatrix");

            migrationBuilder.DropTable(
                name: "M_TarifnonmedisHarga");

            migrationBuilder.DropTable(
                name: "M_TarifnonmedisMatrix");

            migrationBuilder.DropTable(
                name: "M_TarifnonmedisRekanan");

            migrationBuilder.DropTable(
                name: "M_TarifRekanan");

            migrationBuilder.DropTable(
                name: "M_TarifRekananSub");

            migrationBuilder.DropTable(
                name: "M_Tennant");

            migrationBuilder.DropTable(
                name: "M_Tindakan");

            migrationBuilder.DropTable(
                name: "M_User");

            migrationBuilder.DropTable(
                name: "M_AsalGroup");

            migrationBuilder.DropTable(
                name: "M_Supplier");

            migrationBuilder.DropTable(
                name: "M_Barang");

            migrationBuilder.DropTable(
                name: "M_Kamarinap");

            migrationBuilder.DropTable(
                name: "M_Laboratorium");

            migrationBuilder.DropTable(
                name: "M_Module");

            migrationBuilder.DropTable(
                name: "M_Diagnosa");

            migrationBuilder.DropTable(
                name: "M_PemeriksaanPenunjang");

            migrationBuilder.DropTable(
                name: "M_Radiologi");

            migrationBuilder.DropTable(
                name: "M_Rekanan");

            migrationBuilder.DropTable(
                name: "M_StandartfieldGroup");

            migrationBuilder.DropTable(
                name: "M_TarifGroup");

            migrationBuilder.DropTable(
                name: "M_TarifPelayanan");

            migrationBuilder.DropTable(
                name: "M_TarifNonMedis");

            migrationBuilder.DropTable(
                name: "M_Dokter");

            migrationBuilder.DropTable(
                name: "M_UserGroup");

            migrationBuilder.DropTable(
                name: "M_FarmakoterapiSub");

            migrationBuilder.DropTable(
                name: "M_KelompokBarang");

            migrationBuilder.DropTable(
                name: "M_Hargakamar");

            migrationBuilder.DropTable(
                name: "M_Map");

            migrationBuilder.DropTable(
                name: "M_LaboratoriumGroup");

            migrationBuilder.DropTable(
                name: "M_RadiologiGroup");

            migrationBuilder.DropTable(
                name: "M_TarifnonmedisGroup");

            migrationBuilder.DropTable(
                name: "M_Coa");

            migrationBuilder.DropTable(
                name: "M_Farmakoterapi");

            migrationBuilder.DropTable(
                name: "M_Ruang");

            migrationBuilder.DropTable(
                name: "M_CoaSubKlasifikasi");

            migrationBuilder.DropTable(
                name: "M_Gudang");

            migrationBuilder.DropTable(
                name: "M_CoaKlasifikasi");

            migrationBuilder.DropTable(
                name: "M_CoaGolongan");
        }
    }
}
