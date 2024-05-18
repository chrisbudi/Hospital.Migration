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
        public Task<IActionResult> GetBankCoa()
        {
            // load source 
            var bank = _dbWin.TmBanks.Select(x => new M_Bank()
            {
                IdBank = Guid.NewGuid(),
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


            var subKlasifikasi = _dbWin.TmCoaSubklasifikasis.Select(x => new M_CoaSubklasifikasi()
            {
                IdSubklasifikasi = Guid.NewGuid(),
                OldIdSubklasifikasi = x.IdSubklasifikasi,
                Kdsubklasifikasi = x.VKdsubklasifikasi,
                DC = x.VDc,
                NmSubKlasifikasi = x.VNmsubklasifikasi,
                Urut = x.VUrut,
                IdKlasifikasi = x.IdKlasifikasi,
                IsAktif = x.IsAktif
            });

            var coa = _dbWin.TmCoas.Select(x => new M_Coa()
            {
                IdCoa = Guid.NewGuid(),
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
            });

            var klasifikasi = _dbWin.TmCoaKlasifikasis.Select(x => new M_CoaKlasifikasi()
            {
                IdKlasifikasi = x.IdKlasifikasi,
                NmKlasifikasi = x.VNmklasifikasi,
                Urut = x.VUrut,
                IsAktif = x.IsAktif,
                IdGolongan = x.IdGolongan,
            });

            var golongan = _dbWin.TmCoaGolongans.Select(x => new M_CoaGolongan()
            {
                IdGolongan = x.IdGolongan,
                NmGolongan = x.VNmgolongan,
                IsAktif = x.IsAktif
            });

            _dbs.AddRange(golongan);
            _dbs.AddRange(klasifikasi);
            _dbs.AddRange(subKlasifikasi);
            _dbs.AddRange(coa);
            _dbs.AddRange(bank);

            _dbs.SaveChanges();

            return Task.FromResult<IActionResult>(Ok("Asal"));
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
