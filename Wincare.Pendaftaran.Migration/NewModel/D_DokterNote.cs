

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_DokterNote")]
public partial class D_DokterNote
{
    [Key]
    [Column("IdDokter", TypeName = "numeric(18, 0)")]
    public decimal IdDokter { get; set; }

    [Required]
    [Column("KdDokter")]
    [StringLength(6)]
    [Unicode(false)]
    public string Kddokter { get; set; }

    [Column("Keterangan")]
    [StringLength(100)]
    [Unicode(false)]
    public string Keterangan { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("TglInput", TypeName = "datetime")]
    public DateTime? TglInput { get; set; }
}
