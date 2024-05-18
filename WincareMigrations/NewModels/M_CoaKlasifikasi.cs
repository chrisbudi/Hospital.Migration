using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_CoaKlasifikasi")]
[Index("IsAktif", Name = "IX_M_CoaKlasifikasi_IsAktif")]
[Index("NmKlasifikasi", Name = "IX_M_CoaKlasifikasi_NmKlasifikasi")]
public partial class M_CoaKlasifikasi
{
    [Key]
    [Column("IdKlasifikasi", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdKlasifikasi { get; set; }

    [Column("NmKlasifikasi")]
    [StringLength(50)]
    [Unicode(false)]
    public string NmKlasifikasi { get; set; }

    [Column("Urut", TypeName = "numeric(18, 0)")]
    public decimal? Urut { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [Column("IdGolongan", TypeName = "numeric(18, 0)")]
    public decimal? IdGolongan { get; set; }

    [ForeignKey("IdGolongan")]
    [InverseProperty("M_CoaKlasifikasis")]
    public virtual M_CoaGolongan IdGolonganNavigation { get; set; }

    [InverseProperty("IdKlasifikasiNavigation")]
    public virtual ICollection<M_CoaSubklasifikasi> M_CoaSubklasifikasis { get; set; } = new List<M_CoaSubklasifikasi>();
}
