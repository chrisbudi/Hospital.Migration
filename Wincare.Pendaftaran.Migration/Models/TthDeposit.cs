﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Wincare.Pendaftaran.Migration.Models;

[Table("TTH_DEPOSIT")]
public partial class TthDeposit
{
    [Key]
    [Column("IDDEPOSIT", TypeName = "numeric(18, 0)")]
    public decimal Iddeposit { get; set; }

    [Column("IDKUNJUNGAN", TypeName = "numeric(18, 0)")]
    public decimal? Idkunjungan { get; set; }

    [Column("TGLDEPOSIT", TypeName = "datetime")]
    public DateTime? Tgldeposit { get; set; }

    [Column("TUNAI", TypeName = "decimal(18, 0)")]
    public decimal? Tunai { get; set; }

    [Column("KREDIT", TypeName = "decimal(18, 0)")]
    public decimal? Kredit { get; set; }

    [Column("NAMAKK")]
    [StringLength(50)]
    [Unicode(false)]
    public string Namakk { get; set; }

    [Column("JENISKK")]
    [StringLength(50)]
    [Unicode(false)]
    public string Jeniskk { get; set; }

    [Column("NAMABANKKREDIT")]
    [StringLength(50)]
    [Unicode(false)]
    public string Namabankkredit { get; set; }

    [Column("NOBATCH")]
    [StringLength(50)]
    [Unicode(false)]
    public string Nobatch { get; set; }

    [Column("NOMESIN")]
    [StringLength(50)]
    [Unicode(false)]
    public string Nomesin { get; set; }

    [Column("CHARGEKREDIT", TypeName = "decimal(18, 0)")]
    public decimal? Chargekredit { get; set; }

    [Column("TRANSFER", TypeName = "decimal(18, 0)")]
    public decimal? Transfer { get; set; }

    [Column("NOMORTRANSFER")]
    [StringLength(50)]
    [Unicode(false)]
    public string Nomortransfer { get; set; }

    [Column("NAMABANKTRANSFER")]
    [StringLength(50)]
    [Unicode(false)]
    public string Namabanktransfer { get; set; }

    [Column("REKASAL")]
    [StringLength(50)]
    [Unicode(false)]
    public string Rekasal { get; set; }

    [Column("VBY")]
    [StringLength(50)]
    [Unicode(false)]
    public string Vby { get; set; }

    [Column("ID_STATUS")]
    public int? IdStatus { get; set; }

    [Column("V_NOTE")]
    [StringLength(50)]
    [Unicode(false)]
    public string VNote { get; set; }

    [ForeignKey("Idkunjungan")]
    [InverseProperty("TthDeposits")]
    public virtual TthKunjungan IdkunjunganNavigation { get; set; }
}