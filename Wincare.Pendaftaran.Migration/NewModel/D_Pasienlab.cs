using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("TT_PASIENLAB")]
[Index("IdPasienlab", Name = "IX_TT_PASIENLAB")]
[Index("IdRegistrasi", Name = "IX_TT_PASIENLAB_1")]
[Index("DTglsample", Name = "IX_TT_PASIENLAB_10")]
[Index("IdNum", Name = "IX_TT_PASIENLAB_11")]
[Index("VBy", Name = "IX_TT_PASIENLAB_12")]
[Index("VKddokter", Name = "IX_TT_PASIENLAB_2")]
[Index("VKddokterpjawab", Name = "IX_TT_PASIENLAB_3")]
[Index("VKelas", Name = "IX_TT_PASIENLAB_4")]
[Index("VKoderuangan", Name = "IX_TT_PASIENLAB_5")]
[Index("VNmdokter", Name = "IX_TT_PASIENLAB_6")]
[Index("VPenanggungjawab", Name = "IX_TT_PASIENLAB_7")]
[Index("VUnit", Name = "IX_TT_PASIENLAB_8")]
[Index("DTgldatang", Name = "IX_TT_PASIENLAB_9")]
public partial class D_Pasienlab
{
    [Column("ID_NUM", TypeName = "numeric(18, 0)")]
    public decimal IdNum { get; set; }

    [Required]
    [Column("ID_REGISTRASI")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdRegistrasi { get; set; }

    [Column("D_TGLDATANG", TypeName = "datetime")]
    public DateTime? DTgldatang { get; set; }

    [Column("V_JAM")]
    [StringLength(5)]
    [Unicode(false)]
    public string VJam { get; set; }

    [Column("I_URUT")]
    public int? IUrut { get; set; }

    [Column("C_ISDONE")]
    [StringLength(1)]
    [Unicode(false)]
    public string CIsdone { get; set; }

    [Column("V_KODERUANGAN")]
    [StringLength(5)]
    [Unicode(false)]
    public string VKoderuangan { get; set; }

    [Column("V_UNIT")]
    [StringLength(50)]
    [Unicode(false)]
    public string VUnit { get; set; }

    [Column("V_KDDOKTER")]
    [StringLength(6)]
    [Unicode(false)]
    public string VKddokter { get; set; }

    [Key]
    [Column("ID_PASIENLAB")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdPasienlab { get; set; }

    [Column("V_NMDOKTER")]
    [StringLength(100)]
    [Unicode(false)]
    public string VNmdokter { get; set; }

    [Column("D_TGLSAMPLE", TypeName = "datetime")]
    public DateTime? DTglsample { get; set; }

    [Column("V_JAMINPUT")]
    [StringLength(10)]
    [Unicode(false)]
    public string VJaminput { get; set; }

    [Column("V_CATATAN", TypeName = "text")]
    public string VCatatan { get; set; }

    [Column("V_KDDOKTERPJAWAB")]
    [StringLength(6)]
    [Unicode(false)]
    public string VKddokterpjawab { get; set; }

    [Column("V_PENANGGUNGJAWAB")]
    [StringLength(100)]
    [Unicode(false)]
    public string VPenanggungjawab { get; set; }

    [Column("V_BY")]
    [StringLength(50)]
    [Unicode(false)]
    public string VBy { get; set; }
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

    [Column("V_STATUS")]
    [StringLength(50)]
    [Unicode(false)]
    public string VStatus { get; set; }

    [Column("V_KELAS")]
    [StringLength(50)]
    [Unicode(false)]
    public string VKelas { get; set; }

    [Column("V_KETKLINIK")]
    [StringLength(50)]
    [Unicode(false)]
    public string VKetklinik { get; set; }

    [Column("V_PENGOBATAN")]
    [StringLength(50)]
    [Unicode(false)]
    public string VPengobatan { get; set; }

    [Column("V_KETBAHAN")]
    [StringLength(50)]
    [Unicode(false)]
    public string VKetbahan { get; set; }

    [Column("V_KETCAIRAN")]
    [StringLength(50)]
    [Unicode(false)]
    public string VKetcairan { get; set; }

    [Column("V_KETKHUSUS")]
    [StringLength(50)]
    [Unicode(false)]
    public string VKetkhusus { get; set; }

    [Column("ID_STATUS")]
    public int? IdStatus { get; set; }

    [ForeignKey("IdRegistrasi")]
    [InverseProperty("TtPasienlabs")]
    public virtual D_Kunjungan IdRegistrasiNavigation { get; set; }

    [InverseProperty("IdPasienlabNavigation")]
    public virtual ICollection<D_result_Hasillab> TrHasillabs { get; set; } = new List<D_result_Hasillab>();

    [ForeignKey("VKddokter")]
    [InverseProperty("TtPasienlabVKddokterNavigations")]
    public virtual D_Dokter VKddokterNavigation { get; set; }

    [ForeignKey("VKddokterpjawab")]
    [InverseProperty("TtPasienlabVKddokterpjawabNavigations")]
    public virtual D_Dokter VKddokterpjawabNavigation { get; set; }

    [ForeignKey("VKoderuangan")]
    [InverseProperty("TtPasienlabs")]
    public virtual D_Ruang VKoderuanganNavigation { get; set; }
}
