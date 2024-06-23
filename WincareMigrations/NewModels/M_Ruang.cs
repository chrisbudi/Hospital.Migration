

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_Ruang")]
[Index("Koderuangan", Name = "IX_M_Ruang")]
[Index("Nama", Name = "IX_M_Ruang_1")]
[Index("Kamar", Name = "IX_M_Ruang_2")]
[Index("KodeInventoryGudangObat", Name = "IX_M_Ruang_3")]
[Index("KodeRequestGudangObat", Name = "IX_M_Ruang_4")]
[Index("KodeTarif", Name = "IX_M_Ruang_5")]
[Index("IsAktif", Name = "IX_M_Ruang_6")]
[Index("IdRuang", Name = "IX_M_Ruang_7")]
[Index("KdInhealth", Name = "IX_V_KDINHEALTH")]
[Index("LynInhealth", Name = "IX_V_LYNINHEALTH")]
public partial class M_Ruang
{
    [Key]
    [Column("IdRuang")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IdRuang { get; set; }

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

    [Column("KodeInventoryGudangObat")]
    public long? KodeInventoryGudangObat { get; set; }

    [Column("KodeRequestObat")]
    [StringLength(2)]
    [Unicode(false)]
    public string KodeRequestObat { get; set; }

    [Column("KodeRequestGudangObat")]
    public long? KodeRequestGudangObat { get; set; }

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
    [InverseProperty("M_RuangKodeRequestobatNavigations")]
    public virtual M_Gudang KodeRequestobatNavigation { get; set; }

    [InverseProperty("KoderuanganNavigation")]
    public virtual ICollection<M_Jadwaldokter> M_Jadwaldokters { get; set; } = new List<M_Jadwaldokter>();

    [InverseProperty("KoderuanganNavigation")]
    public virtual ICollection<M_Map> M_Maps { get; set; } = new List<M_Map>();

    [InverseProperty("KoderuanganNavigation")]
    public virtual ICollection<M_User> M_Users { get; set; } = new List<M_User>();

    [ForeignKey("KodeInventoryGudangObat")]
    [InverseProperty("M_RuangVKodeinventoryNavigations")]
    public virtual M_Gudang KodeinventoryNavigation { get; set; }
}
