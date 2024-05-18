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
    public Guid IdPaketkelas { get; set; }

    [Column("OldIdPaketkelas", TypeName = "numeric(18, 0)")]
    public decimal OldIdPaketkelas { get; set; }


    [Column("IdMasterPemeriksaanPenunjang")]
    public Guid IdMasterPemeriksaanPenunjang { get; set; }

    [Column("OldIdMasterPemeriksaanPenunjang", TypeName = "numeric(18, 0)")]
    public decimal OldIdMasterPemeriksaanPenunjang { get; set; }


    [Column("IdPenunjangDetail")]
    public Guid? IdPenunjangDetail { get; set; }

    [Column("OldIdPenunjangDetail", TypeName = "numeric(18, 0)")]
    public decimal? OldIdPenunjangDetail { get; set; }

    [Column("RekananId")]
    public Guid RekananId { get; set; }

    [Column("OldRekananid", TypeName = "numeric(18, 0)")]
    public decimal OldRekananId { get; set; }

    [Column("Kelas")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kelas { get; set; }

    [Column("Jumlah", TypeName = "decimal(18, 0)")]
    public decimal? DJumlah { get; set; }

    [Column("Harga", TypeName = "decimal(18, 0)")]
    public decimal? DHarga { get; set; }

    [Column("Cito", TypeName = "decimal(18, 0)")]
    public decimal? DCito { get; set; }

    [Column("Penyulit", TypeName = "decimal(18, 0)")]
    public decimal? DPenyulit { get; set; }

    [Column("SecondTnd", TypeName = "decimal(18, 0)")]
    public decimal? DSecondTnd { get; set; }

    [Column("Adm", TypeName = "decimal(18, 0)")]
    public decimal? DAdm { get; set; }

    [Column("Diskon", TypeName = "decimal(18, 0)")]
    public decimal? DDiskon { get; set; }

    [Column("Subtotal", TypeName = "decimal(18, 0)")]
    public decimal? DSubtotal { get; set; }

    [Column("Beapasien", TypeName = "decimal(18, 0)")]
    public decimal? DBeapasien { get; set; }

    [Column("Bearekanan", TypeName = "decimal(18, 0)")]
    public decimal? DBearekanan { get; set; }

    [Column("Jasamedis", TypeName = "decimal(18, 0)")]
    public decimal? DJasamedis { get; set; }

    [Column("Jasamedis2", TypeName = "decimal(18, 0)")]
    public decimal? DJasamedis2 { get; set; }

    [Column("Jasamedis3", TypeName = "decimal(18, 0)")]
    public decimal? DJasamedis3 { get; set; }

    [Column("Jasamedis4", TypeName = "decimal(18, 0)")]
    public decimal? DJasamedis4 { get; set; }

    [Column("Jasamedis5", TypeName = "decimal(18, 0)")]
    public decimal? DJasamedis5 { get; set; }

    [Column("JasaRS", TypeName = "decimal(18, 0)")]
    public decimal? DJasars { get; set; }

    [Column("BahanAlkes", TypeName = "decimal(18, 0)")]
    public decimal? DBahanalkes { get; set; }

    [Column("TglAwal", TypeName = "TIMESTAMP")]
    public DateTime? DTglawal { get; set; }

    [Column("TglAkhir", TypeName = "TIMESTAMP")]
    public DateTime? DTglakhir { get; set; }

    [Column("LastUpdate", TypeName = "TIMESTAMP")]
    public DateTime? DLastupdate { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }
}
