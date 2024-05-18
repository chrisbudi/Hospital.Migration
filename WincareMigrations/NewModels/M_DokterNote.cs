using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_DokterNote")]
public partial class M_DokterNote
{
    [Key]
    [Column("IdDokterNote", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdDokterNote { get; set; }

    [Column("IdDokter", TypeName = "numeric(18, 0)")]
    public decimal IdDokter { get; set; }

    [Required]
    [Column("KdDokter")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdDokter { get; set; }

    [Column("Keterangan")]
    [StringLength(100)]
    [Unicode(false)]
    public string Keterangan { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("TglInput", TypeName = "TIMESTAMP")]
    public DateTime? TglInput { get; set; }
}