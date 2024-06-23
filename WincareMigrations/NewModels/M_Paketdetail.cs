using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;
[Table("M_PaketDetail")]
public partial class M_Paketdetail
{
    [Key]
    [Column("IdPaketdetail")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IdPaketdetail { get; set; }

    [Column("KdPaketDetail")]
    [StringLength(50)]
    [Unicode(false)]
    public string KdPaketDetail { get; set; }

    [Column("NmPaketDetail")]
    [StringLength(50)]
    [Unicode(false)]
    public string NmPaketDetail { get; set; }

    [Column("Group")]
    [StringLength(50)]
    [Unicode(false)]
    public string Group { get; set; }

    [Column("Tipe")]
    [StringLength(50)]
    [Unicode(false)]
    public string VTipe { get; set; }

    [Column("Harga", TypeName = "decimal(18, 0)")]
    public decimal? Harga { get; set; }

    [Column("Rekanan")]
    [StringLength(50)]
    [Unicode(false)]
    public string Rekanan { get; set; }
}