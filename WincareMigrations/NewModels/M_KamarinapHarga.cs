using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("M_KamarinapHarga")]
public partial class M_KamarinapHarga
{
    [Key]
    [Column("IdKamarInapHarga", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdKamarInapHarga { get; set; }

    [Column("KdTmpTidur")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdTmpTidur { get; set; }

    [Column("IdKamarInap", TypeName = "numeric(18, 0)")]
    public decimal IdKamarinap { get; set; }

    [Column("RekananId", TypeName = "numeric(18, 0)")]
    public decimal? RekananId { get; set; }

    [Column("Harga", TypeName = "decimal(18, 0)")]
    public decimal? Harga { get; set; }

    [Column("BeaPasien", TypeName = "decimal(18, 0)")]
    public decimal? BeaPasien { get; set; }

    [Column("BeaRekanan", TypeName = "decimal(18, 0)")]
    public decimal? DBearekanan { get; set; }

    [Column("JasaMedis", TypeName = "decimal(18, 0)")]
    public decimal? JasaMedis { get; set; }

    [Column("JasaRS", TypeName = "decimal(18, 0)")]
    public decimal? JasaRS { get; set; }

    [Column("Bahanalkes", TypeName = "decimal(18, 0)")]
    public decimal? Bahanalkes { get; set; }

    [Column("Diskon", TypeName = "decimal(18, 0)")]
    public decimal? Diskon { get; set; }

    [Column("DCito", TypeName = "decimal(18, 0)")]
    public decimal? DCito { get; set; }

    [Column("DPenyulit", TypeName = "decimal(18, 0)")]
    public decimal? Penyulit { get; set; }

    [Column("SecondTnd", TypeName = "decimal(18, 0)")]
    public decimal? SecondTnd { get; set; }

    [Column("Adm", TypeName = "decimal(18, 0)")]
    public decimal? Adm { get; set; }

    [Column("Tglawal", TypeName = "TIMESTAMP")]
    public DateTime? Tglawal { get; set; }

    [Column("Tglakhir", TypeName = "TIMESTAMP")]
    public DateTime? Tglakhir { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [ForeignKey("IdKamarinap")]
    [InverseProperty("M_KamarInapHargas")]
    public virtual M_Kamarinap KdtmptidurNavigation { get; set; }
}
