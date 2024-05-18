using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_FarmakoterapiSub")]
public partial class M_FarmakoterapiSub
{
    [Key]
    [Column("IdSubFarmakoterapi", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdSubfarmakoterapi { get; set; }

    [Column("NmSubFarmakoterapi")]
    [StringLength(200)]
    [Unicode(false)]
    public string NmSubFarmakoterapi { get; set; }

    [Column("IdFarmakoterapi", TypeName = "numeric(18, 0)")]
    public decimal? IdFarmakoterapi { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [ForeignKey("IdFarmakoterapi")]
    [InverseProperty("M_FarmakoterapiSubs")]
    public virtual M_Farmakoterapi IdFarmakoterapiNavigation { get; set; }

    [InverseProperty("IdSubfarmakoterapiNavigation")]
    public virtual ICollection<M_Barang> MBarangs { get; set; } = new List<M_Barang>();
}