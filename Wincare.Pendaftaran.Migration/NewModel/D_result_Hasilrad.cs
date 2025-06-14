﻿

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_result_Hasilrad")]
[Index("IdPasienRad", Name = "IX_HASILRAD_idpasienrad")]
[Index("IdTrhasilrad", Name = "IX_HASILRAD_idtrhasilrad")]
[Index("KdDokter", Name = "IX_HASILRAD_kddokter")]
[Index("NmDokter", Name = "IX_HASILRAD_nmdokter")]
public partial class D_result_Hasilrad
{
    [Key]
    [Column("IdTrhasilrad", TypeName = "numeric(18, 0)")]
    public decimal IdTrhasilrad { get; set; }

    [Required]
    [Column("IdPasienRad")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdPasienRad { get; set; }

    [Required]
    [Column("KdRad")]
    [StringLength(8)]
    [Unicode(false)]
    public string KdRad { get; set; }

    [Column("NmPemeriksaan")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmPemeriksaan { get; set; }

    [Column("Hasil", TypeName = "text")]
    public string Hasil { get; set; }

    [Column("KdDokter")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdDokter { get; set; }

    [Column("NmDokter")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmDokter { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("Rtf")]
    [MaxLength(50)]
    public byte[] Rtf { get; set; }

    [Column("TglInput", TypeName = "datetime")]
    public DateTime? TglInput { get; set; }

    [Column("IdStatus")]
    public int? IdStatus { get; set; }

    [ForeignKey("IdPasienRad")]
    [InverseProperty("TrHasilrads")]
    public virtual D_Pasienrad IdPasienRadNavigation { get; set; }
}
