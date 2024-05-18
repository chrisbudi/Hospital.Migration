using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_SettingDaftar")]
public partial class M_SettingDaftar
{
    [Key]
    [Column("IdSettingdaftar")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdSettingdaftar { get; set; }

    [Column("NmUnitDaftar")]
    [StringLength(50)]
    [Unicode(false)]
    public string NmUnitDaftar { get; set; }

    [Column("Koderuangan")]
    [StringLength(5)]
    [Unicode(false)]
    public string KodeRuangan { get; set; }

    [Column("Tujuan")]
    [StringLength(50)]
    [Unicode(false)]
    public string Tujuan { get; set; }

    [Column("IsTampil")]
    public bool? IsTampil { get; set; }
}