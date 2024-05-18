using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_TarifPelayanan")]
[Index("Kodetariflayan", Name = "IX_M_SettingKomputerAntrian_vnmkomp", IsUnique = true)]
public partial class M_TarifPelayanan
{
    [Key]
    [Column("IdTariflayan")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdTariflayan { get; set; }

    [Column("KodeTarifLayan")]
    [StringLength(2)]
    [Unicode(false)]
    public string Kodetariflayan { get; set; }

    [Column("NamaTarifLayan")]
    [StringLength(50)]
    [Unicode(false)]
    public string Namatariflayan { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [InverseProperty("VKodetariflayanNavigation")]
    public virtual ICollection<M_TarifDetail> M_Tarifdetails { get; set; } = new List<M_TarifDetail>();
}