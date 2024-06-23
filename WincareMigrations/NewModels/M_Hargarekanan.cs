

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_HargaRekanan")]
[Index("BarangId", Name = "IX_M_HargaRekanan_barangId")]
[Index("Harga", Name = "IX_M_HargaRekanan_harga")]
[Index("Hargajual", Name = "IX_M_HargaRekanan_hargaJual")]
[Index("IdHargaRekanan", Name = "IX_M_HargaRekanan_idHargaRekanan")]
[Index("IsAktif", Name = "IX_M_HargaRekanan_isAktif")]
[Index("LastUpdate", Name = "IX_M_HargaRekanan_lastUpdate")]
[Index("RekananId", Name = "IX_M_HargaRekanan_rekananId")]
public partial class M_Hargarekanan
{
    [Key]
    [Column("IdHargaRekanan")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IdHargaRekanan { get; set; }

    [Column("OldIdHargaRekanan", TypeName = "numeric(18, 0)")]
    public decimal OldIdHargaRekanan { get; set; }

    [Column("OldBarangId", TypeName = "numeric(18, 0)")]
    public decimal? OldBarangId { get; set; }

    [Column("BarangId")]
    public Ulid? BarangId { get; set; }


    [Column("RekananId")]
    public long? RekananId { get; set; }


    [Column("Harga", TypeName = "decimal(19, 2)")]
    public decimal? Harga { get; set; }

    [Column("LastUpdate", TypeName = "timestamp")]
    public DateTime? LastUpdate { get; set; }

    [Column("InpuBy")]
    [StringLength(50)]
    [Unicode(false)]
    public string InpuBy { get; set; }

    [Column("Margin", TypeName = "decimal(18, 0)")]
    public decimal? Margin { get; set; }

    [Column("Diskon", TypeName = "decimal(18, 0)")]
    public decimal? Diskon { get; set; }

    [Column("Ppn", TypeName = "decimal(18, 0)")]
    public decimal? Ppn { get; set; }

    [Column("Hargajual", TypeName = "decimal(18, 0)")]
    public decimal? Hargajual { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [ForeignKey("BarangId")]
    [InverseProperty("M_Hargarekanans")]
    public virtual M_Barang Barang { get; set; }

    [ForeignKey("RekananId")]
    [InverseProperty("M_Hargarekanans")]
    public virtual M_Rekanan Rekanan { get; set; }
}