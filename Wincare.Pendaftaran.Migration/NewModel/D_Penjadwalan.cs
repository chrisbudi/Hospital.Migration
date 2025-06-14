﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Penjadwalan")]
public partial class D_Penjadwalan
{
    [Key]
    [Column("IdPenjadwalan", TypeName = "numeric(18, 0)")]
    public decimal IdPenjadwalan { get; set; }

    [Column("IdPasien")]
    [StringLength(10)]
    [Unicode(false)]
    public string IdPasien { get; set; }

    [Column("NamaPasien")]
    [StringLength(100)]
    [Unicode(false)]
    public string NamaPasien { get; set; }

    [Column("AlamatPasien")]
    [StringLength(300)]
    [Unicode(false)]
    public string AlamatPasien { get; set; }

    [Column("TelpPasien")]
    [StringLength(100)]
    [Unicode(false)]
    public string TelpPasien { get; set; }

    [Column("KdDokter")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdDokter { get; set; }

    [Column("KodeRuangan")]
    [StringLength(5)]
    [Unicode(false)]
    public string KodeRuangan { get; set; }

    [Column("TglJadwal", TypeName = "datetime")]
    public DateTime? TglJadwal { get; set; }

    [Column("Urut")]
    public int? Urut { get; set; }

    [Column("Jam")]
    [StringLength(5)]
    [Unicode(false)]
    public string Jam { get; set; }

    [Column("IdJadwal", TypeName = "numeric(18, 0)")]
    public decimal? IdJadwal { get; set; }

    [Column("TglInput", TypeName = "datetime")]
    public DateTime? TglInput { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("Status")]
    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("Ket")]
    [StringLength(100)]
    [Unicode(false)]
    public string Ket { get; set; }

    [ForeignKey("IdPasien")]
    [InverseProperty("TtPenjadwalans")]
    public virtual D_Pasien IdPasienNavigation { get; set; }
}
