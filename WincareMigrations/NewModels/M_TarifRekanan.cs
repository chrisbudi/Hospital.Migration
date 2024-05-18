

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_TarifRekanan")]
public partial class M_TarifRekanan
{
    [Key]
    [Column("IdTarifRekanan")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid IdTarifRekanan { get; set; }

    [Column("OldIdTarifRekanan", TypeName = "numeric(18, 0)")]
    public decimal OldIdTarifRekanan { get; set; }

    [Required]
    [Column("KdTarifDetail")]
    [StringLength(10)]
    [Unicode(false)]
    public string KdTarifDetail { get; set; }

    [Column("RekananId")]
    public Guid RekananId { get; set; }

    [Column("OldRekananId", TypeName = "numeric(18, 0)")]
    public decimal OldRekananId { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }
}