﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Kuitansialke")]
[Index("IdNumAlkes", Name = "IX_KUITANSIALKES")]
[Index("Tgl", Name = "IX_KUITANSIALKES_tgl")]
public partial class D_Kuitansialke
{
    [Column("IdNumAlkes", TypeName = "numeric(18, 0)")]
    public decimal IdNumAlkes { get; set; }

    [Key]
    [Column("IdKuitansiAlkes")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdKuitansiAlkes { get; set; }

    [Column("IdRegistrasi")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdRegistrasi { get; set; }

    [Column("KdDokter")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdDokter { get; set; }

    [Column("NmDokter")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmDokter { get; set; }

    [Column("Tgl", TypeName = "datetime")]
    public DateTime? Tgl { get; set; }

    [Column("KodeTarif")]
    [StringLength(2)]
    [Unicode(false)]
    public string KodeTarif { get; set; }

    [Column("KodeRuangan")]
    [StringLength(5)]
    [Unicode(false)]
    public string KodeRuangan { get; set; }

    [Column("Status")]
    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("KodeInventory")]
    [StringLength(2)]
    [Unicode(false)]
    public string KodeInventory { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }
    // DISINI APPROVE
    [Column("C_APPROVE")]
    [StringLength(1)]
    [Unicode(false)]
    public string CApprove { get; set; }

    [Column("D_APPROVE", TypeName = "datetime")]
    public DateTime? DApprove { get; set; }

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

    [Column("ID_STATUS")]
    public int? IdStatus { get; set; }

    [ForeignKey("VKodeinventory")]
    [InverseProperty("TtKuitansialkes")]
    public virtual D_Gudang VKodeinventoryNavigation { get; set; }

    [ForeignKey("VKoderuangan")]
    [InverseProperty("TtKuitansialkes")]
    public virtual D_Ruang VKoderuanganNavigation { get; set; }
}
