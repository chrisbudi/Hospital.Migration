﻿

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_result_Hasillab")]
[Index("IdHasilLab", Name = "IX_HASILLAB")]
[Index("Hasil", Name = "IX_HASILLAB_1")]
[Index("NiStandart", Name = "IX_HASILLAB_2")]
[Index("IdDetilPemeriksaanLab", Name = "IX_HASILLAB_3")]
[Index("IdPasienLab", Name = "IX_HASILLAB_4")]
public partial class D_result_Hasillab
{
    [Key]
    [Column("IdHasilLab", TypeName = "numeric(18, 0)")]
    public decimal IdHasilLab { get; set; }

    [Column("IdDetilPemeriksaanLab")]
    public int? IdDetilPemeriksaanLab { get; set; }

    [Column("IdPasienLab")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdPasienLab { get; set; }

    [Column("KdPemeriksaanLab")]
    [StringLength(8)]
    [Unicode(false)]
    public string KdPemeriksaanLab { get; set; }

    [Column("NmPemeriksaan")]
    [StringLength(100)]
    [Unicode(false)]
    public string NmPemeriksaan { get; set; }

    [Column("Hasil")]
    [StringLength(255)]
    [Unicode(false)]
    public string Hasil { get; set; }

    [Column("NiStandart")]
    [StringLength(300)]
    [Unicode(false)]
    public string NiStandart { get; set; }

    [Column("Satuan")]
    [StringLength(300)]
    [Unicode(false)]
    public string Satuan { get; set; }

    [Column("By")]
    [StringLength(50)]
    [Unicode(false)]
    public string By { get; set; }

    [Column("IdStatus")]
    public int? IdStatus { get; set; }

    [ForeignKey("IdPasienLab")]
    [InverseProperty("TrHasillabs")]
    public virtual D_Pasienlab IdPasienLabNavigation { get; set; }
}
