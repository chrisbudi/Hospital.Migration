using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wincare.Core.DatabaseConfig;

namespace WincareMigrations.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DatabaseController : ControllerBase
    {

        [HttpGet("UpdateAllSequence")]
        public async Task<IActionResult> Get()
        {

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseNpgsql("Server=simplecliniq.czwkw6ameocg.ap-southeast-1.rds.amazonaws.com;Database=db_simple_cliniq;User Id=postgres;Password=development()qwerty34");

            using (var context = new ApplicationDbContext(optionsBuilder.Options))
            {
                var sequences = context.GetAllSequences();

                foreach (var sequence in sequences)
                {
                    var tableName = sequence.sequence_name.Substring(0, sequence.sequence_name.IndexOf('_', 2));
                    if (string.IsNullOrEmpty(tableName))
                    {
                        continue;
                    }

                    var primaryKeyColumn = context.GetPrimaryKeyColumnForTable(tableName);
                    if (string.IsNullOrEmpty(primaryKeyColumn))
                    {
                        continue;
                    }

                    var maxId = context.GetMaxIdForTable(tableName, primaryKeyColumn);
                    context.AlterSequence($"{sequence.sequence_name}", (maxId + 1));
                }
            }
            return Ok("Done");
        }
    }
}
