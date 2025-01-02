using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_JadwalDokter")]
[Index("IdJadwal", Name = "IX_JADWALDOKTER")]
[Index("KdDokter", Name = "IX_JADWALDOKTER_1")]
[Index("KodeRuangan", Name = "IX_JADWALDOKTER_2")]
[Index("NamaKlinik", Name = "IX_JADWALDOKTER_3")]
[Index("Hari", Name = "IX_JADWALDOKTER_4")]
[Index("JamStart", Name = "IX_JADWALDOKTER_5")]
[Index("JamFinish", Name = "IX_JADWALDOKTER_6")]
[Index("Aktif", Name = "IX_JADWALDOKTER_7")]
public partial class D_JadwalDokter
{
    [Key]
    [Column("IdJadwal", TypeName = "numeric(18, 0)")]
    public decimal IdJadwal { get; set; }

    [Column("KdDokter")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdDokter { get; set; }

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

    [Column("NamaKlinik")]
    [StringLength(100)]
    [Unicode(false)]
    public string NamaKlinik { get; set; }

    [Column("ServisTime")]
    public int? ServisTime { get; set; }

    [Column("Aktif")]
    public bool? Aktif { get; set; }

    [ForeignKey("KdDokter")]
    [InverseProperty("TmJadwaldokters")]
    public virtual D_Dokter KdDokterNavigation { get; set; }

    [ForeignKey("KodeRuangan")]
    [InverseProperty("TmJadwaldokters")]
    public virtual D_Ruang KodeRuanganNavigation { get; set; }
}
