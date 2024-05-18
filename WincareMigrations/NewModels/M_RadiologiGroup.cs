

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_RadiologiGroup")]
public partial class M_RadiologiGroup
{
    [Key]
    [Column("IdGroup", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdGroup { get; set; }

    [Column("Nmgroup")]
    [StringLength(100)]
    [Unicode(false)]
    public string VNmgroup { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [Column("IdGrouptarif", TypeName = "numeric(18, 0)")]
    public decimal? IdGrouptarif { get; set; }

    [InverseProperty("IdGroupNavigation")]
    public virtual ICollection<M_Radiologi> M_Radiologis { get; set; } = new List<M_Radiologi>();
}