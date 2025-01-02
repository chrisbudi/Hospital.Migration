using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Pasienpenunjang")]
[Index("IdRegistrasi", "TglKunjungan", "Penunjang", "KdDokter", "IdPasienPenunjang", "Done", "IdNumPasienpenj", Name = "IX_PASIENPENUNJANG", IsUnique = true)]
public partial class D_Pasienpenunjang
{
    [Column("IdNumPasienpenj", TypeName = "numeric(18, 0)")]
    public decimal IdNumPasienpenj { get; set; }

    [Required]
    [Column("IdRegistrasi")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdRegistrasi { get; set; }

    [Column("IdPasien")]
    [StringLength(10)]
    [Unicode(false)]
    public string IdPasien { get; set; }

    [Column("TglKunjungan", TypeName = "datetime")]
    public DateTime? TglKunjungan { get; set; }

    [Column("Jam")]
    [StringLength(5)]
    [Unicode(false)]
    public string Jam { get; set; }

    [Column("Urut")]
    public int? Urut { get; set; }

    [Column("Note")]
    [StringLength(250)]
    [Unicode(false)]
    public string Note { get; set; }

    [Column("Done")]
    [StringLength(1)]
    [Unicode(false)]
    public string Done { get; set; }

    [Required]
    [Column("Penunjang")]
    [StringLength(20)]
    [Unicode(false)]
    public string Penunjang { get; set; }

    [Column("KodeRuangan")]
    [StringLength(5)]
    [Unicode(false)]
    public string KodeRuangan { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("KdDokter")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdDokter { get; set; }

    [Column("NmDokter")]
    [StringLength(60)]
    [Unicode(false)]
    public string NmDokter { get; set; }

    [Column("KdUnit")]
    [StringLength(5)]
    [Unicode(false)]
    public string KdUnit { get; set; }

    [Column("Unit")]
    [StringLength(50)]
    [Unicode(false)]
    public string Unit { get; set; }

    [Column("KdPengirim")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdPengirim { get; set; }

    [Column("NmPengirim")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmPengirim { get; set; }

    [Key]
    [Column("IdPasienPenunjang")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdPasienPenunjang { get; set; }

    [Column("Status")]
    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("Kelas")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kelas { get; set; }

    [Column("IdStatus")]
    public int? IdStatus { get; set; }

    [ForeignKey("KodeRuangan")]
    [InverseProperty("TtPasienpenunjangs")]
    public virtual D_Ruang KodeRuanganNavigation { get; set; }
}
