﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wincare.Pendaftaran.Migration.NewModel;

[PrimaryKey("IdRegistrasi", "TglMasuk")]
[Table("D_Betinap")]
[Index("TglMasuk", Name = "IX_BETINAP_tglmasuk")]
[Index("NoTmpTidur", Name = "IX_BETINAP_notmptidur")]
[Index("Ruang", Name = "IX_BETINAP_ruang")]
public partial class D_Betinap
{
    [Column("IdNum", TypeName = "numeric(18, 0)")]
    public decimal IdNum { get; set; }

    [Key]
    [Column("IdRegistrasi")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdRegistrasi { get; set; }

    [Key]
    [Column("TglMasuk", TypeName = "datetime")]
    public DateTime TglMasuk { get; set; }

    [Column("TglKeluar", TypeName = "datetime")]
    public DateTime? TglKeluar { get; set; }

    [Column("Jam")]
    [StringLength(5)]
    [Unicode(false)]
    public string Jam { get; set; }

    [Column("Bagian")]
    [StringLength(15)]
    [Unicode(false)]
    public string Bagian { get; set; }

    [Column("Ruang")]
    [StringLength(15)]
    [Unicode(false)]
    public string Ruang { get; set; }

    [Column("Kelas")]
    [StringLength(15)]
    [Unicode(false)]
    public string Kelas { get; set; }

    [Required]
    [Column("NoTmpTidur")]
    [StringLength(6)]
    [Unicode(false)]
    public string NoTmpTidur { get; set; }

    [Column("KodeTarif")]
    [StringLength(2)]
    [Unicode(false)]
    public string KodeTarif { get; set; }

    [Column("KodeRuangan")]
    [StringLength(5)]
    [Unicode(false)]
    public string KodeRuangan { get; set; }

    [Column("Note")]
    [StringLength(300)]
    [Unicode(false)]
    public string Note { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("Diskon", TypeName = "decimal(18, 0)")]
    public decimal? Diskon { get; set; }

    [Column("Harga", TypeName = "decimal(18, 0)")]
    public decimal? Harga { get; set; }

    [Column("BeaPasien", TypeName = "decimal(18, 0)")]
    public decimal? BeaPasien { get; set; }

    [Column("BeaRekanan", TypeName = "decimal(18, 0)")]
    public decimal? BeaRekanan { get; set; }

    [Column("TipeAskes", TypeName = "numeric(18, 0)")]
    public decimal? TipeAskes { get; set; }
    // DISINI APPROVE
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
    public virtual D_Kunjungan IdRegistrasiNavigation { get; set; }
}
