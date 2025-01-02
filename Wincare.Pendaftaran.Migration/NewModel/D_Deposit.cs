

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Wincare.Pendaftaran.Migration.NewModel;


namespace Wincare.Pendaftaran.Migration.NewModel;

[PrimaryKey("IdRegistrasi", "Tgl", "Id")]
[Table("Deposit")]
[Index("IdRegistrasi", Name = "IX_DEPOSIT")]
[Index("Tgl", Name = "IX_DEPOSIT_1")]
[Index("Charge", Name = "IX_DEPOSIT_2")]
[Index("Kredit", Name = "IX_DEPOSIT_3")]
[Index("Transfer", Name = "IX_DEPOSIT_4")]
[Index("Tunai", Name = "IX_DEPOSIT_5")]
[Index("IdStatus", Name = "IX_DEPOSIT_6")]
[Index("Id", Name = "IX_DEPOSIT_7")]
public partial class D_Deposit
{
    [Key]
    [Column("IdRegistrasi")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdRegistrasi { get; set; }

    [Key]
    [Column("Tgl", TypeName = "datetime")]
    public DateTime Tgl { get; set; }

    [Column("Tunai", TypeName = "decimal(18, 0)")]
    public decimal? Tunai { get; set; }

    [Column("Kredit", TypeName = "decimal(18, 0)")]
    public decimal? Kredit { get; set; }
    [Column("Charge", TypeName = "decimal(18, 0)")]
    public decimal? Charge { get; set; }

    [Column("KreditNamaBank")]
    [StringLength(100)]
    [Unicode(false)]
    public string KreditNamaBank { get; set; }

    [Column("KreditNoBatch")]
    [StringLength(100)]
    [Unicode(false)]
    public string KreditNoBatch { get; set; }

    [Column("KreditNoCard")]
    [StringLength(100)]
    [Unicode(false)]
    public string KreditNoCard { get; set; }

    [Column("KreditJenisCard")]
    [StringLength(100)]
    [Unicode(false)]
    public string KreditJenisCard { get; set; }

    [Column("Transfer", TypeName = "decimal(18, 0)")]
    public decimal? Transfer { get; set; }

    [Column("TransferNoRekAsal")]
    [StringLength(100)]
    [Unicode(false)]
    public string TransferNoRekAsal { get; set; }

    [Column("TransferNomor")]
    [StringLength(100)]
    [Unicode(false)]
    public string TransferNomor { get; set; }

    [Column("TransferNamaBank")]
    [StringLength(100)]
    [Unicode(false)]
    public string TransferNamaBank { get; set; }

    [Column("Note")]
    [StringLength(300)]
    [Unicode(false)]
    public string Note { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("Status")]
    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; }

    [Key]
    [Column("Id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("IdStatus")]
    public int? IdStatus { get; set; }

    [ForeignKey("IdRegistrasi")]
    [InverseProperty("TtDeposits")]
    public virtual D_Kunjungan IdRegistrasiNavigation { get; set; }
}
