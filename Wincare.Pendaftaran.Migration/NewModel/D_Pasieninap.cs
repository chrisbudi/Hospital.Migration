using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Pasieninap")]
[Index("Done", Name = "IX_PASIENINAP_isdone")]
[Index("TglDatang", Name = "IX_PASIENINAP_tgldatang")]
[Index("IdNum", Name = "IX_PASIENINAP_idnum")]
[Index("IdPasienInap", Name = "IX_PASIENINAP_idpaiseninap")]
[Index("IdRegistrasi", Name = "IX_PASIENINAP_idregistrasi")]
[Index("KdPengirim", Name = "IX_PASIENINAP_kdpengirim")]
[Index("NmPengirim", Name = "IX_PASIENINAP_nmpengirim")]
[Index("KdDokter", Name = "IX_PASIENINAP_vkddokter")]
public partial class D_Pasieninap
{
    [Column("IdNum", TypeName = "numeric(18, 0)")]
    public decimal IdNum { get; set; }

    [Key]
    [Column("IdRegistrasi")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdRegistrasi { get; set; }

    [Column("IdPasienInap")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdPasienInap { get; set; }

    [Column("TglDatang", TypeName = "datetime")]
    public DateTime? TglDatang { get; set; }

    [Column("JamDatang")]
    [StringLength(5)]
    [Unicode(false)]
    public string JamDatang { get; set; }

    [Column("KdDokter")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdDokter { get; set; }

    [Column("CaraMasuk")]
    [StringLength(50)]
    [Unicode(false)]
    public string CaraMasuk { get; set; }

    [Column("KdPengirim")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdPengirim { get; set; }

    [Column("NmPengirim")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmPengirim { get; set; }

    [Column("TipePengirim")]
    [StringLength(50)]
    [Unicode(false)]
    public string TipePengirim { get; set; }

    [Column("Keluhan")]
    [StringLength(300)]
    [Unicode(false)]
    public string Keluhan { get; set; }

    [Column("KeteranganAwal")]
    [StringLength(300)]
    [Unicode(false)]
    public string KeteranganAwal { get; set; }

    [Column("NmPenjamin")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmPenjamin { get; set; }

    [Column("AlamatPenjamin")]
    [StringLength(200)]
    [Unicode(false)]
    public string AlamatPenjamin { get; set; }

    [Column("TelpPenjamin")]
    [StringLength(100)]
    [Unicode(false)]
    public string TelpPenjamin { get; set; }

    [Column("JaminPribadi")]
    public bool? JaminPribadi { get; set; }

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

    [Column("KeadaanAkhir")]
    [StringLength(50)]
    [Unicode(false)]
    public string KeadaanAkhir { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("Done")]
    [StringLength(1)]
    [Unicode(false)]
    public string Done { get; set; }

    [Column("Note")]
    [StringLength(500)]
    [Unicode(false)]
    public string Note { get; set; }

    [Column("Dokter1")]
    [StringLength(20)]
    [Unicode(false)]
    public string Dokter1 { get; set; }

    [Column("Dokter2")]
    [StringLength(20)]
    [Unicode(false)]
    public string Dokter2 { get; set; }

    [Column("Dokter3")]
    [StringLength(20)]
    [Unicode(false)]
    public string Dokter3 { get; set; }

    [Column("Dokter4")]
    [StringLength(20)]
    [Unicode(false)]
    public string Dokter4 { get; set; }

    [Column("Dokter5")]
    [StringLength(20)]
    [Unicode(false)]
    public string Dokter5 { get; set; }

    [Column("KodeRuangan")]
    [StringLength(5)]
    [Unicode(false)]
    public string KodeRuangan { get; set; }

    [Column("IdStatus")]
    public int? IdStatus { get; set; }

    [Column("HakKelas")]
    [StringLength(20)]
    [Unicode(false)]
    public string HakKelas { get; set; }

    [ForeignKey("KodeRuangan")]
    [InverseProperty("TtPasieninaps")]
    public virtual D_Ruang KodeRuanganNavigation { get; set; }
}
