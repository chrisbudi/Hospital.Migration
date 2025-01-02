

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Wincare.Pendaftaran.Migration.NewModel;

[PrimaryKey("KdTarifDetail", "KodeRuangan")]
[Table("D_TarifMatrix")]
public partial class D_TarifMatrix
{
    [Column("IdTarifMatrix", TypeName = "numeric(18, 0)")]
    public decimal IdTarifMatrix { get; set; }

    [Key]
    [Column("KdTarifDetail")]
    [StringLength(50)]
    [Unicode(false)]
    public string KdTarifDetail { get; set; }

    [Key]
    [Column("KodeRuangan")]
    [StringLength(50)]
    [Unicode(false)]
    public string KodeRuangan { get; set; }

    [Column("Aktif")]
    public bool? Aktif { get; set; }
}
