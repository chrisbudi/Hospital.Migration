using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Acountpasien")] //TtAcountpasien
public partial class D_Accountpasien
{
    [Key]
    [Column("IdAcountPasien")]
    public Ulid IdAcountPasien { get; set; }

    [Required]
    [Column("IdRegistrasi")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdRegistrasi { get; set; }

    [Required]
    [Column("Item")]
    [StringLength(250)]
    [Unicode(false)]
    public string Item { get; set; }

    [Column("Biaya", TypeName = "decimal(18, 0)")]
    public decimal? Biaya { get; set; }

    [Column("Paket")]
    [StringLength(250)]
    [Unicode(false)]
    public string Paket { get; set; }

    [Column("Unit")]
    [StringLength(150)]
    [Unicode(false)]
    public string Unit { get; set; }

    [Column("Disc", TypeName = "decimal(18, 0)")]
    public decimal? Disc { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("Tgl", TypeName = "datetime")]
    public DateTime? Tgl { get; set; }
    //DISINI APPROVE
    [Column("C_APPROVE_VER")]
    [StringLength(1)]
    [Unicode(false)]
    public string CApproveVer { get; set; }

    [Column("V_APPROVE_VER")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApproveVer { get; set; }

    [Column("D_APPROVE_VER", TypeName = "datetime")]
    public DateTime? DApproveVer { get; set; }

    [Column("ID_STATUS")]
    public int? IdStatus { get; set; }
}
