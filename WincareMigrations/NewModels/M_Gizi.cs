using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("M_Gizi")]
public partial class M_Gizi
{
    [Key]
    [Column("IdGizi")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid IdGizi { get; set; }


    [Column("OldIdGizi", TypeName = "numeric(18, 0)")]
    public decimal OldIdGizi { get; set; }

    [Column("Kdmakanan")]
    [StringLength(10)]
    [Unicode(false)]
    public string VKdmakanan { get; set; }

    [Column("Nmmakanan")]
    [StringLength(100)]
    [Unicode(false)]
    public string VNmmakanan { get; set; }

    [Column("Group")]
    [StringLength(50)]
    [Unicode(false)]
    public string VGroup { get; set; }

    [Column("Note")]
    [StringLength(200)]
    [Unicode(false)]
    public string VNote { get; set; }

    [Column("Kandungan")]
    [StringLength(200)]
    [Unicode(false)]
    public string VKandungan { get; set; }

    [Column("Energi", TypeName = "decimal(18, 0)")]
    public decimal? DEnergi { get; set; }

    [Column("Protein", TypeName = "decimal(18, 0)")]
    public decimal? DProtein { get; set; }

    [Column("Lemak", TypeName = "decimal(18, 0)")]
    public decimal? DLemak { get; set; }

    [Column("Kh", TypeName = "decimal(18, 0)")]
    public decimal? DKh { get; set; }

    [Column("Calsium", TypeName = "decimal(18, 0)")]
    public decimal? DCalsium { get; set; }

    [Column("Fosfor", TypeName = "decimal(18, 0)")]
    public decimal? DFosfor { get; set; }

    [Column("Fe", TypeName = "decimal(18, 0)")]
    public decimal? DFe { get; set; }

    [Column("Vita", TypeName = "decimal(18, 0)")]
    public decimal? DVita { get; set; }

    [Column("Vitb1", TypeName = "decimal(18, 0)")]
    public decimal? DVitb1 { get; set; }

    [Column("Vitc", TypeName = "decimal(18, 0)")]
    public decimal? DVitc { get; set; }

    [Column("Air", TypeName = "decimal(18, 0)")]
    public decimal? DAir { get; set; }

    [Column("Bdd", TypeName = "decimal(18, 0)")]
    public decimal? DBdd { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }
}