using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_SettingPemeriksaan")]
public partial class M_SettingPemeriksaan
{
    [Key]
    [Column("IdSettingPeriksaan")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdSettingperiksa { get; set; }

    [Column("NmPemeriksaan")]
    [StringLength(50)]
    [Unicode(false)]
    public string Nmpemeriksaan { get; set; }


    [Column("Group")]
    [StringLength(20)]
    [Unicode(false)]
    public string Group { get; set; }

    [Column("IsTampil")]
    public bool? IsTampil { get; set; }
}