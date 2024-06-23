

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_Coa")]
[Index("IsAktif", Name = "IX_M_Coa_ISAKTIF")]
[Index("SaldoAwal", Name = "IX_M_Coa_SALDO")]
[Index("DC", Name = "IX_M_Coa_VDC")]
[Index("Kdakun", Name = "IX_M_Coa_VKDAKUN")]
[Index("NmAkun", Name = "IX_M_Coa_VNMAKUN")]
public partial class M_Coa
{
    [Key]
    [Column("IdCoa")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Ulid IdCoa { get; set; }

    [Column("OldIdCoa", TypeName = "numeric(18, 0)")]
    public decimal OldIdCoa { get; set; }

    [Column("Kdakun")]
    [StringLength(8)]
    [Unicode(false)]
    public string Kdakun { get; set; }

    [Column("NmAkun")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmAkun { get; set; }

    [Column("NmAkunAlias")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmAkunAlias { get; set; }

    [Column("DC")]
    [StringLength(50)]
    [Unicode(false)]
    public string DC { get; set; }

    [Column("TglSaldoAwal", TypeName = "timestamp")]
    public DateTime? DTglsaldoawal { get; set; }

    [Column("SaldoAwal", TypeName = "decimal(18, 0)")]
    public decimal? SaldoAwal { get; set; }

    [Column("Subklasifikasi")]
    public Ulid? IdSubklasifikasi { get; set; }

    [Column("OldSubklasifikasi", TypeName = "numeric(18, 0)")]
    public decimal? OldIdSubklasifikasi { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [ForeignKey("IdSubklasifikasi")]
    [InverseProperty("M_Coas")]
    public virtual M_CoaSubklasifikasi IdSubklasifikasiNavigation { get; set; }

    [InverseProperty("KdAkunNavigation")]
    public virtual ICollection<M_Dokter> M_Dokters { get; set; } = new List<M_Dokter>();
}