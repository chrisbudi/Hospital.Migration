using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_CoaSubKlasifikasi")]
[Index("IsAktif", Name = "IX_M_CoaSubKlasifikasi_ISAKTIF")]
[Index("Kdsubklasifikasi", Name = "IX_M_CoaSubKlasifikasi_Kdsub")]
[Index("NmSubKlasifikasi", Name = "IX_M_CoaSubKlasifikasi_Nmsub")]
[Index("DC", Name = "IX_M_CoaSubKlasifikasi_DC")]
public partial class M_CoaSubklasifikasi
{
    [Key]
    [Column("IdSubKlasifikasi")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Ulid IdSubklasifikasi { get; set; }

    [Column("OldIdSubKlasifikasi", TypeName = "numeric(18, 0)")]
    public decimal OldIdSubklasifikasi { get; set; }

    [Column("KdSubKlasifikasi")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kdsubklasifikasi { get; set; }

    [Column("NmSubKlasifikasi")]
    [StringLength(50)]
    [Unicode(false)]
    public string NmSubKlasifikasi { get; set; }

    [Column("Urut", TypeName = "numeric(18, 0)")]
    public decimal? Urut { get; set; }

    [Column("DC")]
    [StringLength(50)]
    [Unicode(false)]
    public string DC { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [Column("IdKlasifikasi", TypeName = "numeric(18, 0)")]
    public decimal? IdKlasifikasi { get; set; }

    [ForeignKey("IdKlasifikasi")]
    [InverseProperty("M_CoaSubklasifikasis")]
    public virtual M_CoaKlasifikasi IdKlasifikasiNavigation { get; set; }

    [InverseProperty("IdSubklasifikasiNavigation")]
    public virtual ICollection<M_Coa> M_Coas { get; set; } = new List<M_Coa>();
}
