

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_HargaBarang")]
[Index("BarangId", Name = "IX_M_HargaBarang_barangId")]
[Index("DiskonOff", Name = "IX_M_HargaBarang_diskonOff")]
[Index("DiskonOn", Name = "IX_M_HargaBarang_diskonOn")]
[Index("Harga", Name = "IX_M_HargaBarang_harga")]
[Index("IsAktif", Name = "IX_M_HargaBarang_IsAktif")]
[Index("LastUpdate", Name = "IX_M_HargaBarang_lastupdate")]
[Index("Ppn", Name = "IX_M_HargaBarang_ppn")]
[Index("SupplierId", Name = "IX_M_HargaBarang_supplierId")]
public partial class M_HargaBarang
{
    [Key]
    [Column("IdHargaBeli")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Ulid Idhargabeli { get; set; }


    [Column("OldIdHargaBeli", TypeName = "numeric(18, 0)")]
    public decimal OldIdhargabeli { get; set; }

    [Column("BarangId")]
    public Ulid? BarangId { get; set; }

    [Column("OldBarangId", TypeName = "numeric(18, 0)")]
    public decimal? OldBarangId { get; set; }

    [Column("SupplierId")]
    public long? SupplierId { get; set; }

    [Column("LastUpdate", TypeName = "timestamp")]
    public DateTime? LastUpdate { get; set; }

    [Column("Harga", TypeName = "decimal(18, 0)")]
    public decimal? Harga { get; set; }

    [Column("InputBy")]
    [StringLength(50)]
    [Unicode(false)]
    public string InputBy { get; set; }

    [Column("DiskonOn", TypeName = "decimal(18, 2)")]
    public decimal? DiskonOn { get; set; }

    [Column("DiskonOff", TypeName = "decimal(18, 2)")]
    public decimal? DiskonOff { get; set; }

    [Column("PPN", TypeName = "decimal(18, 0)")]
    public decimal? Ppn { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [ForeignKey("BarangId")]
    [InverseProperty("M_Hargabarangs")]
    public virtual M_Barang Barang { get; set; }

    [ForeignKey("SupplierId")]
    [InverseProperty("M_Hargabarangs")]
    public virtual M_Supplier Supplier { get; set; }
}