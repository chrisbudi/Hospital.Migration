using EFCore.BulkExtensions;
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
        public async Task<IActionResult> GetBarangAturanPakai()
        {

            if (!_dbs.TmKelompokbarangs.Any())
            {
                // load source 
                var kelBarang = _dbWin.TmKelompokbarangs.Select(m => new M_KelompokBarang()
                {
                    IdGroupTarif = m.IdGrouptarif,
                    KelompokId = m.Kelompokid,
                    Kode = m.Kode,
                    Margin = m.Margin,
                    Nama = m.Nama,
                    Note = m.Note ?? "",
                    IsAktif = m.IsAktif,
                });
                await _dbs.BulkInsertAsync(kelBarang, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }


            // load source 
            if (!_dbs.TmFarmakoterapis.Any())
            {
                var farmako = _dbWin.TmFarmakoterapis.
                    Select(m => new M_Farmakoterapi()
                    {
                        IdFarmakoterapi = (long)m.IdFarmakoterapi,
                        Nmfarmakoterapi = m.VNmfarmakoterapi,
                        IsAktif = m.IsAktif
                    });
                await _dbs.BulkInsertAsync(farmako, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmFarmakoterapiSubs.Any())
            {
                var subfarmako = _dbWin.TmFarmakoterapiSubs.
                    Select(m => new M_FarmakoterapiSub()
                    {
                        IdFarmakoterapi = (long)m.IdFarmakoterapi,
                        IdSubfarmakoterapi = (long)m.IdSubfarmakoterapi,
                        NmSubFarmakoterapi = m.VNmsubfarmakoterapi,
                        IsAktif = m.IsAktif
                    });
                await _dbs.BulkInsertAsync(subfarmako, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmBarangs.Any())
            {

                // load source 
                var barang = _dbWin.TmBarangs.AsEnumerable().Select(m => new M_Barang()
                {
                    BarangId = Ulid.NewUlid(),
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
                });
                await _dbs.AddRangeAsync(barang);
                await _dbs.BulkSaveChangesAsync();

            }

            //if (!_dbs.TmBarangAturanpakais.Any())
            //{
            //    var barangPakai = _dbWin.TmBarangAturanpakais.Select(m => new M_BarangAturanpakai()
            //    {
            //        IdAturanpakai = m.IdAturanpakai,
            //        KdAturanPakai = m.VKdaturanpakai,
            //        Nmaturanpakai = m.VNmaturanpakai,
            //        Ketaturanpakai = m.VKetaturanpakai,
            //    });
            //    await _dbs.BulkInsertAsync(barangPakai, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
            //    await _dbs.BulkSaveChangesAsync();
            //}
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



            return Ok("Asal");
        }
    }
}
