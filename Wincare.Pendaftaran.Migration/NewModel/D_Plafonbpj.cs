using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Plafonbpj")]
public partial class D_Plafonbpj
{
    [Key]
    [Column("IdBpjs", TypeName = "numeric(18, 0)")]
    public decimal IdBpjs { get; set; }

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

    [Column("Status")]
    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("IdStatus")]
    public int? IdStatus { get; set; }
}
