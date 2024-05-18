using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_TarifnonmedisGroup")]
public partial class M_TarifnonmedisGroup
{
    [Key]
    [Column("IdGroupNonMedis")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdGroupNonMedis { get; set; }

    [Column("Nmgroupnonmedis")]
    [StringLength(50)]
    [Unicode(false)]
    public string NmGroupNonMedis { get; set; }

    [Column("Kdakun")]
    [StringLength(8)]
    [Unicode(false)]
    public string KdAkun { get; set; }

    [InverseProperty("IdGroupnonmedisNavigation")]
    public virtual ICollection<M_TarifNonMedis> M_Tarifnonmedis { get; set; } = new List<M_TarifNonMedis>();
}