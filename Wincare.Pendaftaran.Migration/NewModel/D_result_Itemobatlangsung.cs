﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_result_Itemobatlangsung")] //TrItemobatlangsung
public partial class D_result_Itemobatlangsung
{
    [Key]
    [Column("IdItemObatLangsung", TypeName = "numeric(18, 0)")]
    public decimal IdItemObatLangsung { get; set; }

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

    [Column("Harga", TypeName = "decimal(18, 0)")]
    public decimal? Harga { get; set; }

    [Column("Jumlah", TypeName = "decimal(18, 0)")]
    public decimal? Jumlah { get; set; }

    [Column("Diskon", TypeName = "decimal(18, 0)")]
    public decimal? Diskon { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }
    //DISINI APPROVE
    [Column("C_APPROVE")]
    [StringLength(1)]
    [Unicode(false)]
    public string CApprove { get; set; }

    [Column("D_APPROVE", TypeName = "datetime")]
    public DateTime? DApprove { get; set; }

    [Column("V_APPROVE")]
    [StringLength(50)]
    [Unicode(false)]
    public string VApprove { get; set; }

    [Column("C_APPROVE_VER")]
    [StringLength(1)]
    [Unicode(false)]
    public string CApproveVer { get; set; }

    [Column("D_APPROVE_VER", TypeName = "datetime")]
    public DateTime? DApproveVer { get; set; }

    [Column("V_NOTEOBAT")]
    [StringLength(50)]
    [Unicode(false)]
    public string VNoteobat { get; set; }

    [Column("ID_STATUS")]
    public int? IdStatus { get; set; }

    [Column("V_APPROVE_VER")]
    [StringLength(50)]
    [Unicode(false)]
    public string VApproveVer { get; set; }

    [ForeignKey("VNokuitansi")]
    [InverseProperty("TrItemobatlangsungs")]
    public virtual D_Obatlangsung VNokuitansiNavigation { get; set; }
}
