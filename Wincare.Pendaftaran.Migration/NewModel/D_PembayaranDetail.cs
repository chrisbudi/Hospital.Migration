﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_PembayaranDetail")]
[Index("IdRegistrasi", Name = "IX_PEMBAYARAN_DETAIL")]
[Index("Tgl", Name = "IX_PEMBAYARAN_DETAIL_1")]
[Index("ChargeKredit", Name = "IX_PEMBAYARAN_DETAIL_10")]
[Index("Compliment", Name = "IX_PEMBAYARAN_DETAIL_11")]
[Index("Kembali", Name = "IX_PEMBAYARAN_DETAIL_12")]
[Index("IdStatus", Name = "IX_PEMBAYARAN_DETAIL_13")]
[Index("NomorByrPasien", Name = "IX_PEMBAYARAN_DETAIL_14")]
[Index("BayarTunai", Name = "IX_PEMBAYARAN_DETAIL_15")]
[Index("By", Name = "IX_PEMBAYARAN_DETAIL_16")]
[Index("BeaPasien", Name = "IX_PEMBAYARAN_DETAIL_2")]
[Index("BeaRekanan", Name = "IX_PEMBAYARAN_DETAIL_3")]
[Index("PerjanjianPrshn", Name = "IX_PEMBAYARAN_DETAIL_4")]
[Index("Asuransi", Name = "IX_PEMBAYARAN_DETAIL_5")]
[Index("BayarKredit", Name = "IX_PEMBAYARAN_DETAIL_6")]
[Index("BayarTransfer", Name = "IX_PEMBAYARAN_DETAIL_7")]
[Index("Idn", Name = "IX_PEMBAYARAN_DETAIL_8")]
[Index("BeaCharge", Name = "IX_PEMBAYARAN_DETAIL_9")]
public partial class D_PembayaranDetail
{
    [Key]
    [Column("Idn", TypeName = "numeric(18, 0)")]
    public decimal Idn { get; set; }

    [Column("NomorByrPasien")]
    [StringLength(12)]
    [Unicode(false)]
    public string NomorByrPasien { get; set; }

    [Column("IdRegistrasi")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdRegistrasi { get; set; }

    [Column("Tgl", TypeName = "datetime")]
    public DateTime? Tgl { get; set; }

    [Column("Jumlah", TypeName = "decimal(18, 0)")]
    public decimal? Jumlah { get; set; }

    [Column("BeaPasien", TypeName = "decimal(18, 0)")]
    public decimal? BeaPasien { get; set; }

    [Column("BeaRekanan", TypeName = "decimal(18, 0)")]
    public decimal? BeaRekanan { get; set; }

    [Column("BeaCharge", TypeName = "decimal(18, 0)")]
    public decimal? BeaCharge { get; set; }

    [Column("Administrasi", TypeName = "decimal(18, 0)")]
    public decimal? Administrasi { get; set; }

    [Column("Materai", TypeName = "decimal(18, 0)")]
    public decimal? Materai { get; set; }

    [Column("Deposit", TypeName = "decimal(18, 0)")]
    public decimal? Deposit { get; set; }

    [Column("BayarKredit", TypeName = "decimal(18, 0)")]
    public decimal? BayarKredit { get; set; }

    [Column("ChargeKredit", TypeName = "decimal(18, 0)")]
    public decimal? ChargeKredit { get; set; }

    [Column("NoNamacc")]
    [StringLength(300)]
    [Unicode(false)]
    public string NoNamacc { get; set; }

    [Column("BayarTunai", TypeName = "decimal(18, 0)")]
    public decimal? BayarTunai { get; set; }

    [Column("PerjanjianPrshn", TypeName = "decimal(18, 0)")]
    public decimal? PerjanjianPrshn { get; set; }

    [Column("Asuransi", TypeName = "decimal(18, 0)")]
    public decimal? Asuransi { get; set; }

    [Column("Lainlain", TypeName = "decimal(18, 0)")]
    public decimal? Lainlain { get; set; }

    [Column("Kembali", TypeName = "decimal(18, 0)")]
    public decimal? Kembali { get; set; }

    [Column("Compliment", TypeName = "decimal(18, 0)")]
    public decimal? Compliment { get; set; }

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

    [Column("BayarTransfer", TypeName = "decimal(18, 0)")]
    public decimal? BayarTransfer { get; set; }

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

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("Status")]
    [StringLength(1)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("Otorisasi")]
    [StringLength(50)]
    [Unicode(false)]
    public string Otorisasi { get; set; }

    [Column("IdStatus")]
    public int? IdStatus { get; set; }
}
