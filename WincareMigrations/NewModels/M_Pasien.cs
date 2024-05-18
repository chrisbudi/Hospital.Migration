using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;
[Table("M_Pasien")]
[Index("AgamaPasien", Name = "IX_M_Pasien_agama")]
[Index("AlamatPasien", Name = "IX_M_Pasien_alamat")]
[Index("IsBlacklist", Name = "IX_M_Pasien_blacklist")]
[Index("HpPasien", Name = "IX_M_Pasien_hp")]
[Index("IdPasien", Name = "IX_M_Pasien_idpasien")]
[Index("IsAktif", Name = "IX_M_Pasien_isaktif")]
[Index("Kelaminpasien", Name = "IX_M_Pasien_kelamin")]
[Index("KotaPasien", Name = "IX_M_Pasien_kota")]
[Index("NamaPasien", Name = "IX_M_Pasien_namapasien")]
[Index("Noktpsimpasien", Name = "IX_M_Pasien_noktp")]
[Index("NoPenjamin", Name = "IX_M_Pasien_nopenjamin")]
[Index("PekerjaanPasien", Name = "IX_M_Pasien_pekerjaan")]
[Index("StatusKWNPasien", Name = "IX_M_Pasien_statuskawin")]
[Index("TelpPasien", Name = "IX_M_Pasien_telp")]
[Index("Tmptlahirpasien", Name = "IX_M_Pasien_tempatlahir")]
[Index("Tgllahirpasien", Name = "IX_M_Pasien_tgllahir")]
public partial class M_Pasien
{
    [Key]
    [Column("IdPasien")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid IdPasien { get; set; }

    [Column("OldIdPasien", TypeName = "numeric(18, 0)")]
    public decimal OldIdPasien { get; set; }

    [Column("PasienNo")]
    [StringLength(10)]
    [Unicode(false)]
    public string PasienNo { get; set; }

    [Required]
    [Column("NamaPasien")]
    [StringLength(100)]
    [Unicode(false)]
    public string NamaPasien { get; set; }

    [Column("NamaKelPasien")]
    [StringLength(50)]
    [Unicode(false)]
    public string NamaKelPasien { get; set; }

    [Column("Kelaminpasien")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kelaminpasien { get; set; }

    [Column("Tmptlahirpasien")]
    [StringLength(50)]
    [Unicode(false)]
    public string Tmptlahirpasien { get; set; }

    [Column("Tgllahirpasien", TypeName = "TIMESTAMP")]
    public DateTime? Tgllahirpasien { get; set; }

    [Column("AgamaPasien")]
    [StringLength(50)]
    [Unicode(false)]
    public string AgamaPasien { get; set; }

    [Column("StatusKWNPasien")]
    [StringLength(50)]
    [Unicode(false)]
    public string StatusKWNPasien { get; set; }

    [Column("PendidikanPasien")]
    [StringLength(50)]
    [Unicode(false)]
    public string Pendidikanpasien { get; set; }

    [Column("PekerjaanPasien")]
    [StringLength(50)]
    [Unicode(false)]
    public string PekerjaanPasien { get; set; }

    [Column("AlamatPekerjaan")]
    [StringLength(200)]
    [Unicode(false)]
    public string AlamatPekerjaan { get; set; }

    [Column("TelpPekerjaan")]
    [StringLength(100)]
    [Unicode(false)]
    public string TelpPekerjaan { get; set; }

    [Column("Noktpsimpasien")]
    [StringLength(50)]
    [Unicode(false)]
    public string Noktpsimpasien { get; set; }

    [Column("JenisIdentitas")]
    [StringLength(50)]
    [Unicode(false)]
    public string JenisIdentitas { get; set; }

    [Column("NoPenjamin")]
    [StringLength(50)]
    [Unicode(false)]
    public string NoPenjamin { get; set; }

    [Column("AlamatPasien")]
    [StringLength(200)]
    [Unicode(false)]
    public string AlamatPasien { get; set; }

    [Column("KotaPasien")]
    [StringLength(50)]
    [Unicode(false)]
    public string KotaPasien { get; set; }

    [Column("TelpPasien")]
    [StringLength(100)]
    [Unicode(false)]
    public string TelpPasien { get; set; }

    [Column("HpPasien")]
    [StringLength(20)]
    [Unicode(false)]
    public string HpPasien { get; set; }

    [Column("AlergiPasien")]
    [StringLength(200)]
    [Unicode(false)]
    public string AlergiPasien { get; set; }

    [Column("CatKhusPasien")]
    [StringLength(200)]
    [Unicode(false)]
    public string CatKhusPasien { get; set; }

    [Column("AyahPasien")]
    [StringLength(100)]
    [Unicode(false)]
    public string AyahPasien { get; set; }

    [Column("IbuPasien")]
    [StringLength(100)]
    [Unicode(false)]
    public string IbuPasien { get; set; }

    [Column("PasanganPasien")]
    [StringLength(100)]
    [Unicode(false)]
    public string PasanganPasien { get; set; }

    [Column("NamaPenanggung")]
    [StringLength(100)]
    [Unicode(false)]
    public string NamaPenanggung { get; set; }

    [Column("AlamatPenanggung")]
    [StringLength(200)]
    [Unicode(false)]
    public string AlamatPenanggung { get; set; }

    [Column("TelpPenanggung")]
    [StringLength(100)]
    [Unicode(false)]
    public string TelpPenanggung { get; set; }

    [Column("Kodepos")]
    [StringLength(5)]
    [Unicode(false)]
    public string Kodepos { get; set; }

    [Column("Petugas")]
    [StringLength(50)]
    [Unicode(false)]
    public string Petugas { get; set; }

    [Column("Rhesus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Rhesus { get; set; }

    [Column("Goldarah")]
    [StringLength(3)]
    [Unicode(false)]
    public string Goldarah { get; set; }

    [Column("Tgldaftar", TypeName = "TIMESTAMP")]
    public DateTime? Tgldaftar { get; set; }

    [Column("Iscetakkartu")]
    [StringLength(1)]
    [Unicode(false)]
    public string Iscetakkartu { get; set; }

    [Column("Warganegara")]
    [StringLength(50)]
    [Unicode(false)]
    public string Warganegara { get; set; }

    [Column("Jenispasien")]
    [StringLength(50)]
    [Unicode(false)]
    public string Jenispasien { get; set; }

    [Column("RekananId", TypeName = "numeric(18, 0)")]
    public decimal? RekananId { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [Column("Suku")]
    [StringLength(50)]
    [Unicode(false)]
    public string Suku { get; set; }

    [Column("Perusahaan")]
    [StringLength(100)]
    [Unicode(false)]
    public string Perusahaan { get; set; }

    [Column("Provinsi")]
    [StringLength(100)]
    [Unicode(false)]
    public string Provinsi { get; set; }

    [Column("IsBlacklist")]
    public bool? IsBlacklist { get; set; }

    [Column("IsKunjungan")]
    public bool? IsKunjungan { get; set; }

    [ForeignKey("RekananId")]
    [InverseProperty("M_Pasiens")]
    public virtual M_Rekanan Rekanan { get; set; }
}
