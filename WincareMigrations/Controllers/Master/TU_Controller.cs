using Microsoft.AspNetCore.Mvc;
using WincareMigrations.Models;
using WincareMigrations.NewModels;

namespace WincareMigrations.Controllers.Master
{
    [Route("api/[controller]")]
    [ApiController]
    public class TU_Controller(WinCare2Context _dbWin, SimpleContext _dbs) : ControllerBase
    {

        [HttpGet()]
        public Task<IActionResult> GetTU()
        {
            // load source 
            var tarifGroup = _dbWin.TmTarifGroups.Select(m => new M_TarifGroup()
            {
                AliasGroup = m.VAliasgroup,
                IdGrouptarif = (int)m.IdGrouptarif,
                IsAktif = m.IsAktif,
                KdAkun = m.VKdakun,
                NmGroupTarif = m.VNmgrouptarif,
            });
            _dbs.AddRange(tarifGroup);

            var tarifHarga = _dbWin.TmTarifHargas.Select(m => new M_TarifHarga()
            {
                IsAktif = m.IsAktif,
                Cito = m.DCito,
                Bearekanan = m.DBearekanan,
                Adm = m.DAdm,
                Bahanalkes = m.DBahanalkes,
                Jasamedis = m.DJasamedis,
                Jasars = m.DJasars,
                Kelas = m.VKelas,
                Penyulit = m.DPenyulit,
                Tglawal = m.DTglawal,
                Beapasien = m.DBeapasien,
                Diskon = m.DDiskon,
                By = m.VBy,
                Harga = m.DHarga,
                Jasamedis2 = m.DJasamedis2,
                Jasamedis3 = m.DJasamedis3,
                Jasamedis4 = m.DJasamedis4,
                Jasamedis5 = m.DJasamedis5,
                Kdtarifdetail = m.VKdtarifdetail,
                Lastupdate = m.DLastupdate,
                OldIdTarifkelas = m.IdTarifkelas,

                OldRekananId = m.Rekananid,
                SecondTnd = m.D2tnd,
                Tglakhir = m.DTglakhir,
            });
            _dbs.AddRange(tarifHarga);

            var tarifMatrix = _dbWin.TmTarifMatrices.Select(m => new M_TarifMatrix()
            {
                IsAktif = m.IsAktif,
                //IdRuang = m.IdRuang,
                IdTarifmatrix = Guid.NewGuid(),
                //IdTarifdetail = m.tarif,
                Kdtarifdetail = m.VKdtarifdetail,
                Koderuangan = m.VKoderuangan,
                OldIdTarifmatrix = m.IdTarifmatrix,
            });

            _dbs.AddRange(tarifMatrix);





            _dbs.SaveChanges();

            return Task.FromResult<IActionResult>(Ok("Asal"));
        }




        [HttpGet("fixMapping")]
        public Task<IActionResult> FixMapping()
        {

            return Task.FromResult<IActionResult>(Ok("Asal"));
        }
    }



}
