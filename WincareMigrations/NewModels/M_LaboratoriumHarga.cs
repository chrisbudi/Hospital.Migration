using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_LaboratoriumHarga")]
public partial class M_LaboratoriumHarga
{
    [Key]
    [Column("IdLabharga", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdLabharga { get; set; }

    [Required]
    [Column("KdPemeriksaanLab")]
    [StringLength(8)]
    [Unicode(false)]
    public string KdPemeriksaanLab { get; set; }

    [Column("IdPemeriksaanLab")]
    public long? IdPemeriksaanLab { get; set; }


    [Column("RekananId")]
    public long? RekananId { get; set; }

    [Required]
    [Column("Kelas")]
    [StringLength(20)]
    [Unicode(false)]
    public string Kelas { get; set; }

    [Column("IdHargakamar")]
    public long? IdHargakamar { get; set; }

    [Column("Harga", TypeName = "decimal(18, 0)")]
    public decimal? Harga { get; set; }

    [Column("Beapasien", TypeName = "decimal(18, 0)")]
    public decimal? Beapasien { get; set; }

    [Column("Bearekanan", TypeName = "decimal(18, 0)")]
    public decimal? Bearekanan { get; set; }

    [Column("Jasamedis", TypeName = "decimal(18, 0)")]
    public decimal? Jasamedis { get; set; }

    [Column("Jasars", TypeName = "decimal(18, 0)")]
    public decimal? Jasars { get; set; }

    [Column("Bahanalkes", TypeName = "decimal(18, 0)")]
    public decimal? Bahanalkes { get; set; }

    [Column("Diskon", TypeName = "decimal(18, 0)")]
    public decimal? Diskon { get; set; }

    [Column("Cito", TypeName = "decimal(18, 0)")]
    public decimal? Cito { get; set; }

    [Column("Penyulit", TypeName = "decimal(18, 0)")]
    public decimal? Penyulit { get; set; }

    [Column("SecondTnd", TypeName = "decimal(18, 0)")]
    public decimal? SecondTnd { get; set; }

    [Column("Adm", TypeName = "decimal(18, 0)")]
    public decimal? DAdm { get; set; }

    [Column("Tglawal", TypeName = "timestamp")]
    public DateTime? DTglawal { get; set; }

    [Column("Tglakhir", TypeName = "timestamp")]
    public DateTime? DTglakhir { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [Column("LastUpdate", TypeName = "timestamp")]
    public DateTime? DLastupdate { get; set; }

    [ForeignKey("RekananId")]
    [InverseProperty("M_LaboratoriumHargas")]
    public virtual M_Rekanan Rekanan { get; set; }

    [ForeignKey("IdPemeriksaanLab")]
    [InverseProperty("M_LaboratoriumHargas")]
    public virtual M_Laboratorium KdPemeriksaanlabNavigation { get; set; }

    [ForeignKey("IdHargakamar")]
    [InverseProperty("M_LaboratoriumHargas")]
    public virtual M_Hargakamar KelasNavigation { get; set; }
}

