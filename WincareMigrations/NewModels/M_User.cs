

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_User")]
public partial class M_User
{
    [Key]
    [Column("IdUser")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Ulid Iduser { get; set; }

    [Column("OldIdUser", TypeName = "numeric(18, 0)")]
    public decimal OldIduser { get; set; }

    [Required]
    [Column("KodeRuangan")]
    [StringLength(5)]
    [Unicode(false)]
    public string KodeRuangan { get; set; }

    [Column("IdRuang")]
    public long? IdRuang { get; set; }

    [Column("Namalengkap")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Namalengkap { get; set; }

    [Column("Nmuser")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nmuser { get; set; }

    [Column("Password")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Password { get; set; }

    [Column("KdDokter")]
    [StringLength(6)]
    [Unicode(false)]
    public string? KdDokter { get; set; }

    [Column("IdDokter", TypeName = "decimal(18,0)")]
    public decimal? IdDokter { get; set; }

    [Column("IsUser")]
    public bool? IsUser { get; set; }

    [Column("IsManager")]
    public bool? IsManager { get; set; }

    [Column("IsAdmin")]
    public bool? IsAdmin { get; set; }

    [Column("IsMod")]
    public bool? IsMod { get; set; }

    [Column("IsDokter")]
    public bool? IsDokter { get; set; }

    [Column("IsMemo")]
    public bool? IsMemo { get; set; }

    [Column("IdGroupUser", TypeName = "numeric(18, 0)")]
    public decimal? IdGroupUser { get; set; }

    [Column("Ttd", TypeName = "text")]
    public string? Ttd { get; set; }

    [Column("Isaktif")]
    public bool? IsAktif { get; set; }

    [Column("Id")]
    [StringLength(128)]
    public string Id { get; set; }

    public bool? Transmigrated { get; set; }

    [Column("IdKaryawan")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IdKaryawan { get; set; }

    [Column("PIN", TypeName = "numeric(10, 2)")]
    public decimal? Pin { get; set; }

    [ForeignKey("IdGroupUser")]
    [InverseProperty("M_Users")]
    public virtual M_UserGroup IdGroupuserNavigation { get; set; }

    [ForeignKey("IdDokter")]
    [InverseProperty("M_Users")]
    public virtual M_Dokter KdDokterNavigation { get; set; }

    [ForeignKey("IdRuang")]
    [InverseProperty("M_Users")]
    public virtual M_Ruang KoderuanganNavigation { get; set; }
}