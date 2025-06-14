﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_PasienRencanaRad")]
public partial class D_PasienRencanaRad
{
    [Key]
    [Column("IdRencanaKegiatan", TypeName = "numeric(18, 0)")]
    public decimal IdRencanaKegiatan { get; set; }

    [Column("Tgl", TypeName = "datetime")]
    public DateTime? Tgl { get; set; }

    [Column("Jam")]
    [StringLength(5)]
    [Unicode(false)]
    public string Jam { get; set; }

    [Column("IdPasien")]
    [StringLength(10)]
    [Unicode(false)]
    public string IdPasien { get; set; }

    [Column("NamaPasien")]
    [StringLength(100)]
    [Unicode(false)]
    public string NamaPasien { get; set; }

    [Column("Telepon")]
    [StringLength(50)]
    [Unicode(false)]
    public string Telepon { get; set; }

    [Column("KdDokter")]
    [StringLength(6)]
    [Unicode(false)]
    public string KdDokter { get; set; }

    [Column("NmDokter")]
    [StringLength(50)]
    [Unicode(false)]
    public string NmDokter { get; set; }

    [Column("Kelompok")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kelompok { get; set; }

    [Column("Kegiatan")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kegiatan { get; set; }

    [Column("Status")]
    [StringLength(1)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [ForeignKey("IdPasien")]
    [InverseProperty("TtPasienRencanaRads")]
    public virtual D_Pasien IdPasienNavigation { get; set; }
}
