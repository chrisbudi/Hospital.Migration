﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Wincare.Pelayanan.Migration.NewModels;

[Table("L_PaketDetail")]
public partial class L_Paketdetail
{
     [Key]
    [Column("IdPaketdetail", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdPaketdetail { get; set; }

    [Column("KdPaketDetail")]
    [StringLength(50)]
    [Unicode(false)]
    public string KdPaketDetail { get; set; }

    [Column("NmPaketDetail")]
    [StringLength(50)]
    [Unicode(false)]
    public string NmPaketDetail { get; set; }

    [Column("Group")]
    [StringLength(50)]
    [Unicode(false)]
    public string Group { get; set; }

    [Column("Tipe")]
    [StringLength(50)]
    [Unicode(false)]
    public string VTipe { get; set; }

    [Column("Harga", TypeName = "decimal(18, 0)")]
    public decimal? Harga { get; set; }

    [Column("Rekanan")]
    [StringLength(50)]
    [Unicode(false)]
    public string Rekanan { get; set; }
}