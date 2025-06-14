﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Wincare.Pelayanan.Migration.NewModels;

[Table("L_LisHasil")]
public partial class L_LisHasil
{
    [Key]
    [Column("idn", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Idn { get; set; }
    
    [Column("OldIdn", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal Idn { get; set; }

    [Required]
    [Column("IdPasienlab")]
    [StringLength(15)]
    [Unicode(false)]
    public string IdPasienlab { get; set; }

    [Column("NoUrut")]
    public int? NoUrut { get; set; }

    [Column("KodeTest")]
    [StringLength(8)]
    [Unicode(false)]
    public string KodeTest { get; set; }

    [Column("NmTest")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmTest { get; set; }

    [Column("hasil")]
    [StringLength(100)]
    [Unicode(false)]
    public string Hasil { get; set; }

    [Column("unit")]
    [StringLength(15)]
    [Unicode(false)]
    public string Unit { get; set; }

    [Column("normal")]
    [StringLength(80)]
    [Unicode(false)]
    public string Normal { get; set; }

    [Column("flag")]
    [StringLength(2)]
    [Unicode(false)]
    public string Flag { get; set; }

    [Column("type")]
    [StringLength(2)]
    [Unicode(false)]
    public string Type { get; set; }
    
}