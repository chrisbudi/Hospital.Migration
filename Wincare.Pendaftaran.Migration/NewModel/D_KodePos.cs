using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_KodePos")]
public partial class D_KodePos
{
    [Key]
    [Column("IdKodePos", TypeName = "numeric(18, 0)")]
    public decimal IdKodePos { get; set; }

    [Required]
    [Column("KdKodePos")]
    [StringLength(5)]
    [Unicode(false)]
    public string KdKodePos { get; set; }

    [Column("Kelurahan")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kelurahan { get; set; }

    [Column("Kecamatan")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kecamatan { get; set; }

    [Column("Kabupaten")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kabupaten { get; set; }

    [Column("Provinsi")]
    [StringLength(50)]
    [Unicode(false)]
    public string Provinsi { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }
}
