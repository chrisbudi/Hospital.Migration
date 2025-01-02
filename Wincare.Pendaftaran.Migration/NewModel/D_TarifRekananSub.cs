

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_TarifRekananSub")]
public partial class D_TarifRekananSub
{
    [Key]
    [Column("IdTarifRekananSub", TypeName = "numeric(18, 0)")]
    public decimal IdTarifRekananSub { get; set; }

    [Column("RekananIdHd", TypeName = "numeric(18, 0)")]
    public decimal RekananIdHd { get; set; }

    [Column("RekananIdDt", TypeName = "numeric(18, 0)")]
    public decimal RekananIdDt { get; set; }
}
