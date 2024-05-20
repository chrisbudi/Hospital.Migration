using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_KamarinapRekanan")]
public partial class M_KamarInapRekanan
{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("IdKamarinaprek", TypeName = "numeric(18, 0)")]
    public decimal IdKamarinaprek { get; set; }

    [Required]
    [Column("KdTmpTidur")]
    [StringLength(6)]
    [Unicode(false)]
    public string Kdtmptidur { get; set; }

    [Column("RekananId")]
    public Guid RekananId { get; set; }

    [Column("OldRekananId", TypeName = "numeric(18, 0)")]
    public decimal OldRekananId { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }
}