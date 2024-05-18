

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_TarifRekananSub")]
public partial class M_TarifRekananSub
{
    [Key]
    [Column("IdTarifrekanansub")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid IdTarifrekanansub { get; set; }

    [Column("IdTarifRekananSub", TypeName = "numeric(18, 0)")]
    public decimal OldIdTarifRekananSub { get; set; }

    [Column("RekananIdHd", TypeName = "numeric(18, 0)")]
    public decimal RekananIdHd { get; set; }

    [Column("RekananidDt", TypeName = "numeric(18, 0)")]
    public decimal RekananidDt { get; set; }
}