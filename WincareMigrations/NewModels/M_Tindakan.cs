

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_Tindakan")]
public partial class M_Tindakan
{
    [Key]
    [Column("IdTindakan", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdTindakan { get; set; }

    [Column("KdTindakan")]
    [StringLength(8)]
    [Unicode(false)]
    public string Kdtindakan { get; set; }

    [Column("NmTindakan")]
    [StringLength(200)]
    [Unicode(false)]
    public string Nmtindakan { get; set; }

    [Column("NmPendek")]
    [StringLength(100)]
    [Unicode(false)]
    public string Nmpendek { get; set; }

    [Column("IS_AKTIF")]
    public bool? IsAktif { get; set; }
}