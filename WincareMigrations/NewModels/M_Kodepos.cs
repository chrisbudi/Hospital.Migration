using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_Kodepos")]
public partial class M_Kodepos
{
    [Key]
    [Column("IdKodepos")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdKodepos { get; set; }


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

    [Column("IS_AKTIF")]
    public bool? IsAktif { get; set; }
}