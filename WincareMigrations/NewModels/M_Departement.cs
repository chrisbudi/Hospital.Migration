using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WincareMigrations.NewModels;

[Table("M_Department")]
public partial class M_Departement
{
    [Key]
    [Column("IdDepartment", TypeName = "numeric(18, 0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal IdDepartment { get; set; }

    [Column("NamaDepartemen")]
    [StringLength(255)]
    [Unicode(false)]
    public string NamaDepartemen { get; set; }
}