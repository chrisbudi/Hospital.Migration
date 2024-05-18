using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_AsalGroup")]
[Index("IdAsalGroup", Name = "IX_M_AsalGroup_IdAsalGroup")]
[Index("IsAktif", Name = "IX_M_AsalGroup_IS_Aktif")]
[Index("NamaGroupAsal", Name = "IX_M_AsalGroup_NamaGroupAsal")]
public partial class M_AsalGroup
{
    [Key]
    [Column("IdAsalGroup")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdAsalGroup { get; set; }

    [Column("NamaGroupAsal")]
    [StringLength(50)]
    [Unicode(false)]
    public string NamaGroupAsal { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [InverseProperty("IdAsalgroupNavigation")]
    public virtual ICollection<M_Asal> MAsals { get; set; } = new List<M_Asal>();
}