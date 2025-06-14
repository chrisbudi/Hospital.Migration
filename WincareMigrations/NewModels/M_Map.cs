﻿

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_Map")]
public partial class M_Map
{
    [Key]
    [Column("IdMapid")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IdMapid { get; set; }

    [Column("NmMap")]
    [StringLength(50)]
    [Unicode(false)]
    public string Nmmap { get; set; }

    [Required]
    [Column("KodeRuangan")]
    [StringLength(5)]
    [Unicode(false)]
    public string KodeRuangan { get; set; }

    [Column("IdRuang")]
    public long? IdRuang { get; set; }

    [Column("Note")]
    [StringLength(200)]
    [Unicode(false)]
    public string Note { get; set; }

    [Column("Image", TypeName = "bytea")]
    public byte[] Image { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [InverseProperty("IdMap")]
    public virtual ICollection<M_Kamarinap> M_Kamarinaps { get; set; } = new List<M_Kamarinap>();

    [ForeignKey("IdRuang")]
    [InverseProperty("M_Maps")]
    public virtual M_Ruang KoderuanganNavigation { get; set; }
}