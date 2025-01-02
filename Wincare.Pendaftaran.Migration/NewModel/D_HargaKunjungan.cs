using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_HargaKunjungan")]
public partial class D_HargaKunjungan
{
    [Column("IdNum", TypeName = "numeric(18, 0)")]
    public decimal IdNum { get; set; }

    [Key]
    [Column("IdKunjungan", TypeName = "numeric(18, 0)")]
    public decimal IdKunjungan { get; set; }

    [Column("IdPengunjung")]
    [StringLength(10)]
    [Unicode(false)]
    public string IdPengunjung { get; set; }

    [Column("TglMasuk", TypeName = "datetime")]
    public DateTime? TglMasuk { get; set; }

    [Column("TglKeluar", TypeName = "datetime")]
    public DateTime? TglKeluar { get; set; }

    [Column("Status")]
    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("Kamar")]
    [StringLength(5)]
    [Unicode(false)]
    public string Kamar { get; set; }

    [Column("RekananId", TypeName = "varchar(26)")]
    public decimal? RekananId { get; set; }

    [Column("AlasanBatal")]
    [StringLength(100)]
    [Unicode(false)]
    public string AlasanBatal { get; set; }

    [ForeignKey("IdPengunjung")]
    [InverseProperty("TthKunjungans")]
    public virtual D_Pengunjung IdpengunjungNavigation { get; set; }

    [ForeignKey("Kamar")]
    [InverseProperty("TthKunjungans")]
    public virtual D_Kamar KamarNavigation { get; set; }

    [ForeignKey("RekananId")]
    [InverseProperty("TthKunjungans")]
    public virtual D_Rekanan Rekanan { get; set; }

    [InverseProperty("IdkunjunganNavigation")]
    public virtual ICollection<D_Deposit> TthDeposits { get; set; } = new List<D_Deposit>();

    [InverseProperty("IdkunjunganNavigation")]
    public virtual ICollection<D_HargaPengunjungInap> TthPengunjunginaps { get; set; } = new List<D_HargaPengunjungInap>();

    [InverseProperty("IdkunjunganNavigation")]
    public virtual ICollection<D_HasilTransaksi> TthTransaksis { get; set; } = new List<D_HasilTransaksi>();
}
