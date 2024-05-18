using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_Farmakoterapi")]
public partial class M_Farmakoterapi
{
    [Key]
    [Column("IdFarmakoterapi")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdFarmakoterapi { get; set; }

    [Column("Nmfarmakoterapi")]
    [StringLength(200)]
    [Unicode(false)]
    public string Nmfarmakoterapi { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [InverseProperty("IdFarmakoterapiNavigation")]
    public virtual ICollection<M_Barang> MBarangs { get; set; } = new List<M_Barang>();

    [InverseProperty("IdFarmakoterapiNavigation")]
    public virtual ICollection<M_FarmakoterapiSub> M_FarmakoterapiSubs { get; set; } = new List<M_FarmakoterapiSub>();
}