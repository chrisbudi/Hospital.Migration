﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Wincare.Pelayanan.Migration.Models;

[Table("TT_KUITANSIUDD")]
public partial class TtKuitansiudd
{
    [Key]
    [Column("ID_KUITANSIUDD", TypeName = "numeric(18, 0)")]
    public decimal IdKuitansiudd { get; set; }

    [Column("ID_REGISTRASI")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdRegistrasi { get; set; }

    [Column("V_KDDOKTER")]
    [StringLength(6)]
    [Unicode(false)]
    public string VKddokter { get; set; }

    [Column("V_NMDOKTER")]
    [StringLength(100)]
    [Unicode(false)]
    public string VNmdokter { get; set; }

    [Column("D_TGL", TypeName = "datetime")]
    public DateTime? DTgl { get; set; }

    [Column("V_KODETARIF")]
    [StringLength(50)]
    [Unicode(false)]
    public string VKodetarif { get; set; }

    [Column("V_KODERUANGAN")]
    [StringLength(5)]
    [Unicode(false)]
    public string VKoderuangan { get; set; }

    [Column("V_NOREQUEST")]
    [StringLength(50)]
    [Unicode(false)]
    public string VNorequest { get; set; }

    [Column("C_STATUS")]
    public bool? CStatus { get; set; }

    [Column("V_BY")]
    [StringLength(50)]
    [Unicode(false)]
    public string VBy { get; set; }

    [Column("V_KODEREQUESTOBAT")]
    [StringLength(2)]
    [Unicode(false)]
    public string VKoderequestobat { get; set; }

    [InverseProperty("IdKuitansiuddNavigation")]
    public virtual ICollection<TtResepudd> TtResepudds { get; set; } = new List<TtResepudd>();

    [ForeignKey("VKoderuangan")]
    [InverseProperty("TtKuitansiudds")]
    public virtual TmRuang VKoderuanganNavigation { get; set; }
}