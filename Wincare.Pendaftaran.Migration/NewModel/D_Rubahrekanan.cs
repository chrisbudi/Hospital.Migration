using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Rubahrekanan")]
public partial class D_Rubahrekanan
{
    [Key]
    [Column("IdRubahRekanan", TypeName = "numeric(18, 0)")]
    public decimal IdRubahRekanan { get; set; }

    [Column("TglRubah", TypeName = "datetime")]
    public DateTime? TglRubah { get; set; }

    [Column("IdRegistrasi")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdRegistrasi { get; set; }

    [Column("RekananidAsal", TypeName = "numeric(18, 0)")]
    public decimal? RekananidAsal { get; set; }

    [Column("RekananidTujuan", TypeName = "numeric(18, 0)")]
    public decimal? RekananidTujuan { get; set; }

    [Column("Keterangan")]
    [StringLength(50)]
    [Unicode(false)]
    public string Keterangan { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }
}
