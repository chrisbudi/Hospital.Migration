using EFCore.BulkExtensions;
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
            if (!dbt.TmAntrianCounters.Any())
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

                dbt.BulkInsert(antrian, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                dbt.BulkSaveChanges();
            }


            if (!dbt.TmAntrianCounterAudios.Any())
            {
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


                dbt.BulkInsert(antrianAudio, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                dbt.BulkSaveChanges();
            }

            if (!dbt.TmAntrianLayanans.Any())
            {
                var antrianLayanan = dbs.TmAntrianLayanans.Select(s => new M_AntrianLayanan
                {
                    IdLayanan = (long)s.IdLayanan,
                    Kdlayanan = s.VKdlayanan,
                    Layanan = s.VLayanan,
                    IsAktif = s.IsAktif,
                    Inisial = s.VInisial,
                    Kdlokasi = s.VKdlokasi
                }).ToList();

                dbt.BulkInsert(antrianLayanan, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                dbt.BulkSaveChanges();
            }
            if (!dbt.TmAntrianLokasis.Any())
            {
                var antrianLokasi = dbs.TmAntrianLokasis.Select(s => new M_AntrianLokasi
                {
                    IdLokasi = (long)s.IdLokasi,
                    Kdlokasi = s.VKdlokasi,
                    Lokasi = s.VLokasi,
                    IsAktif = s.IsAktif,
                    Action = s.Action
                }).ToList();
                dbt.AddRange(antrianLokasi);
                dbt.BulkSaveChanges();
            }




            return Task.FromResult<IActionResult>(Ok("Antrian"));
        }
    }
}
