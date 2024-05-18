using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_Asal")]
[Index("IdAsal", Name = "IX_M_Asal_IdAsal")]
[Index("IdAsalGroup", Name = "IX_M_Asal_IdAsalgroup")]
[Index("IsAktif", Name = "IX_M_Asal_IsAktif")]
[Index("KdAsal", Name = "IX_M_Asal_Kdasal")]
[Index("NmAsal", Name = "IX_M_Asal_Nmasal")]
public partial class M_Asal
{

    [Key]
    [Column("IdAsal")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IdAsal { get; set; }


    [Column("IdAsalGroup")]
    public int? IdAsalGroup { get; set; }

    [Column("Kdasal")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdAsal { get; set; }

    [Required]
    [Column("NmAsal")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmAsal { get; set; }

    [Column("IsAktif")]
    public bool IsAktif { get; set; }

    [ForeignKey("IdAsalGroup")]
    [InverseProperty("MAsals")]
    public virtual M_AsalGroup IdAsalgroupNavigation { get; set; }
}