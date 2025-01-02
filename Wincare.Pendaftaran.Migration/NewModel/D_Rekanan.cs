using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Rekanan")]
[Index("IdNumRekanan", Name = "IX_REKANAN")]
[Index("RekananId", Name = "IX_REKANAN_1")]
[Index("NmRekanan", Name = "IX_REKANAN_2")]
[Index("Aktif", Name = "IX_REKANAN_3")]
[Index("Alias", Name = "IX_REKANAN_4")]
public partial class D_Rekanan
{
    [Column("IdNumRekanan", TypeName = "numeric(18, 0)")]
    public decimal IdNumRekanan { get; set; }

    [Key]
    [Column("RekananId", TypeName = "numeric(18, 0)")]
    public decimal RekananId { get; set; }

    [Column("NmRekanan")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmRekanan { get; set; }

    [Column("Alamat")]
    [StringLength(200)]
    [Unicode(false)]
    public string Alamat { get; set; }

    [Column("Kota")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kota { get; set; }

    [Column("Telp")]
    [StringLength(100)]
    [Unicode(false)]
    public string Telp { get; set; }

    [Column("Alias")]
    [StringLength(50)]
    [Unicode(false)]
    public string Alias { get; set; }

    [Column("Aktif")]
    public bool? Aktif { get; set; }

    [Column("KdAkun")]
    [StringLength(8)]
    [Unicode(false)]
    public string KdAkun { get; set; }

    [Column("PaketBhp")]
    public bool? PaketBhp { get; set; }

    [Column("Tarif")]
    public bool? Tarif { get; set; }

    [Column("TarifNonmed")]
    public bool? TarifNonmed { get; set; }

    [Column("Cob")]
    public bool? Cob { get; set; }

    [InverseProperty("Rekanan")]
    public virtual ICollection<D_Pasien> TmPasiens { get; set; } = new List<D_Pasien>();

    [InverseProperty("Rekanan")]
    public virtual ICollection<D_Kunjungan> TtKunjungans { get; set; } = new List<D_Kunjungan>();

    [InverseProperty("Rekanan")]
    public virtual ICollection<D_HargaKunjungan> TthKunjungans { get; set; } = new List<D_HargaKunjungan>();
}
