

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_Smf")]
public partial class M_Smf
{
    [Key]
    [Column("IdSmf")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdSmf { get; set; }

    [Column("Kdsmf")]
    [StringLength(2)]
    [Unicode(false)]
    public string Kdsmf { get; set; }

    [Column("Nmsmf")]
    [StringLength(50)]
    [Unicode(false)]
    public string Nmsmf { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }
}