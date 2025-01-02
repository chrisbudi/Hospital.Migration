using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Kamar")]
public partial class D_Kamar
{
    [Column("IdKamar", TypeName = "numeric(18, 0)")]
    public decimal Idkamar { get; set; }

    [Key]
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

    [Column("Status")]
    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("Aktif")]
    public bool? Aktif { get; set; }

    [Column("KodeRuangan")]
    [StringLength(5)]
    [Unicode(false)]
    public string KodeRuangan { get; set; }

    [InverseProperty("KamarNavigation")]
    public virtual ICollection<D_HargaKunjungan> TthKunjungans { get; set; } = new List<D_HargaKunjungan>();

    [InverseProperty("KamarNavigation")]
    public virtual ICollection<D_HargaPengunjungInap> TthPengunjunginaps { get; set; } = new List<D_HargaPengunjungInap>();
}
