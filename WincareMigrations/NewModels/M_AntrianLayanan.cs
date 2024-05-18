using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_AntrianLayanan")]
[Index("IdLayanan", Name = "IX_M_AntrianLayanan_idlayanan")]
[Index("Inisial", Name = "IX_M_AntrianLayanan_inisial")]
[Index("IsAktif", Name = "IX_M_AntrianLayanan_isaktif")]
[Index("Kdlayanan", Name = "IX_M_AntrianLayanan_vkdlayan")]
[Index("Layanan", Name = "IX_M_AntrianLayanan_vlayanan")]
public partial class M_AntrianLayanan
{
    [Key]
    [Column("IdLayanan")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IdLayanan { get; set; }

    [Required]
    [Column("KdLayanan")]
    [StringLength(5)]
    [Unicode(false)]
    public string Kdlayanan { get; set; }

    [Column("Layanan")]
    [StringLength(50)]
    [Unicode(false)]
    public string Layanan { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [Column("Inisial")]
    [StringLength(2)]
    [Unicode(false)]
    public string Inisial { get; set; }

    [Column("KdLokasi")]
    [StringLength(5)]
    [Unicode(false)]
    public string Kdlokasi { get; set; }
}