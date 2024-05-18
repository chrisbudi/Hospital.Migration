using Microsoft.AspNetCore.Mvc;
using WincareMigrations.Models;
using WincareMigrations.NewModels;

namespace WincareMigrations.Controllers.Master
{
    [Route("api/[controller]")]
    [ApiController]
    public class AntrianController(WinCare2Context dbs, SimpleContext dbt) : ControllerBase
    {
        [HttpGet()]
        public Task<IActionResult> Antrian()
        {
            var antrian = dbs.TmAntrianCounters.Select(s => new M_AntrianCounter
            {
                IdCounter = (long)s.IdCounter,
                Kdcounter = s.VKdcounter,
                Kdlayanan = s.VKdlayanan,
                Kdlokasi = s.VKdlokasi,
                Counter = s.VCounter,
                IsAktif = s.IsAktif
            }).ToList();

            var antrianAudio = dbs.TmAntrianCounterAudios.Select(s => new M_AntrianCounterAudio
            {
                IdCounteraudio = (long)s.IdCounteraudio,
                Kdcounter = s.VKdcounter,
                Counter = s.VCounter,
                IsAktif = s.IsAktif,
                Kdlayanan = s.VKdlayanan,
                Kdlokasi = s.VKdlokasi,
                File = s.VFile,
                Nomor = s.VNomor
            }).ToList();

            var antrianLayanan = dbs.TmAntrianLayanans.Select(s => new M_AntrianLayanan
            {
                IdLayanan = (long)s.IdLayanan,
                Kdlayanan = s.VKdlayanan,
                Layanan = s.VLayanan,
                IsAktif = s.IsAktif,
                Inisial = s.VInisial,
                Kdlokasi = s.VKdlokasi
            }).ToList();

            var antrianLokasi = dbs.TmAntrianLokasis.Select(s => new M_AntrianLokasi
            {
                IdLokasi = (long)s.IdLokasi,
                Kdlokasi = s.VKdlokasi,
                Lokasi = s.VLokasi,
                IsAktif = s.IsAktif,
                Action = s.Action
            }).ToList();


            dbt.TmAntrianCounters.AddRange(antrian);
            dbt.TmAntrianCounterAudios.AddRange(antrianAudio);
            dbt.TmAntrianLayanans.AddRange(antrianLayanan);
            dbt.TmAntrianLokasis.AddRange(antrianLokasi);
            dbt.SaveChanges();


            return Task.FromResult<IActionResult>(Ok("Antrian"));
        }
    }
}
