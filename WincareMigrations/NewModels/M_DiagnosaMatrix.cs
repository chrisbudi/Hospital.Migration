using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_DiagnosaMatrix")]
public partial class M_DiagnosaMatrix
{
    [Key]
    [Column("IdMatrixDiagnosa", TypeName = "decimal(18, 2)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdDiagnosaMatrix { get; set; }


    [Column("IdRuangan")]
    public decimal IdRuangan { get; set; }

    [Column("KodeRuangan")]
    [StringLength(8)]
    [Unicode(false)]
    public string Koderuangan { get; set; }

    [Column("IdDiagnosa", TypeName = "decimal(18,2)")]
    public decimal IdDiagnosa { get; set; }

    [Column("KdDiagnosa")]
    [StringLength(8)]
    [Unicode(false)]
    public string Kddiagnosa { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }
}