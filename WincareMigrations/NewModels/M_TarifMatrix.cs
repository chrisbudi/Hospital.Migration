using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_TarifMatrix")]
public partial class M_TarifMatrix
{

    [Key]
    [Column("IdTarifmatrix")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid IdTarifmatrix { get; set; }

    [Column("OldIdTarifmatrix", TypeName = "numeric(18, 0)")]
    public decimal OldIdTarifmatrix { get; set; }


    [Column("IdTarifdetail")]
    public Guid IdTarifdetail { get; set; }

    [Column("Kdtarifdetail")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kdtarifdetail { get; set; }

    [Column("IdRuang")]
    public Guid IdRuang { get; set; }

    [Column("Koderuangan")]
    [StringLength(50)]
    [Unicode(false)]
    public string Koderuangan { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }
}