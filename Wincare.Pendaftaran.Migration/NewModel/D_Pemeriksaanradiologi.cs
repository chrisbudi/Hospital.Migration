﻿

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Pemeriksaanradiologi")]
[Index("IdNumPasienRad", Name = "IX_PEMERIKSAANRADIOLOGI_idnum")]
[Index("IdPasienRad", Name = "IX_PEMERIKSAANRADIOLOGI_idpasienrad")]
[Index("Kelompok", Name = "IX_PEMERIKSAANRADIOLOGI_kelompok")]
[Index("NmPemeriksaanRad", Name = "IX_PEMERIKSAANRADIOLOGI_nmpemeriksaan")]
[Index("KdRad", Name = "IX_PEMERIKSAANRADIOLOGI_vkdrad")]
[Index("Kelas", Name = "IX_PEMERIKSAANRADIOLOGI_vkelas")]
public partial class D_Pemeriksaanradiologi
{
    [Key]
    [Column("IdNumPasienrad", TypeName = "numeric(18, 0)")]
    public decimal IdNumPasienrad { get; set; }

    [Required]
    [Column("IdPasienRad")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdPasienRad { get; set; }

    [Required]
    [Column("KdRad")]
    [StringLength(8)]
    [Unicode(false)]
    public string KdRad { get; set; }

    [Column("NmPemeriksaanRad")]
    [StringLength(200)]
    [Unicode(false)]
    public string NmPemeriksaanRad { get; set; }

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

    [Column("Subtotal", TypeName = "decimal(18, 0)")]
    public decimal? Subtotal { get; set; }

    [Column("BeaPasien", TypeName = "decimal(18, 0)")]
    public decimal? BeaPasien { get; set; }

    [Column("BeaRekanan", TypeName = "decimal(18, 0)")]
    public decimal? BeaRekanan { get; set; }

    [Column("JasaBaca", TypeName = "decimal(18, 0)")]
    public decimal? JasaBaca { get; set; }

    [Column("JasaPengirim", TypeName = "decimal(18, 0)")]
    public decimal? JasaPengirim { get; set; }

    [Column("Jasars", TypeName = "decimal(18, 0)")]
    public decimal? Jasars { get; set; }

    [Column("BahanAlkes", TypeName = "decimal(18, 0)")]
    public decimal? BahanAlkes { get; set; }

    [Column("Kelompok")]
    [StringLength(100)]
    [Unicode(false)]
    public string Kelompok { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }
// DISINI APPROVE
    [Column("V_APPROVE")]
    [StringLength(50)]
    [Unicode(false)]
    public string VApprove { get; set; }

    [Column("C_APPROVE")]
    [StringLength(1)]
    [Unicode(false)]
    public string CApprove { get; set; }

    [Column("D_APPROVE", TypeName = "datetime")]
    public DateTime? DApprove { get; set; }

    [Column("V_APPROVE_ANA")]
    [StringLength(50)]
    [Unicode(false)]
    public string VApproveAna { get; set; }

    [Column("C_APPROVE_ANA")]
    [StringLength(1)]
    [Unicode(false)]
    public string CApproveAna { get; set; }

    [Column("D_APPROVE_ANA", TypeName = "datetime")]
    public DateTime? DApproveAna { get; set; }

    [Column("V_APPROVE_VER")]
    [StringLength(50)]
    [Unicode(false)]
    public string VApproveVer { get; set; }

    [Column("C_APPROVE_VER")]
    [StringLength(1)]
    [Unicode(false)]
    public string CApproveVer { get; set; }

    [Column("D_APPROVE_VER", TypeName = "datetime")]
    public DateTime? DApproveVer { get; set; }

    [Column("V_KELAS")]
    [StringLength(50)]
    [Unicode(false)]
    public string VKelas { get; set; }

    [Column("ID_STATUS")]
    public int? IdStatus { get; set; }
}
