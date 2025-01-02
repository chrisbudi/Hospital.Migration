using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_KamarInap")]
[Index("KdTmpTidur", Name = "IX_KAMARINAP_kdtmptidur")]
[Index("Lantai", Name = "IX_KAMARINAP_lantai")]
public partial class D_KamarInap
{
    [Column("IdKamarInap", TypeName = "numeric(18, 0)")]
    public decimal IdKamarInap { get; set; }

    [Key]
    [Column("KdTmpTidur")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdTmpTidur { get; set; }

    [Required]
    [Column("Kelas")]
    [StringLength(20)]
    [Unicode(false)]
    public string Kelas { get; set; }

    [Column("Lantai")]
    [StringLength(6)]
    [Unicode(false)]
    public string Lantai { get; set; }

    [Column("NoKamar")]
    [StringLength(6)]
    [Unicode(false)]
    public string NoKamar { get; set; }

    [Column("KodeTarif")]
    [StringLength(2)]
    [Unicode(false)]
    public string KodeTarif { get; set; }

    [Column("KodeRuangan")]
    [StringLength(5)]
    [Unicode(false)]
    public string KodeRuangan { get; set; }

    [Column("Isi")]
    [StringLength(1)]
    [Unicode(false)]
    public string Isi { get; set; }

    [Column("X")]
    public int? X { get; set; }

    [Column("Y")]
    public int? Y { get; set; }

    [Column("IdMapId", TypeName = "numeric(18, 0)")]
    public decimal? IdMapId { get; set; }

    [Column("Aktif")]
    public bool? Aktif { get; set; }
}
