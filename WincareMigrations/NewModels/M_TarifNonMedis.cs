using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_TarifNonMedis")]
[Index("KdTarif", Name = "IX_TmTarifNonMedis_KdTarif", IsUnique = true)]
public partial class M_TarifNonMedis
{

    [Key]

    [Column("IdNonMedis", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdNonMedis { get; set; }

    [Column("KdTarif")]
    [StringLength(10)]
    [Unicode(false)]
    public string KdTarif { get; set; }

    [Column("Nmtarif")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmTarif { get; set; }

    [Column("IdGroupNonMedis")]
    public int? IdGroupNonMedis { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [ForeignKey("IdGroupNonMedis")]
    [InverseProperty("M_Tarifnonmedis")]
    public virtual M_TarifnonmedisGroup IdGroupnonmedisNavigation { get; set; }

    [InverseProperty("KdtarifNavigation")]
    public virtual ICollection<M_TarifnonmedisHarga> M_TarifnonmedisHargas { get; set; } = new List<M_TarifnonmedisHarga>();

    [InverseProperty("KdtarifNavigation")]
    public virtual ICollection<M_TarifnonmedisMatrix> M_TarifnonmedisMatrices { get; set; } = new List<M_TarifnonmedisMatrix>();

    [InverseProperty("KdtarifNavigation")]
    public virtual ICollection<M_TarifnonmedisRekanan> M_TarifnonmedisRekanans { get; set; } = new List<M_TarifnonmedisRekanan>();
}
