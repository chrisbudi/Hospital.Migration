using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_SettingBayar")]
public partial class M_SettingBayar
{
    [Key]
    [Column("IdSettingBayar")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdSettingBayar { get; set; }

    [Column("CaraBayar")]
    [StringLength(50)]
    [Unicode(false)]
    public string CaraBayar { get; set; }

    [Column("KdAkun")]
    [StringLength(50)]
    [Unicode(false)]
    public string VKdakun { get; set; }
}