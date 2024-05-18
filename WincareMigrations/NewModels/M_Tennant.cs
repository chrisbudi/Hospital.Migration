using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_Tennant")]
public partial class M_Tenant
{
    [Key]
    [Column("IdTenant")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid IdTenant { get; set; }


    [Column("OldIdTenant", TypeName = "numeric(18, 0)")]
    public decimal OldIdTenant { get; set; }

    [Column("TenantCode")]
    [StringLength(5)]
    [Unicode(false)]
    public string TenantCode { get; set; }

    [Column("TenantName")]
    [StringLength(50)]
    [Unicode(false)]
    public string TenantName { get; set; }

    [Column("TenantAddress")]
    [StringLength(50)]
    [Unicode(false)]
    public string TenantAddress { get; set; }

    [Column("Phone")]
    [StringLength(50)]
    [Unicode(false)]
    public string Phone { get; set; }

    [Column("Website")]
    [StringLength(50)]
    [Unicode(false)]
    public string Website { get; set; }

    [Column("Email")]
    [StringLength(50)]
    [Unicode(false)]
    public string Email { get; set; }

    [Column("Logo")]
    [StringLength(100)]
    [Unicode(false)]
    public string Logo { get; set; }

    [Column("CodeLogo", TypeName = "text")]
    public string Codelogo { get; set; }

    public DateTime StartDateTime { get; set; }

    public DateTime ExpiredDate { get; set; }

    [Column("SubscriptionCode")]
    [StringLength(100)]
    public string SubscriptionCode { get; set; }


}
