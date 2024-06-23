using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace WincareMigrations.NewModels;

[Table("M_Supplier")]
[Index("Alamat", Name = "IX_M_Supplier_ALAMAT")]
[Index("IsAktif", Name = "IX_M_Supplier_ISAKTIF")]
[Index("NamaSupplier", Name = "IX_M_Supplier_NAMA")]
[Index("SupplierId", Name = "IX_M_Supplier_SUPPLIERID")]
[Index("KdAkun", Name = "IX_M_Supplier_V_KDAKUN")]
public partial class M_Supplier
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("SupplierId")]
    public long SupplierId { get; set; }

    [Column("NamaSupplier")]
    [StringLength(50)]
    [Unicode(false)]
    public string NamaSupplier { get; set; }

    [Column("Alamat")]
    [StringLength(500)]
    [Unicode(false)]
    public string Alamat { get; set; }

    [Column("Cp")]
    [StringLength(50)]
    [Unicode(false)]
    public string Cp { get; set; }

    [Column("Fax")]
    [StringLength(50)]
    [Unicode(false)]
    public string Fax { get; set; }

    [Column("Kota")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kota { get; set; }

    [Column("Telpon")]
    [StringLength(50)]
    [Unicode(false)]
    public string Telpon { get; set; }

    [Column("Note")]
    [StringLength(500)]
    [Unicode(false)]
    public string Note { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [Column("KdAkun")]
    [StringLength(50)]
    [Unicode(false)]
    public string KdAkun { get; set; }

    [InverseProperty("Supplier")]
    public virtual ICollection<M_HargaBarang> M_Hargabarangs { get; set; } = new List<M_HargaBarang>();
}
