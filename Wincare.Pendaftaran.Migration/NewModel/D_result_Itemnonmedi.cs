

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

using Wincare.Pendaftaran.Migration.NewModel;

namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_result_Itemnonmedi")]
public partial class D_result_Itemnonmedi
{
    [Key]
    [Column("IdItemNonmedis", TypeName = "numeric(18, 0)")]
    public decimal IdItemNonmedis { get; set; }

    [Column("IdTransaksiNonmedis", TypeName = "numeric(18, 0)")]
    public decimal? IdTransaksiNonmedis { get; set; }

    [Required]
    [Column("KdTarif")]
    [StringLength(10)]
    [Unicode(false)]
    public string KdTarif { get; set; }

    [Column("NmTarif")]
    [StringLength(50)]
    [Unicode(false)]
    public string NmTarif { get; set; }

    [Column("Group")]
    [StringLength(50)]
    [Unicode(false)]
    public string Group { get; set; }

    [Column("Harga", TypeName = "decimal(18, 0)")]
    public decimal? Harga { get; set; }

    [Column("Jumlah", TypeName = "decimal(18, 0)")]
    public decimal? Jumlah { get; set; }

    [Column("Diskon", TypeName = "decimal(18, 0)")]
    public decimal? Diskon { get; set; }

    [Column("Subtotal", TypeName = "decimal(18, 0)")]
    public decimal? Subtotal { get; set; }

    [Column("BeaPasien", TypeName = "decimal(18, 0)")]
    public decimal? BeaPasien { get; set; }

    [Column("BeaRekanan", TypeName = "decimal(18, 0)")]
    public decimal? BeaRekanan { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [ForeignKey("IdTransaksiNonmedis")]
    [InverseProperty("TrItemnonmedis")]
    public virtual D_Transaksinonmedi IdTransaksinonmedisNavigation { get; set; }
}
