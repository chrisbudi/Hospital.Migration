using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_LaboratoriumRekanan")]
public partial class M_LaboratoriumRekanan
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("IdLabrekanan")]
    public long IdLabRekanan { get; set; }

    [Column("KdPemeriksaanLab")]
    [StringLength(8)]
    [Unicode(false)]
    public string KdPemeriksaanLab { get; set; }

    [Column("IdPemeriksaanLab")]
    public long? IdPemeriksaanLab { get; set; }

    [Column("RekananId")]
    public long RekananId { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [ForeignKey("RekananId")]
    [InverseProperty("M_LaboratoriumRekanans")]
    public virtual M_Rekanan Rekanan { get; set; }

    [ForeignKey("IdPemeriksaanLab")]
    [InverseProperty("M_LaboratoriumRekanans")]
    public virtual M_Laboratorium KdpemeriksaanlabNavigation { get; set; }
}