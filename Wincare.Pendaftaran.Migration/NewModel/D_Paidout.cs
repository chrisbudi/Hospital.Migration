

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Wincare.Pendaftaran.Migration.NewModel;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Paidout")]
[Index("IdPaidout", Name = "IX_PAIDOUT")]
[Index("Tgl", Name = "IX_PAIDOUT_1")]
[Index("IdStatus", Name = "IX_PAIDOUT_2")]
[Index("Jumlah", Name = "IX_PAIDOUT_3")]
[Index("CaraBayar", Name = "IX_PAIDOUT_4")]
public partial class D_Paidout
{
    [Key]
    [Column("IdPaidout", TypeName = "numeric(18, 0)")]
    public decimal IdPaidout { get; set; }

    [Column("IdRegistrasi")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdRegistrasi { get; set; }

    [Column("IdPasien")]
    [StringLength(10)]
    [Unicode(false)]
    public string IdPasien { get; set; }

    [Column("NamaPasien")]
    [StringLength(100)]
    [Unicode(false)]
    public string NamaPasien { get; set; }

    [Column("Tgl", TypeName = "datetime")]
    public DateTime? Tgl { get; set; }

    [Column("Jumlah", TypeName = "decimal(18, 0)")]
    public decimal? Jumlah { get; set; }

    [Column("CaraBayar")]
    [StringLength(50)]
    [Unicode(false)]
    public string CaraBayar { get; set; }

    [Column("NoteBayar")]
    [StringLength(100)]
    [Unicode(false)]
    public string NoteBayar { get; set; }

    [Column("Keterangan")]
    [StringLength(500)]
    [Unicode(false)]
    public string Keterangan { get; set; }

    [Column("ApprovedBy")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApprovedBy { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("IdStatus")]
    public int? IdStatus { get; set; }

    [ForeignKey("IdRegistrasi")]
    [InverseProperty("TtPaidouts")]
    public virtual D_Kunjungan IdRegistrasiNavigation { get; set; }
}
