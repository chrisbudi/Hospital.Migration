using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;
[Table("M_ObatUnit")]
[Index("BarangId", Name = "IX_M_ObatUnit_barangid")]
[Index("ExpiredDate", Name = "IX_M_ObatUnit_d_expireddate")]
[Index("StokMax", Name = "IX_M_ObatUnit_d_stokmax")]
[Index("StokMin", Name = "IX_M_ObatUnit_d_stokmin")]
[Index("StokNow", Name = "IX_M_ObatUnit_d_stoknow")]
[Index("IdObatUnit", Name = "IX_M_ObatUnit_id_obatunit")]
[Index("IsAktif", Name = "IX_M_ObatUnit_is_aktif")]
[Index("KodeInventory", Name = "IX_M_ObatUnit_v_kdinventory")]
[Index("KdObat", Name = "IX_M_ObatUnit_v_kdobat")]
[Index("Rod", Name = "IX_M_ObatUnit_v_rod")]
[Index("NmObat", Name = "IX_M_ObatUnit_vnmobat")]
public partial class M_Obatunit
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("IdObatUnit", TypeName = "numeric(18, 0)")]
    public decimal IdObatUnit { get; set; }

    [Column("BarangId")]
    public Guid? BarangId { get; set; }

    [Column("OldBarangId", TypeName = "numeric(18, 0)")]
    public decimal? OldBarangId { get; set; }

    [Column("KdObat")]
    [StringLength(10)]
    [Unicode(false)]
    public string KdObat { get; set; }

    [Column("NmObat")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmObat { get; set; }

    [Column("KodeInventory")]
    [StringLength(2)]
    [Unicode(false)]
    public string KodeInventory { get; set; }

    [Column("ExpiredDate", TypeName = "TIMESTAMP")]
    public DateTime? ExpiredDate { get; set; }

    [Column("StokMin", TypeName = "decimal(18, 0)")]
    public decimal? StokMin { get; set; }

    [Column("StokMax", TypeName = "decimal(18, 0)")]
    public decimal? StokMax { get; set; }

    [Column("StokNow", TypeName = "decimal(18, 0)")]
    public decimal? StokNow { get; set; }

    [Column("Rod")]
    public bool? Rod { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }
}