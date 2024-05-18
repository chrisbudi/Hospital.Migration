using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_DTD")]
public partial class M_Dtd
{
    [Key]
    [Column("IdDTD", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdDtd { get; set; }

    [Column("KdDTD")]
    [StringLength(8)]
    [Unicode(false)]
    [Required]
    public string Kddtd { get; set; }

    [Column("NmDTD")]
    [StringLength(200)]
    [Unicode(false)]
    public string Nmdtd { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }
}