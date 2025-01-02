
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_PlafonbpjsHistory")]
public partial class D_PlafonbpjsHistory
{
    [Key]
    [Column("IdBpjsHistory", TypeName = "numeric(18, 0)")]
    public decimal IdBpjsHistory { get; set; }

    [Column("IdRegistrasi")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdRegistrasi { get; set; }

    [Column("Tgl", TypeName = "datetime")]
    public DateTime? Tgl { get; set; }

    [Column("Bpjs", TypeName = "decimal(18, 0)")]
    public decimal? Bpjs { get; set; }

    [Column("Keterangan")]
    [StringLength(50)]
    [Unicode(false)]
    public string Keterangan { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("IdStatus")]
    public int? IdStatus { get; set; }
}
