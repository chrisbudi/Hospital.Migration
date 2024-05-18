using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_Laboratorium")]
public partial class M_Laboratorium
{
    [Key]
    [Column("IdPemeriksaanLab", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdPemeriksaanLab { get; set; }

    [Column("KdPemeriksaanLab")]
    [StringLength(8)]
    [Unicode(false)]
    public string KdPemeriksaanLab { get; set; }

    [Column("NmPemeriksaanLab")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmPemeriksaanLab { get; set; }

    [Column("IdGroup", TypeName = "numeric(18, 0)")]
    public decimal? IdGroup { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [ForeignKey("IdGroup")]
    [InverseProperty("M_Laboratoria")]
    public virtual M_LaboratoriumGroup IdGroupNavigation { get; set; }

    [InverseProperty("KdPemeriksaanlabNavigation")]
    public virtual ICollection<M_LaboratoriumHarga> M_LaboratoriumHargas { get; set; } = new List<M_LaboratoriumHarga>();

    [InverseProperty("KdpemeriksaanlabNavigation")]
    public virtual ICollection<M_LaboratoriumRekanan> M_LaboratoriumRekanans { get; set; } = new List<M_LaboratoriumRekanan>();
}
