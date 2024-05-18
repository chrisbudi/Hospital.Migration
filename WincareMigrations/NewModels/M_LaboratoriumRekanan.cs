using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_LaboratoriumRekanan")]
public partial class M_LaboratoriumRekanan
{
    [Key]
    [Column("IdLabrekanan")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid IdLabRekanan { get; set; }

    [Column("OldIdLabrekanan", TypeName = "numeric(18, 0)")]
    public decimal OldIdLabRekanan { get; set; }

    [Column("KdPemeriksaanLab")]
    [StringLength(8)]
    [Unicode(false)]
    public string KdPemeriksaanLab { get; set; }

    [Column("IdPemeriksaanLab", TypeName = "numeric(18, 0)")]
    public decimal? IdPemeriksaanLab { get; set; }

    [Column("RekananId", TypeName = "numeric(18, 0)")]
    public decimal RekananId { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [ForeignKey("RekananId")]
    [InverseProperty("M_LaboratoriumRekanans")]
    public virtual M_Rekanan Rekanan { get; set; }

    [ForeignKey("IdPemeriksaanLab")]
    [InverseProperty("M_LaboratoriumRekanans")]
    public virtual M_Laboratorium KdpemeriksaanlabNavigation { get; set; }
}