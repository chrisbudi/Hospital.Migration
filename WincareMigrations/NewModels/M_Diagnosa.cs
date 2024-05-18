using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_Diagnosa")]
[Index("NmDiagnosa", Name = "IX_M_Diagnosa_NmDiagnosa")]
[Index("KdDiagnosa", Name = "IX_M_Diagnosa_KdDiagnosa")]
public partial class M_Diagnosa
{
    [Key]
    [Column("IdDiagnosa", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdDiagnosa { get; set; }

    [Column("KdDiagnosa")]
    [StringLength(8)]
    [Unicode(false)]
    public string KdDiagnosa { get; set; }

    [Column("NmDiagnosa")]
    [StringLength(300)]
    [Unicode(false)]
    public string NmDiagnosa { get; set; }

    [Column("Ispenyakit")]
    public bool? IsPenyakit { get; set; }

    [Column("kdDTD")]
    [StringLength(8)]
    [Unicode(false)]
    public string KdDTD { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [InverseProperty("KdDiagnosaNavigation")]
    public virtual ICollection<M_Morfologi> M_Morfologis { get; set; } = new List<M_Morfologi>();
}
