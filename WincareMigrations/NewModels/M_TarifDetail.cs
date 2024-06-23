using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_TarifDetail")]
public partial class M_TarifDetail
{
    [Key]
    [Column("IdTarifdetail")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Ulid IdTarifdetail { get; set; }

    [Column("OldIdTarifdetail", TypeName = "numeric(18, 0)")]
    public decimal OldIdTarifdetail { get; set; }

    [Column("KodeTarifLayan")]
    [StringLength(2)]
    [Unicode(false)]
    public string KodeTarifLayan { get; set; }

    [Column("KdTarifDetail")]
    [StringLength(10)]
    [Unicode(false)]
    public string KdTarifDetail { get; set; }

    [Required]
    [Column("NmTarifDetail")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmTarifDetail { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [Column("IdGroupTarif")]
    public int? IdGroupTarif { get; set; }

    [ForeignKey("IdGroupTarif")]
    [InverseProperty("M_Tarifdetails")]
    public virtual M_TarifGroup IdGrouptarifNavigation { get; set; }

    [ForeignKey("Kodetariflayan")]
    [InverseProperty("M_Tarifdetails")]
    public virtual M_TarifPelayanan VKodetariflayanNavigation { get; set; }
}
