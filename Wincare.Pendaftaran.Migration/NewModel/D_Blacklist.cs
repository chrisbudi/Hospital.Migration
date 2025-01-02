

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Blacklist")]
public partial class D_Blacklist
{
    [Key]
    [Column("IdBlacklist", TypeName = "numeric(18, 0)")]
    public decimal IdBlacklist { get; set; }

    [Column("IdPasien")]
    [StringLength(10)]
    [Unicode(false)]
    public string IdPasien { get; set; }

    [Column("Tgl", TypeName = "datetime")]
    public DateTime? Tgl { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("Keterangan")]
    [StringLength(50)]
    [Unicode(false)]
    public string Keterangan { get; set; }
}
