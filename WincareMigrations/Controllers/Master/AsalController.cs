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
            // load source 
            var data = _dbWin.TmAsals.Select(s => new M_Asal
            {
                IdAsal = (long)s.IdAsal,
                IdAsalGroup = (int)s.IdAsalgroup,
                KdAsal = s.VKdasal,
                NmAsal = s.VNmasal,
                IsAktif = s.IsAktif
            }).ToList();


            _dbs.TmAsals.AddRange(data);

            var dataAsalGroup = _dbWin.TmAsalGroups.Select(s => new M_AsalGroup
            {
                IdAsalGroup = (int)s.IdAsalgroup,
                NamaGroupAsal = s.VNmgroupasal,
                IsAktif = s.IsAktif
            }).ToList();


            _dbs.TmAsalGroups.AddRange(dataAsalGroup);

            _dbs.SaveChanges();



            return Task.FromResult<IActionResult>(Ok("Asal"));
        }
    }
}
