﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Wincare.Pelayanan.Migration.Models;

[Table("TM_HARGABARANG")]
[Index("Barangid", Name = "IX_TM_HARGABARANG_barangid")]
[Index("Diskonoff", Name = "IX_TM_HARGABARANG_diskonoff")]
[Index("Diskonon", Name = "IX_TM_HARGABARANG_diskonon")]
[Index("Harga", Name = "IX_TM_HARGABARANG_harga")]
[Index("IsAktif", Name = "IX_TM_HARGABARANG_isaktif")]
[Index("Lastupdate", Name = "IX_TM_HARGABARANG_lastupdate")]
[Index("Ppn", Name = "IX_TM_HARGABARANG_ppn")]
[Index("Supplierid", Name = "IX_TM_HARGABARANG_supplierid")]
public partial class TmHargabarang
{
    [Key]
    [Column("IDHARGABELI", TypeName = "numeric(18, 0)")]
    public decimal Idhargabeli { get; set; }

    [Column("BARANGID", TypeName = "numeric(18, 0)")]
    public decimal? Barangid { get; set; }

    [Column("SUPPLIERID", TypeName = "numeric(18, 0)")]
    public decimal? Supplierid { get; set; }

    [Column("LASTUPDATE", TypeName = "datetime")]
    public DateTime? Lastupdate { get; set; }

    [Column("HARGA", TypeName = "decimal(18, 0)")]
    public decimal? Harga { get; set; }

    [Column("INPUTBY")]
    [StringLength(50)]
    [Unicode(false)]
    public string Inputby { get; set; }

    [Column("DISKONON", TypeName = "decimal(18, 2)")]
    public decimal? Diskonon { get; set; }

    [Column("DISKONOFF", TypeName = "decimal(18, 2)")]
    public decimal? Diskonoff { get; set; }

    [Column("PPN", TypeName = "decimal(18, 0)")]
    public decimal? Ppn { get; set; }

    [Column("IS_AKTIF")]
    public bool? IsAktif { get; set; }
}