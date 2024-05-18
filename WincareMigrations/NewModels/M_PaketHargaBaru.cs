using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_PaketHargaBaru")]
public partial class M_PaketHargaBaru
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("IdPaketkelas", TypeName = "numeric(18, 0)")]
    public decimal IdPaketkelas { get; set; }

    [Column("IdMasterPemeriksaanPenunjang")]
    public Guid IdMasterPemeriksaanPenunjang { get; set; }

    [Column("OldIdMasterPemeriksaanPenunjang", TypeName = "numeric(18, 0)")]
    public decimal OldIdMasterPemeriksaanPenunjang { get; set; }

    [Column("IdPenunjangDetail")]
    public Guid? IdPenunjangDetail { get; set; }

    [Column("OldIdPenunjangDetail", TypeName = "numeric(18, 0)")]
    public decimal? OldIdPenunjangDetail { get; set; }

    [Column("RekananId")]
    public Guid Rekananid { get; set; }

    [Column("OldRekananId", TypeName = "numeric(18, 0)")]
    public decimal OldRekananid { get; set; }

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
    public decimal? Penyulit { get; set; }

    [Column("SecondTnd", TypeName = "decimal(18, 0)")]
    public decimal? SecondTnd { get; set; }

    [Column("Adm", TypeName = "decimal(18, 0)")]
    public decimal? Adm { get; set; }

    [Column("Diskon", TypeName = "decimal(18, 0)")]
    public decimal? Diskon { get; set; }

    [Column("Subtotal", TypeName = "decimal(18, 0)")]
    public decimal? Subtotal { get; set; }

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
    public decimal? Jasars { get; set; }

    [Column("Bahanalkes", TypeName = "decimal(18, 0)")]
    public decimal? Bahanalkes { get; set; }

    [Column("Tglawal", TypeName = "TIMESTAMP")]
    public DateTime? Tglawal { get; set; }

    [Column("Tglakhir", TypeName = "TIMESTAMP")]
    public DateTime? Tglakhir { get; set; }

    [Column("Lastupdate", TypeName = "TIMESTAMP")]
    public DateTime? Lastupdate { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }
}
