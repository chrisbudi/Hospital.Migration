﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Wincare.Pendaftaran.Migration.Models;

[Table("TMH_PENGUNJUNG")]
public partial class TmhPengunjung
{
    [Column("ID_NUMPENGUNJUNG", TypeName = "numeric(18, 0)")]
    public decimal IdNumpengunjung { get; set; }

    [Key]
    [Column("IDPENGUNJUNG")]
    [StringLength(10)]
    [Unicode(false)]
    public string Idpengunjung { get; set; }

    [Column("NAMAPENGUNJUNG")]
    [StringLength(100)]
    [Unicode(false)]
    public string Namapengunjung { get; set; }

    [Column("TGLLAHIR", TypeName = "datetime")]
    public DateTime? Tgllahir { get; set; }

    [Column("ALAMAT")]
    [StringLength(100)]
    [Unicode(false)]
    public string Alamat { get; set; }

    [Column("KOTA")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kota { get; set; }

    [Column("TELP")]
    [StringLength(50)]
    [Unicode(false)]
    public string Telp { get; set; }

    [Column("PEKERJAAN")]
    [StringLength(50)]
    [Unicode(false)]
    public string Pekerjaan { get; set; }

    [Column("ALAMATPEKERJAAN")]
    [StringLength(100)]
    [Unicode(false)]
    public string Alamatpekerjaan { get; set; }

    [Column("TELPPEKERJAAN")]
    [StringLength(50)]
    [Unicode(false)]
    public string Telppekerjaan { get; set; }

    [Column("JENISIDENTITAS")]
    [StringLength(50)]
    [Unicode(false)]
    public string Jenisidentitas { get; set; }

    [Column("NOMORIDENTITAS")]
    [StringLength(50)]
    [Unicode(false)]
    public string Nomoridentitas { get; set; }

    [Column("NAMAORANGDEKAT")]
    [StringLength(100)]
    [Unicode(false)]
    public string Namaorangdekat { get; set; }

    [Column("ALAMATORANGDEKAT")]
    [StringLength(50)]
    [Unicode(false)]
    public string Alamatorangdekat { get; set; }

    [Column("TELPORANGDEKAT")]
    [StringLength(50)]
    [Unicode(false)]
    public string Telporangdekat { get; set; }

    [Column("IS_KUNJUNGAN")]
    public bool? IsKunjungan { get; set; }

    [InverseProperty("IdpengunjungNavigation")]
    public virtual ICollection<TthKunjungan> TthKunjungans { get; set; } = new List<TthKunjungan>();
}