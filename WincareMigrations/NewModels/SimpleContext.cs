using Microsoft.EntityFrameworkCore;
using Wincare.Core;

namespace WincareMigrations.NewModels;

public partial class SimpleContext : DbContext

{

    //private readonly string strUUid = "uuid_generate_v4()";

    //HasDefaultValueSql(strUUid)

    public SimpleContext(DbContextOptions<SimpleContext> options)
        : base(options)
    {
    }

    public virtual DbSet<M_AntrianCounter> TmAntrianCounters { get; set; }

    public virtual DbSet<M_AntrianCounterAudio> TmAntrianCounterAudios { get; set; }

    public virtual DbSet<M_AntrianLayanan> TmAntrianLayanans { get; set; }

    public virtual DbSet<M_AntrianLokasi> TmAntrianLokasis { get; set; }

    public virtual DbSet<M_Asal> TmAsals { get; set; }

    public virtual DbSet<M_AsalGroup> TmAsalGroups { get; set; }

    public virtual DbSet<M_Aturanpakai> TmAturanpakais { get; set; }

    public virtual DbSet<M_Bank> TmBanks { get; set; }

    public virtual DbSet<M_Barang> TmBarangs { get; set; }

    public virtual DbSet<M_BarangAturanpakai> TmBarangAturanpakais { get; set; }

    public virtual DbSet<M_Coa> TmCoas { get; set; }

    public virtual DbSet<M_CoaGolongan> TmCoaGolongans { get; set; }

    public virtual DbSet<M_CoaKlasifikasi> TmCoaKlasifikasis { get; set; }

    public virtual DbSet<M_CoaSubklasifikasi> TmCoaSubklasifikasis { get; set; }

    public virtual DbSet<M_CountTraffic> TmCounttraffics { get; set; }

    public virtual DbSet<M_Departement> TmDepartements { get; set; }

    public virtual DbSet<M_Diagnosa> TmDiagnosas { get; set; }

    public virtual DbSet<M_DiagnosaMatrix> TmDiagnosaMatrices { get; set; }

    public virtual DbSet<M_Dokter> TmDokters { get; set; }

    public virtual DbSet<M_DokterHonor> TmDokterHonors { get; set; }

    public virtual DbSet<M_DokterNote> TmDokterNotes { get; set; }

    public virtual DbSet<M_Dtd> TmDtds { get; set; }

    public virtual DbSet<M_Farmakoterapi> TmFarmakoterapis { get; set; }

    public virtual DbSet<M_FarmakoterapiSub> TmFarmakoterapiSubs { get; set; }

    public virtual DbSet<M_Gizi> TmGizis { get; set; }

    public virtual DbSet<M_Gudang> TmGudangs { get; set; }

    public virtual DbSet<M_HargaBarang> TmHargabarangs { get; set; }

    public virtual DbSet<M_Hargakamar> TmHargakamars { get; set; }

    public virtual DbSet<M_Hargarekanan> TmHargarekanans { get; set; }

    public virtual DbSet<M_Jadwaldokter> TmJadwaldokters { get; set; }

    public virtual DbSet<M_Kamarinap> TmKamarinaps { get; set; }

    public virtual DbSet<M_KamarinapHarga> TmKamarinapHargas { get; set; }

    public virtual DbSet<M_KamarInapRekanan> TmKamarinapRekanans { get; set; }

    public virtual DbSet<M_KelompokBarang> TmKelompokbarangs { get; set; }

    public virtual DbSet<M_Kodepos> TmKodepos { get; set; }

    public virtual DbSet<M_Laboratorium> TmLaboratoria { get; set; }

    public virtual DbSet<M_LaboratoriumGroup> TmLaboratoriumGroups { get; set; }

    public virtual DbSet<M_LaboratoriumHarga> TmLaboratoriumHargas { get; set; }

    public virtual DbSet<M_LaboratoriumRekanan> TmLaboratoriumRekanans { get; set; }

    public virtual DbSet<M_Map> TmMaps { get; set; }

    public virtual DbSet<M_MasterPaketH> TmMasterPaketHs { get; set; }

    public virtual DbSet<M_MasterTnd> TmMasterTnds { get; set; }

    public virtual DbSet<M_Module> TmModules { get; set; }

    public virtual DbSet<M_ModuleDetail> TmModuleDetails { get; set; }

    public virtual DbSet<M_Morfologi> TmMorfologis { get; set; }

    public virtual DbSet<M_Obatunit> TmObatunits { get; set; }

    public virtual DbSet<M_PaketHarga> TmPaketHargas { get; set; }

    public virtual DbSet<M_PaketHargaBaru> TmPaketHargaBarus { get; set; }

    public virtual DbSet<M_PaketMatrix> TmPaketMatrices { get; set; }

    public virtual DbSet<M_PaketRekanan> TmPaketRekanans { get; set; }

    public virtual DbSet<M_Paketdetail> TmPaketdetails { get; set; }

    public virtual DbSet<M_Pasien> TmPasiens { get; set; }

    public virtual DbSet<M_PemeriksaanPenunjang> TmPemeriksaanpenunjangs { get; set; }

    public virtual DbSet<M_PemeriksaanPenunjangDetail> TmPemeriksaanpenunjangdetails { get; set; }

    public virtual DbSet<M_Radiologi> TmRadiologis { get; set; }

    public virtual DbSet<M_RadiologiGroup> TmRadiologiGroups { get; set; }

    public virtual DbSet<M_RadiologiHarga> TmRadiologiHargas { get; set; }

    public virtual DbSet<M_RadiologiRekanan> TmRadiologiRekanans { get; set; }

    public virtual DbSet<M_Rekanan> TmRekanans { get; set; }

    public virtual DbSet<M_Ruang> TmRuangs { get; set; }


    public virtual DbSet<M_SettingAdm> TmSettingAdms { get; set; }

    public virtual DbSet<M_SettingBayar> TmSettingBayars { get; set; }

    public virtual DbSet<M_SettingDaftar> TmSettingDaftars { get; set; }

    public virtual DbSet<M_SettingKomputerAntrian> TmSettingKomputerAntrians { get; set; }

    public virtual DbSet<M_SettingPemeriksaan> TmSettingPemeriksaans { get; set; }

    public virtual DbSet<M_Tenant> TmSettingPrshns { get; set; }

    public virtual DbSet<M_Smf> TmSmfs { get; set; }

    public virtual DbSet<M_Standartfield> TmStandartfields { get; set; }

    public virtual DbSet<M_StandartfieldGroup> TmStandartfieldGroups { get; set; }

    public virtual DbSet<M_Status> TmStatuses { get; set; }

    public virtual DbSet<M_Supplier> TmSuppliers { get; set; }

    public virtual DbSet<M_TarifGroup> TmTarifGroups { get; set; }

    public virtual DbSet<M_TarifHarga> TmTarifHargas { get; set; }

    public virtual DbSet<M_TarifMatrix> TmTarifMatrices { get; set; }

    public virtual DbSet<M_TarifPelayanan> TmTarifPelayanans { get; set; }

    public virtual DbSet<M_TarifRekanan> TmTarifRekanans { get; set; }

    public virtual DbSet<M_TarifRekananSub> TmTarifRekananSubs { get; set; }

    public virtual DbSet<M_TarifDetail> TmTarifdetails { get; set; }

    public virtual DbSet<M_TarifNonMedis> TmTarifnonmedis { get; set; }

    public virtual DbSet<M_TarifnonmedisGroup> TmTarifnonmedisGroups { get; set; }

    public virtual DbSet<M_TarifnonmedisHarga> TmTarifnonmedisHargas { get; set; }

    public virtual DbSet<M_TarifnonmedisMatrix> TmTarifnonmedisMatrices { get; set; }

    public virtual DbSet<M_TarifnonmedisRekanan> TmTarifnonmedisRekanans { get; set; }

    public virtual DbSet<M_Tindakan> TmTindakans { get; set; }

    public virtual DbSet<M_User> TmUsers { get; set; }

    public virtual DbSet<M_UserGroup> TmUserGroups { get; set; }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder
            .Properties<Ulid>()
            .HaveConversion<UlidToStringConverter>();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<M_AntrianCounter>(entity =>
        {
            entity.Property(e => e.IdCounter).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_AntrianCounterAudio>(entity =>
        {
            entity.Property(e => e.IdCounteraudio).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_AntrianLayanan>(entity =>
        {
            entity.Property(e => e.IdLayanan).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_AntrianLokasi>(entity =>
        {
            entity.Property(e => e.IdLokasi).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_Asal>(entity =>
        {
            entity.Property(e => e.IdAsal).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdAsalgroupNavigation).WithMany(p => p.MAsals).HasConstraintName("FK_M_ASAL_M_ASAL_GROUP");
        });

        modelBuilder.Entity<M_AsalGroup>(entity =>
        {
            entity.Property(e => e.IdAsalGroup).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_Aturanpakai>(entity =>
        {
            entity.Property(e => e.IdAturanpakai).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_Bank>(entity =>
        {
            entity.Property(e => e.IdBank).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_Barang>(entity =>
        {
            entity.Property(e => e.BarangId).ValueGeneratedOnAdd();
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Tipebarang).IsFixedLength();

            entity.HasOne(d => d.IdFarmakoterapiNavigation).WithMany(p => p.MBarangs).HasConstraintName("FK_M_BARANG_M_FARMAKOTERAPI");

            entity.HasOne(d => d.IdSubfarmakoterapiNavigation).WithMany(p => p.MBarangs).HasConstraintName("FK_M_BARANG_M_FARMAKOTERAPI_SUB");

            entity.HasOne(d => d.Kelompok).WithMany(p => p.MBarangs).HasConstraintName("FK_M_BARANG_M_KELOMPOKBARANG2");
        });

        modelBuilder.Entity<M_BarangAturanpakai>(entity =>
        {
            entity.Property(e => e.IdAturanpakai).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_Coa>(entity =>
        {
            entity.Property(e => e.IdCoa).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdSubklasifikasiNavigation).WithMany(p => p.M_Coas).HasConstraintName("FK_M_COA_M_COA_SUBKLASIFIKASI");
        });

        modelBuilder.Entity<M_CoaGolongan>(entity =>
        {
            entity.Property(e => e.IdGolongan).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_CoaKlasifikasi>(entity =>
        {
            entity.Property(e => e.IdKlasifikasi).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdGolonganNavigation).WithMany(p => p.M_CoaKlasifikasis).HasConstraintName("FK_M_COA_KLASIFIKASI_M_COA_GOLONGAN");
        });

        modelBuilder.Entity<M_CoaSubklasifikasi>(entity =>
        {
            entity.Property(e => e.IdSubklasifikasi).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdKlasifikasiNavigation).WithMany(p => p.M_CoaSubklasifikasis).HasConstraintName("FK_M_COA_SUBKLASIFIKASI_M_COA_KLASIFIKASI");
        });

        modelBuilder.Entity<M_CountTraffic>(entity =>
        {
            entity.Property(e => e.Idcounttraffic).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_Diagnosa>(entity =>
        {
            entity.Property(e => e.IdDiagnosa).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_DiagnosaMatrix>(entity =>
        {
            entity.Property(e => e.IdDiagnosaMatrix).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_Dokter>(entity =>
        {
            entity.Property(e => e.IdDokter).ValueGeneratedOnAdd();
            entity.Property(e => e.Kodetarif).IsFixedLength();

            entity.HasOne(d => d.KdAkunNavigation).WithMany(p => p.M_Dokters).HasConstraintName("FK_M_DOKTER_M_COA");
        });

        modelBuilder.Entity<M_DokterHonor>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_DokterNote>(entity =>
        {
            entity.Property(e => e.IdDokterNote).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_Dtd>(entity =>
        {
            entity.Property(e => e.IdDtd).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_Farmakoterapi>(entity =>
        {
            entity.Property(e => e.IdFarmakoterapi).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_FarmakoterapiSub>(entity =>
        {
            entity.Property(e => e.IdSubfarmakoterapi).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdFarmakoterapiNavigation).WithMany(p => p.M_FarmakoterapiSubs).HasConstraintName("FK_M_FARMAKOTERAPI_SUB_M_FARMAKOTERAPI");
        });

        modelBuilder.Entity<M_Gizi>(entity =>
        {
            entity.Property(e => e.IdGizi).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_Gudang>(entity =>
        {
            entity.Property(e => e.IdGudangObat).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_HargaBarang>(entity =>
        {
            entity.Property(e => e.Idhargabeli).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Barang).WithMany(p => p.M_Hargabarangs).HasConstraintName("FK_M_HARGABARANG_M_BARANG");

            entity.HasOne(d => d.Supplier).WithMany(p => p.M_Hargabarangs).HasConstraintName("FK_M_HARGABARANG_M_SUPPLIER");
        });

        modelBuilder.Entity<M_Hargakamar>(entity =>
        {
            entity.Property(e => e.IdHargakamar).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_Hargarekanan>(entity =>
        {
            entity.Property(e => e.IdHargaRekanan).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Barang).WithMany(p => p.M_Hargarekanans).HasConstraintName("FK_M_HARGAREKANAN_M_BARANG");

            entity.HasOne(d => d.Rekanan).WithMany(p => p.M_Hargarekanans).HasConstraintName("FK_M_HARGAREKANAN_M_REKANAN");
        });

        modelBuilder.Entity<M_Jadwaldokter>(entity =>
        {
            entity.Property(e => e.IdJadwal).ValueGeneratedOnAdd();

            entity.HasOne(d => d.KdDokterNavigation).WithMany(p => p.M_JadwalDokters).HasConstraintName("FK_M_JADWALDOKTER_M_DOKTER_(kddokter)");

            entity.HasOne(d => d.KoderuanganNavigation).WithMany(p => p.M_Jadwaldokters)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_M_JADWALDOKTER_M_RUANG_(kdruangan)");
        });

        modelBuilder.Entity<M_Kamarinap>(entity =>
        {
            entity.Property(e => e.Isi).IsFixedLength();
            entity.Property(e => e.IdKamarinap).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdMap).WithMany(p => p.M_Kamarinaps).HasConstraintName("FK_M_KAMARINAP_M_MAP");

            entity.HasOne(d => d.KelasNavigation).WithMany(p => p.M_Kamarinaps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_M_KAMARINAP_M_HARGAKAMAR");
        });

        modelBuilder.Entity<M_KamarinapHarga>(entity =>
        {
            entity.Property(e => e.IdKamarInapHarga).ValueGeneratedOnAdd();

            entity.HasOne(d => d.KdtmptidurNavigation).WithMany(p => p.M_KamarInapHargas).HasConstraintName("FK_M_KAMARINAP_HARGA_M_KAMARINAP");
        });

        modelBuilder.Entity<M_KamarInapRekanan>(entity =>
        {

            entity.Property(e => e.IdKamarinaprek).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_KelompokBarang>(entity =>
        {

            entity.Property(e => e.KelompokId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_Kodepos>(entity =>
        {

            entity.Property(e => e.IdKodepos).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_Laboratorium>(entity =>
        {
            entity.Property(e => e.IdPemeriksaanLab).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.M_Laboratoria).HasConstraintName("FK_M_LABORATORIUM_M_LABORATORIUM_GROUP");
        });

        modelBuilder.Entity<M_LaboratoriumGroup>(entity =>
        {
            entity.Property(e => e.IdGroup).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_LaboratoriumHarga>(entity =>
        {

            entity.Property(e => e.IdLabharga).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Rekanan).WithMany(p => p.M_LaboratoriumHargas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_M_LABORATORIUM_HARGA_M_REKANAN");

            entity.HasOne(d => d.KdPemeriksaanlabNavigation).WithMany(p => p.M_LaboratoriumHargas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_M_LABORATORIUM_HARGA_M_LABORATORIUM");

            entity.HasOne(d => d.KelasNavigation).WithMany(p => p.M_LaboratoriumHargas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_M_LABORATORIUM_HARGA_M_HARGAKAMAR");
        });

        modelBuilder.Entity<M_LaboratoriumRekanan>(entity =>
        {
            entity.Property(e => e.IdLabRekanan).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Rekanan).WithMany(p => p.M_LaboratoriumRekanans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_M_LABORATORIUM_REKANAN_M_REKANAN");

            entity.HasOne(d => d.KdpemeriksaanlabNavigation).WithMany(p => p.M_LaboratoriumRekanans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_M_LABORATORIUM_REKANAN_M_LABORATORIUM");
        });

        modelBuilder.Entity<M_Map>(entity =>
        {
            entity.Property(e => e.IdMapid).ValueGeneratedOnAdd();

            entity.HasOne(d => d.KoderuanganNavigation).WithMany(p => p.M_Maps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_M_MAP_M_RUANG");
        });

        modelBuilder.Entity<M_MasterPaketH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_Module>(entity =>
        {
            entity.Property(e => e.IdModule).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_ModuleDetail>(entity =>
        {
            entity.Property(e => e.IdModuledetail).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdModuleNavigation).WithMany(p => p.M_ModuleDetails).HasConstraintName("FK_M_MODULE_DETAIL_M_MODULE");
        });

        modelBuilder.Entity<M_Morfologi>(entity =>
        {
            entity.Property(e => e.IdMorfologi).ValueGeneratedOnAdd();

            entity.HasOne(d => d.KdDiagnosaNavigation).WithMany(p => p.M_Morfologis).HasConstraintName("FK_M_MORFOLOGI_M_DIAGNOSA");
        });

        modelBuilder.Entity<M_Obatunit>(entity =>
        {
            entity.Property(e => e.IdObatUnit).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_PaketHarga>(entity =>
        {
            entity.Property(e => e.IdPaketkelas).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_PaketHargaBaru>(entity =>
        {
            entity.Property(e => e.IdPaketkelas).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_PaketMatrix>(entity =>
        {
            entity.Property(e => e.IdPaketmatrix).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_PaketRekanan>(entity =>
        {
            entity.Property(e => e.IdPaketRekanan).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_Pasien>(entity =>
        {
            entity.Property(e => e.Iscetakkartu).IsFixedLength();
            entity.Property(e => e.IdPasien).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Rekanan).WithMany(p => p.M_Pasiens).HasConstraintName("FK_M_PASIEN_M_REKANAN_(rekananid)");
        });

        modelBuilder.Entity<M_PemeriksaanPenunjang>(entity =>
        {
            entity.Property(e => e.IdMasterPemeriksaanPenunjang).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_PemeriksaanPenunjangDetail>(entity =>
        {
            entity.Property(e => e.IdPenunjangDetail).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdMasterPemeriksaanPenunjangNavigation).WithMany(p => p.M_PemeriksaanPenunjangDetails).HasConstraintName("FK_M_PEMERIKSAANPENUNJANGDETAIL_M_PEMERIKSAANPENUNJANG");
        });

        modelBuilder.Entity<M_Radiologi>(entity =>
        {
            entity.Property(e => e.IdPemeriksaanRad).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.M_Radiologis).HasConstraintName("FK_M_RADIOLOGI_M_RADIOLOGI_GROUP");
        });

        modelBuilder.Entity<M_RadiologiGroup>(entity =>
        {
            entity.Property(e => e.IdGroup).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_RadiologiHarga>(entity =>
        {
            entity.Property(e => e.IdRadharga).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Rekanan).WithMany(p => p.M_RadiologiHargas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_M_RADIOLOGI_HARGA_M_REKANAN");

            entity.HasOne(d => d.KdpemeriksaanRadNavigation).WithMany(p => p.M_RadiologiHargas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_M_RADIOLOGI_HARGA_M_RADIOLOGI");

            entity.HasOne(d => d.KelasNavigation).WithMany(p => p.M_RadiologiHargas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_M_RADIOLOGI_HARGA_M_HARGAKAMAR");
        });

        modelBuilder.Entity<M_RadiologiRekanan>(entity =>
        {
            entity.Property(e => e.IdRadrekanan).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Rekanan).WithMany(p => p.M_RadiologiRekanans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_M_RADIOLOGI_REKANAN_M_REKANAN");

            entity.HasOne(d => d.KdpemeriksaanRadNavigation).WithMany(p => p.M_RadiologiRekanans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_M_RADIOLOGI_REKANAN_M_RADIOLOGI");
        });

        modelBuilder.Entity<M_Rekanan>(entity =>
        {
            entity.Property(e => e.IdRekanan).ValueGeneratedOnAdd();
            entity.Property(e => e.IsCob).HasDefaultValue(false);
        });

        modelBuilder.Entity<M_Ruang>(entity =>
        {
            entity.Property(e => e.IdRuang).ValueGeneratedOnAdd();
            entity.Property(e => e.Kelompok).IsFixedLength();

            entity.HasOne(d => d.KodeRequestobatNavigation).WithMany(p => p.M_RuangKodeRequestobatNavigations).HasConstraintName("FK_M_RUANG_M_GUDANG2_(requestobat)");

            entity.HasOne(d => d.KodeinventoryNavigation).WithMany(p => p.M_RuangVKodeinventoryNavigations).HasConstraintName("FK_M_RUANG_M_GUDANG_(kdinventory)");
        });

        modelBuilder.Entity<M_SettingAdm>(entity =>
        {
            entity.Property(e => e.IdAdm).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_SettingBayar>(entity =>
        {
            entity.Property(e => e.IdSettingBayar).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_SettingDaftar>(entity =>
        {
            entity.Property(e => e.IdSettingdaftar).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_SettingKomputerAntrian>(entity =>
        {
            entity.Property(e => e.IdSettingKomp).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_SettingPemeriksaan>(entity =>
        {
            entity.Property(e => e.IdSettingperiksa).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_Tenant>(entity =>
        {
            entity.Property(e => e.IdTenant).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_Smf>(entity =>
        {
            entity.Property(e => e.IdSmf).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_Standartfield>(entity =>
        {
            entity.Property(e => e.IdField).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdFieldgroupNavigation).WithMany(p => p.M_Standartfields).HasConstraintName("FK_M_STANDARTFIELD_M_STANDARTFIELD_GROUP");
        });

        modelBuilder.Entity<M_StandartfieldGroup>(entity =>
        {
            entity.Property(e => e.IdFieldgroup).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_Supplier>(entity =>
        {
            entity.Property(e => e.SupplierId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_TarifGroup>(entity =>
        {
            entity.Property(e => e.IdGrouptarif).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_TarifHarga>(entity =>
        {
            entity.HasKey(e => e.IdTarifkelas);

            entity.Property(e => e.IdTarifkelas).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_TarifMatrix>(entity =>
        {
            entity.Property(e => e.IdTarifmatrix).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_TarifPelayanan>(entity =>
        {
            entity.Property(e => e.IdTariflayan).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_TarifRekanan>(entity =>
        {
            entity.Property(e => e.IdTarifRekanan).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_TarifRekananSub>(entity =>
        {
            entity.Property(e => e.IdTarifrekanansub).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_TarifDetail>(entity =>
        {
            entity.Property(e => e.IdTarifdetail).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdGrouptarifNavigation).WithMany(p => p.M_Tarifdetails).HasConstraintName("FK_M_TARIFDETAIL_M_TARIF_GROUP");

            entity.HasOne(d => d.VKodetariflayanNavigation).WithMany(p => p.M_Tarifdetails).HasConstraintName("FK_M_TARIFDETAIL_M_TARIF_PELAYANAN");
        });

        modelBuilder.Entity<M_TarifNonMedis>(entity =>
        {
            entity.Property(e => e.IdNonMedis).ValueGeneratedOnAdd();

            //entity.HasOne(d => d.IdGroupnonmedisNavigation).WithMany(p => p.M_Tarifnonmedis)
            //.HasConstraintName("FK_M_TARIFNONMEDIS_M_TARIFNONMEDIS_GROUP");
        });

        modelBuilder.Entity<M_TarifnonmedisGroup>(entity =>
        {
            entity.Property(e => e.IdGroupNonMedis).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_TarifnonmedisHarga>(entity =>
        {
            entity.Property(e => e.IdNonmedishrg).ValueGeneratedOnAdd();

            entity.HasOne(d => d.KdtarifNavigation).WithMany(p => p.M_TarifnonmedisHargas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_M_TARIFNONMEDIS_HARGA_M_TARIFNONMEDIS");
        });

        modelBuilder.Entity<M_TarifnonmedisMatrix>(entity =>
        {
            entity.Property(e => e.IdNonMedisMatrix).ValueGeneratedOnAdd();

            entity.HasOne(d => d.KdtarifNavigation).WithMany(p => p.M_TarifnonmedisMatrices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_M_TARIFNONMEDIS_MATRIX_M_TARIFNONMEDIS");
        });

        modelBuilder.Entity<M_TarifnonmedisRekanan>(entity =>
        {
            entity.Property(e => e.IdNonMedRek).ValueGeneratedOnAdd();

            entity.HasOne(d => d.KdtarifNavigation).WithMany(p => p.M_TarifnonmedisRekanans).HasConstraintName("FK_M_TARIFNONMEDIS_REKANAN_M_TARIFNONMEDIS");
        });

        modelBuilder.Entity<M_Tindakan>(entity =>
        {
            entity.Property(e => e.IdTindakan).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<M_User>(entity =>
        {
            entity.Property(e => e.Iduser).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdGroupuserNavigation).WithMany(p => p.M_Users).HasConstraintName("FK_M_USER_M_USER_GROUP");

            entity.HasOne(d => d.KdDokterNavigation).WithMany(p => p.M_Users).HasConstraintName("FK_M_USER_M_DOKTER");

            entity.HasOne(d => d.KoderuanganNavigation).WithMany(p => p.M_Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_M_USER_M_RUANG");
        });

        modelBuilder.Entity<M_UserGroup>(entity =>
        {
            entity.Property(e => e.IdGroupUser).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}