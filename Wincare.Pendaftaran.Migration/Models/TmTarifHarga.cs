﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Wincare.Pendaftaran.Migration.Models;

[Table("TM_TARIF_HARGA")]
public partial class TmTarifHarga
{
    [Key]
    [Column("ID_TARIFKELAS", TypeName = "numeric(18, 0)")]
    public decimal IdTarifkelas { get; set; }

    [Column("V_KDTARIFDETAIL")]
    [StringLength(10)]
    [Unicode(false)]
    public string VKdtarifdetail { get; set; }

    [Column("REKANANID", TypeName = "numeric(18, 0)")]
    public decimal? Rekananid { get; set; }

    [Column("V_KELAS")]
    [StringLength(50)]
    [Unicode(false)]
    public string VKelas { get; set; }

    [Column("D_HARGA", TypeName = "decimal(18, 0)")]
    public decimal? DHarga { get; set; }

    [Column("D_CITO", TypeName = "decimal(18, 0)")]
    public decimal? DCito { get; set; }

    [Column("D_PENYULIT", TypeName = "decimal(18, 0)")]
    public decimal? DPenyulit { get; set; }

    [Column("D_2TND", TypeName = "decimal(18, 0)")]
    public decimal? D2tnd { get; set; }

    [Column("D_ADM", TypeName = "decimal(18, 0)")]
    public decimal? DAdm { get; set; }

    [Column("D_DISKON", TypeName = "decimal(18, 0)")]
    public decimal? DDiskon { get; set; }

    [Column("D_BEAPASIEN", TypeName = "decimal(18, 0)")]
    public decimal? DBeapasien { get; set; }

    [Column("D_BEAREKANAN", TypeName = "decimal(18, 0)")]
    public decimal? DBearekanan { get; set; }

    [Column("D_JASAMEDIS", TypeName = "decimal(18, 0)")]
    public decimal? DJasamedis { get; set; }

    [Column("D_JASAMEDIS2", TypeName = "decimal(18, 0)")]
    public decimal? DJasamedis2 { get; set; }

    [Column("D_JASAMEDIS3", TypeName = "decimal(18, 0)")]
    public decimal? DJasamedis3 { get; set; }

    [Column("D_JASAMEDIS4", TypeName = "decimal(18, 0)")]
    public decimal? DJasamedis4 { get; set; }

    [Column("D_JASAMEDIS5", TypeName = "decimal(18, 0)")]
    public decimal? DJasamedis5 { get; set; }

    [Column("D_JASARS", TypeName = "decimal(18, 0)")]
    public decimal? DJasars { get; set; }

    [Column("D_BAHANALKES", TypeName = "decimal(18, 0)")]
    public decimal? DBahanalkes { get; set; }

    [Column("D_TGLAWAL", TypeName = "datetime")]
    public DateTime? DTglawal { get; set; }

    [Column("D_TGLAKHIR", TypeName = "datetime")]
    public DateTime? DTglakhir { get; set; }

    [Column("V_BY")]
    [StringLength(50)]
    [Unicode(false)]
    public string VBy { get; set; }

    [Column("IS_AKTIF")]
    public bool? IsAktif { get; set; }

    [Column("D_LASTUPDATE", TypeName = "datetime")]
    public DateTime? DLastupdate { get; set; }
}