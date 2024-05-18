

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_MasterPaketH")]
public partial class M_MasterPaketH
{
    [Key]
    [Column("Id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Column("OldId", TypeName = "numeric(18, 0)")]
    public decimal OldId { get; set; }

    [Column("IdMasterPemeriksaan", TypeName = "numeric(18, 0)")]
    public decimal? Idmasterpemeriksaan { get; set; }

    [Column("NmPemeriksaan")]
    [StringLength(100)]
    [Unicode(false)]
    public string VNmpemeriksaan { get; set; }

    [Column("KdPemeriksaan")]
    [StringLength(50)]
    [Unicode(false)]
    public string VKdpemeriksaan { get; set; }

    [Column("Harga", TypeName = "decimal(18, 0)")]
    public decimal? DHarga { get; set; }

    [Column("Penunjang")]
    [StringLength(50)]
    [Unicode(false)]
    public string VPenunjang { get; set; }

    [Column("IdGroupTarif", TypeName = "numeric(18, 0)")]
    public decimal? IdGrouptarif { get; set; }
}
