﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Wincare.Pelayanan.Migration.NewModels;

[Table("L_RitemObatLangsung")]
public partial class L_RitemObatLangsung
{
    [Key]
    [Column("IdItemObatLangsung")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid IdItemobatlangsung { get; set; }

    [Column("OldIdItemObatLangsung", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal OldIdItemobatlangsung { get; set; }

    [Column("NoKuitansi")]
    [StringLength(10)]
    [Unicode(false)]
    public string NoKuitansi { get; set; }

    [Column("KdObat")]
    [StringLength(10)]
    [Unicode(false)]
    public string KdObat { get; set; }

    [Column("IdBarang", TypeName = "numeric(18, 0)")]
    public decimal? IdBarang { get; set; }

    [Column("NoItem")]
    [StringLength(6)]
    [Unicode(false)]
    public string NoItem { get; set; }

    [Column("NmObat")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmObat { get; set; }

    [Column("DHarga", TypeName = "decimal(18, 0)")]
    public decimal? DHarga { get; set; }

    [Column("DJumlah", TypeName = "decimal(18, 0)")]
    public decimal? DJumlah { get; set; }

    [Column("DDiskon", TypeName = "decimal(18, 0)")]
    public decimal? DDiskon { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("CApprove")]
    [StringLength(1)]
    [Unicode(false)]
    public string CApprove { get; set; }

    [Column("DApprove", TypeName = "datetime")]
    public DateTime? DApprove { get; set; }

    [Column("VApprove")]
    [StringLength(50)]
    [Unicode(false)]
    public string VApprove { get; set; }

    [Column("CApproveVer")]
    [StringLength(1)]
    [Unicode(false)]
    public string CApproveVer { get; set; }

    [Column("DApproveVer", TypeName = "datetime")]
    public DateTime? DApproveVer { get; set; }

    [Column("VNoteObat")]
    [StringLength(50)]
    [Unicode(false)]
    public string VNoteobat { get; set; }

    [Column("IdStatus")]
    public int? IdStatus { get; set; }

    [Column("VApproveVer")]
    [StringLength(50)]
    [Unicode(false)]
    public string VApproveVer { get; set; }

    [ForeignKey("IdStatus")]
    [InverseProperty("L_RItemobatlangsungs")]
    public virtual L_Status IdStatusNavigation { get; set; }

    [ForeignKey("Nokuitansi")]
    [InverseProperty("L_RItemobatlangsungs")]
    public virtual TtObatlangsung NokuitansiNavigation { get; set; }
}