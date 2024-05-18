using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;


[Table("M_PaketMatrix")]
public partial class M_PaketMatrix
{
    [Key]
    [Column("IdPaketMatrix")]
    public Guid IdPaketmatrix { get; set; }

    [Column("OldIdPaketmatrix", TypeName = "numeric(18, 0)")]
    public decimal OldIdPaketmatrix { get; set; }

    [Column("IdMasterpemeriksaanpenunjang", TypeName = "numeric(18, 0)")]
    public decimal IdMasterpemeriksaanpenunjang { get; set; }

    [Column("Koderuangan")]
    [StringLength(5)]
    [Unicode(false)]
    public string KodeRuangan { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }
}