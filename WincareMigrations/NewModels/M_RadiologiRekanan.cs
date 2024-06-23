

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_RadiologiRekanan")]
public partial class M_RadiologiRekanan
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("IdRadrekanan")]
    public long IdRadrekanan { get; set; }

    [Required]
    [Column("KdPemeriksaanRad")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdPemeriksaanRad { get; set; }

    [Column("IdPemeriksaanRad")]
    public long? IdPemeriksaanRad { get; set; }

    [Column("RekananId")]
    public long? RekananId { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [ForeignKey("RekananId")]
    [InverseProperty("M_RadiologiRekanans")]
    public virtual M_Rekanan Rekanan { get; set; }

    [ForeignKey("IdPemeriksaanRad")]
    [InverseProperty("M_RadiologiRekanans")]
    public virtual M_Radiologi KdpemeriksaanRadNavigation { get; set; }
}