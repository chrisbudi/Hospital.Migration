

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_Gudang")]
[Index("IsRequest", Name = "IX_M_Gudang_Isrequest")]
[Index("IsAktif", Name = "IX_M_Gudang_IsAktif")]
[Index("KodeInventory", Name = "IX_M_GudangKdinv")]
[Index("IsListropp", Name = "IX_M_GudangLisrop")]
[Index("NamaGudangObat", Name = "IX_M_GudangNamagudang")]
public partial class M_Gudang
{
    [Key]
    [Column("IdGudangObat")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IdGudangObat { get; set; }

    [Column("KodeInventory")]
    [StringLength(2)]
    [Unicode(false)]
    public string KodeInventory { get; set; }

    [Column("NamaGudangObat")]
    [StringLength(50)]
    [Unicode(false)]
    public string NamaGudangObat { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [Column("IsRequest")]
    public bool? IsRequest { get; set; }

    [Column("IsListropp")]
    public bool? IsListropp { get; set; }

    [Column("IsTipebarang")]
    [StringLength(1)]
    [Unicode(false)]
    public string IsTipebarang { get; set; }

    [Column("IsPaketbhp")]
    public bool? IsPaketbhp { get; set; }

    [Column("IsReturbhp")]
    public bool? IsReturbhp { get; set; }

    [InverseProperty("KodeRequestobatNavigation")]
    public virtual ICollection<M_Ruang> M_RuangKodeRequestobatNavigations { get; set; } = new List<M_Ruang>();

    [InverseProperty("KodeinventoryNavigation")]
    public virtual ICollection<M_Ruang> M_RuangVKodeinventoryNavigations { get; set; } = new List<M_Ruang>();
}