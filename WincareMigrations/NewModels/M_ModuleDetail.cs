using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_ModuleDetail")]
public partial class M_ModuleDetail
{
    [Key]
    [Column("IdModuleDetail")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdModuledetail { get; set; }

    [Column("IdModule")]
    public int? IdModule { get; set; }

    [Column("NmModulDetail")]
    [StringLength(50)]
    [Unicode(false)]
    public string NmModulDetail { get; set; }

    [Column("NmModuleDetailSub")]
    [StringLength(50)]
    [Unicode(false)]
    public string VNmModuleDetailSub { get; set; }

    [Column("Urut", TypeName = "numeric(18, 0)")]
    public decimal? Urut { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [ForeignKey("IdModule")]
    [InverseProperty("M_ModuleDetails")]
    public virtual M_Module IdModuleNavigation { get; set; }
}