using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels
{
    [Table("M_Rekanan")]
    [Index("IdRekanan", Name = "IX_M_Rekanan_IdRekanan")]
    [Index("NmRekanan", Name = "IX_M_Rekanan_NmRekanan")]
    [Index("IsAktif", Name = "IX_M_Rekanan_IsAktif")]
    [Index("Alias", Name = "IX_M_Rekanan_Alias")]
    public partial class M_Rekanan
    {
        [Key]
        [Column("IdRekanan", TypeName = "numeric(18, 0)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal IdRekanan { get; set; }

        [Column("NmRekanan")]
        [StringLength(100)]
        [Unicode(false)]
        public string NmRekanan { get; set; }

        [Column("Alamat")]
        [StringLength(200)]
        [Unicode(false)]
        public string Alamat { get; set; }

        [Column("Kota")]
        [StringLength(50)]
        [Unicode(false)]
        public string Kota { get; set; }

        [Column("Telp")]
        [StringLength(100)]
        [Unicode(false)]
        public string Telp { get; set; }

        [Column("Alias")]
        [StringLength(50)]
        [Unicode(false)]
        public string Alias { get; set; }

        [Column("IsAktif")]
        public bool? IsAktif { get; set; }

        [Column("KdAkun")]
        [StringLength(8)]
        [Unicode(false)]
        public string KdAkun { get; set; }

        [Column("IsPaketBHP")]
        public bool? IsPaketbhp { get; set; }

        [Column("IsTarif")]
        public bool? IsTarif { get; set; }

        [Column("IsTarifNonMed")]
        public bool? IsTarifNonMed { get; set; }

        [Column("IsCob")]
        public bool IsCob { get; set; }

        [InverseProperty("Rekanan")]
        public virtual ICollection<M_Hargarekanan> M_Hargarekanans { get; set; } = new List<M_Hargarekanan>();

        [InverseProperty("Rekanan")]
        public virtual ICollection<M_LaboratoriumHarga> M_LaboratoriumHargas { get; set; } = new List<M_LaboratoriumHarga>();

        [InverseProperty("Rekanan")]
        public virtual ICollection<M_LaboratoriumRekanan> M_LaboratoriumRekanans { get; set; } = new List<M_LaboratoriumRekanan>();

        [InverseProperty("Rekanan")]
        public virtual ICollection<M_Pasien> M_Pasiens { get; set; } = new List<M_Pasien>();

        [InverseProperty("Rekanan")]
        public virtual ICollection<M_RadiologiHarga> M_RadiologiHargas { get; set; } = new List<M_RadiologiHarga>();

        [InverseProperty("Rekanan")]
        public virtual ICollection<M_RadiologiRekanan> M_RadiologiRekanans { get; set; } = new List<M_RadiologiRekanan>();
    }
}
