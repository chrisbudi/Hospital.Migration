using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_Module")]
public partial class M_Module
{
    [Key]
    [Column("IdModule")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdModule { get; set; }

    [Column("Nmmodule")]
    [StringLength(50)]
    [Unicode(false)]
    public string Nmmodule { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [InverseProperty("IdModuleNavigation")]
    public virtual ICollection<M_ModuleDetail> M_ModuleDetails { get; set; } = new List<M_ModuleDetail>();
}