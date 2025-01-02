using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wincare.Pendaftaran.Migration.NewModel;


[Table("D_Pengunjung")]
public partial class D_Pengunjung
{
    [Column("IdNumPengunjung", TypeName = "numeric(18, 0)")]
    public decimal IdNumPengunjung { get; set; }

    [Key]
    [Column("Idpengunjung")]
    [StringLength(10)]
    [Unicode(false)]
    public string IdPengunjung { get; set; }

    [Column("NamaPengunjung")]
    [StringLength(100)]
    [Unicode(false)]
    public string NamaPengunjung { get; set; }

    [Column("TglLahir", TypeName = "datetime")]
    public DateTime? TglLahir { get; set; }

    [Column("Alamat")]
    [StringLength(100)]
    [Unicode(false)]
    public string Alamat { get; set; }

    [Column("Kota")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kota { get; set; }

    [Column("Telp")]
    [StringLength(50)]
    [Unicode(false)]
    public string Telp { get; set; }

    [Column("Pekerjaan")]
    [StringLength(50)]
    [Unicode(false)]
    public string Pekerjaan { get; set; }

    [Column("AlamatPekerjaan")]
    [StringLength(100)]
    [Unicode(false)]
    public string AlamatPekerjaan { get; set; }

    [Column("TelpPekerjaan")]
    [StringLength(50)]
    [Unicode(false)]
    public string TelpPekerjaan { get; set; }

    [Column("JenisIdentitas")]
    [StringLength(50)]
    [Unicode(false)]
    public string JenisIdentitas { get; set; }

    [Column("NomorIdentitas")]
    [StringLength(50)]
    [Unicode(false)]
    public string NomorIdentitas { get; set; }

    [Column("NamaOrangDekat")]
    [StringLength(100)]
    [Unicode(false)]
    public string NamaOrangDekat { get; set; }

    [Column("AlamatOrangDekat")]
    [StringLength(50)]
    [Unicode(false)]
    public string AlamatOrangDekat { get; set; }

    [Column("TelpOrangDekat")]
    [StringLength(50)]
    [Unicode(false)]
    public string TelpOrangDekat { get; set; }

    [Column("Kunjungan")]
    public bool? Kunjungan { get; set; }

    [InverseProperty("IdpengunjungNavigation")]
    public virtual ICollection<D_HargaKunjungan> TthKunjungans { get; set; } = new List<D_HargaKunjungan>();
}
