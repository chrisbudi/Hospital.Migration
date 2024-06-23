using EFCore.BulkExtensions;
using Microsoft.AspNetCore.Mvc;
using WincareMigrations.Models;
using WincareMigrations.NewModels;

namespace WincareMigrations.Controllers.Master
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsalController(WinCare2Context _dbWin, SimpleContext _dbs) : ControllerBase
    {

        [HttpGet()]
        public Task<IActionResult> GetAsal()
        {

            if (!_dbs.TmAsalGroups.Any())
            {

                var dataAsalGroup = _dbWin.TmAsalGroups.Select(s => new M_AsalGroup
                {
                    IdAsalGroup = (int)s.IdAsalgroup,
                    NamaGroupAsal = s.VNmgroupasal,
                    IsAktif = s.IsAktif
                });
                _dbs.BulkInsertAsync(dataAsalGroup, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                _dbs.BulkSaveChangesAsync();
            }

            // load source 
            if (!_dbs.TmAsalGroups.Any())
            {
                var data = _dbWin.TmAsals.Select(s => new M_Asal
                {
                    IdAsal = (long)s.IdAsal,
                    IdAsalGroup = (int)s.IdAsalgroup,
                    KdAsal = s.VKdasal,
                    NmAsal = s.VNmasal,
                    IsAktif = s.IsAktif
                });

                _dbs.BulkInsertAsync(data, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                _dbs.BulkSaveChangesAsync();

            }

            return Task.FromResult<IActionResult>(Ok("Asal"));
        }
    }
}
