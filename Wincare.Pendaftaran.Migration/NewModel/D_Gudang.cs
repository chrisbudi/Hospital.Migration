using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Gudang")]
[Index("Request", Name = "IX_GUDANG_ISREQUEST")]
[Index("Aktif", Name = "IX_GUDANG_IS_AKTIF")]
[Index("KodeInventory", Name = "IX_GUDANG_KDINV")]
[Index("Listropp", Name = "IX_GUDANG_LISROP")]
[Index("NamaGudangObat", Name = "IX_GUDANG_NAMAGUDANG")]
public partial class D_Gudang
{
    [Column("IdGudangObat", TypeName = "numeric(18, 0)")]
    public decimal IdGudangobat { get; set; }

    [Key]
    [Column("KodeInventory")]
    [StringLength(2)]
    [Unicode(false)]
    public string Kodeinventory { get; set; }

    [Column("NamaGudangObat")]
    [StringLength(50)]
    [Unicode(false)]
    public string NamaGudangObat { get; set; }

    [Column("Aktif")]
    public bool? Aktif { get; set; }

    [Column("Request")]
    public bool? Request { get; set; }

    [Column("Listropp")]
    public bool? Listropp { get; set; }

    [Column("TipeBarang")]
    [StringLength(1)]
    [Unicode(false)]
    public string TipeBarang { get; set; }

    [Column("Paketbhp")]
    public bool? Paketbhp { get; set; }

    [Column("Returbhp")]
    public bool? Returbhp { get; set; }

    [InverseProperty("KodeRequestobatNavigation")]
    public virtual ICollection<D_Ruang> TmRuangKodeRequestobatNavigations { get; set; } = new List<D_Ruang>();

    [InverseProperty("VKodeinventoryNavigation")]
    public virtual ICollection<D_Ruang> TmRuangVKodeinventoryNavigations { get; set; } = new List<D_Ruang>();

    [InverseProperty("VKodeinventoryNavigation")]
    public virtual ICollection<D_Kuitansialke> TtKuitansialkes { get; set; } = new List<D_Kuitansialke>();

    [InverseProperty("VKoderequestobatNavigation")]
    public virtual ICollection<D_Kuitansiresep> TtKuitansireseps { get; set; } = new List<D_Kuitansiresep>();
}
