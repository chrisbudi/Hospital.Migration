

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_Standartfield")]
public partial class M_Standartfield
{
    [Key]
    [Column("IdField", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdField { get; set; }

    [Column("IdFieldgroup", TypeName = "numeric(18, 0)")]
    public decimal? IdFieldgroup { get; set; }

    [Column("KodeField")]
    [StringLength(5)]
    [Unicode(false)]
    [Required]
    public string KodeField { get; set; }

    [Column("VDeskfield")]
    [StringLength(50)]
    [Unicode(false)]
    public string DeskField { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [Column("Keterangan")]
    [StringLength(50)]
    [Unicode(false)]
    public string Keterangan { get; set; }

    [ForeignKey("IdFieldgroup")]
    [InverseProperty("M_Standartfields")]
    public virtual M_StandartfieldGroup IdFieldgroupNavigation { get; set; }
}
