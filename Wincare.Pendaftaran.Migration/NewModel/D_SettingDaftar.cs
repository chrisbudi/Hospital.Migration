using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_SettingDaftar")]
public partial class D_SettingDaftar
{
    [Column("SettingDaftar")]
    public long SettingDaftar { get; set; }

    [Column("NmUnitDaftar")]
    [StringLength(50)]
    [Unicode(false)]
    public string NmUnitDaftar { get; set; }

    [Column("KodeRuangan")]
    [StringLength(5)]
    [Unicode(false)]
    public string KodeRuangan { get; set; }

    [Key]
    [Column("Tujuan")]
    [StringLength(50)]
    [Unicode(false)]
    public string Tujuan { get; set; }

    [Column("Tampil")]
    public bool? Tampil { get; set; }
}
