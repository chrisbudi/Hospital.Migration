using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;
[Table("M_DokterHonor")]
public partial class M_DokterHonor
{
    [Key]
    [Column("Id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal Id { get; set; }

    [Column("KdDokter")]
    [StringLength(6)]
    [Unicode(false)]
    [Required]
    public string KdDokter { get; set; }

    [Column("NmDokter")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmDokter { get; set; }

    [Column("Tarif", TypeName = "decimal(18, 0)")]
    public decimal? Tarif { get; set; }

    [Column("JasaMedis", TypeName = "decimal(18, 0)")]
    public decimal? JasaMedis { get; set; }

    [Column("JasaRS", TypeName = "decimal(18, 0)")]
    public decimal? JasaRS { get; set; }

    [Column("Ket")]
    [StringLength(50)]
    [Unicode(false)]
    public string Ket { get; set; }
}