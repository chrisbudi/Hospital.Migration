using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;
[Table("M_PemeriksaanPenunjang")]
public partial class M_PemeriksaanPenunjang
{
    [Key]
    [Column("IdMasterPemeriksaanPenunjang", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdMasterPemeriksaanPenunjang { get; set; }

    [Required]
    [Column("KdPemeriksaan")]
    [StringLength(8)]
    [Unicode(false)]
    public string KdPemeriksaan { get; set; }

    [Column("NmPemeriksaan")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmPemeriksaan { get; set; }

    [Column("Harga", TypeName = "decimal(18, 0)")]
    public decimal? Harga { get; set; }

    [Column("BeaPasien", TypeName = "decimal(18, 0)")]
    public decimal? BeaPasien { get; set; }

    [Column("BeaRekanan", TypeName = "decimal(18, 0)")]
    public decimal? BeaRekanan { get; set; }

    [Column("Penunjang")]
    [StringLength(20)]
    [Unicode(false)]
    public string Penunjang { get; set; }

    [Column("RekananId")]
    public Guid RekananId { get; set; }

    [Column("OldRekananId", TypeName = "numeric(18, 0)")]
    public decimal OldRekananId { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [Column("IdGroupTarif")]
    public Guid IdGroupTarif { get; set; }

    [Column("OldIdGroupTarif", TypeName = "numeric(18, 0)")]
    public decimal? OldIdGroupTarif { get; set; }

    [InverseProperty("IdMasterPemeriksaanPenunjangNavigation")]
    public virtual ICollection<M_PemeriksaanPenunjangDetail> M_PemeriksaanPenunjangDetails { get; set; } = new List<M_PemeriksaanPenunjangDetail>();
}
