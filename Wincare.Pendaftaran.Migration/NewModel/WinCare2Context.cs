using Microsoft.EntityFrameworkCore;

namespace Wincare.Pendaftaran.Migration.NewModel;

public partial class SimpleContext : DbContext
{
    public SimpleContext(DbContextOptions<SimpleContext> options)
        : base(options)
    {
    }

    public virtual DbSet<D_Dokter> TmDokters { get; set; }

    public virtual DbSet<D_DokterNote> TmDokterNotes { get; set; }

    public virtual DbSet<D_Gudang> TmGudangs { get; set; }

    public virtual DbSet<D_JadwalDokter> TmJadwaldokters { get; set; }

    public virtual DbSet<D_KamarInap> TmKamarinaps { get; set; }

    public virtual DbSet<D_KodePos> TmKodepos { get; set; }

    public virtual DbSet<D_Pasien> TmPasiens { get; set; }

    public virtual DbSet<D_Rekanan> TmRekanans { get; set; }

    public virtual DbSet<D_Ruang> TmRuangs { get; set; }

    public virtual DbSet<D_SettingAdm> TmSettingAdms { get; set; }

    public virtual DbSet<D_SettingDaftar> TmSettingDaftars { get; set; }

    public virtual DbSet<D_TarifGroup> TmTarifGroups { get; set; }

    public virtual DbSet<D_TarifHarga> TmTarifHargas { get; set; }

    public virtual DbSet<D_TarifMatrix> TmTarifMatrices { get; set; }

    public virtual DbSet<D_TarifRekanan> TmTarifRekanans { get; set; }

    public virtual DbSet<D_TarifRekananSub> TmTarifRekananSubs { get; set; }

    public virtual DbSet<D_Tarifdetail> TmTarifdetails { get; set; }

    public virtual DbSet<D_Kamar> TmhKamars { get; set; }

    public virtual DbSet<D_HargaPengunjungInap> TmhPengunjungs { get; set; }

    public virtual DbSet<D_result_Hasillab> TrHasillabs { get; set; }

    public virtual DbSet<D_result_Hasilrad> TrHasilrads { get; set; }

    public virtual DbSet<D_result_Itemnonmedi> TrItemnonmedis { get; set; }

    public virtual DbSet<D_result_Itemobatlangsung> TrItemobatlangsungs { get; set; }

    public virtual DbSet<D_result_Itempaket> TrItempakets { get; set; }

    public virtual DbSet<D_Accountpasien> TtAcountpasiens { get; set; }

    public virtual DbSet<D_Betinap> TtBetinaps { get; set; }

    public virtual DbSet<D_Blacklist> TtBlacklists { get; set; }

    public virtual DbSet<D_Deposit> TtDeposits { get; set; }

    public virtual DbSet<D_Kuitansi> TtKuitansis { get; set; }

    public virtual DbSet<D_Kuitansialke> TtKuitansialkes { get; set; }

    public virtual DbSet<D_Kuitansiresep> TtKuitansireseps { get; set; }

    public virtual DbSet<D_Kunjungan> TtKunjungans { get; set; }

    public virtual DbSet<D_Liburdokter> TtLiburdokters { get; set; }

    public virtual DbSet<D_Notedokter> TtNotedokters { get; set; }

    public virtual DbSet<D_Obatalke> TtObatalkes { get; set; }

    public virtual DbSet<D_Obatlangsung> TtObatlangsungs { get; set; }

    public virtual DbSet<D_Paidout> TtPaidouts { get; set; }

    public virtual DbSet<D_Paket> TtPakets { get; set; }

    public virtual DbSet<D_PaketPbAppDetail> TtPaketPbAppDetails { get; set; }

    public virtual DbSet<D_PasienRencanaRad> TtPasienRencanaRads { get; set; }

    public virtual DbSet<D_Pasieninap> TtPasieninaps { get; set; }

    public virtual DbSet<D_Pasienlab> TtPasienlabs { get; set; }

    public virtual DbSet<D_Pasienpenunjang> TtPasienpenunjangs { get; set; }

    public virtual DbSet<D_Pasienrad> TtPasienrads { get; set; }

    public virtual DbSet<D_Pasienugd> TtPasienugds { get; set; }

    public virtual DbSet<D_Pembayaran> TtPembayarans { get; set; }

    public virtual DbSet<D_PembayaranDetail> TtPembayaranDetails { get; set; }

    public virtual DbSet<D_PembayaranLock> TtPembayaranLocks { get; set; }

    public virtual DbSet<D_Pemeriksaanradiologi> TtPemeriksaanradiologis { get; set; }

    public virtual DbSet<D_Penjadwalan> TtPenjadwalans { get; set; }

    public virtual DbSet<D_Plafonbpj> TtPlafonbpjs { get; set; }

    public virtual DbSet<D_PlafonbpjsHistory> TtPlafonbpjsHistories { get; set; }

    public virtual DbSet<D_Resep> TtReseps { get; set; }

    public virtual DbSet<D_Retur> TtReturs { get; set; }

    public virtual DbSet<D_Returalke> TtReturalkes { get; set; }

    public virtual DbSet<D_Rubahrekanan> TtRubahrekanans { get; set; }

    public virtual DbSet<D_Tindakan> TtTindakans { get; set; }

    public virtual DbSet<D_TindakanDetail> TtTindakanDetails { get; set; }

    public virtual DbSet<D_Transaksi> TtTransaksis { get; set; }

    public virtual DbSet<D_Transaksinonmedi> TtTransaksinonmedis { get; set; }


    public virtual DbSet<D_HargaPengunjungInap> TthPengunjunginaps { get; set; }

    public virtual DbSet<D_HasilRubahrekananHotel> TthRubahrekananHotels { get; set; }

    public virtual DbSet<D_HasilTransaksi> TthTransaksis { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<D_Dokter>(entity =>
        {
            entity.ToTable("D_DOKTER", tb =>
                {
                    tb.HasTrigger("INSERT_TM_ASAL");
                    tb.HasTrigger("UPDATE_TM_ASAL");
                });

            entity.Property(e => e.IdDokter).ValueGeneratedOnAdd();
            entity.Property(e => e.KodeTarif).IsFixedLength();
        });

        modelBuilder.Entity<D_DokterNote>(entity =>
        {
            entity.Property(e => e.IdDokter).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_Gudang>(entity =>
        {
            entity.Property(e => e.IdGudangobat).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_JadwalDokter>(entity =>
        {
            entity.HasKey(e => e.IdJadwal).HasName("PK_TR_JADWALDOKTER");

            entity.Property(e => e.IdJadwal).ValueGeneratedOnAdd();

            entity.HasOne(d => d.KdDokterNavigation).WithMany(p => p.TmJadwaldokters).HasConstraintName("FK_TM_JADWALDOKTER_TM_DOKTER_(kddokter)");

            entity.HasOne(d => d.KodeRuanganNavigation).WithMany(p => p.TmJadwaldokters)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TM_JADWALDOKTER_TM_RUANG_(kdruangan)");
        });

        modelBuilder.Entity<D_KamarInap>(entity =>
        {
            entity.Property(e => e.Isi).IsFixedLength();
            entity.Property(e => e.IdKamarInap).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_KodePos>(entity =>
        {
            entity.HasKey(e => e.IdKodePos).HasName("PK_TM_KODEPOS_1");

            entity.Property(e => e.IdKodePos).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_Pasien>(entity =>
        {
            entity.Property(e => e.CetakKartu).IsFixedLength();
            entity.Property(e => e.IdNumPasien).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Rekanan).WithMany(p => p.TmPasiens).HasConstraintName("FK_TM_PASIEN_TM_REKANAN_(rekananid)");
        });

        modelBuilder.Entity<D_Rekanan>(entity =>
        {
            entity.Property(e => e.IdNumRekanan).ValueGeneratedOnAdd();
            entity.Property(e => e.Cob).HasDefaultValue(false);
        });

        modelBuilder.Entity<D_Ruang>(entity =>
        {
            entity.Property(e => e.IdNumRuang).ValueGeneratedOnAdd();
            entity.Property(e => e.Kelompok).IsFixedLength();

            entity.HasOne(d => d.KodeRequestObatNavigation).WithMany(p => p.TmRuangKodeRequestobatNavigations).HasConstraintName("FK_TM_RUANG_TM_GUDANG2_(requestobat)");

            entity.HasOne(d => d.KodeInventoryNavigation).WithMany(p => p.TmRuangVKodeinventoryNavigations).HasConstraintName("FK_TM_RUANG_TM_GUDANG_(kdinventory)");

        });

        modelBuilder.Entity<D_SettingAdm>(entity =>
        {
            entity.Property(e => e.IdNumAdm).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_SettingDaftar>(entity =>
        {
            entity.Property(e => e.SettingDaftar).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_TarifGroup>(entity =>
        {
            entity.Property(e => e.IdGroupTarif).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_TarifHarga>(entity =>
        {
            entity.HasKey(e => e.IdTarifKelas).HasName("PK_TM_TARIF_KELAS2");

            entity.ToTable("TM_TARIF_HARGA", tb => tb.HasTrigger("UPDATE_STATUS_TM_TARIF_HARGA"));

            entity.Property(e => e.IdTarifKelas).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_TarifMatrix>(entity =>
        {
            entity.Property(e => e.IdTarifMatrix).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_TarifRekanan>(entity =>
        {
            entity.HasKey(e => e.IdTarifRekanan).HasName("PK_TM_TARIF_REKANAN2");

            entity.Property(e => e.IdTarifRekanan).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_TarifRekananSub>(entity =>
        {
            entity.Property(e => e.IdTarifRekananSub).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_Tarifdetail>(entity =>
        {
            entity.Property(e => e.IdTarifDetail).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdGroupTarifNavigation).WithMany(p => p.TmTarifdetails).HasConstraintName("FK_TM_TARIFDETAIL_TM_TARIF_GROUP");
        });

        modelBuilder.Entity<D_Kamar>(entity =>
        {
            entity.Property(e => e.Idkamar).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_Pengunjung>(entity =>
        {
            entity.Property(e => e.IdNumPengunjung).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_result_Hasillab>(entity =>
        {
            entity.Property(e => e.IdHasilLab).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdPasienLabNavigation).WithMany(p => p.TrHasillabs).HasConstraintName("FK_TR_HASILLAB_TT_PASIENLAB");
        });

        modelBuilder.Entity<D_result_Hasilrad>(entity =>
        {
            entity.HasKey(e => e.IdTrhasilrad).HasName("PK_TR_HASILRAD_1");

            entity.Property(e => e.IdTrhasilrad).ValueGeneratedOnAdd();
            entity.Property(e => e.Rtf).IsFixedLength();

            entity.HasOne(d => d.IdPasienRadNavigation).WithMany(p => p.TrHasilrads)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TR_HASILRAD_TT_PASIENRAD");
        });

        modelBuilder.Entity<D_result_Itemnonmedi>(entity =>
        {
            entity.Property(e => e.IdItemNonmedis).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdTransaksinonmedisNavigation).WithMany(p => p.TrItemnonmedis).HasConstraintName("FK_TR_ITEMNONMEDIS_TT_TRANSAKSINONMEDIS");
        });

        modelBuilder.Entity<D_result_Itemobatlangsung>(entity =>
        {
            entity.Property(e => e.IdItemObatLangsung).ValueGeneratedOnAdd();
            entity.Property(e => e.CApprove).IsFixedLength();
            entity.Property(e => e.CApproveVer).IsFixedLength();

            entity.HasOne(d => d.VNokuitansiNavigation).WithMany(p => p.TrItemobatlangsungs).HasConstraintName("FK_TR_ITEMOBATLANGSUNG_TT_OBATLANGSUNG");
        });

        modelBuilder.Entity<D_result_Itempaket>(entity =>
        {
            entity.Property(e => e.IdDetailPaket).ValueGeneratedOnAdd();
            entity.Property(e => e.Approve).IsFixedLength();
            entity.Property(e => e.CApproveVer).IsFixedLength();

            entity.HasOne(d => d.IdPaketNavigation).WithMany(p => p.TrItempakets).HasConstraintName("FK_TR_ITEMPAKET_TT_PAKET");
        });

        modelBuilder.Entity<D_Accountpasien>(entity =>
        {
            entity.Property(e => e.IdAcountPasien).ValueGeneratedOnAdd();
            entity.Property(e => e.CApproveVer).IsFixedLength();
            entity.Property(e => e.Unit).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<D_Betinap>(entity =>
        {
            entity.Property(e => e.CApprove).IsFixedLength();
            entity.Property(e => e.IdNum).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdRegistrasiNavigation).WithMany(p => p.TtBetinaps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TT_BETINAP_TT_KUNJUNGAN");
        });

        modelBuilder.Entity<D_Blacklist>(entity =>
        {
            entity.Property(e => e.IdBlacklist).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_Deposit>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            //entity.HasOne(d => d.IdRegistrasiNavigation).WithMany(p => p.TtDeposits)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK_TT_DEPOSIT_TT_KUNJUNGAN");
        });

        modelBuilder.Entity<D_Kuitansi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TT_EDITKUITANSI");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_Kuitansialke>(entity =>
        {
            entity.Property(e => e.CApprove).IsFixedLength();
            entity.Property(e => e.CApproveVer).IsFixedLength();
            entity.Property(e => e.IdNumAlkes).ValueGeneratedOnAdd();

            entity.HasOne(d => d.VKodeinventoryNavigation).WithMany(p => p.TtKuitansialkes).HasConstraintName("FK_TT_KUITANSIALKES_TM_GUDANG");

            entity.HasOne(d => d.VKoderuanganNavigation).WithMany(p => p.TtKuitansialkes).HasConstraintName("FK_TT_KUITANSIALKES_TM_RUANG");
        });

        modelBuilder.Entity<D_Kuitansiresep>(entity =>
        {
            entity.Property(e => e.CApprove).IsFixedLength();
            entity.Property(e => e.CApproveAa).IsFixedLength();
            entity.Property(e => e.CApproveVer).IsFixedLength();
            entity.Property(e => e.Idn).ValueGeneratedOnAdd();
            entity.Property(e => e.TtdDokter).HasDefaultValue("");

            entity.HasOne(d => d.VKddokterNavigation).WithMany(p => p.TtKuitansireseps).HasConstraintName("FK_TT_KUITANSIRESEP_TM_DOKTER");

            entity.HasOne(d => d.VKoderequestobatNavigation).WithMany(p => p.TtKuitansireseps).HasConstraintName("FK_TT_KUITANSIRESEP_TM_GUDANG");

            entity.HasOne(d => d.VKoderuanganNavigation).WithMany(p => p.TtKuitansireseps).HasConstraintName("FK_TT_KUITANSIRESEP_TM_RUANG");
        });

        modelBuilder.Entity<D_Kunjungan>(entity =>
        {
            entity.Property(e => e.Batal).IsFixedLength();
            entity.Property(e => e.IdNumKunjungan).ValueGeneratedOnAdd();
            entity.Property(e => e.NomorSep).HasDefaultValue("");

            entity.HasOne(d => d.IdPasienNavigation).WithMany(p => p.TtKunjungans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TT_KUNJUNGAN_TM_PASIEN_(idpasien)");

            entity.HasOne(d => d.Rekanan).WithMany(p => p.TtKunjungans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TT_KUNJUNGAN_TM_REKANAN_(rekananid)");
        });

        modelBuilder.Entity<D_Liburdokter>(entity =>
        {
            entity.Property(e => e.IdLiburDokter).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_Notedokter>(entity =>
        {
            entity.Property(e => e.IdNoteDokter).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_Obatalke>(entity =>
        {
            entity.Property(e => e.IdAlkes).ValueGeneratedOnAdd();
            entity.Property(e => e.CApprove).IsFixedLength();
            entity.Property(e => e.CApproveVer).IsFixedLength();
        });

        modelBuilder.Entity<D_Obatlangsung>(entity =>
        {
            entity.Property(e => e.BBayar).IsFixedLength();
            entity.Property(e => e.CApproveVer).IsFixedLength();
            entity.Property(e => e.IdObatlangsung).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_Paidout>(entity =>
        {
            entity.Property(e => e.IdPaidout).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdRegistrasiNavigation).WithMany(p => p.TtPaidouts).HasConstraintName("FK_TT_PAIDOUT_TT_KUNJUNGAN");
        });

        modelBuilder.Entity<D_Paket>(entity =>
        {
            entity.ToTable("TT_PAKET", tb => tb.HasTrigger("UPDATE_TT_TRANSAKSI"));

            entity.Property(e => e.IdPaket).ValueGeneratedOnAdd();
            entity.Property(e => e.CApprove).IsFixedLength();
            entity.Property(e => e.CApproveVer).IsFixedLength();
            entity.Property(e => e.VKddokter).IsFixedLength();
            entity.Property(e => e.VKdpemeriksaan).IsFixedLength();
            entity.Property(e => e.VKodetarif).IsFixedLength();
            entity.Property(e => e.VNmdokter).IsFixedLength();
            entity.Property(e => e.VNmpemeriksaan).IsFixedLength();
            entity.Property(e => e.VNmunit).IsFixedLength();

            entity.HasOne(d => d.IdRegistrasiNavigation).WithMany(p => p.TtPakets).HasConstraintName("FK_TT_PAKET_TT_KUNJUNGAN");
        });

        modelBuilder.Entity<D_PaketPbAppDetail>(entity =>
        {
            entity.Property(e => e.IdPaketpbAppDetail).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_PasienRencanaRad>(entity =>
        {
            entity.Property(e => e.IdRencanaKegiatan).ValueGeneratedOnAdd();
            entity.Property(e => e.Status).IsFixedLength();

            entity.HasOne(d => d.IdPasienNavigation).WithMany(p => p.TtPasienRencanaRads).HasConstraintName("FK_TT_PASIEN_RENCANA_RAD_TM_PASIEN");
        });

        modelBuilder.Entity<D_Pasieninap>(entity =>
        {
            entity.Property(e => e.Done).IsFixedLength();
            entity.Property(e => e.IdNum).ValueGeneratedOnAdd();

            entity.HasOne(d => d.KodeRuanganNavigation).WithMany(p => p.TtPasieninaps).HasConstraintName("FK_TT_PASIENINAP_TM_RUANG");
        });

        modelBuilder.Entity<D_Pasienlab>(entity =>
        {
            entity.Property(e => e.CApprove).IsFixedLength();
            entity.Property(e => e.CApproveAna).IsFixedLength();
            entity.Property(e => e.CApproveVer).IsFixedLength();
            entity.Property(e => e.CIsdone).IsFixedLength();
            entity.Property(e => e.IdNum).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdRegistrasiNavigation).WithMany(p => p.TtPasienlabs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TT_PASIENLAB_TT_KUNJUNGAN");

            entity.HasOne(d => d.VKddokterNavigation).WithMany(p => p.TtPasienlabVKddokterNavigations).HasConstraintName("FK_TT_PASIENLAB_TM_DOKTER3");

            entity.HasOne(d => d.VKddokterpjawabNavigation).WithMany(p => p.TtPasienlabVKddokterpjawabNavigations).HasConstraintName("FK_TT_PASIENLAB_TM_DOKTER2");

            entity.HasOne(d => d.VKoderuanganNavigation).WithMany(p => p.TtPasienlabs).HasConstraintName("FK_TT_PASIENLAB_TM_RUANG");
        });

        modelBuilder.Entity<D_Pasienpenunjang>(entity =>
        {
            entity.HasKey(e => e.IdPasienPenunjang).HasName("PK_TT_PASIENHEMO");

            entity.Property(e => e.Done).IsFixedLength();
            entity.Property(e => e.IdNumPasienpenj).ValueGeneratedOnAdd();

            entity.HasOne(d => d.KodeRuanganNavigation).WithMany(p => p.TtPasienpenunjangs).HasConstraintName("FK_TT_PASIENPENUNJANG_TM_RUANG");
        });

        modelBuilder.Entity<D_Pasienrad>(entity =>
        {
            entity.Property(e => e.CApprove).IsFixedLength();
            entity.Property(e => e.CApproveAna).IsFixedLength();
            entity.Property(e => e.CApproveVer).IsFixedLength();
            entity.Property(e => e.Done).IsFixedLength();
            entity.Property(e => e.IdNum).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdRegistrasiNavigation).WithMany(p => p.TtPasienrads)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TT_PASIENRAD_TT_KUNJUNGAN");

            entity.HasOne(d => d.KdDokterNavigation).WithMany(p => p.TtPasienrads)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TT_PASIENRAD_TM_DOKTER");

            entity.HasOne(d => d.KodeRuanganNavigation).WithMany(p => p.TtPasienrads).HasConstraintName("FK_TT_PASIENRAD_TM_RUANG");
        });

        modelBuilder.Entity<D_Pasienugd>(entity =>
        {
            entity.Property(e => e.IdNumPasienUgd).ValueGeneratedOnAdd();
            entity.Property(e => e.Done).IsFixedLength();
            entity.Property(e => e.Nadi).IsFixedLength();
            entity.Property(e => e.SuhuTubuh).IsFixedLength();
            entity.Property(e => e.TekananDarah).IsFixedLength();

            entity.HasOne(d => d.IdRegistrasiNavigation).WithMany(p => p.TtPasienugds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TT_PASIENUGD_TT_KUNJUNGAN");

            entity.HasOne(d => d.KdDokterNavigation).WithMany(p => p.TtPasienugds).HasConstraintName("FK_TT_PASIENUGD_TM_DOKTER");

            entity.HasOne(d => d.KodeRuanganNavigation).WithMany(p => p.TtPasienugds).HasConstraintName("FK_TT_PASIENUGD_TM_RUANG");
        });

        modelBuilder.Entity<D_Pembayaran>(entity =>
        {
            entity.HasKey(e => e.NomorByrPasien).HasName("PK_TT_PEMBAYARAN_1");

            entity.Property(e => e.IdPembayaran).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_PembayaranDetail>(entity =>
        {
            entity.HasKey(e => e.Idn).HasName("PK_TT_PEMBAYARAN");

            entity.Property(e => e.Idn).ValueGeneratedOnAdd();
            entity.Property(e => e.Status).IsFixedLength();
        });

        modelBuilder.Entity<D_Pemeriksaanradiologi>(entity =>
        {
            entity.Property(e => e.IdNumPasienrad).ValueGeneratedOnAdd();
            entity.Property(e => e.CApprove).IsFixedLength();
            entity.Property(e => e.CApproveAna).IsFixedLength();
            entity.Property(e => e.CApproveVer).IsFixedLength();
        });

        modelBuilder.Entity<D_Penjadwalan>(entity =>
        {
            entity.Property(e => e.IdPenjadwalan).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdPasienNavigation).WithMany(p => p.TtPenjadwalans).HasConstraintName("FK_TT_PENJADWALAN_TM_PASIEN");
        });

        modelBuilder.Entity<D_Plafonbpj>(entity =>
        {
            entity.Property(e => e.IdBpjs).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_PlafonbpjsHistory>(entity =>
        {
            entity.Property(e => e.IdBpjsHistory).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_Resep>(entity =>
        {
            entity.HasKey(e => e.IdObatresep).HasName("PK_TT_RESEPX");

            entity.Property(e => e.IdObatresep).ValueGeneratedOnAdd();
            entity.Property(e => e.CApprove).IsFixedLength();
            entity.Property(e => e.CApproveAa).IsFixedLength();
            entity.Property(e => e.CApproveVer).IsFixedLength();
            entity.Property(e => e.DDosisracikan).IsFixedLength();
        });

        modelBuilder.Entity<D_Retur>(entity =>
        {
            entity.Property(e => e.IdReturdetail).ValueGeneratedOnAdd();
            entity.Property(e => e.CApprove).IsFixedLength();
            entity.Property(e => e.CApproveVer).IsFixedLength();
        });

        modelBuilder.Entity<D_Returalke>(entity =>
        {
            entity.Property(e => e.CApprove).IsFixedLength();
            entity.Property(e => e.CApproveVer).IsFixedLength();
        });

        modelBuilder.Entity<D_Rubahrekanan>(entity =>
        {
            entity.Property(e => e.IdRubahRekanan).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_Tindakan>(entity =>
        {
            entity.Property(e => e.IdTindakan).ValueGeneratedOnAdd();
            entity.Property(e => e.CApprove).IsFixedLength();
            entity.Property(e => e.CApprove2).IsFixedLength();

            entity.HasOne(d => d.IdRegistrasiNavigation).WithMany(p => p.TtTindakans).HasConstraintName("FK_TT_TINDAKAN_TT_KUNJUNGAN");
        });

        modelBuilder.Entity<D_TindakanDetail>(entity =>
        {
            entity.HasKey(e => e.IdTindakandetail).HasName("PK_TT_TINDAKAN1");

            entity.ToTable("TT_TINDAKAN_DETAIL", tb =>
                {
                    tb.HasTrigger("INSERT_STATUS_TINDAKAN");
                    tb.HasTrigger("UPDATE_STATUS_TINDAKAN");
                });

            entity.Property(e => e.IdTindakandetail).ValueGeneratedOnAdd();
            entity.Property(e => e.CApprove).IsFixedLength();
            entity.Property(e => e.CApprove2).IsFixedLength();
        });

        modelBuilder.Entity<D_Transaksi>(entity =>
        {
            entity.ToTable("TT_TRANSAKSI", tb =>
                {
                    tb.HasTrigger("INSERT_STATUS_TRANSAKSI");
                    tb.HasTrigger("UPDATE_STATUS_TRANSAKSI");
                });

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.CApprove).IsFixedLength();
            entity.Property(e => e.CApprove2).IsFixedLength();
            entity.Property(e => e.IsBayar).IsFixedLength();
        });

        modelBuilder.Entity<D_Transaksinonmedi>(entity =>
        {
            entity.Property(e => e.IdTransaksiNonMedis).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_HasilDeposit>(entity =>
        {
            entity.Property(e => e.IdDeposit).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdkunjunganNavigation).WithMany(p => p.TtDeposits).HasConstraintName("FK_TTH_DEPOSIT_TTH_KUNJUNGAN");
        });

        modelBuilder.Entity<D_HargaKunjungan>(entity =>
        {
            entity.Property(e => e.IdNum).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdpengunjungNavigation).WithMany(p => p.TthKunjungans).HasConstraintName("FK_TTH_KUNJUNGAN_TMH_PENGUNJUNG");

            entity.HasOne(d => d.KamarNavigation).WithMany(p => p.TthKunjungans).HasConstraintName("FK_TTH_KUNJUNGAN_TMH_KAMAR");

            entity.HasOne(d => d.Rekanan).WithMany(p => p.TthKunjungans).HasConstraintName("FK_TTH_KUNJUNGAN_TM_REKANAN");
        });

        modelBuilder.Entity<D_HargaPengunjungInap>(entity =>
        {
            entity.Property(e => e.Idpengunjunginap).ValueGeneratedOnAdd();

            //entity.HasOne(d => d.IdkunjunganNavigation).WithMany(p => p.)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK_TTH_PENGUNJUNGINAP_TTH_KUNJUNGAN");

            entity.HasOne(d => d.KamarNavigation).WithMany(p => p.TthPengunjunginaps).HasConstraintName("FK_TTH_PENGUNJUNGINAP_TMH_KAMAR");
        });

        modelBuilder.Entity<D_HasilRubahrekananHotel>(entity =>
        {
            entity.HasKey(e => e.IdRubahrekananhtl).HasName("PK_TT_RUBAHREKANAN_HOTEL");

            entity.Property(e => e.IdRubahrekananhtl).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<D_HasilTransaksi>(entity =>
        {
            entity.Property(e => e.Idtransaksi).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdkunjunganNavigation).WithMany(p => p.TthTransaksis).HasConstraintName("FK_TTH_TRANSAKSI_TTH_KUNJUNGAN");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
