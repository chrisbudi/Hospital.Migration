

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_PaketPbAppDetail")]
public partial class D_PaketPbAppDetail
{
    [Key]
    [Column("IdPaketpbAppDetail", TypeName = "numeric(18, 0)")]
    public decimal IdPaketpbAppDetail { get; set; }

    [Column("IdPaketpbApp", TypeName = "numeric(18, 0)")]
    public decimal? IdPaketpbApp { get; set; }

    [Column("IdBarang", TypeName = "numeric(18, 0)")]
    public decimal? IdBarang { get; set; }

    [Column("Jml", TypeName = "decimal(18, 2)")]
    public decimal? Jml { get; set; }

    [Column("JmlApp", TypeName = "decimal(18, 2)")]
    public decimal? JmlApp { get; set; }

    [Column("ByApp")]
    [StringLength(50)]
    [Unicode(false)]
    public string ByApp { get; set; }

    [Column("IdStatus")]
    public int? IdStatus { get; set; }
}
