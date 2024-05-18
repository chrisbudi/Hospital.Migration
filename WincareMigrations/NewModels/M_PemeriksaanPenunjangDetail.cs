

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_PemeriksaanPenunjangDetail")]
public partial class M_PemeriksaanPenunjangDetail
{
    [Key]
    [Column("IdPenunjangDetail", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdPenunjangDetail { get; set; }

    [Column("IdMasterPemeriksaanPenunjang", TypeName = "numeric(18, 0)")]
    public decimal? IdMasterPemeriksaanPenunjang { get; set; }

    [Column("KdPemeriksaan")]
    [StringLength(8)]
    [Unicode(false)]
    public string KdPemeriksaan { get; set; }

    [Column("KdDetail")]
    [StringLength(10)]
    [Unicode(false)]
    public string KdDetail { get; set; }

    [Column("NmDetail")]
    [StringLength(200)]
    [Unicode(false)]
    public string NmDetail { get; set; }

    [Column("Group")]
    [StringLength(50)]
    [Unicode(false)]
    public string Group { get; set; }

    [Column("Tipe")]
    [StringLength(50)]
    [Unicode(false)]
    public string Tipe { get; set; }

    [Column("Jumlah", TypeName = "decimal(18, 0)")]
    public decimal? Jumlah { get; set; }

    [Column("Harga", TypeName = "decimal(18, 0)")]
    public decimal? Harga { get; set; }

    [Column("BeaPasien", TypeName = "decimal(18, 0)")]
    public decimal? BeaPasien { get; set; }

    [Column("BeaRekanan", TypeName = "decimal(18, 0)")]
    public decimal? BeaRekanan { get; set; }

    [Column("KodeTarif")]
    [StringLength(10)]
    [Unicode(false)]
    public string KodeTarif { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [ForeignKey("IdMasterPemeriksaanPenunjang")]
    [InverseProperty("M_PemeriksaanPenunjangDetails")]
    public virtual M_PemeriksaanPenunjang IdMasterPemeriksaanPenunjangNavigation { get; set; }

}