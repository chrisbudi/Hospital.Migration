﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Wincare.Pendaftaran.Migration.Models;

[PrimaryKey("IdRegistrasi", "DTglmasuk")]
[Table("TT_BETINAP")]
[Index("DTglmasuk", Name = "IX_TT_BETINAP_tglmasuk")]
[Index("VNotmptidur", Name = "IX_TT_BETINAP_v_notmptidur")]
[Index("VRuang", Name = "IX_TT_BETINAP_v_ruang")]
public partial class TtBetinap
{
    [Column("ID_NUM", TypeName = "numeric(18, 0)")]
    public decimal IdNum { get; set; }

    [Key]
    [Column("ID_REGISTRASI")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdRegistrasi { get; set; }

    [Key]
    [Column("D_TGLMASUK", TypeName = "datetime")]
    public DateTime DTglmasuk { get; set; }

    [Column("D_TGLKELUAR", TypeName = "datetime")]
    public DateTime? DTglkeluar { get; set; }

    [Column("V_JAM")]
    [StringLength(5)]
    [Unicode(false)]
    public string VJam { get; set; }

    [Column("V_BAGIAN")]
    [StringLength(15)]
    [Unicode(false)]
    public string VBagian { get; set; }

    [Column("V_RUANG")]
    [StringLength(15)]
    [Unicode(false)]
    public string VRuang { get; set; }

    [Column("V_KELAS")]
    [StringLength(15)]
    [Unicode(false)]
    public string VKelas { get; set; }

    [Required]
    [Column("V_NOTMPTIDUR")]
    [StringLength(6)]
    [Unicode(false)]
    public string VNotmptidur { get; set; }

    [Column("V_KODETARIF")]
    [StringLength(2)]
    [Unicode(false)]
    public string VKodetarif { get; set; }

    [Column("V_KODERUANGAN")]
    [StringLength(5)]
    [Unicode(false)]
    public string VKoderuangan { get; set; }

    [Column("V_NOTE")]
    [StringLength(300)]
    [Unicode(false)]
    public string VNote { get; set; }

    [Column("V_BY")]
    [StringLength(50)]
    [Unicode(false)]
    public string VBy { get; set; }

    [Column("D_DISKON", TypeName = "decimal(18, 0)")]
    public decimal? DDiskon { get; set; }

    [Column("D_HARGA", TypeName = "decimal(18, 0)")]
    public decimal? DHarga { get; set; }

    [Column("D_BEAPASIEN", TypeName = "decimal(18, 0)")]
    public decimal? DBeapasien { get; set; }

    [Column("D_BEAREKANAN", TypeName = "decimal(18, 0)")]
    public decimal? DBearekanan { get; set; }

    [Column("C_TIPEASKES", TypeName = "numeric(18, 0)")]
    public decimal? CTipeaskes { get; set; }

    [Column("C_APPROVE")]
    [StringLength(1)]
    [Unicode(false)]
    public string CApprove { get; set; }

    [Column("V_APPROVE")]
    [StringLength(50)]
    [Unicode(false)]
    public string VApprove { get; set; }

    [Column("D_APPROVE", TypeName = "datetime")]
    public DateTime? DApprove { get; set; }

    [Column("ID_STATUS")]
    public int? IdStatus { get; set; }

    [Column("V_PENANGGUNGJAWAB")]
    [StringLength(50)]
    [Unicode(false)]
    public string VPenanggungjawab { get; set; }

    [ForeignKey("IdRegistrasi")]
    [InverseProperty("TtBetinaps")]
    public virtual TtKunjungan IdRegistrasiNavigation { get; set; }
}