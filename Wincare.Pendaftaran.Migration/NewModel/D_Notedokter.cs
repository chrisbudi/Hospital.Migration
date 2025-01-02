

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Notedokter")]
public partial class D_Notedokter
{
    [Key]
    [Column("IdNoteDokter", TypeName = "numeric(18, 0)")]
    public decimal IdNoteDokter { get; set; }

    [Required]
    [Column("KdDokter")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdDokter { get; set; }

    [Column("KETERANKeteranganGAN")]
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
