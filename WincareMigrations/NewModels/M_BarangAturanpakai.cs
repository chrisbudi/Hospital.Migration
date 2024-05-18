using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_BarangAturanpakai")]
public partial class M_BarangAturanpakai
{
    [Key]

    [Column("IdAturanpakai", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdAturanpakai { get; set; }

    [Column("KdAturanPakai")]
    [StringLength(10)]
    [Unicode(false)]
    public string KdAturanPakai { get; set; }

    [Column("NmAturanPakai")]
    [StringLength(50)]
    [Unicode(false)]
    public string Nmaturanpakai { get; set; }

    [Column("KetAturanPakai")]
    [StringLength(50)]
    [Unicode(false)]
    public string Ketaturanpakai { get; set; }
}