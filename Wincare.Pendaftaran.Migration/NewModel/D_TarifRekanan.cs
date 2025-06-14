﻿

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_TarifRekanan")]
public partial class D_TarifRekanan
{
    [Key]
    [Column("IdTarifRekanan", TypeName = "numeric(18, 0)")]
    public decimal IdTarifRekanan { get; set; }

    [Required]
    [Column("KdTarifDetail")]
    [StringLength(10)]
    [Unicode(false)]
    public string KdTarifDetail { get; set; }

    [Column("RekananId", TypeName = "numeric(18, 0)")]
    public decimal RekananId { get; set; }

    [Column("Aktif")]
    public bool? Aktif { get; set; }
}
