using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_SettingAdm")]
public partial class M_SettingAdm
{
    [Key]
    [Column("IdSettingAdm", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdAdm { get; set; }

    [Column("RekananId")]
    public Ulid RekananId { get; set; }

    [Column("OldRekananId", TypeName = "numeric(18, 0)")]
    public decimal? OldRekananId { get; set; }

    [Column("Kategori")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kategori { get; set; }

    [Column("Biaya", TypeName = "decimal(18, 0)")]
    public decimal? Biaya { get; set; }

    [Column("Percent", TypeName = "decimal(18, 2)")]
    public decimal? Percent { get; set; }
}