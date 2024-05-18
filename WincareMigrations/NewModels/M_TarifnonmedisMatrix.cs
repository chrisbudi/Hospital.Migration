using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_TarifnonmedisMatrix")]
public partial class M_TarifnonmedisMatrix
{
    [Key]
    [Column("IdNonMedisMatrix", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdNonMedisMatrix { get; set; }

    [Required]
    [Column("KdTarif")]
    [StringLength(10)]
    [Unicode(false)]
    public string KdTarif { get; set; }

    [Column("IdNonMedis", TypeName = "numeric(18,0)")]
    public decimal IdNonMedis { get; set; }

    [Column("KodeRuangan")]
    [StringLength(8)]
    [Unicode(false)]
    public string VKoderuangan { get; set; }

    [ForeignKey("IdNonMedis")]
    [InverseProperty("M_TarifnonmedisMatrices")]
    public virtual M_TarifNonMedis KdtarifNavigation { get; set; }
}