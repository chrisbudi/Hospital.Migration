﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_result_Itempaket")] //TrItempaket
public partial class D_result_Itempaket
{
    [Key]
    [Column("IdDetailPaket", TypeName = "numeric(18, 0)")]
    public decimal IdDetailPaket { get; set; }

    [Column("IdPaket", TypeName = "numeric(18, 0)")]
    public decimal? IdPaket { get; set; }

    [Column("NomorPaket")]
    [StringLength(12)]
    [Unicode(false)]
    public string NomorPaket { get; set; }

    [Column("IdMasterPemeriksaanPenunjang", TypeName = "numeric(18, 0)")]
    public decimal? IdMasterPemeriksaanPenunjang { get; set; }

    [Column("IdPenunjangDetail", TypeName = "numeric(18, 0)")]
    public decimal? IdPenunjangDetail { get; set; }

    [Column("KdDetail")]
    [StringLength(10)]
    [Unicode(false)]
    public string KdDetail { get; set; }

    [Column("NmDetail")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmDetail { get; set; }

    [Column("Group")]
    [StringLength(100)]
    [Unicode(false)]
    public string Group { get; set; }

    [Column("Tipe")]
    [StringLength(50)]
    [Unicode(false)]
    public string Tipe { get; set; }

    [Column("KdDokter")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdDokter { get; set; }

    [Column("NmDokter")]
    [StringLength(50)]
    [Unicode(false)]
    public string NmDokter { get; set; }

    [Column("Jumlah", TypeName = "decimal(18, 0)")]
    public decimal? Jumlah { get; set; }

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

    [Column("SubTotal", TypeName = "decimal(18, 0)")]
    public decimal? SubTotal { get; set; }

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

    [Column("KodeTarif")]
    [StringLength(10)]
    [Unicode(false)]
    public string KodeTarif { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("Approve")]
    [StringLength(1)]
    [Unicode(false)]
    public string Approve { get; set; }

    [Column("DateApprove", TypeName = "datetime")]
    public DateTime? DateApprove { get; set; }
    //DISINI APPROVE
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

    [Column("IdStatus")]
    public int? IdStatus { get; set; }

    [ForeignKey("IdPaket")]
    [InverseProperty("TrItempakets")]
    public virtual D_Paket IdPaketNavigation { get; set; }
}
