using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_PaketRekanan")]
public partial class M_PaketRekanan
{
    [Key]
    [Column("IdPaketRekanan")]
    public Guid IdPaketRekanan { get; set; }

    [Column("OldIdPaketRekanan", TypeName = "numeric(18, 0)")]
    public decimal OldIdPaketRekanan { get; set; }

    [Column("IdMasterPemeriksaanPenunjang")]
    public Guid IdMasterPemeriksaanPenunjang { get; set; }

    [Column("OldIdMasterPemeriksaanPenunjang", TypeName = "numeric(18, 0)")]
    public decimal OldIdMasterPemeriksaanPenunjang { get; set; }

    [Column("RekananId")]
    public Guid RekananId { get; set; }

    [Column("OldRekananId", TypeName = "numeric(18, 0)")]
    public decimal OldRekananId { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }
}
