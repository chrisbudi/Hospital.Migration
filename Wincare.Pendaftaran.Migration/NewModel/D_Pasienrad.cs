﻿

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Pasienrad")]
[Index("IdRegistrasi", "TglDatang", "KdDokter", "IdPasienrad", "IdNum", "By", "Kelas", "KodeRuangan", "NmDokter", "Unit", "Done", "IdStatus", "Ket", "Urut", Name = "IX_PASIENRAD", IsUnique = true)]
public partial class D_Pasienrad
{
    [Column("IdNum", TypeName = "numeric(18, 0)")]
    public decimal IdNum { get; set; }

    [Required]
    [Column("IdRegistrasi")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdRegistrasi { get; set; }

    [Column("TglDatang", TypeName = "datetime")]
    public DateTime TglDatang { get; set; }

    [Column("Jam")]
    [StringLength(5)]
    [Unicode(false)]
    public string Jam { get; set; }

    [Column("Urut")]
    public int? Urut { get; set; }

    [Column("Done")]
    [StringLength(1)]
    [Unicode(false)]
    public string Done { get; set; }

    [Column("KodeRuangan")]
    [StringLength(5)]
    [Unicode(false)]
    public string KodeRuangan { get; set; }

    [Column("Unit")]
    [StringLength(50)]
    [Unicode(false)]
    public string Unit { get; set; }

    [Required]
    [Column("KdDokter")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdDokter { get; set; }

    [Column("NmDokter")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmDokter { get; set; }

    [Column("Ket")]
    [StringLength(6)]
    [Unicode(false)]
    public string Ket { get; set; }

    [Key]
    [Column("IdPasienrad")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdPasienrad { get; set; }

    [Column("VStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string VStatus { get; set; }

    [Column("Kelas")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kelas { get; set; }

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

    [Column("V_APPROVE_ANA")]
    [StringLength(50)]
    [Unicode(false)]
    public string VApproveAna { get; set; }

    [Column("C_APPROVE_ANA")]
    [StringLength(1)]
    [Unicode(false)]
    public string CApproveAna { get; set; }

    [Column("D_APPROVE_ANA", TypeName = "datetime")]
    public DateTime? DApproveAna { get; set; }

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

    [Column("V_KETKLINIK")]
    [StringLength(50)]
    [Unicode(false)]
    public string Ketklinik { get; set; }

    [Column("V_PENGOBATAN")]
    [StringLength(50)]
    [Unicode(false)]
    public string VPengobatan { get; set; }

    [Column("V_KETBAHAN")]
    [StringLength(50)]
    [Unicode(false)]
    public string Ketbahan { get; set; }

    [Column("ID_STATUS")]
    public int? IdStatus { get; set; }

    [ForeignKey("IdRegistrasi")]
    [InverseProperty("TtPasienrads")]
    public virtual D_Kunjungan IdRegistrasiNavigation { get; set; }

    [InverseProperty("IdPasienradNavigation")]
    public virtual ICollection<D_result_Hasilrad> TrHasilrads { get; set; } = new List<D_result_Hasilrad>();

    [ForeignKey("KdDokter")]
    [InverseProperty("TtPasienrads")]
    public virtual D_Dokter KdDokterNavigation { get; set; }

    [ForeignKey("KodeRuangan")]
    [InverseProperty("TtPasienrads")]
    public virtual D_Ruang KodeRuanganNavigation { get; set; }
}
