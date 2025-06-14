﻿

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_TarifHarga")]
public partial class D_TarifHarga
{
    [Key]
    [Column("IdTarifKelas", TypeName = "numeric(18, 0)")]
    public decimal IdTarifKelas { get; set; }

    [Column("KdTarifDetail")]
    [StringLength(10)]
    [Unicode(false)]
    public string KdTarifDetail { get; set; }

    [Column("RekananId", TypeName = "numeric(18, 0)")]
    public decimal? RekananId { get; set; }

    [Column("Kelas")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kelas { get; set; }

    [Column("Harga", TypeName = "decimal(18, 0)")]
    public decimal? Harga { get; set; }

    [Column("Cito", TypeName = "decimal(18, 0)")]
    public decimal? Cito { get; set; }

    [Column("Penyulit", TypeName = "decimal(18, 0)")]
    public decimal? Penyulit { get; set; }

    [Column("Second", TypeName = "decimal(18, 0)")]
    public decimal? Second { get; set; }

    [Column("Adm", TypeName = "decimal(18, 0)")]
    public decimal? Adm { get; set; }

    [Column("Diskon", TypeName = "decimal(18, 0)")]
    public decimal? Diskon { get; set; }

    [Column("BeaPasien", TypeName = "decimal(18, 0)")]
    public decimal? BeaPasien { get; set; }

    [Column("BeaRekanan", TypeName = "decimal(18, 0)")]
    public decimal? BeaRekanan { get; set; }

    [Column("JasaMedis", TypeName = "decimal(18, 0)")]
    public decimal? JasaMedis { get; set; }

    [Column("JasaMedis2", TypeName = "decimal(18, 0)")]
    public decimal? JasaMedis2 { get; set; }

    [Column("JasaMedis3", TypeName = "decimal(18, 0)")]
    public decimal? JasaMedis3 { get; set; }

    [Column("JasaMedis4", TypeName = "decimal(18, 0)")]
    public decimal? JasaMedis4 { get; set; }

    [Column("JasaMedis5", TypeName = "decimal(18, 0)")]
    public decimal? JasaMedis5 { get; set; }

    [Column("Jasars", TypeName = "decimal(18, 0)")]
    public decimal? Jasars { get; set; }

    [Column("BahanAlkes", TypeName = "decimal(18, 0)")]
    public decimal? BahanAlkes { get; set; }

    [Column("TglAwal", TypeName = "datetime")]
    public DateTime? TglAwal { get; set; }

    [Column("TglAkhir", TypeName = "datetime")]
    public DateTime? TglAkhir { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("Aktif")]
    public bool? Aktif { get; set; }

    [Column("LastUpdate", TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }
}
