

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_JadwalDokter")]
[Index("IdJadwal", Name = "IX_M_JadwalDokter_IdJadwal")]
[Index("KdDokter", Name = "IX_M_JadwalDokter_KdDokter")]
[Index("KodeRuangan", Name = "IX_M_JadwalDokter_KdRuangan")]
[Index("NamaKlinik", Name = "IX_M_JadwalDokter_NamaKlinik")]
[Index("Hari", Name = "IX_M_JadwalDokter_Hari")]
[Index("JamStart", Name = "IX_M_JadwalDokter_JamStart")]
[Index("JamFinish", Name = "IX_M_JadwalDokter_JamFinish")]
[Index("IsAktif", Name = "IX_M_JadwalDokter_IsAktif")]
public partial class M_Jadwaldokter
{
    [Key]
    [Column("IdJadwal")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IdJadwal { get; set; }

    [Column("KdDokter")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdDokter { get; set; }

    [Column("IdDokter")]
    public decimal? IdDokter { get; set; }

    [Required]
    [Column("Hari")]
    [StringLength(30)]
    [Unicode(false)]
    public string Hari { get; set; }

    [Required]
    [Column("JamStart")]
    [StringLength(5)]
    [Unicode(false)]
    public string JamStart { get; set; }

    [Column("JamFinish")]
    [StringLength(5)]
    [Unicode(false)]
    public string JamFinish { get; set; }

    [Required]
    [Column("KodeRuangan")]
    [StringLength(5)]
    [Unicode(false)]
    public string KodeRuangan { get; set; }

    [Column("IdRuangan")]
    public long? IdRuangan { get; set; }


    [Column("NamaKlinik")]
    [StringLength(100)]
    [Unicode(false)]
    public string NamaKlinik { get; set; }

    [Column("ServisTime")]
    public int? ServisTime { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [ForeignKey("IdDokter")]
    [InverseProperty("M_JadwalDokters")]
    public virtual M_Dokter KdDokterNavigation { get; set; }

    [ForeignKey("IdRuangan")]
    [InverseProperty("M_Jadwaldokters")]
    public virtual M_Ruang KoderuanganNavigation { get; set; }
}