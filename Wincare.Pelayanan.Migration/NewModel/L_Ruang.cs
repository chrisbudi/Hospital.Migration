﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Wincare.Pelayanan.Migration.NewModels;

[Table("L_Ruang")]
[Index("Koderuangan", Name = "IX_L_Ruang")]
[Index("Nama", Name = "IX_L_Ruang_1")]
[Index("Kamar", Name = "IX_L_Ruang_2")]
[Index("KodeInventoryGudangObat", Name = "IX_L_Ruang_3")]
[Index("KodeRequestGudangObat", Name = "IX_L_Ruang_4")]
[Index("KodeTarif", Name = "IX_L_Ruang_5")]
[Index("IsAktif", Name = "IX_L_Ruang_6")]
[Index("IdRuang", Name = "IX_L_Ruang_7")]
[Index("KdInhealth", Name = "IX_V_KDINHEALTH")]
[Index("LynInhealth", Name = "IX_V_LYNINHEALTH")]
public partial class L_Ruang
{
    [Key]
    [Column("IdRuang", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdRuang { get; set; }

    [Column("KodeRuangan")]
    [StringLength(5)]
    [Unicode(false)]
    [Required]
    public string Koderuangan { get; set; }

    [Required]
    [Column("Nama")]
    [StringLength(50)]
    [Unicode(false)]
    public string Nama { get; set; }

    [Column("NoRuang")]
    [StringLength(10)]
    [Unicode(false)]
    public string Noruang { get; set; }

    [Column("Kelompok")]
    [StringLength(1)]
    [Unicode(false)]
    public string Kelompok { get; set; }

    [Column("Kamar")]
    [StringLength(10)]
    [Unicode(false)]
    public string Kamar { get; set; }

    [Column("KodeInventory")]
    [StringLength(2)]
    [Unicode(false)]
    public string KodeInventory { get; set; }

    [Column("KodeInventoryGudangObat", TypeName = "numeric(18,0)")]
    public decimal? KodeInventoryGudangObat { get; set; }

    [Column("KodeRequestObat")]
    [StringLength(2)]
    [Unicode(false)]
    public string KodeRequestObat { get; set; }

    [Column("KodeRequestGudangObat", TypeName = "numeric(18,0)")]
    public decimal? KodeRequestGudangObat { get; set; }

    [Column("KodeTarif")]
    [StringLength(2)]
    [Unicode(false)]
    public string KodeTarif { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [Column("IsTarif")]
    public bool? IsTarif { get; set; }

    [Column("GdgPaket")]
    [StringLength(2)]
    [Unicode(false)]
    public string GdgPaket { get; set; }

    [Column("GdgRetur")]
    [StringLength(2)]
    [Unicode(false)]
    public string GdgRetur { get; set; }

    [Column("GdgPenerimaan")]
    [StringLength(2)]
    [Unicode(false)]
    public string GdgPenerimaan { get; set; }

    [Column("KdInhealth")]
    [StringLength(3)]
    [Unicode(false)]
    public string KdInhealth { get; set; }

    [Column("LynInhealth")]
    [StringLength(50)]
    [Unicode(false)]
    public string LynInhealth { get; set; }

    [ForeignKey("KodeRequestGudangObat")]
    [InverseProperty("L_RuangKodeRequestobatNavigations")]
    public virtual L_Gudang KodeRequestobatNavigation { get; set; }

    [InverseProperty("KoderuanganNavigation")]
    public virtual ICollection<L_Jadwaldokter> L_Jadwaldokters { get; set; } = new List<L_Jadwaldokter>();

    [InverseProperty("KoderuanganNavigation")]
    public virtual ICollection<L_Map> M_Maps { get; set; } = new List<L_Map>();

    [InverseProperty("KoderuanganNavigation")]
    public virtual ICollection<L_User> L_Users { get; set; } = new List<L_User>();

    [ForeignKey("KodeInventoryGudangObat")]
    [InverseProperty("L_RuangVKodeinventoryNavigations")]
    public virtual L_Gudang KodeinventoryNavigation { get; set; }
}