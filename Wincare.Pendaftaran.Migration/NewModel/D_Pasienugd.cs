using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Pasienugd")]
[Index("IdNumPasienUgd", Name = "IX_PASIENUGD_idnum")]
[Index("IdPasienIgd", Name = "IX_PASIENUGD_idpasienigd")]
[Index("IdRegistrasi", Name = "IX_PASIENUGD_idreg")]
[Index("Done", Name = "IX_PASIENUGD_isdone")]
[Index("KdDokter", Name = "IX_PASIENUGD_kddokter")]
[Index("KodeRuangan", Name = "IX_PASIENUGD_kdruang")]
[Index("NmDokter", Name = "IX_PASIENUGD_nmdokter")]
[Index("TglDatang", Name = "IX_PASIENUGD_tgl")]
[Index("KdPengirim", Name = "IX_PASIENUGD_vkdpengirim")]
public partial class D_Pasienugd
{
    [Key]
    [Column("IdNumPasienUgd", TypeName = "numeric(18, 0)")]
    public decimal IdNumPasienUgd { get; set; }

    [Required]
    [Column("IdRegistrasi")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdRegistrasi { get; set; }

    [Column("IdPasienIgd")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdPasienIgd { get; set; }

    [Column("TglDatang", TypeName = "datetime")]
    public DateTime TglDatang { get; set; }

    [Column("JamDatang")]
    [StringLength(5)]
    [Unicode(false)]
    public string JamDatang { get; set; }

    [Column("DibawaOleh")]
    [StringLength(100)]
    [Unicode(false)]
    public string DibawaOleh { get; set; }

    [Column("TglPulang", TypeName = "datetime")]
    public DateTime? TglPulang { get; set; }

    [Column("JamPulang")]
    [StringLength(5)]
    [Unicode(false)]
    public string JamPulang { get; set; }

    [Column("CaraKeluar")]
    [StringLength(50)]
    [Unicode(false)]
    public string CaraKeluar { get; set; }

    [Column("KasusPolisi")]
    public bool? KasusPolisi { get; set; }

    [Column("KasusKecelakaan")]
    public bool? KasusKecelakaan { get; set; }

    [Column("Visum")]
    public bool? Visum { get; set; }

    [Column("TglKelakaan", TypeName = "datetime")]
    public DateTime? TglKelakaan { get; set; }

    [Column("TmpKecelakaan")]
    [StringLength(100)]
    [Unicode(false)]
    public string TmpKecelakaan { get; set; }

    [Column("DiberitahukanKeKeluarga")]
    public bool? DiberitahukanKeKeluarga { get; set; }

    [Column("DiberitahukanKePolisi")]
    public bool? DiberitahukanKePolisi { get; set; }

    [Column("KeadaanTerakhir")]
    [StringLength(50)]
    [Unicode(false)]
    public string KeadaanTerakhir { get; set; }

    [Column("TglPemberitahuan", TypeName = "datetime")]
    public DateTime? TglPemberitahuan { get; set; }

    [Column("JamPemberitahuan")]
    [StringLength(5)]
    [Unicode(false)]
    public string JamPemberitahuan { get; set; }

    [Column("NmPemberitahu")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmPemberitahu { get; set; }

    [Column("Penjamin")]
    [StringLength(100)]
    [Unicode(false)]
    public string Penjamin { get; set; }

    [Column("RiwayatSingkat")]
    [StringLength(300)]
    [Unicode(false)]
    public string RiwayatSingkat { get; set; }

    [Column("Pendarahan")]
    public bool? Pendarahan { get; set; }

    [Column("SuhuTubuh")]
    [StringLength(5)]
    [Unicode(false)]
    public string SuhuTubuh { get; set; }

    [Column("Nadi")]
    [StringLength(5)]
    [Unicode(false)]
    public string Nadi { get; set; }

    [Column("TekananDarah")]
    [StringLength(8)]
    [Unicode(false)]
    public string TekananDarah { get; set; }

    [Column("Anamnese")]
    [StringLength(300)]
    [Unicode(false)]
    public string Anamnese { get; set; }

    [Column("PemeriksaanFisik")]
    [StringLength(300)]
    [Unicode(false)]
    public string PemeriksaanFisik { get; set; }

    [Column("PemeriksaanLanjutan")]
    [StringLength(300)]
    [Unicode(false)]
    public string PemeriksaanLanjutan { get; set; }

    [Column("PemeriksaanPenunjang")]
    [StringLength(300)]
    [Unicode(false)]
    public string PemeriksaanPenunjang { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("Done")]
    [StringLength(1)]
    [Unicode(false)]
    public string Done { get; set; }

    [Column("KdPengirim")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdPengirim { get; set; }

    [Column("NmPengirim")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmPengirim { get; set; }

    [Column("KdDokter")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdDokter { get; set; }

    [Column("NmDokter")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmDokter { get; set; }

    [Column("KodeRuangan")]
    [StringLength(5)]
    [Unicode(false)]
    public string KodeRuangan { get; set; }

    [Column("IdStatus")]
    public int? IdStatus { get; set; }

    [ForeignKey("IdRegistrasi")]
    [InverseProperty("TtPasienugds")]
    public virtual D_Kunjungan IdRegistrasiNavigation { get; set; }

    [ForeignKey("KdDokter")]
    [InverseProperty("TtPasienugds")]
    public virtual D_Dokter KdDokterNavigation { get; set; }

    [ForeignKey("KodeRuangan")]
    [InverseProperty("TtPasienugds")]
    public virtual D_Ruang KodeRuanganNavigation { get; set; }
}
