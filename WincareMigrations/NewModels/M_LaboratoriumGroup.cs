using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_LaboratoriumGroup")]
public partial class M_LaboratoriumGroup
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

    [Column("IsPk")]
    public bool? IsPk { get; set; }

    [InverseProperty("IdGroupNavigation")]
    public virtual ICollection<M_Laboratorium> M_Laboratoria { get; set; } = new List<M_Laboratorium>();
}