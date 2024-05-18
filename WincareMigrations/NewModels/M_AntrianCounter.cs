using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_AntrianCounter")]
[Index("IdCounter", Name = "IX_M_AntrianCounter_idcounter")]
[Index("IsAktif", Name = "IX_M_AntrianCounter_isaktif")]
[Index("Kdcounter", Name = "IX_M_AntrianCounter_vkdcounter")]
[Index("Counter", Name = "IX_M_AntrianCounter_vnmcounter")]
public partial class M_AntrianCounter
{
    [Key]
    [Column("IdCounter")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IdCounter { get; set; }

    [Required]
    [Column("Kdcounter")]
    [StringLength(5)]
    [Unicode(false)]
    public string Kdcounter { get; set; }

    [Column("Counter")]
    [StringLength(50)]
    [Unicode(false)]
    public string Counter { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [Column("Kdlokasi")]
    [StringLength(5)]
    [Unicode(false)]
    public string Kdlokasi { get; set; }

    [Column("Kdlayanan")]
    [StringLength(5)]
    [Unicode(false)]
    public string Kdlayanan { get; set; }
}