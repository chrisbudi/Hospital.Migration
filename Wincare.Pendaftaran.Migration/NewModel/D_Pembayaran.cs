using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Pembayaran")]
[Index("Tgl", Name = "IX_PEMBAYARAN")]
[Index("NomorByrPasien", Name = "IX_PEMBAYARAN_1")]
[Index("By", Name = "IX_PEMBAYARAN_2")]
[Index("Jumlah", Name = "IX_PEMBAYARAN_3")]
public partial class D_Pembayaran
{
    [Column("IdPembayaran", TypeName = "numeric(18, 0)")]
    public decimal IdPembayaran { get; set; }

    [Key]
    [Column("NomorByrPasien")]
    [StringLength(12)]
    [Unicode(false)]
    public string NomorByrPasien { get; set; }

    [Required]
    [Column("IdRegistrasi")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdRegistrasi { get; set; }

    [Column("Tgl", TypeName = "datetime")]
    public DateTime Tgl { get; set; }

    [Column("Jumlah", TypeName = "decimal(18, 0)")]
    public decimal? Jumlah { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }
}
