

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_StandartfieldGroup")]
public partial class M_StandartfieldGroup
{
    [Key]
    [Column("IdFieldgroup", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdFieldgroup { get; set; }

    [Column("Nmfieldgroup")]
    [StringLength(50)]
    [Unicode(false)]
    public string VNmfieldgroup { get; set; }

    [Column("DTanggal", TypeName = "timestamp")]
    public DateTime? DTanggal { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [Column("VKeterangan")]
    [StringLength(50)]
    [Unicode(false)]
    public string VKeterangan { get; set; }

    [InverseProperty("IdFieldgroupNavigation")]
    public virtual ICollection<M_Standartfield> M_Standartfields { get; set; } = new List<M_Standartfield>();
}