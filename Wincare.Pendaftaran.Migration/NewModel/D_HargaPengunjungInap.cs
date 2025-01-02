using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("d_hargaPengunjungInap")]
public partial class D_HargaPengunjungInap
{
    [Key]
    [Column("IdPengunjungInap")]
    public decimal Idpengunjunginap { get; set; }

    [Column("IdKunjungan")]
    public decimal Idkunjungan { get; set; }

    [Column("TglMasuk", TypeName = "datetime")]
    public DateTime? Tglmasuk { get; set; }

    [Column("TglKeluar", TypeName = "datetime")]
    public DateTime? Tglkeluar { get; set; }

    [Column("Kamar")]
    [StringLength(5)]
    [Unicode(false)]
    public string Kamar { get; set; }

    [Column("Kelas")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kelas { get; set; }

    [Column("Harga", TypeName = "decimal(18, 0)")]
    public decimal? Harga { get; set; }

    [Column("STATUS")]
    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("VBY")]
    [StringLength(50)]
    [Unicode(false)]
    public string Vby { get; set; }

    [Column("KodeRuangan")]
    [StringLength(5)]
    [Unicode(false)]
    public string Koderuangan { get; set; }

    [ForeignKey("Idkunjungan")]
    [InverseProperty("TthPengunjunginaps")]
    public virtual D_Kunjungan IdkunjunganNavigation { get; set; }

    [ForeignKey("Kamar")]
    [InverseProperty("TthPengunjunginaps")]
    public virtual D_Kamar KamarNavigation { get; set; }
}
