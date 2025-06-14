﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;
[Table("M_TarifHarga")]
public partial class M_TarifHarga
{
    [Key]
    [Column("IdTarifkelas")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Ulid IdTarifkelas { get; set; }

    [Column("OldIdTarifkelas", TypeName = "numeric(18, 0)")]
    public decimal OldIdTarifkelas { get; set; }

    [Column("Kdtarifdetail")]
    [StringLength(10)]
    [Unicode(false)]
    public string Kdtarifdetail { get; set; }

    [Column("RekananId")]
    public Ulid? RekananId { get; set; }

    [Column("OldRekananId", TypeName = "numeric(18, 0)")]
    public decimal? OldRekananId { get; set; }

    [Column("Kelas")]
    [StringLength(50)]
    [Unicode(false)]
    public string Kelas { get; set; }

    [Column("Harga", TypeName = "decimal(18, 0)")]
    public decimal? Harga { get; set; }

    [Column("Cito", TypeName = "decimal(18, 0)")]
    public decimal? Cito { get; set; }

    [Column("Penyulit", TypeName = "decimal(18, 0)")]
    public decimal? Penyulit { get; set; }

    [Column("SecondTnd", TypeName = "decimal(18, 0)")]
    public decimal? SecondTnd { get; set; }

    [Column("Adm", TypeName = "decimal(18, 0)")]
    public decimal? Adm { get; set; }

    [Column("Diskon", TypeName = "decimal(18, 0)")]
    public decimal? Diskon { get; set; }

    [Column("Beapasien", TypeName = "decimal(18, 0)")]
    public decimal? Beapasien { get; set; }

    [Column("Bearekanan", TypeName = "decimal(18, 0)")]
    public decimal? Bearekanan { get; set; }

    [Column("Jasamedis", TypeName = "decimal(18, 0)")]
    public decimal? Jasamedis { get; set; }

    [Column("Jasamedis2", TypeName = "decimal(18, 0)")]
    public decimal? Jasamedis2 { get; set; }

    [Column("Jasamedis3", TypeName = "decimal(18, 0)")]
    public decimal? Jasamedis3 { get; set; }

    [Column("Jasamedis4", TypeName = "decimal(18, 0)")]
    public decimal? Jasamedis4 { get; set; }

    [Column("Jasamedis5", TypeName = "decimal(18, 0)")]
    public decimal? Jasamedis5 { get; set; }

    [Column("Jasars", TypeName = "decimal(18, 0)")]
    public decimal? Jasars { get; set; }

    [Column("Bahanalkes", TypeName = "decimal(18, 0)")]
    public decimal? Bahanalkes { get; set; }

    [Column("Tglawal", TypeName = "timestamp")]
    public DateTime? Tglawal { get; set; }

    [Column("Tglakhir", TypeName = "timestamp")]
    public DateTime? Tglakhir { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("IsAktif")]
    public bool? IsAktif { get; set; }

    [Column("Lastupdate", TypeName = "timestamp")]
    public DateTime? Lastupdate { get; set; }
}
