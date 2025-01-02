

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Liburdokter")]
public partial class D_Liburdokter
{
    [Key]
    [Column("IdLiburDokter", TypeName = "numeric(18, 0)")]
    public decimal IdLiburDokter { get; set; }

    [Required]
    [Column("KdDokter")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdDokter { get; set; }

    [Column("TglAwal", TypeName = "datetime")]
    public DateTime? TglAwal { get; set; }

    [Column("TglAkhir", TypeName = "datetime")]
    public DateTime? TglAkhir { get; set; }

    [Column("Keterangan")]
    [StringLength(500)]
    [Unicode(false)]
    public string Keterangan { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("TglInput", TypeName = "datetime")]
    public DateTime? TglInput { get; set; }
}
