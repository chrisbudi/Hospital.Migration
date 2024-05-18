using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_TarifnonmedisRekanan")]
public partial class M_TarifnonmedisRekanan
{
    [Key]
    [Column("IdNonMedRek")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdNonMedRek { get; set; }

    [Column("KdTarif")]
    [StringLength(10)]
    [Unicode(false)]
    public string KdTarif { get; set; }

    [Column("IdTarifNon", TypeName = "numeric(18, 0)")]
    public decimal IdTarifNon { get; set; }

    [Column("OldIdRekanan", TypeName = "numeric(18, 0)")]
    public decimal? OldIdRekanan { get; set; }

    [Column("IdRekanan")]
    public Guid IdRekanan { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [ForeignKey("IdTarifNon")]
    [InverseProperty("M_TarifnonmedisRekanans")]
    public virtual M_TarifNonMedis KdtarifNavigation { get; set; }
}