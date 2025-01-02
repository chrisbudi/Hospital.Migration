

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Kunjungan")]
[Index("IdRegistrasi", Name = "IX_KUNJUNGAN")]
[Index("IdPasien", Name = "IX_KUNJUNGAN_1")]
[Index("RekananId", Name = "IX_KUNJUNGAN_2")]
[Index("TujuanKunjungan", Name = "IX_KUNJUNGAN_3")]
[Index("TglPulang", Name = "IX_KUNJUNGAN_4")]
[Index("TglKunjungan", Name = "IX_KUNJUNGAN_5")]
[Index("IdNumKunjungan", Name = "IX_KUNJUNGAN_6")]
[Index("Cob", Name = "IX_KUNJUNGAN_cob")]
[Index("Batal", Name = "IX_KUNJUNGAN_isbatal")]
public partial class D_Kunjungan
{
    [Column("IdNumKunjungan", TypeName = "numeric(18, 0)")]
    public decimal IdNumKunjungan { get; set; }

    [Key]
    [Column("IdRegistrasi")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdRegistrasi { get; set; }

    [Required]
    [Column("IdPasien")]
    [StringLength(10)]
    [Unicode(false)]
    public string IdPasien { get; set; }

    [Column("TglKunjungan", TypeName = "datetime")]
    public DateTime? TglKunjungan { get; set; }

    [Column("VJamkunjungan")]
    [StringLength(12)]
    [Unicode(false)]
    public string VJamkunjungan { get; set; }

    [Column("TglPulang", TypeName = "datetime")]
    public DateTime? TglPulang { get; set; }

    [Column("TujuanKunjungan")]
    [StringLength(50)]
    [Unicode(false)]
    public string TujuanKunjungan { get; set; }

    [Column("Batal")]
    [StringLength(1)]
    [Unicode(false)]
    public string Batal { get; set; }

    [Column("AlasanBatal")]
    [StringLength(100)]
    [Unicode(false)]
    public string AlasanBatal { get; set; }

    [Column("RekananId", TypeName = "numeric(18, 0)")]
    public decimal RekananId { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("Ket")]
    [StringLength(100)]
    [Unicode(false)]
    public string Ket { get; set; }

    [Column("Otorisasi")]
    [StringLength(50)]
    [Unicode(false)]
    public string Otorisasi { get; set; }

    [Column("TglOtorisasi", TypeName = "datetime")]
    public DateTime? TglOtorisasi { get; set; }

    [Column("IdStatus")]
    public int? IdStatus { get; set; }

    [Column("Transaksi", TypeName = "decimal(18, 0)")]
    public decimal? Transaksi { get; set; }

    [Column("Umur")]
    [StringLength(50)]
    [Unicode(false)]
    public string Umur { get; set; }

    [Column("Cob")]
    public bool? Cob { get; set; }

    [Column("NomorSep")]
    [StringLength(50)]
    [Unicode(false)]
    public string NomorSep { get; set; }

    [ForeignKey("IdPasien")]
    [InverseProperty("TtKunjungans")]
    public virtual D_Pasien IdPasienNavigation { get; set; }

    [ForeignKey("RekananId")]
    [InverseProperty("TtKunjungans")]
    public virtual D_Rekanan Rekanan { get; set; }

    [InverseProperty("IdRegistrasiNavigation")]
    public virtual ICollection<D_Betinap> TtBetinaps { get; set; } = new List<D_Betinap>();

    [InverseProperty("IdRegistrasiNavigation")]
    public virtual ICollection<D_HasilDeposit> TtDeposits { get; set; } = new List<D_HasilDeposit>();

    [InverseProperty("IdRegistrasiNavigation")]
    public virtual ICollection<D_Paidout> TtPaidouts { get; set; } = new List<D_Paidout>();

    [InverseProperty("IdRegistrasiNavigation")]
    public virtual ICollection<D_Paket> TtPakets { get; set; } = new List<D_Paket>();

    [InverseProperty("IdRegistrasiNavigation")]
    public virtual ICollection<D_Pasienlab> TtPasienlabs { get; set; } = new List<D_Pasienlab>();

    [InverseProperty("IdRegistrasiNavigation")]
    public virtual ICollection<D_Pasienrad> TtPasienrads { get; set; } = new List<D_Pasienrad>();

    [InverseProperty("IdRegistrasiNavigation")]
    public virtual ICollection<D_Pasienugd> TtPasienugds { get; set; } = new List<D_Pasienugd>();

    [InverseProperty("IdRegistrasiNavigation")]
    public virtual ICollection<D_Tindakan> TtTindakans { get; set; } = new List<D_Tindakan>();
}
