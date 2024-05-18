

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_RadiologiHarga")]
public partial class M_RadiologiHarga
{
    [Key]
    [Column("IdRadHarga", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdRadharga { get; set; }

    [Required]
    [Column("KdPemeriksaanRad")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdPemeriksaanRad { get; set; }

    [Column("IdPemeriksaanRad", TypeName = "numeric(18, 0)")]
    public decimal IdPemeriksaanRad { get; set; }

    [Column("RekananId", TypeName = "numeric(18, 0)")]
    public decimal Rekananid { get; set; }

    [Required]
    [Column("Kelas")]
    [StringLength(20)]
    [Unicode(false)]
    public string Kelas { get; set; }

    [Column("IdHargakamar", TypeName = "numeric(18, 0)")]
    public decimal? IdHargakamar { get; set; }

    [Column("Harga", TypeName = "decimal(18, 0)")]
    public decimal? DHarga { get; set; }

    [Column("BeaPasien", TypeName = "decimal(18, 0)")]
    public decimal? DBeapasien { get; set; }

    [Column("BeaRekanan", TypeName = "decimal(18, 0)")]
    public decimal? Bearekanan { get; set; }

    [Column("JasaMedis", TypeName = "decimal(18, 0)")]
    public decimal? Jasamedis { get; set; }

    [Column("JasaRS", TypeName = "decimal(18, 0)")]
    public decimal? Jasars { get; set; }

    [Column("BahanAlkes", TypeName = "decimal(18, 0)")]
    public decimal? BahanAlkes { get; set; }

    [Column("Diskon", TypeName = "decimal(18, 0)")]
    public decimal? DDiskon { get; set; }

    [Column("Cito", TypeName = "decimal(18, 0)")]
    public decimal? Cito { get; set; }

    [Column("Penyulit", TypeName = "decimal(18, 0)")]
    public decimal? Penyulit { get; set; }

    [Column("SecondTnd", TypeName = "decimal(18, 0)")]
    public decimal? DSecondTnd { get; set; }

    [Column("Adm", TypeName = "decimal(18, 0)")]
    public decimal? Adm { get; set; }

    [Column("Tglawal", TypeName = "TIMESTAMP")]
    public DateTime? Tglawal { get; set; }

    [Column("Tglakhir", TypeName = "TIMESTAMP")]
    public DateTime? DTglakhir { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string VBy { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [Column("Lastupdate", TypeName = "TIMESTAMP")]
    public DateTime? DLastupdate { get; set; }

    [ForeignKey("Rekananid")]
    [InverseProperty("M_RadiologiHargas")]
    public virtual M_Rekanan Rekanan { get; set; }

    [ForeignKey("IdPemeriksaanRad")]
    [InverseProperty("M_RadiologiHargas")]
    public virtual M_Radiologi KdpemeriksaanRadNavigation { get; set; }

    [ForeignKey("IdHargakamar")]
    [InverseProperty("M_RadiologiHargas")]
    public virtual M_Hargakamar KelasNavigation { get; set; }
}