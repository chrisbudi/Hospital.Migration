using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_AturanPakai")]
[Index("IdAturanpakai", Name = "IX_M_AturanPakai_IdAturanPakai")]
[Index("IsAktif", Name = "IX_M_AturanPakai_IsAktif")]
[Index("KdAturanPakai", Name = "IX_M_AturanPakai_KdAturanPakai")]
[Index("KetAturanpakai", Name = "IX_M_AturanPakai_KetAturanPakai")]
[Index("NamaAturanpakai", Name = "IX_M_AturanPakai_NmAturanPakai")]
public partial class M_Aturanpakai
{
    [Key]
    [Column("IdAturanpakai", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdAturanpakai { get; set; }

    [Column("KdAturanPakai")]
    [StringLength(10)]
    [Unicode(false)]
    public string KdAturanPakai { get; set; }

    [Column("NamaAturanpakai")]
    [StringLength(50)]
    [Unicode(false)]
    public string NamaAturanpakai { get; set; }

    [Column("KetAturanpakai")]
    [StringLength(50)]
    [Unicode(false)]
    public string KetAturanpakai { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }
}