using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("TT_TINDAKAN_DETAIL")]
[Index("VNomortindakan", Name = "IX_TT_TINDAKAN_DETAIL")]
[Index("DBeapasien", Name = "IX_TT_TINDAKAN_DETAIL_1")]
[Index("DBearekanan", Name = "IX_TT_TINDAKAN_DETAIL_2")]
[Index("DBiaya", Name = "IX_TT_TINDAKAN_DETAIL_3")]
[Index("IJml", Name = "IX_TT_TINDAKAN_DETAIL_4")]
public partial class D_TindakanDetail
{
    [Key]
    [Column("ID_TINDAKANDETAIL", TypeName = "numeric(18, 0)")]
    public decimal IdTindakandetail { get; set; }

    [Column("V_NOMORTINDAKAN")]
    [StringLength(12)]
    [Unicode(false)]
    public string VNomortindakan { get; set; }

    [Column("ID_REGISTRASI")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdRegistrasi { get; set; }

    [Column("V_KDTINDAKAN")]
    [StringLength(10)]
    [Unicode(false)]
    public string VKdtindakan { get; set; }

    [Column("V_NMTINDAKAN")]
    [StringLength(100)]
    [Unicode(false)]
    public string VNmtindakan { get; set; }

    [Column("I_JML")]
    public int? IJml { get; set; }

    [Column("D_BIAYA", TypeName = "decimal(18, 0)")]
    public decimal? DBiaya { get; set; }

    [Column("D_CITO", TypeName = "decimal(18, 0)")]
    public decimal? DCito { get; set; }

    [Column("D_PENYULIT", TypeName = "decimal(18, 0)")]
    public decimal? DPenyulit { get; set; }

    [Column("D_2TND", TypeName = "decimal(18, 0)")]
    public decimal? D2tnd { get; set; }

    [Column("D_ADM", TypeName = "decimal(18, 0)")]
    public decimal? DAdm { get; set; }

    [Column("D_DISKON", TypeName = "decimal(18, 0)")]
    public decimal? DDiskon { get; set; }

    [Column("D_SUBTOTAL", TypeName = "decimal(18, 0)")]
    public decimal? DSubtotal { get; set; }

    [Column("D_BEAPASIEN", TypeName = "decimal(18, 0)")]
    public decimal? DBeapasien { get; set; }

    [Column("D_BEAREKANAN", TypeName = "decimal(18, 0)")]
    public decimal? DBearekanan { get; set; }

    [Column("V_KDDOKTER")]
    [StringLength(6)]
    [Unicode(false)]
    public string VKddokter { get; set; }

    [Column("V_NMDOKTER")]
    [StringLength(100)]
    [Unicode(false)]
    public string VNmdokter { get; set; }

    [Column("D_TGLTINDAKAN", TypeName = "datetime")]
    public DateTime? DTgltindakan { get; set; }

    [Column("V_NOTE")]
    [StringLength(300)]
    [Unicode(false)]
    public string VNote { get; set; }

    [Column("V_KODETARIF")]
    [StringLength(2)]
    [Unicode(false)]
    public string VKodetarif { get; set; }

    [Column("D_JASAMEDIS", TypeName = "decimal(18, 0)")]
    public decimal? DJasamedis { get; set; }

    [Column("D_JASAMEDIS2", TypeName = "decimal(18, 0)")]
    public decimal? DJasamedis2 { get; set; }

    [Column("D_JASAMEDIS3", TypeName = "decimal(18, 0)")]
    public decimal? DJasamedis3 { get; set; }

    [Column("D_JASARS", TypeName = "decimal(18, 0)")]
    public decimal? DJasars { get; set; }

    [Column("D_BAHANALKES", TypeName = "decimal(18, 0)")]
    public decimal? DBahanalkes { get; set; }

    [Column("V_GROUP")]
    [StringLength(50)]
    [Unicode(false)]
    public string VGroup { get; set; }

    [Column("V_KDDOKTER2")]
    [StringLength(6)]
    [Unicode(false)]
    public string VKddokter2 { get; set; }

    [Column("V_NMDOKTER2")]
    [StringLength(100)]
    [Unicode(false)]
    public string VNmdokter2 { get; set; }

    [Column("V_KDDOKTER3")]
    [StringLength(6)]
    [Unicode(false)]
    public string VKddokter3 { get; set; }

    [Column("V_NMDOKTER3")]
    [StringLength(100)]
    [Unicode(false)]
    public string VNmdokter3 { get; set; }

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

    [Column("V_APPROVE")]
    [StringLength(50)]
    [Unicode(false)]
    public string VApprove { get; set; }

    [Column("C_APPROVE2")]
    [StringLength(1)]
    [Unicode(false)]
    public string CApprove2 { get; set; }

    [Column("D_APPROVE2", TypeName = "datetime")]
    public DateTime? DApprove2 { get; set; }

    [Column("V_STATUS")]
    [StringLength(20)]
    [Unicode(false)]
    public string VStatus { get; set; }

    [Column("ID_STATUS")]
    public int? IdStatus { get; set; }

    [Column("V_APPROVE2")]
    [StringLength(50)]
    [Unicode(false)]
    public string VApprove2 { get; set; }
}
