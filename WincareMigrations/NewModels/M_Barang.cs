using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_Barang")]
[Index("Etiket", Name = "IX_M_Barang_Etiket")]
[Index("Farmakoterapi", Name = "IX_M_Barang_Farmakoterapi")]
[Index("BarangId", Name = "IX_M_Barang_IdBarang")]
[Index("Isaktif", Name = "IX_M_Barang_IsAktif")]
[Index("Isi", Name = "IX_M_Barang_Isi")]
[Index("Jenis", Name = "IX_M_Barang_Jenis")]
[Index("Kandungan", Name = "IX_M_Barang_Kandungan")]
[Index("Kemasan", Name = "IX_M_Barang_Kemasan")]
[Index("Kode", Name = "IX_M_Barang_Kode")]
[Index("Merk", Name = "IX_M_Barang_Merk")]
[Index("Nama", Name = "IX_M_Barang_Nama")]
[Index("Pabrik", Name = "IX_M_Barang_Pabrik")]
[Index("Satuan", Name = "IX_M_Barang_Satuan")]
[Index("Subfarmakoterapi", Name = "IX_M_Barang_SubFarmakoterapi")]
[Index("Tipebarang", Name = "IX_M_Barang_TipeBarang")]
[Index("Ukuran", Name = "IX_M_Barang_Ukuran")]
[Index("KelompokId", Name = "IX_M_Barang_kelompokId")]
public partial class M_Barang
{
    [Key]
    [Column("barangId")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid BarangId { get; set; }

    [Column("OldBarangId", TypeName = "numeric(18, 0)")]
    public decimal OldBarangId { get; set; }

    [Column("KelompokId", TypeName = "numeric(18, 0)")]
    public decimal? KelompokId { get; set; }

    [Required]
    [Column("kode")]
    [StringLength(10)]
    [Unicode(false)]
    public string Kode { get; set; }

    [Column("Nama")]
    [StringLength(100)]
    [Unicode(false)]
    public string Nama { get; set; }

    [Column("Satuan")]
    [StringLength(50)]
    [Unicode(false)]
    public string Satuan { get; set; }

    [Column("Merk")]
    [StringLength(50)]
    [Unicode(false)]
    public string Merk { get; set; }

    [Column("Ukuran")]
    [StringLength(50)]
    [Unicode(false)]
    public string Ukuran { get; set; }

    [Column("Jenis")]
    [StringLength(50)]
    [Unicode(false)]
    public string Jenis { get; set; }

    [Column("ExpiredDate", TypeName = "TIMESTAMP")]
    public DateTime? Expireddate { get; set; }

    [Column("Etiket")]
    [StringLength(50)]
    [Unicode(false)]
    public string Etiket { get; set; }

    [Column("Isi", TypeName = "decimal(18, 0)")]
    public decimal? Isi { get; set; }

    [Column("Kandungan")]
    [StringLength(200)]
    [Unicode(false)]
    public string Kandungan { get; set; }

    [Column("Kemasan")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kemasan { get; set; }

    [Column("Pabrik")]
    [StringLength(100)]
    [Unicode(false)]
    public string Pabrik { get; set; }

    [Column("TipeBarang")]
    [StringLength(1)]
    [Unicode(false)]
    public string Tipebarang { get; set; }

    [Column("Note")]
    [StringLength(500)]
    [Unicode(false)]
    public string Note { get; set; }

    [Column("Farmakoterapi")]
    [StringLength(200)]
    [Unicode(false)]
    public string Farmakoterapi { get; set; }

    [Column("SubFarmakoterapi")]
    [StringLength(200)]
    [Unicode(false)]
    public string Subfarmakoterapi { get; set; }

    [Column("IdFarmakoterapi", TypeName = "numeric(18, 0)")]
    public decimal? IdFarmakoterapi { get; set; }

    [Column("IdSubFarmakoterapi", TypeName = "numeric(18, 0)")]
    public decimal? IdSubfarmakoterapi { get; set; }

    [Column("HargaBeli", TypeName = "decimal(18, 2)")]
    public decimal? Hargabeli { get; set; }

    [Column("DiskonOn", TypeName = "decimal(18, 2)")]
    public decimal? Diskonon { get; set; }

    [Column("HargaJual", TypeName = "decimal(18, 2)")]
    public decimal? Hargajual { get; set; }

    [Column("DiskonOff", TypeName = "decimal(18, 2)")]
    public decimal? Diskonoff { get; set; }

    [Column("StokMin", TypeName = "decimal(18, 2)")]
    public decimal? Stokmin { get; set; }

    [Column("StokMax", TypeName = "decimal(18, 2)")]
    public decimal? Stokmax { get; set; }

    [Column("StokNow", TypeName = "decimal(18, 2)")]
    public decimal? Stoknow { get; set; }

    [Column("NoBatch")]
    [StringLength(50)]
    [Unicode(false)]
    public string Nobatch { get; set; }

    [Column("Timestamp")]
    public byte[] Timestamp { get; set; }

    [Column("IsAktif")]
    public bool? Isaktif { get; set; }

    [Column("IsFormularium")]
    public bool? Isformularium { get; set; }

    [Column("EtiketQty")]
    public bool? EtiketQty { get; set; }

    [ForeignKey("IdFarmakoterapi")]
    [InverseProperty("MBarangs")]
    public virtual M_Farmakoterapi IdFarmakoterapiNavigation { get; set; }

    [ForeignKey("IdSubfarmakoterapi")]
    [InverseProperty("MBarangs")]
    public virtual M_FarmakoterapiSub IdSubfarmakoterapiNavigation { get; set; }

    [ForeignKey("KelompokId")]
    [InverseProperty("MBarangs")]
    public virtual M_KelompokBarang Kelompok { get; set; }

    [InverseProperty("Barang")]
    public virtual ICollection<M_HargaBarang> M_Hargabarangs { get; set; } = new List<M_HargaBarang>();

    [InverseProperty("Barang")]
    public virtual ICollection<M_Hargarekanan> M_Hargarekanans { get; set; } = new List<M_Hargarekanan>();
}