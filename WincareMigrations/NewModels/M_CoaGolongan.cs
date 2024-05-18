using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_CoaGolongan")]
[Index("IsAktif", Name = "IX_M_CoaGolongan_IsAktif")]
[Index("NmGolongan", Name = "IX_M_CoaGolongan_NmGolo")]
public partial class M_CoaGolongan
{
    [Key]
    [Column("IdGolongan", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdGolongan { get; set; }

    [Column("NmGolongan")]
    [StringLength(50)]
    [Unicode(false)]
    public string NmGolongan { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [InverseProperty("IdGolonganNavigation")]
    public virtual ICollection<M_CoaKlasifikasi> M_CoaKlasifikasis { get; set; } = new List<M_CoaKlasifikasi>();
}
