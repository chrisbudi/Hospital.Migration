using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_SettingPemeriksaan")]
public partial class M_SettingPemeriksaan
{
    [Key]
    [Column("IdSettingPeriksaan", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdSettingperiksa { get; set; }

    [Column("NmPemeriksaan")]
    [StringLength(50)]
    [Unicode(false)]
    public string VNmpemeriksaan { get; set; }


    [Column("Group")]
    [StringLength(20)]
    [Unicode(false)]
    public string Group { get; set; }

    [Column("IsTampil")]
    public bool? IsTampil { get; set; }
}