﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Transaksinonmedi")]
[Index("IdTransaksiNonMedis", Name = "IX_TRANSAKSINONMEDIS")]
[Index("Tgl", Name = "IX_TRANSAKSINONMEDIS_1")]
[Index("BayarTransfer", Name = "IX_TRANSAKSINONMEDIS_10")]
[Index("IdStatus", Name = "IX_TRANSAKSINONMEDIS_11")]
[Index("Status", Name = "IX_TRANSAKSINONMEDIS_12")]
[Index("NoKuitansi", Name = "IX_TRANSAKSINONMEDIS_2")]
[Index("IdPasien", Name = "IX_TRANSAKSINONMEDIS_3")]
[Index("NmPembeli", Name = "IX_TRANSAKSINONMEDIS_4")]
[Index("Keterangan", Name = "IX_TRANSAKSINONMEDIS_5")]
[Index("RekananId", Name = "IX_TRANSAKSINONMEDIS_6")]
[Index("BayarTunai", Name = "IX_TRANSAKSINONMEDIS_7")]
[Index("BayarKredit", Name = "IX_TRANSAKSINONMEDIS_8")]
[Index("Charge", Name = "IX_TRANSAKSINONMEDIS_9")]
public partial class D_Transaksinonmedi
{
    [Key]
    [Column("IdTransaksiNonMedis", TypeName = "numeric(18, 0)")]
    public decimal IdTransaksiNonMedis { get; set; }

    [Column("Tgl", TypeName = "datetime")]
    public DateTime? Tgl { get; set; }

    [Column("NoKuitansi")]
    [StringLength(50)]
    [Unicode(false)]
    public string NoKuitansi { get; set; }

    [Column("IdPasien")]
    [StringLength(10)]
    [Unicode(false)]
    public string IdPasien { get; set; }

    [Column("NmPembeli")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmPembeli { get; set; }

    [Column("Keterangan")]
    [StringLength(300)]
    [Unicode(false)]
    public string Keterangan { get; set; }

    [Column("Total", TypeName = "decimal(18, 0)")]
    public decimal? Total { get; set; }

    [Column("BayarTunai", TypeName = "decimal(18, 0)")]
    public decimal? BayarTunai { get; set; }

    [Column("BayarKredit", TypeName = "decimal(18, 0)")]
    public decimal? BayarKredit { get; set; }

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

    [Column("Bayartransfer", TypeName = "decimal(18, 0)")]
    public decimal? Bayartransfer { get; set; }

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

    [Column("Compliment", TypeName = "decimal(18, 0)")]
    public decimal? Compliment { get; set; }

    [Column("Asuransi", TypeName = "decimal(18, 0)")]
    public decimal? Asuransi { get; set; }

    [Column("Perjanjian", TypeName = "decimal(18, 0)")]
    public decimal? Perjanjian { get; set; }

    [Column("Kembali", TypeName = "decimal(18, 0)")]
    public decimal? Kembali { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("Status")]
    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("RekananId", TypeName = "numeric(18, 0)")]
    public decimal? RekananId { get; set; }

    [Column("IdStatus")]
    public int? IdStatus { get; set; }

    [InverseProperty("IdTransaksinonmedisNavigation")]
    public virtual ICollection<D_result_Itemnonmedi> TrItemnonmedis { get; set; } = new List<D_result_Itemnonmedi>();
}
