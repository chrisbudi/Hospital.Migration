

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Obatalke")]
[Index("IdAlkes", Name = "IX_OBATALKES")]
[Index("IdKuitansiAlkes", Name = "IX_OBATALKES_1")]
[Index("Jml", Name = "IX_OBATALKES_2")]
public partial class D_Obatalke
{
    [Key]
    [Column("IdAlkes", TypeName = "numeric(18, 0)")]
    public decimal IdAlkes { get; set; }

    [Column("IdObatalkes")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdObatalkes { get; set; }

    [Column("IdKuitansiAlkes")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdKuitansiAlkes { get; set; }

    [Column("IdBarang", TypeName = "numeric(18, 0)")]
    public decimal? IdBarang { get; set; }

    [Column("KdObatAlkes")]
    [StringLength(10)]
    [Unicode(false)]
    public string KdObatAlkes { get; set; }

    [Column("NmObatAlkes")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmObatAlkes { get; set; }

    [Column("Harga", TypeName = "decimal(18, 0)")]
    public decimal? Harga { get; set; }

    [Column("Jml", TypeName = "decimal(18, 0)")]
    public decimal? Jml { get; set; }

    [Column("Note")]
    [StringLength(255)]
    [Unicode(false)]
    public string Note { get; set; }

    [Column("Diskon", TypeName = "decimal(18, 0)")]
    public decimal? Diskon { get; set; }

    [Column("RekananId", TypeName = "numeric(18, 0)")]
    public decimal? RekananId { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }
// DISINI APPROVE
    [Column("C_APPROVE")]
    [StringLength(1)]
    [Unicode(false)]
    public string CApprove { get; set; }

    [Column("D_APPROVE", TypeName = "datetime")]
    public DateTime? DApprove { get; set; }

    [Column("V_APPROVE_VER")]
    [StringLength(50)]
    [Unicode(false)]
    public string VApproveVer { get; set; }

    [Column("C_APPROVE_VER")]
    [StringLength(1)]
    [Unicode(false)]
    public string CApproveVer { get; set; }

    [Column("D_APPROVE_VER", TypeName = "datetime")]
    public DateTime? DApproveVer { get; set; }

    [Column("ID_STATUS")]
    public int? IdStatus { get; set; }
}
