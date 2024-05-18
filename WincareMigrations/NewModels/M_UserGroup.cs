

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_UserGroup")]
public partial class M_UserGroup
{
    [Key]
    [Column("IdGroupUser", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdGroupUser { get; set; }

    [Column("NmGroupUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string NmgroupUser { get; set; }

    [InverseProperty("IdGroupuserNavigation")]
    public virtual ICollection<M_User> M_Users { get; set; } = new List<M_User>();
}