using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_Bank")]
public partial class M_Bank
{
    [Key]
    [Column("IdBank")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid IdBank { get; set; }

    [Column("OldIdBank", TypeName = "numeric(18, 0)")]
    public decimal OldIdBank { get; set; }

    [Column("Kdbank")]
    [StringLength(5)]
    [Unicode(false)]
    public string KdBank { get; set; }

    [Column("NmBank")]
    [StringLength(50)]
    [Unicode(false)]
    public string NmBank { get; set; }

    [Column("Cabang")]
    [StringLength(50)]
    [Unicode(false)]
    public string Cabang { get; set; }

    [Column("Alamat")]
    [StringLength(50)]
    [Unicode(false)]
    public string Alamat { get; set; }

    [Column("Kota")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kota { get; set; }

    [Column("Telepon")]
    [StringLength(50)]
    [Unicode(false)]
    public string Telepon { get; set; }

    [Column("IsAktif")]
    public bool IsAktif { get; set; }

    [Column("NomorRekening")]
    [StringLength(50)]
    [Unicode(false)]
    public string NomorRekening { get; set; }

    [Column("KdAkun")]
    [StringLength(8)]
    [Unicode(false)]
    public string KdAkun { get; set; }
}