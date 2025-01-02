using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Ruang")]
[Index("KodeRuangan", Name = "IX_RUANG")]
[Index("Nama", Name = "IX_RUANG_1")]
[Index("Kamar", Name = "IX_RUANG_2")]
[Index("KodeInventory", Name = "IX_RUANG_3")]
[Index("KodeRequestobat", Name = "IX_RUANG_4")]
[Index("KodeTarif", Name = "IX_RUANG_5")]
[Index("Aktif", Name = "IX_RUANG_6")]
[Index("IdNumRuang", Name = "IX_RUANG_7")]
[Index("KdInhealth", Name = "IX_KDINHEALTH")]
[Index("LynInhealth", Name = "IX_LYNINHEALTH")]
public partial class D_Ruang
{
    [Column("IdNumRuang", TypeName = "numeric(18, 0)")]
    public decimal IdNumRuang { get; set; }

    [Key]
    [Column("KodeRuangan")]
    [StringLength(5)]
    [Unicode(false)]
    public string KodeRuangan { get; set; }

    [Required]
    [Column("Nama")]
    [StringLength(50)]
    [Unicode(false)]
    public string Nama { get; set; }

    [Column("NoRuang")]
    [StringLength(10)]
    [Unicode(false)]
    public string NoRuang { get; set; }

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

    [Column("KodeRequestObat")]
    [StringLength(2)]
    [Unicode(false)]
    public string KodeRequestObat { get; set; }

    [Column("KodeTarif")]
    [StringLength(2)]
    [Unicode(false)]
    public string KodeTarif { get; set; }

    [Column("Aktif")]
    public bool? Aktif { get; set; }

    [Column("IsTarif")]
    public bool? IsTarif { get; set; }

    [Column("Gdgpaket")]
    [StringLength(2)]
    [Unicode(false)]
    public string Gdgpaket { get; set; }

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

    [ForeignKey("KodeRequestObat")]
    [InverseProperty("TmRuangKodeRequestobatNavigations")]
    public virtual D_Gudang KodeRequestObatNavigation { get; set; }

    [InverseProperty("VKoderuanganNavigation")]
    public virtual ICollection<D_JadwalDokter> TmJadwaldokters { get; set; } = new List<D_JadwalDokter>();

    [InverseProperty("VKoderuanganNavigation")]
    public virtual ICollection<D_Kuitansialke> TtKuitansialkes { get; set; } = new List<D_Kuitansialke>();

    [InverseProperty("VKoderuanganNavigation")]
    public virtual ICollection<D_Kuitansiresep> TtKuitansireseps { get; set; } = new List<D_Kuitansiresep>();

    [InverseProperty("VKoderuanganNavigation")]
    public virtual ICollection<D_Pasieninap> TtPasieninaps { get; set; } = new List<D_Pasieninap>();

    [InverseProperty("VKoderuanganNavigation")]
    public virtual ICollection<D_Pasienlab> TtPasienlabs { get; set; } = new List<D_Pasienlab>();

    [InverseProperty("VKoderuanganNavigation")]
    public virtual ICollection<D_Pasienpenunjang> TtPasienpenunjangs { get; set; } = new List<D_Pasienpenunjang>();

    [InverseProperty("VKoderuanganNavigation")]
    public virtual ICollection<D_Pasienrad> TtPasienrads { get; set; } = new List<D_Pasienrad>();

    [InverseProperty("VKoderuanganNavigation")]
    public virtual ICollection<D_Pasienugd> TtPasienugds { get; set; } = new List<D_Pasienugd>();

    [ForeignKey("KodeInventory")]
    [InverseProperty("TmRuangVKodeinventoryNavigations")]
    public virtual D_Gudang KodeInventoryNavigation { get; set; }
}
