using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;
[Table("M_PaketHarga")]
public partial class M_PaketHarga
{
    [Key]
    [Column("IdPaketkelas")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IdPaketkelas { get; set; }

    [Column("OldIdPaketkelas", TypeName = "numeric(18, 0)")]
    public decimal OldIdPaketkelas { get; set; }


    [Column("IdMasterPemeriksaanPenunjang")]
    public Ulid IdMasterPemeriksaanPenunjang { get; set; }

    [Column("OldIdMasterPemeriksaanPenunjang", TypeName = "numeric(18, 0)")]
    public decimal OldIdMasterPemeriksaanPenunjang { get; set; }


    [Column("IdPenunjangDetail")]
    public long? IdPenunjangDetail { get; set; }

    [Column("OldIdPenunjangDetail", TypeName = "numeric(18, 0)")]
    public decimal? OldIdPenunjangDetail { get; set; }

    [Column("RekananId")]
    public long RekananId { get; set; }

    [Column("OldRekananid", TypeName = "numeric(18, 0)")]
    public decimal OldRekananId { get; set; }

    [Column("Kelas")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kelas { get; set; }

    [Column("Jumlah", TypeName = "decimal(18, 0)")]
    public decimal? Jumlah { get; set; }

    [Column("Harga", TypeName = "decimal(18, 0)")]
    public decimal? Harga { get; set; }

    [Column("Cito", TypeName = "decimal(18, 0)")]
    public decimal? Cito { get; set; }

    [Column("Penyulit", TypeName = "decimal(18, 0)")]
    public decimal? DPenyulit { get; set; }

    [Column("SecondTnd", TypeName = "decimal(18, 0)")]
    public decimal? SecondTnd { get; set; }

    [Column("Adm", TypeName = "decimal(18, 0)")]
    public decimal? Adm { get; set; }

    [Column("Diskon", TypeName = "decimal(18, 0)")]
    public decimal? Diskon { get; set; }

    [Column("Subtotal", TypeName = "decimal(18, 0)")]
    public decimal? DSubtotal { get; set; }

    [Column("Beapasien", TypeName = "decimal(18, 0)")]
    public decimal? Beapasien { get; set; }

    [Column("Bearekanan", TypeName = "decimal(18, 0)")]
    public decimal? Bearekanan { get; set; }

    [Column("Jasamedis", TypeName = "decimal(18, 0)")]
    public decimal? Jasamedis { get; set; }

    [Column("Jasamedis2", TypeName = "decimal(18, 0)")]
    public decimal? Jasamedis2 { get; set; }

    [Column("Jasamedis3", TypeName = "decimal(18, 0)")]
    public decimal? Jasamedis3 { get; set; }

    [Column("Jasamedis4", TypeName = "decimal(18, 0)")]
    public decimal? Jasamedis4 { get; set; }

    [Column("Jasamedis5", TypeName = "decimal(18, 0)")]
    public decimal? Jasamedis5 { get; set; }

    [Column("JasaRS", TypeName = "decimal(18, 0)")]
    public decimal? JasaRS { get; set; }

    [Column("BahanAlkes", TypeName = "decimal(18, 0)")]
    public decimal? BahanAlkes { get; set; }

    [Column("TglAwal", TypeName = "timestamp")]
    public DateTime? Tglawal { get; set; }

    [Column("TglAkhir", TypeName = "timestamp")]
    public DateTime? Tglakhir { get; set; }

    [Column("LastUpdate", TypeName = "timestamp")]
    public DateTime? Lastupdate { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }
}
