﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Wincare.Pendaftaran.Migration.Models;

[Table("TTH_TRANSAKSI")]
public partial class TthTransaksi
{
    [Key]
    [Column("IDTRANSAKSI", TypeName = "numeric(18, 0)")]
    public decimal Idtransaksi { get; set; }

    [Column("IDKUNJUNGAN", TypeName = "numeric(18, 0)")]
    public decimal? Idkunjungan { get; set; }

    [Column("TGLTRANSAKSI", TypeName = "datetime")]
    public DateTime? Tgltransaksi { get; set; }

    [Column("V_GROUP")]
    [StringLength(100)]
    [Unicode(false)]
    public string VGroup { get; set; }

    [Column("NAMATRANSAKSI")]
    [StringLength(100)]
    [Unicode(false)]
    public string Namatransaksi { get; set; }

    [Column("HARGA", TypeName = "decimal(18, 0)")]
    public decimal? Harga { get; set; }

    [Column("JUMLAH", TypeName = "decimal(18, 0)")]
    public decimal? Jumlah { get; set; }

    [Column("DISKON", TypeName = "decimal(18, 0)")]
    public decimal? Diskon { get; set; }

    [Column("SUBTOTAL", TypeName = "decimal(18, 0)")]
    public decimal? Subtotal { get; set; }

    [Column("BEAPASIEN", TypeName = "decimal(18, 0)")]
    public decimal? Beapasien { get; set; }

    [Column("BEAREKANAN", TypeName = "decimal(18, 0)")]
    public decimal? Bearekanan { get; set; }

    [Column("VBY")]
    [StringLength(50)]
    [Unicode(false)]
    public string Vby { get; set; }

    [Column("ID_STATUS")]
    public int? IdStatus { get; set; }

    [ForeignKey("Idkunjungan")]
    [InverseProperty("TthTransaksis")]
    public virtual TthKunjungan IdkunjunganNavigation { get; set; }
}