﻿

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_SettingAdm")]
public partial class D_SettingAdm
{
    [Key]
    [Column("IdNumAdm", TypeName = "numeric(18, 0)")]
    public decimal IdNumAdm { get; set; }

    [Column("RekananId", TypeName = "numeric(18, 0)")]
    public decimal? RekananId { get; set; }

    [Column("Kategori")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kategori { get; set; }

    [Column("Biaya", TypeName = "decimal(18, 0)")]
    public decimal? Biaya { get; set; }

    [Column("Percent", TypeName = "decimal(18, 2)")]
    public decimal? Percent { get; set; }
}
