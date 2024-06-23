using EFCore.BulkExtensions;
using Microsoft.AspNetCore.Mvc;

using WincareMigrations.Models;
using WincareMigrations.NewModels;

namespace WincareMigrations.Controllers.Master
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankCoaController(WinCare2Context _dbWin, SimpleContext _dbs) : ControllerBase
    {

        [HttpGet()]
        public async Task<IActionResult> GetBankCoa()
        {
            // load source 
            if (!_dbs.TmBanks.Any())
            {
                var bank = _dbWin.TmBanks.AsEnumerable().Select(x => new M_Bank()
                {
                    IdBank = Ulid.NewUlid(),
                    OldIdBank = x.IdBank,
                    KdBank = x.VKdbank,
                    NmBank = x.VNmbank,
                    Cabang = x.VCabang,
                    Alamat = x.VAlamat,
                    Kota = x.VKota,
                    Telepon = x.VTelepon,
                    IsAktif = x.IsAktif,
                    NomorRekening = x.VNomorrekening,
                    KdAkun = x.VKdakun
                });
                await _dbs.BulkInsertAsync(bank, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.Default });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmCoaGolongans.Any())
            {
                var golongan = _dbWin.TmCoaGolongans.Select(x => new M_CoaGolongan()
                {
                    IdGolongan = x.IdGolongan,
                    NmGolongan = x.VNmgolongan,
                    IsAktif = x.IsAktif
                });
                await _dbs.BulkInsertAsync(golongan, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmCoaKlasifikasis.Any())
            {
                var klasifikasi = _dbWin.TmCoaKlasifikasis.Select(x => new M_CoaKlasifikasi()
                {
                    IdKlasifikasi = x.IdKlasifikasi,
                    NmKlasifikasi = x.VNmklasifikasi,
                    Urut = x.VUrut,
                    IsAktif = x.IsAktif,
                    IdGolongan = x.IdGolongan,
                });
                await _dbs.BulkInsertAsync(klasifikasi, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }


            if (!_dbs.TmCoaSubklasifikasis.Any())
            {
                var subKlasifikasi = _dbWin.TmCoaSubklasifikasis.AsEnumerable().Select(x => new M_CoaSubklasifikasi()
                {
                    IdSubklasifikasi = Ulid.NewUlid(),
                    OldIdSubklasifikasi = x.IdSubklasifikasi,
                    Kdsubklasifikasi = x.VKdsubklasifikasi,
                    DC = x.VDc,
                    NmSubKlasifikasi = x.VNmsubklasifikasi,
                    Urut = x.VUrut,
                    IdKlasifikasi = x.IdKlasifikasi,
                    IsAktif = x.IsAktif
                });
                //await _dbs.BulkInsertAsync(subKlasifikasi, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.AddRangeAsync(subKlasifikasi);
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmCoas.Any())
            {
                var coa = _dbWin.TmCoas.AsEnumerable().Select(x => new M_Coa()
                {
                    IdCoa = Ulid.NewUlid(),
                    OldIdCoa = x.IdCoa,
                    Kdakun = x.VKdakun,
                    NmAkun = x.VNmakun,
                    IsAktif = x.IsAktif,
                    DC = x.VDc,
                    SaldoAwal = x.DSaldoawal,
                    DTglsaldoawal = x.DTglsaldoawal,
                    //IdSubklasifikasi = subKlasifikasi.SingleOrDefault(m => m.OldIdSubklasifikasi == x.IdSubklasifikasi).IdSubklasifikasi,
                    OldIdSubklasifikasi = x.IdSubklasifikasi,
                    NmAkunAlias = x.VNmakunalias
                }); ;
                await _dbs.BulkInsertAsync(coa, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            return Ok("Asal");
        }

        [HttpGet("fixMapping")]
        public Task<IActionResult> FixMapping()
        {
            var coa = _dbs.TmCoas.ToList();
            var subKlasifikasi = _dbs.TmCoaSubklasifikasis.ToList();
            ;

            foreach (var item in coa)
            {
                item.IdSubklasifikasi = subKlasifikasi.SingleOrDefault(m => m.OldIdSubklasifikasi == item.OldIdSubklasifikasi).IdSubklasifikasi;
            }


            _dbs.SaveChanges();

            return Task.FromResult<IActionResult>(Ok("Asal"));
        }
    }
}
