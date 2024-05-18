using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_MasterTnd")]
public partial class M_MasterTnd
{
    [Key]
    [Column("IdGroupTarif")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public double? IdGrouptarif { get; set; }

    [Column("NmgroupTarif")]
    [StringLength(255)]
    public string VNmgrouptarif { get; set; }

    [Column("KdTarifDetail")]
    [StringLength(255)]
    public string VKdtarifdetail { get; set; }

    [Column("NmTarifDetail")]
    [StringLength(255)]
    public string VNmtarifdetail { get; set; }

    [Column("Kelas")]
    [StringLength(255)]
    public string VKelas { get; set; }

    [Column("Harga")]
    public double? DHarga { get; set; }

    [Column("IsAktif")]
    public double? IsAktif { get; set; }

    [Column("HargaBpjs")]
    public double? DHargaBpjs { get; set; }
}