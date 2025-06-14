﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Wincare.Pelayanan.Migration.Models;

[Table("TM_DIAGNOSA")]
[Index("VNmdiagnosa", Name = "IX_TM_DIAGNOSA_NMDIAG")]
[Index("VKddiagnosa", Name = "IX_TM_DIAGNOSA_VKDDIAG")]
public partial class TmDiagnosa
{
    [Column("ID_DIAGNOSA", TypeName = "numeric(18, 0)")]
    public decimal IdDiagnosa { get; set; }

    [Key]
    [Column("V_KDDIAGNOSA")]
    [StringLength(8)]
    [Unicode(false)]
    public string VKddiagnosa { get; set; }

    [Column("V_NMDIAGNOSA")]
    [StringLength(300)]
    [Unicode(false)]
    public string VNmdiagnosa { get; set; }

    [Column("C_ISPENYAKIT")]
    public bool? CIspenyakit { get; set; }

    [Column("V_KDDTD")]
    [StringLength(8)]
    [Unicode(false)]
    public string VKddtd { get; set; }

    [Column("IS_AKTIF")]
    public bool? IsAktif { get; set; }

    [InverseProperty("VKddiagnosaNavigation")]
    public virtual ICollection<TmMorfologi> TmMorfologis { get; set; } = new List<TmMorfologi>();
}