using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_KelompokBarang")]
[Index("IdGroupTarif", Name = "IX_M_KelompokBarang_IDGROUP")]
[Index("IsAktif", Name = "IX_M_KelompokBarang_ISAKTIF")]
[Index("KelompokId", Name = "IX_M_KelompokBarang_KELOMPOKID")]
[Index("Kode", Name = "IX_M_KelompokBarang_KODE")]
[Index("Nama", Name = "IX_M_KelompokBarang_NAMA")]
public partial class M_KelompokBarang
{
    [Key]
    [Column("KelompokId", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal KelompokId { get; set; }

    [Column("Kode")]
    [StringLength(10)]
    [Unicode(false)]
    public string Kode { get; set; }

    [Column("Nama")]
    [StringLength(50)]
    [Unicode(false)]
    public string Nama { get; set; }

    [Column("Margin", TypeName = "numeric(18, 2)")]
    public decimal? Margin { get; set; }

    [Column("Note")]
    [StringLength(500)]
    [Unicode(false)]
    public string Note { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [Column("IdGroupTarif", TypeName = "numeric(18, 0)")]
    public decimal? IdGroupTarif { get; set; }

    [InverseProperty("Kelompok")]
    public virtual ICollection<M_Barang> MBarangs { get; set; } = new List<M_Barang>();
}