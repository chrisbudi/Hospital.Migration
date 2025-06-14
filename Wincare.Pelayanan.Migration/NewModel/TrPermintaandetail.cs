﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Wincare.Pelayanan.Migration.NewModels;

[Table("TR_PERMINTAANDETAIL")]
[Index("Barangid", Name = "IX_TR_PERMINTAANDETAIL_brgid")]
[Index("Jumlah", Name = "IX_TR_PERMINTAANDETAIL_jml")]
[Index("Jumlahminta", Name = "IX_TR_PERMINTAANDETAIL_jmlminta")]
[Index("Jumlahpesan", Name = "IX_TR_PERMINTAANDETAIL_jmlpesan")]
[Index("Permintaanid", Name = "IX_TR_PERMINTAANDETAIL_permintaanid")]
public partial class TrPermintaandetail
{
    [Key]
    [Column("PERMINTAANDETAILID", TypeName = "numeric(18, 0)")]
    public decimal Permintaandetailid { get; set; }

    [Column("PERMINTAANID", TypeName = "numeric(18, 0)")]
    public decimal? Permintaanid { get; set; }

    [Column("BARANGID", TypeName = "numeric(18, 0)")]
    public decimal? Barangid { get; set; }

    [Column("JUMLAH", TypeName = "decimal(18, 0)")]
    public decimal? Jumlah { get; set; }

    [Column("JUMLAHMINTA", TypeName = "decimal(18, 0)")]
    public decimal? Jumlahminta { get; set; }

    [Column("STATUS")]
    [StringLength(1)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("JUMLAHPESAN", TypeName = "decimal(18, 0)")]
    public decimal? Jumlahpesan { get; set; }

    [Column("ISPESAN")]
    public bool? Ispesan { get; set; }

    [Column("HARGAAVG", TypeName = "decimal(18, 0)")]
    public decimal? Hargaavg { get; set; }

    [Column("DISCAVG", TypeName = "decimal(18, 0)")]
    public decimal? Discavg { get; set; }

    [Column("SUBTOTALAVG", TypeName = "decimal(18, 0)")]
    public decimal? Subtotalavg { get; set; }

    [Column("INPUTBY")]
    [StringLength(50)]
    [Unicode(false)]
    public string Inputby { get; set; }

    [Column("D_TGLINPUT", TypeName = "datetime")]
    public DateTime? DTglinput { get; set; }

    [Column("V_APPROVE_CC")]
    [StringLength(50)]
    [Unicode(false)]
    public string VApproveCc { get; set; }

    [Column("D_TGL_CC", TypeName = "datetime")]
    public DateTime? DTglCc { get; set; }

    [Column("V_APPROVE_KEU")]
    [StringLength(50)]
    [Unicode(false)]
    public string VApproveKeu { get; set; }

    [Column("D_TGL_KEU", TypeName = "datetime")]
    public DateTime? DTglKeu { get; set; }

    [Column("V_APPROVE_PEM")]
    [StringLength(50)]
    [Unicode(false)]
    public string VApprovePem { get; set; }

    [Column("D_TGL_PEM", TypeName = "datetime")]
    public DateTime? DTglPem { get; set; }

    [Column("ID_STATUS")]
    public int? IdStatus { get; set; }
}