

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_Hargakamar")]
public partial class M_Hargakamar
{
    [Key]
    [Column("IdHargakamar")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IdHargakamar { get; set; }

    [Column("Kelas")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kelas { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [InverseProperty("KelasNavigation")]
    public virtual ICollection<M_Kamarinap> M_Kamarinaps { get; set; } = new List<M_Kamarinap>();

    [InverseProperty("KelasNavigation")]
    public virtual ICollection<M_LaboratoriumHarga> M_LaboratoriumHargas { get; set; } = new List<M_LaboratoriumHarga>();

    [InverseProperty("KelasNavigation")]
    public virtual ICollection<M_RadiologiHarga> M_RadiologiHargas { get; set; } = new List<M_RadiologiHarga>();
}