using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Dokter")]
[Index("Kddokter", Name = "IX_DOKTER")]
[Index("Nmdokter", Name = "IX_DOKTER_1")]
public partial class D_Dokter
{
    [Column("IdDokter", TypeName = "numeric(18, 0)")]
    public decimal IdDokter { get; set; }

    [Key]
    [Column("KdDokter")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdDokter { get; set; }

    [Column("NmDokter")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmDokter { get; set; }

    [Column("SpesialisasiDokter")]
    [StringLength(60)]
    [Unicode(false)]
    public string SpesialisasiDokter { get; set; }

    [Column("AlamatDokter")]
    [StringLength(200)]
    [Unicode(false)]
    public string AlamatDokter { get; set; }

    [Column("TelpDokter")]
    [StringLength(100)]
    [Unicode(false)]
    public string TelpDokter { get; set; }

    [Column("AlamatPraktek")]
    [StringLength(200)]
    [Unicode(false)]
    public string AlamatPraktek { get; set; }

    [Column("TelpPraktek")]
    [StringLength(100)]
    [Unicode(false)]
    public string TelpPraktek { get; set; }

    [Column("Aktif")]
    public bool? Aktif { get; set; }

    [Column("FotoDokter")]
    [StringLength(100)]
    [Unicode(false)]
    public string FotoDokter { get; set; }

    [Column("KodeTarif")]
    [StringLength(2)]
    [Unicode(false)]
    public string KodeTarif { get; set; }

    [Column("KdAkun")]
    [StringLength(8)]
    [Unicode(false)]
    public string KdAkun { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("Ttd", TypeName = "text")]
    public string Ttd { get; set; }

    [Column("Pin", TypeName = "numeric(18, 2)")]
    public decimal? Pin { get; set; }

    [Column("NoSip")]
    [StringLength(50)]
    [Unicode(false)]
    public string NoSip { get; set; }

    [InverseProperty("VKddokterNavigation")]
    public virtual ICollection<D_JadwalDokter> TmJadwaldokters { get; set; } = new List<D_JadwalDokter>();

    [InverseProperty("VKddokterNavigation")]
    public virtual ICollection<D_Kuitansiresep> TtKuitansireseps { get; set; } = new List<D_Kuitansiresep>();

    [InverseProperty("VKddokterNavigation")]
    public virtual ICollection<D_Pasienlab> TtPasienlabVKddokterNavigations { get; set; } = new List<D_Pasienlab>();

    [InverseProperty("VKddokterpjawabNavigation")]
    public virtual ICollection<D_Pasienlab> TtPasienlabVKddokterpjawabNavigations { get; set; } = new List<D_Pasienlab>();

    [InverseProperty("VKddokterNavigation")]
    public virtual ICollection<D_Pasienrad> TtPasienrads { get; set; } = new List<D_Pasienrad>();

    [InverseProperty("VKddokterNavigation")]
    public virtual ICollection<D_Pasienugd> TtPasienugds { get; set; } = new List<D_Pasienugd>();
}
