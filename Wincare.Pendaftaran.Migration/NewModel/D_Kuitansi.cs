using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Kuitansi")]
public partial class D_Kuitansi
{
    [Key]
    [Column("Id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("IdRegistrasi")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdRegistrasi { get; set; }

    [Column("TerimaDari")]
    [StringLength(50)]
    [Unicode(false)]
    public string TerimaDari { get; set; }

    [Column("Keterangan", TypeName = "text")]
    public string Keterangan { get; set; }

    [Column("Nominal", TypeName = "decimal(18, 0)")]
    public decimal? Nominal { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }
}
