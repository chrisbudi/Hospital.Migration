

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_Radiologi")]
public partial class M_Radiologi
{
    [Key]
    [Column("IdPemeriksaanRad", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdPemeriksaanRad { get; set; }


    [Column("KdPemeriksaanRad")]
    [StringLength(6)]
    [Unicode(false)]
    public string Kdpemeriksaanrad { get; set; }

    [Column("NmPemeriksaanRad")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmPemeriksaanRad { get; set; }

    [Column("IdGroup", TypeName = "numeric(18, 0)")]
    public decimal? IdGroup { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [ForeignKey("IdGroup")]
    [InverseProperty("M_Radiologis")]
    public virtual M_RadiologiGroup IdGroupNavigation { get; set; }

    [InverseProperty("KdpemeriksaanRadNavigation")]
    public virtual ICollection<M_RadiologiHarga> M_RadiologiHargas { get; set; } = new List<M_RadiologiHarga>();

    [InverseProperty("KdpemeriksaanRadNavigation")]
    public virtual ICollection<M_RadiologiRekanan> M_RadiologiRekanans { get; set; } = new List<M_RadiologiRekanan>();
}