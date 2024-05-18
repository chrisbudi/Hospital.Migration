using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_AntrianLokasi")]
[Index("Action", Name = "IX_M_AntrianLokasi_action")]
[Index("IdLokasi", Name = "IX_M_AntrianLokasi_idlokasi")]
[Index("IsAktif", Name = "IX_M_AntrianLokasi_isaktif")]
[Index("Kdlokasi", Name = "IX_M_AntrianLokasi_vkdlokasi")]
[Index("Lokasi", Name = "IX_M_AntrianLokasi_vlokasi")]
public partial class M_AntrianLokasi
{
    [Column("IdLokasi")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IdLokasi { get; set; }

    [Key]
    [Column("Kdlokasi")]
    [StringLength(5)]
    [Unicode(false)]
    public string Kdlokasi { get; set; }

    [Column("Lokasi")]
    [StringLength(50)]
    [Unicode(false)]
    public string Lokasi { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [Column("Action")]
    [StringLength(50)]
    [Unicode(false)]
    public string Action { get; set; }
}