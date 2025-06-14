﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Pasien")]
[Index("AgamaPasien", Name = "IX_PASIEN_agama")]
[Index("AlamatPasien", Name = "IX_PASIEN_alamat")]
[Index("BlackList", Name = "IX_PASIEN_blacklist")]
[Index("HpPasien", Name = "IX_PASIEN_hp")]
[Index("IdPasien", Name = "IX_PASIEN_idpasien")]
[Index("Aktif", Name = "IX_PASIEN_isaktif")]
[Index("KelaminPasien", Name = "IX_PASIEN_kelamin")]
[Index("KotaPasien", Name = "IX_PASIEN_kota")]
[Index("NamaPasien", Name = "IX_PASIEN_namapasien")]
[Index("NoKtpSimPasien", Name = "IX_PASIEN_noktp")]
[Index("NoPenjamin", Name = "IX_PASIEN_nopenjamin")]
[Index("PekerjaanPasien", Name = "IX_PASIEN_pekerjaan")]
[Index("StatusKwnPasien", Name = "IX_PASIEN_statuskawin")]
[Index("TelpPasien", Name = "IX_PASIEN_telp")]
[Index("TmptLahirPasien", Name = "IX_PASIEN_tempatlahir")]
[Index("TglLahirPasien", Name = "IX_PASIEN_tgllahir")]
[Index("IdNumPasien", Name = "idnumpasien")]
public partial class D_Pasien
{
    [Column("IdNumPasien", TypeName = "numeric(18, 0)")]
    public decimal IdNumPasien { get; set; }

    [Key]
    [Column("IdPasien")]
    [StringLength(10)]
    [Unicode(false)]
    public string IdPasien { get; set; }

    [Required]
    [Column("NamaPasien")]
    [StringLength(100)]
    [Unicode(false)]
    public string NamaPasien { get; set; }

    [Column("NamaKelPasien")]
    [StringLength(50)]
    [Unicode(false)]
    public string NamaKelPasien { get; set; }

    [Column("KelaminPasien")]
    [StringLength(50)]
    [Unicode(false)]
    public string KelaminPasien { get; set; }

    [Column("TmptLahirPasien")]
    [StringLength(50)]
    [Unicode(false)]
    public string TmptLahirPasien { get; set; }

    [Column("TglLahirPasien", TypeName = "datetime")]
    public DateTime? TglLahirPasien { get; set; }

    [Column("AgamaPasien")]
    [StringLength(50)]
    [Unicode(false)]
    public string AgamaPasien { get; set; }

    [Column("StatusKwnPasien")]
    [StringLength(50)]
    [Unicode(false)]
    public string StatusKwnPasien { get; set; }

    [Column("PendidikanPasien")]
    [StringLength(50)]
    [Unicode(false)]
    public string PendidikanPasien { get; set; }

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

    [Column("NoKtpSimPasien")]
    [StringLength(50)]
    [Unicode(false)]
    public string NoKtpSimPasien { get; set; }

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

    [Column("KodePos")]
    [StringLength(5)]
    [Unicode(false)]
    public string KodePos { get; set; }

    [Column("Petugas")]
    [StringLength(50)]
    [Unicode(false)]
    public string Petugas { get; set; }

    [Column("Rhesus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Rhesus { get; set; }

    [Column("GolDarah")]
    [StringLength(3)]
    [Unicode(false)]
    public string GolDarah { get; set; }

    [Column("TglDaftar", TypeName = "datetime")]
    public DateTime? TglDaftar { get; set; }

    [Column("CetakKartu")]
    [StringLength(1)]
    [Unicode(false)]
    public string CetakKartu { get; set; }

    [Column("WargaNegara")]
    [StringLength(50)]
    [Unicode(false)]
    public string WargaNegara { get; set; }

    [Column("JenisPasien")]
    [StringLength(50)]
    [Unicode(false)]
    public string JenisPasien { get; set; }

    [Column("RekananId", TypeName = "numeric(18, 0)")]
    public decimal? RekananId { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("Aktif")]
    public bool? Aktif { get; set; }

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

    [Column("BlackList")]
    public bool? BlackList { get; set; }

    [Column("Kunjungan")]
    public bool? Kunjungan { get; set; }

    [ForeignKey("RekananId")]
    [InverseProperty("TmPasiens")]
    public virtual D_Rekanan Rekanan { get; set; }

    [InverseProperty("IdPasienNavigation")]
    public virtual ICollection<D_Kunjungan> TtKunjungans { get; set; } = new List<D_Kunjungan>();

    [InverseProperty("IdPasienNavigation")]
    public virtual ICollection<D_PasienRencanaRad> TtPasienRencanaRads { get; set; } = new List<D_PasienRencanaRad>();

    [InverseProperty("IdPasienNavigation")]
    public virtual ICollection<D_Penjadwalan> TtPenjadwalans { get; set; } = new List<D_Penjadwalan>();
}
