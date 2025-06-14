﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Wincare.Pelayanan.Migration.Models;

[Table("TT_PAKET_PB_RETUR")]
public partial class TtPaketPbRetur
{
    [Key]
    [Column("ID_PAKETPB_RETUR", TypeName = "numeric(18, 0)")]
    public decimal IdPaketpbRetur { get; set; }

    [Column("D_TGLRETUR", TypeName = "datetime")]
    public DateTime? DTglretur { get; set; }

    [Column("ID_PAKETPB_PAKAI", TypeName = "numeric(18, 0)")]
    public decimal IdPaketpbPakai { get; set; }

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

    [Column("ID_REGISTRASI")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdRegistrasi { get; set; }

    [Column("ID_REKANAN", TypeName = "numeric(18, 0)")]
    public decimal? IdRekanan { get; set; }

    [Column("V_BY")]
    [StringLength(50)]
    [Unicode(false)]
    public string VBy { get; set; }

    [Column("ID_STATUS")]
    public int? IdStatus { get; set; }

    [ForeignKey("IdPaketpb")]
    [InverseProperty("TtPaketPbReturs")]
    public virtual TtPaketPb IdPaketpbNavigation { get; set; }

    [ForeignKey("IdPaketpbPakai")]
    [InverseProperty("TtPaketPbReturs")]
    public virtual TtPaketPbPakai IdPaketpbPakaiNavigation { get; set; }

    [ForeignKey("IdRekanan")]
    [InverseProperty("TtPaketPbReturs")]
    public virtual TmRekanan IdRekananNavigation { get; set; }

    [InverseProperty("IdPaketpbReturNavigation")]
    public virtual ICollection<TtPaketPbReturDetail> TtPaketPbReturDetails { get; set; } = new List<TtPaketPbReturDetail>();

    [ForeignKey("VKodetarif")]
    [InverseProperty("TtPaketPbReturVKodetarifNavigations")]
    public virtual TmGudang VKodetarifNavigation { get; set; }

    [ForeignKey("VKodetarifgdg")]
    [InverseProperty("TtPaketPbReturVKodetarifgdgNavigations")]
    public virtual TmGudang VKodetarifgdgNavigation { get; set; }
}