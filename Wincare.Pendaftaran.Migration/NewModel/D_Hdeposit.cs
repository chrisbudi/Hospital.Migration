﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_Hdeposit")]
public partial class D_HasilDeposit
{
    [Key]
    [Column("IdDeposit")]
    public Ulid IdDeposit { get; set; }

    [Column("OldIdDeposit")]
    public long OldIdDeposit { get; set; }

    [Column("IdKunjungan", TypeName = "numeric(18, 0)")]
    public decimal? IdKunjungan { get; set; }

    [Column("TglDeposit", TypeName = "datetime")]
    public DateTime? TglDeposit { get; set; }

    [Column("Tunai", TypeName = "decimal(18, 0)")]
    public decimal? Tunai { get; set; }

    [Column("Kredit", TypeName = "decimal(18, 0)")]
    public decimal? Kredit { get; set; }

    [Column("Namakk")]
    [StringLength(50)]
    [Unicode(false)]
    public string Namakk { get; set; }

    [Column("Jeniskk")]
    [StringLength(50)]
    [Unicode(false)]
    public string Jeniskk { get; set; }

    [Column("NamaBankKredit")]
    [StringLength(50)]
    [Unicode(false)]
    public string NamaBankKredit { get; set; }

    [Column("NoBatch")]
    [StringLength(50)]
    [Unicode(false)]
    public string NoBatch { get; set; }

    [Column("NoMesin")]
    [StringLength(50)]
    [Unicode(false)]
    public string NoMesin { get; set; }

    [Column("ChargeKredit", TypeName = "decimal(18, 0)")]
    public decimal? ChargeKredit { get; set; }

    [Column("TRANSFER", TypeName = "decimal(18, 0)")]
    public decimal? Transfer { get; set; }

    [Column("NOMORTRANSFER")]
    [StringLength(50)]
    [Unicode(false)]
    public string Nomortransfer { get; set; }

    [Column("NAMABANKTRANSFER")]
    [StringLength(50)]
    [Unicode(false)]
    public string Namabanktransfer { get; set; }

    [Column("REKASAL")]
    [StringLength(50)]
    [Unicode(false)]
    public string Rekasal { get; set; }

    [Column("VBY")]
    [StringLength(50)]
    [Unicode(false)]
    public string Vby { get; set; }

    [Column("ID_STATUS")]
    public int? IdStatus { get; set; }

    [Column("V_NOTE")]
    [StringLength(50)]
    [Unicode(false)]
    public string VNote { get; set; }

    [ForeignKey("Idkunjungan")]
    [InverseProperty("TthDeposits")]
    public virtual D_Kunjungan IdkunjunganNavigation { get; set; }
}
