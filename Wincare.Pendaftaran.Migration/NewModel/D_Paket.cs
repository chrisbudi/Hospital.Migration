using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("TT_PAKET")]
[Index("VNomorpaket", Name = "IX_TT_PAKET")]
[Index("IdRegistrasi", Name = "IX_TT_PAKET_1")]
[Index("DTgl", Name = "IX_TT_PAKET_3")]
[Index("VNmpemeriksaan", Name = "IX_TT_PAKET_4")]
public partial class D_Paket
{
    [Key]
    [Column("ID_PAKET", TypeName = "numeric(18, 0)")]
    public decimal IdPaket { get; set; }

    [Column("V_NOMORPAKET")]
    [StringLength(12)]
    [Unicode(false)]
    public string VNomorpaket { get; set; }

    [Column("ID_REGISTRASI")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdRegistrasi { get; set; }

    [Column("D_TGL", TypeName = "datetime")]
    public DateTime? DTgl { get; set; }

    [Column("ID_MASTERPEMERIKSAANPENUNJANG", TypeName = "numeric(18, 0)")]
    public decimal? IdMasterpemeriksaanpenunjang { get; set; }

    [Column("V_KDPEMERIKSAAN")]
    [StringLength(10)]
    [Unicode(false)]
    public string VKdpemeriksaan { get; set; }

    [Column("V_NMPEMERIKSAAN")]
    [StringLength(100)]
    [Unicode(false)]
    public string VNmpemeriksaan { get; set; }

    [Column("V_KODERUANGAN")]
    [StringLength(5)]
    [Unicode(false)]
    public string VKoderuangan { get; set; }

    [Column("V_NMUNIT")]
    [StringLength(100)]
    [Unicode(false)]
    public string VNmunit { get; set; }

    [Column("V_KODETARIF")]
    [StringLength(2)]
    [Unicode(false)]
    public string VKodetarif { get; set; }

    [Column("V_KDDOKTER")]
    [StringLength(6)]
    [Unicode(false)]
    public string VKddokter { get; set; }

    [Column("V_NMDOKTER")]
    [StringLength(100)]
    [Unicode(false)]
    public string VNmdokter { get; set; }

    [Column("ID_REKANAN", TypeName = "numeric(18, 0)")]
    public decimal? IdRekanan { get; set; }

    [Column("D_HARGA", TypeName = "decimal(18, 0)")]
    public decimal? DHarga { get; set; }

    [Column("D_BEAPASIEN", TypeName = "decimal(18, 0)")]
    public decimal? DBeapasien { get; set; }

    [Column("D_BEAREKANAN", TypeName = "decimal(18, 0)")]
    public decimal? DBearekanan { get; set; }

    [Column("D_DISKON", TypeName = "decimal(18, 0)")]
    public decimal? DDiskon { get; set; }

    [Column("V_BY")]
    [StringLength(50)]
    [Unicode(false)]
    public string VBy { get; set; }
    // DISINI APPROVE
    [Column("C_APPROVE")]
    [StringLength(1)]
    [Unicode(false)]
    public string CApprove { get; set; }

    [Column("D_APPROVE", TypeName = "datetime")]
    public DateTime? DApprove { get; set; }

    [Column("V_APPROVE_VER")]
    [StringLength(50)]
    [Unicode(false)]
    public string VApproveVer { get; set; }

    [Column("C_APPROVE_VER")]
    [StringLength(1)]
    [Unicode(false)]
    public string CApproveVer { get; set; }

    [Column("D_APPROVE_VER", TypeName = "datetime")]
    public DateTime? DApproveVer { get; set; }

    [Column("ID_STATUS")]
    public int? IdStatus { get; set; }

    [Column("V_APPROVE")]
    [StringLength(50)]
    [Unicode(false)]
    public string VApprove { get; set; }

    [ForeignKey("IdRegistrasi")]
    [InverseProperty("TtPakets")]
    public virtual D_Kunjungan IdRegistrasiNavigation { get; set; }

    [InverseProperty("IdPaketNavigation")]
    public virtual ICollection<D_result_Itempaket> TrItempakets { get; set; } = new List<D_result_Itempaket>();
}
