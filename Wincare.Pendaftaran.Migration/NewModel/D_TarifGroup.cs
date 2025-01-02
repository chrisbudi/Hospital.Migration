using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_TarifGroup")]
public partial class D_TarifGroup
{
    [Key]
    [Column("IdGroupTarif", TypeName = "numeric(18, 0)")]
    public decimal IdGroupTarif { get; set; }

    [Column("NmGroupTarif")]
    [StringLength(20)]
    [Unicode(false)]
    public string NmGroupTarif { get; set; }

    [Column("AliasGroup")]
    [StringLength(3)]
    [Unicode(false)]
    public string AliasGroup { get; set; }

    [Column("KdAkun")]
    [StringLength(8)]
    [Unicode(false)]
    public string KdAkun { get; set; }

    [Column("Aktif")]
    public bool? Aktif { get; set; }

    [InverseProperty("IdGrouptarifNavigation")]
    public virtual ICollection<D_Tarifdetail> TmTarifdetails { get; set; } = new List<D_Tarifdetail>();
}
