using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_AntrianCounterAudio")]
[Index("IdCounteraudio", Name = "IX_M_AntrianCounterAudio_idcounteraudio")]
[Index("IsAktif", Name = "IX_M_AntrianCounterAudio_isaktif")]
[Index("Kdlayanan", Name = "IX_M_AntrianCounterAudio__kdlayanan")]
[Index("Kdlokasi", Name = "IX_M_AntrianCounterAudio__kdlokasi")]
[Index("Counter", Name = "IX_M_AntrianCounterAudio_counter")]
[Index("File", Name = "IX_M_AntrianCounterAudio_file")]
[Index("Kdcounter", Name = "IX_M_AntrianCounterAudio_kdcounter")]
[Index("Nomor", Name = "IX_M_AntrianCounterAudio_nomor")]
public partial class M_AntrianCounterAudio
{
    [Key]
    [Column("IdCounterAudio")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IdCounteraudio { get; set; }

    [Required]
    [Column("KdCounter")]
    [StringLength(5)]
    [Unicode(false)]
    public string Kdcounter { get; set; }

    [Column("Counter")]
    [StringLength(50)]
    [Unicode(false)]
    public string Counter { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [Column("KdLokasi")]
    [StringLength(5)]
    [Unicode(false)]
    public string Kdlokasi { get; set; }

    [Column("KdLayanan")]
    [StringLength(5)]
    [Unicode(false)]
    public string Kdlayanan { get; set; }

    [Column("File")]
    [StringLength(50)]
    [Unicode(false)]
    public string File { get; set; }

    [Column("Nomor")]
    [StringLength(4)]
    [Unicode(false)]
    public string Nomor { get; set; }
}