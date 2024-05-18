using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_Morfologi")]
public partial class M_Morfologi
{
    [Key]
    [Column("IdMorfologi", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdMorfologi { get; set; }

    [Column("KdMorfologi")]
    [StringLength(8)]
    [Unicode(false)]
    public string Kdmorfologi { get; set; }

    [Column("NmMorfologi")]
    [StringLength(100)]
    [Unicode(false)]
    public string Nmmorfologi { get; set; }

    [Column("KdDiagnosa")]
    [StringLength(8)]
    [Unicode(false)]
    public string Kddiagnosa { get; set; }

    [Column("IdDiagnosa", TypeName = "decimal(18,0)")]
    public decimal IdDiagnosa { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [ForeignKey("IdDiagnosa")]
    [InverseProperty("M_Morfologis")]
    public virtual M_Diagnosa KdDiagnosaNavigation { get; set; }
}