using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_TarifGroup")]
public partial class M_TarifGroup
{
    [Key]
    [Column("IdGroupTarif")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdGrouptarif { get; set; }

    [Column("NmGroupTarif")]
    [StringLength(20)]
    [Unicode(false)]
    public string NmGroupTarif { get; set; }

    [Column("Aliasgroup")]
    [StringLength(3)]
    [Unicode(false)]
    public string AliasGroup { get; set; }

    [Column("KdAkun")]
    [StringLength(8)]
    [Unicode(false)]
    public string KdAkun { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [InverseProperty("IdGrouptarifNavigation")]
    public virtual ICollection<M_TarifDetail> M_Tarifdetails { get; set; } = new List<M_TarifDetail>();
}
