

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_Status")]
[Index("Status", Name = "IX_M_Status")]
[Index("IdStatus", Name = "IX_M_Status_1")]
public partial class M_Status
{
    [Key]
    [Column("IdStatus")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdStatus { get; set; }

    [Column("VStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; }
}