

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

using Wincare.Pendaftaran.Migration.NewModel;

namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Tarifdetail")]
public partial class D_Tarifdetail
{
    [Column("IdTarifDetail", TypeName = "numeric(18, 0)")]
    public decimal IdTarifDetail { get; set; }

    [Column("KodeTarifLayan")]
    [StringLength(2)]
    [Unicode(false)]
    public string KodeTarifLayan { get; set; }

    [Key]
    [Column("KdTarifDetail")]
    [StringLength(10)]
    [Unicode(false)]
    public string KdTarifDetail { get; set; }

    [Required]
    [Column("NmTarifDetail")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmTarifDetail { get; set; }

    [Column("Aktif")]
    public bool? Aktif { get; set; }

    [Column("IdGroupTarif", TypeName = "numeric(18, 0)")]
    public decimal? IdGroupTarif { get; set; }

    [ForeignKey("IdGroupTarif")]
    [InverseProperty("TmTarifdetails")]
    public virtual D_TarifGroup IdGroupTarifNavigation { get; set; }
}
