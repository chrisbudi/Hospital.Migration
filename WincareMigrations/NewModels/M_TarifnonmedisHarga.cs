using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_TarifnonmedisHarga")]
public partial class M_TarifnonmedisHarga
{
    [Key]
    [Column("IdNonmedishrg")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdNonmedishrg { get; set; }

    [Required]
    [Column("Kdtarif")]
    [StringLength(10)]
    [Unicode(false)]
    public string Kdtarif { get; set; }

    [Column("IdTarifNon", TypeName = "numeric(18, 0)")]
    public decimal? IdTarifNon { get; set; }

    [Column("Harga", TypeName = "decimal(18, 0)")]
    public decimal? DHarga { get; set; }

    [Column("Beapasien", TypeName = "decimal(18, 0)")]
    public decimal? DBeapasien { get; set; }

    [Column("Bearekanan", TypeName = "decimal(18, 0)")]
    public decimal? DBearekanan { get; set; }

    [Column("OldRekananId", TypeName = "numeric(18, 0)")]
    public decimal? OldRekananId { get; set; }

    [Column("RekananId")]
    public Ulid? RekananId { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [ForeignKey("IdTarifNon")]
    [InverseProperty("M_TarifnonmedisHargas")]
    public virtual M_TarifNonMedis KdtarifNavigation { get; set; }
}