using Microsoft.AspNetCore.Mvc;
using WincareMigrations.Models;
using WincareMigrations.NewModels;

namespace WincareMigrations.Controllers.Master
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarangController(WinCare2Context _dbWin, SimpleContext _dbs) : ControllerBase
    {

        [HttpGet()]
        public Task<IActionResult> GetBarangAturanPakai()
        {

            var kelBarang = _dbWin.TmKelompokbarangs.Select(m => new M_KelompokBarang()
            {
                IdGroupTarif = m.IdGrouptarif,
                KelompokId = m.Kelompokid,
                Kode = m.Kode,
                Margin = m.Margin,
                Nama = m.Nama,
                Note = m.Note ?? "",
                IsAktif = m.IsAktif,
            }).ToList();

            _dbs.AddRange(kelBarang);

            // load source 
            var farmako = _dbWin.TmFarmakoterapis.
                Select(m => new M_Farmakoterapi()
                {
                    IdFarmakoterapi = m.IdFarmakoterapi,
                    Nmfarmakoterapi = m.VNmfarmakoterapi,
                    IsAktif = m.IsAktif
                }).ToList();
            _dbs.AddRange(farmako);

            var subfarmako = _dbWin.TmFarmakoterapiSubs.
                Select(m => new M_FarmakoterapiSub()
                {
                    IdFarmakoterapi = m.IdFarmakoterapi,
                    IdSubfarmakoterapi = m.IdSubfarmakoterapi,
                    NmSubFarmakoterapi = m.VNmsubfarmakoterapi,
                    IsAktif = m.IsAktif
                }).ToList();

            _dbs.AddRange(subfarmako);


            // load source 
            var barang = _dbWin.TmBarangs.Select(m => new M_Barang()
            {
                BarangId = new Guid(),
                OldBarangId = m.Barangid,
                Kode = m.Kode,
                KelompokId = m.Kelompokid ?? 126,
                Merk = m.Merk ?? "",
                Nama = m.Nama,
                Diskonoff = m.Diskonoff,
                Diskonon = m.Diskonon,
                Etiket = m.Etiket ?? "",
                EtiketQty = m.EtiketQty,
                Expireddate = m.Expireddate,
                Farmakoterapi = m.Farmakoterapi ?? "",
                Hargabeli = m.Hargabeli,
                Hargajual = m.Hargajual,
                IdFarmakoterapi = null,
                IdSubfarmakoterapi = null,
                Isaktif = m.Isaktif,
                Isformularium = m.Isformularium,
                Isi = m.Isi,
                Jenis = m.Jenis ?? "",
                Kandungan = m.Kandungan ?? "",
                Kemasan = m.Kemasan ?? "",
                Nobatch = m.Nobatch ?? "",
                Note = m.Note ?? "",
                Pabrik = m.Pabrik,
                Satuan = m.Satuan ?? "",
                Subfarmakoterapi = m.Subfarmakoterapi ?? "",
                Stokmax = m.Stokmax,
                Stokmin = m.Stokmin,
                Tipebarang = m.Tipebarang,
                Stoknow = m.Stoknow,
                Ukuran = m.Ukuran,
            }).ToList();

            _dbs.AddRange(barang);

            //var barangPakai = _dbWin.TmBarangAturanpakais.Select(m => new M_BarangAturanpakai()
            //{
            //    IdAturanpakai = m.IdAturanpakai,
            //    KdAturanPakai = m.VKdaturanpakai,
            //    Nmaturanpakai = m.VNmaturanpakai,
            //    Ketaturanpakai = m.VKetaturanpakai,
            //}).ToList();
            //_dbs.AddRange(barangPakai);

            var aturanPakai = _dbWin.TmAturanpakais.Select(m => new M_Aturanpakai()
            {
                IdAturanpakai = m.IdAturanpakai,
                KdAturanPakai = m.VKdaturanpakai,
                NamaAturanpakai = m.VNmaturanpakai,
                KetAturanpakai = m.VKetaturanpakai,
                IsAktif = m.IsAktif,
            }).ToList();

            _dbs.AddRange(aturanPakai);


            _dbs.SaveChanges();



            return Task.FromResult<IActionResult>(Ok("Asal"));
        }
    }
}
