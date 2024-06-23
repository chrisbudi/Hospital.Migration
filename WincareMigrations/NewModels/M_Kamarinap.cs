using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WincareMigrations.NewModels;

[Table("M_Kamarinap")]
[Index("KdTmpTidur", Name = "IX_TM_KAMARINAP_kdtmptidur")]
[Index("Lantai", Name = "IX_TM_KAMARINAP_lantai")]
public partial class M_Kamarinap
{
    [Key]
    [Column("IdKamarInap")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IdKamarinap { get; set; }

    [Column("KdTmpTidur")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdTmpTidur { get; set; }

    [Required]
    [Column("Kelas")]
    [StringLength(20)]
    [Unicode(false)]
    public string Kelas { get; set; }


    [Column("IdHargakamar")]
    public long? IdHargakamar { get; set; }

    [Column("Lantai")]
    [StringLength(6)]
    [Unicode(false)]
    public string Lantai { get; set; }

    [Column("Nokamar")]
    [StringLength(6)]
    [Unicode(false)]
    public string Nokamar { get; set; }

    [Column("KodeTarif")]
    [StringLength(2)]
    [Unicode(false)]
    public string KodeTarif { get; set; }

    [Column("KodeRuangan")]
    [StringLength(5)]
    [Unicode(false)]
    public string KodeRuangan { get; set; }

    [Column("Isi")]
    [StringLength(1)]
    [Unicode(false)]
    public string Isi { get; set; }

    [Column("IX")]
    public int? IX { get; set; }

    [Column("IY")]
    public int? IY { get; set; }

    [Column("IdMapid")]
    public long? IdMapid { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [ForeignKey("IdMapid")]
    [InverseProperty("M_Kamarinaps")]
    public virtual M_Map IdMap { get; set; }

    [InverseProperty("KdtmptidurNavigation")]
    public virtual ICollection<M_KamarinapHarga> M_KamarInapHargas { get; set; } = new List<M_KamarinapHarga>();

    [ForeignKey("IdHargakamar")]
    [InverseProperty("M_Kamarinaps")]
    public virtual M_Hargakamar KelasNavigation { get; set; }
}
