using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_SettingKomputerAntrian")]
[Index("IdSettingKomp", Name = "IX_M_SettingKomputerAntrian_idsettingkomp")]
[Index("KdCounter", Name = "IX_M_SettingKomputerAntrian_vkdcounter")]
[Index("KdJenisLayanan", Name = "IX_M_SettingKomputerAntrian_vkdlayanan")]
[Index("KdLokasi", Name = "IX_M_SettingKomputerAntrian_vkdlokasi")]
[Index("NmKomputer", Name = "IX_M_SettingKomputerAntrian_vnmkomp")]
public partial class M_SettingKomputerAntrian
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("IdSettingKomp", TypeName = "numeric(18, 0)")]
    public decimal IdSettingKomp { get; set; }

    [Column("NmKomputer")]
    [StringLength(50)]
    [Unicode(false)]
    public string NmKomputer { get; set; }

    [Column("KdLokasi")]
    [StringLength(5)]
    [Unicode(false)]
    public string KdLokasi { get; set; }

    [Column("KdJenisLayanan")]
    [StringLength(5)]
    [Unicode(false)]
    public string KdJenisLayanan { get; set; }

    [Column("KdCounter")]
    [StringLength(5)]
    [Unicode(false)]
    public string KdCounter { get; set; }

    [Column("Tanggal", TypeName = "TIMESTAMP")]
    public DateTime? Tanggal { get; set; }
}
