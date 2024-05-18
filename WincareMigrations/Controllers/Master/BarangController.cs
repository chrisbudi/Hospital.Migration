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
            // load source 
            var barang = _dbWin.TmBarangs.Select(m => new M_Barang()
            {
                BarangId = new Guid(),
                OldBarangId = m.Barangid,
                Kode = m.Kode,
                KelompokId = m.Kelompokid,
                Merk = m.Merk,
                Nama = m.Nama,
                Diskonoff = m.Diskonoff,
                Diskonon = m.Diskonon,
                Etiket = m.Etiket,
                EtiketQty = m.EtiketQty,
                Expireddate = m.Expireddate,
                Farmakoterapi = m.Farmakoterapi,
                Hargabeli = m.Hargabeli,
                Hargajual = m.Hargajual,
                IdFarmakoterapi = m.IdFarmakoterapi,
                IdSubfarmakoterapi = m.IdSubfarmakoterapi,
                Isaktif = m.Isaktif,
                Isformularium = m.Isformularium,
                Isi = m.Isi,
                Jenis = m.Jenis,
                Kandungan = m.Kandungan,
                Kemasan = m.Kemasan,
                Nobatch = m.Nobatch,
                Note = m.Note,
                Pabrik = m.Pabrik,
                Satuan = m.Satuan,
                Subfarmakoterapi = m.Subfarmakoterapi,
                Stokmax = m.Stokmax,
                Stokmin = m.Stokmin,
                Tipebarang = m.Tipebarang,
                Stoknow = m.Stoknow,
                Ukuran = m.Ukuran,
                Timestamp = m.Timestamp,
            }).ToList();

            var barangPakai = _dbWin.TmBarangAturanpakais.Select(m => new M_BarangAturanpakai()
            {
                IdAturanpakai = m.IdAturanpakai,
                KdAturanPakai = m.VKdaturanpakai,
                Nmaturanpakai = m.VNmaturanpakai,
                Ketaturanpakai = m.VKetaturanpakai,
            }).ToList();

            var aturanPakai = _dbWin.TmAturanpakais.Select(m => new M_Aturanpakai()
            {
                IdAturanpakai = m.IdAturanpakai,
                KdAturanPakai = m.VKdaturanpakai,
                NamaAturanpakai = m.VNmaturanpakai,
                KetAturanpakai = m.VKetaturanpakai,
                IsAktif = m.IsAktif,
            }).ToList();

            _dbs.AddRange(barang);
            _dbs.AddRange(barangPakai);
            _dbs.AddRange(aturanPakai);


            _dbs.SaveChanges();



            return Task.FromResult<IActionResult>(Ok("Asal"));
        }
    }
}
