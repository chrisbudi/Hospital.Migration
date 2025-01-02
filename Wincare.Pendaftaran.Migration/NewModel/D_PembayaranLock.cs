using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wincare.Pendaftaran.Migration.NewModel;

[Table("D_PembayaranLock")]
public partial class D_PembayaranLock
{
    [Key]
    [Column("IdLockBayar", TypeName = "numeric(18, 0)")]
    public decimal IdLockBayar { get; set; }

    [Column("IdRegistrasi")]
    [StringLength(12)]
    [Unicode(false)]
    public string IdRegistrasi { get; set; }

    [Column("LockUnlock")]
    public bool? LockUnlock { get; set; }
}
