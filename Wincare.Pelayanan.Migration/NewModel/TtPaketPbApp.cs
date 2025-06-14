﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Wincare.Pelayanan.Migration.NewModels;

[Table("TT_PAKET_PB_APP")]
public partial class TtPaketPbApp
{
    [Key]
    [Column("ID_PAKETPB_APP", TypeName = "numeric(18, 0)")]
    public decimal IdPaketpbApp { get; set; }

    [Column("D_TGLAPP", TypeName = "datetime")]
    public DateTime? DTglapp { get; set; }

    [Column("ID_PAKETPB", TypeName = "numeric(18, 0)")]
    public decimal? IdPaketpb { get; set; }

    [Column("V_KODETARIF")]
    [StringLength(2)]
    [Unicode(false)]
    public string VKodetarif { get; set; }

    [Column("V_KODETARIFGDG")]
    [StringLength(2)]
    [Unicode(false)]
    public string VKodetarifgdg { get; set; }

    [Column("V_BYAPP")]
    [StringLength(50)]
    [Unicode(false)]
    public string VByapp { get; set; }

    [Column("ID_STATUS")]
    public int? IdStatus { get; set; }

    [ForeignKey("IdPaketpb")]
    [InverseProperty("TtPaketPbApps")]
    public virtual TtPaketPb IdPaketpbNavigation { get; set; }

    [InverseProperty("IdPaketpbAppNavigation")]
    public virtual ICollection<TtPaketPbAppDetail> TtPaketPbAppDetails { get; set; } = new List<TtPaketPbAppDetail>();

    [ForeignKey("VKodetarif")]
    [InverseProperty("TtPaketPbAppVKodetarifNavigations")]
    public virtual TmGudang VKodetarifNavigation { get; set; }

    [ForeignKey("VKodetarifgdg")]
    [InverseProperty("TtPaketPbAppVKodetarifgdgNavigations")]
    public virtual TmGudang VKodetarifgdgNavigation { get; set; }
}