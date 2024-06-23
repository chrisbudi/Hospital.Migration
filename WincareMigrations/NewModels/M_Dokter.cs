using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_Dokter")]
[Index("KdDokter", Name = "IX_M_Dokter_KdDokter")]
[Index("NmDokter", Name = "IX_M_Dokter_NmDokter")]
public partial class M_Dokter
{

    [Key]
    [Column("IdDokter", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdDokter { get; set; }

    [Column("KdDokter")]
    [StringLength(6)]
    [Unicode(false)]
    [Required]
    public string KdDokter { get; set; }

    [Column("NmDokter")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmDokter { get; set; }

    [Column("SpesialisasiDokter")]
    [StringLength(60)]
    [Unicode(false)]
    public string Spesialisasidokter { get; set; }

    [Column("AlamatDokter")]
    [StringLength(200)]
    [Unicode(false)]
    public string Alamatdokter { get; set; }

    [Column("TelpDokter")]
    [StringLength(100)]
    [Unicode(false)]
    public string Telpdokter { get; set; }

    [Column("AlamatPraktek")]
    [StringLength(200)]
    [Unicode(false)]
    public string Alamatpraktek { get; set; }

    [Column("Telppraktek")]
    [StringLength(100)]
    [Unicode(false)]
    public string Telppraktek { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [Column("ImgFotodokter")]
    [StringLength(100)]
    [Unicode(false)]
    public string ImgFotodokter { get; set; }

    [Column("KodeTarif")]
    [StringLength(2)]
    [Unicode(false)]
    public string Kodetarif { get; set; }

    [Column("KdAkun")]
    [StringLength(8)]
    [Unicode(false)]
    public string Kdakun { get; set; }

    [Column("IdCoa")]
    public Ulid? IdCoa { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("IsTtd", TypeName = "text")]
    public string Ttd { get; set; }

    [Column("Pin", TypeName = "numeric(18, 2)")]
    public decimal? Pin { get; set; }

    [Column("NoSip")]
    [StringLength(50)]
    [Unicode(false)]
    public string Nosip { get; set; }

    [InverseProperty("KdDokterNavigation")]
    public virtual ICollection<M_Jadwaldokter> M_JadwalDokters { get; set; } = new List<M_Jadwaldokter>();

    [InverseProperty("KdDokterNavigation")]
    public virtual ICollection<M_User> M_Users { get; set; } = new List<M_User>();

    [ForeignKey("IdCoa")]
    [InverseProperty("M_Dokters")]
    public virtual M_Coa KdAkunNavigation { get; set; }
}
