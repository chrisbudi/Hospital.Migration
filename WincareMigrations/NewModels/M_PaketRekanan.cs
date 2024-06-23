using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_PaketRekanan")]
public partial class M_PaketRekanan
{
    [Key]
    [Column("IdPaketRekanan")]
    public long IdPaketRekanan { get; set; }

    [Column("OldIdPaketRekanan", TypeName = "numeric(18, 0)")]
    public decimal OldIdPaketRekanan { get; set; }

    [Column("IdMasterPemeriksaanPenunjang")]
    public Ulid IdMasterPemeriksaanPenunjang { get; set; }

    [Column("OldIdMasterPemeriksaanPenunjang")]
    public long OldIdMasterPemeriksaanPenunjang { get; set; }

    [Column("RekananId")]
    public Ulid RekananId { get; set; }

    [Column("OldRekananId")]
    public long OldRekananId { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }
}
