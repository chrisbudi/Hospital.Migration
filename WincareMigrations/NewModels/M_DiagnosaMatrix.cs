using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_DiagnosaMatrix")]
public partial class M_DiagnosaMatrix
{
    [Key]
    [Column("IdMatrixDiagnosa")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IdDiagnosaMatrix { get; set; }


    [Column("IdRuangan")]
    public long? IdRuangan { get; set; }

    [Column("KodeRuangan")]
    [StringLength(8)]
    [Unicode(false)]
    public string Koderuangan { get; set; }

    [Column("IdDiagnosa")]
    public long? IdDiagnosa { get; set; }

    [Column("KdDiagnosa")]
    [StringLength(8)]
    [Unicode(false)]
    public string Kddiagnosa { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }
}