using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_CountTraffic")]
public partial class M_CountTraffic
{
    [Key]
    [Column("IdCountTraffic")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Ulid Idcounttraffic { get; set; }

    [Column("OldIdCountTraffic")]
    public decimal OldIdcounttraffic { get; set; }


    [Column("Tanggal", TypeName = "TIMESTAMP")]
    public DateTime? Tanggal { get; set; }

    [Column("jam")]
    [StringLength(50)]
    [Unicode(false)]
    public string Jam { get; set; }

    [Column("Menu")]
    [StringLength(50)]
    [Unicode(false)]
    public string Menu { get; set; }

    [Column("SubMenu")]
    [StringLength(50)]
    [Unicode(false)]
    public string Submenu { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }
}