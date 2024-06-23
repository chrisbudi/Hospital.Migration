using EFCore.BulkExtensions;
using Microsoft.AspNetCore.Mvc;
using WincareMigrations.Models;
using WincareMigrations.NewModels;

namespace WincareMigrations.Controllers.Master
{
    [Route("api/[controller]")]
    [ApiController]
    public class EFGHJ_Controller(WinCare2Context _dbWin, SimpleContext _dbs) : ControllerBase
    {

        [HttpGet()]
        public async Task<IActionResult> GetEFGHJCoa()
        {

            if (!_dbs.TmGudangs.Any())
            {

                var gudang = _dbWin.TmGudangs
                    .Select(m => new M_Gudang()
                    {
                        IdGudangObat = (long)m.IdGudangobat,
                        IsListropp = m.IsListropp,
                        IsPaketbhp = m.IsPaketbhp,
                        IsRequest = m.IsRequest,
                        IsReturbhp = m.IsReturbhp,
                        IsTipebarang = m.IsTipebarang ?? "0",
                        KodeInventory = m.VKodeinventory,
                        NamaGudangObat = m.VNamagudangobat,
                        IsAktif = m.IsAktif
                    }).ToList();

                await _dbs.BulkInsertAsync(gudang, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmGizis.Any())
            {

                var gizi = _dbWin.TmGizis
                    .Select(m => new M_Gizi()
                    {
                        IdGizi = (long)m.IdGizi,
                        OldIdGizi = m.IdGizi,
                        DAir = m.DAir,
                        DBdd = m.DBdd,
                        DCalsium = m.DCalsium,
                        DEnergi = m.DEnergi,
                        DFe = m.DFe,
                        DFosfor = m.DFosfor,
                        DKh = m.DKh,
                        DLemak = m.DLemak,
                        DProtein = m.DProtein,
                        DVita = m.DVita,
                        DVitb1 = m.DVitb1,
                        DVitc = m.DVitc,
                        VGroup = m.VGroup,
                        VKandungan = m.VKandungan,
                        VKdmakanan = m.VKdmakanan,
                        VNmmakanan = m.VNmmakanan,
                        VNote = m.VNote,
                        IsAktif = m.IsAktif,

                    }).ToList();

                await _dbs.AddRangeAsync(gizi);
                await _dbs.BulkSaveChangesAsync();

            }
            if (!_dbs.TmSuppliers.Any())
            {
                var supplier = _dbWin.TmSuppliers.Select(m => new M_Supplier()
                {
                    Alamat = m.Alamat ?? "",
                    Cp = m.Cp ?? "",
                    Fax = m.Fax ?? "",
                    IsAktif = m.Isaktif,
                    KdAkun = m.VKdakun ?? "",
                    Kota = m.Kota ?? "",
                    NamaSupplier = m.Namasupplier,
                    Note = m.Note ?? "",
                    SupplierId = (long)m.Supplierid,
                    Telpon = m.Telpon ?? ""
                });
                await _dbs.BulkInsertAsync(supplier, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmHargabarangs.Any())
            {
                var hBarang = _dbWin.TmHargabarangs.AsEnumerable()
                    .Select(m => new M_HargaBarang()
                    {
                        Idhargabeli = Ulid.NewUlid(),
                        OldIdhargabeli = m.Idhargabeli,
                        DiskonOn = m.Diskonon,
                        DiskonOff = m.Diskonoff,
                        OldBarangId = m.Barangid,
                        Harga = m.Harga,
                        InputBy = m.Inputby ?? "",
                        LastUpdate = m.Lastupdate,
                        Ppn = m.Ppn,
                        SupplierId = m.Supplierid.HasValue ? (long)m.Supplierid : null,
                        IsAktif = m.IsAktif
                    });
                // mapping barangid
                await _dbs.BulkInsertAsync(hBarang, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.Default });
                //await _dbs.AddRangeAsync(hBarang);
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmHargakamars.Any())
            {
                var hKamar = _dbWin.TmHargakamars
                    .Select(m => new M_Hargakamar()
                    {
                        IdHargakamar = (long)m.IdHargakamar,
                        IsAktif = m.IsAktif,
                        By = m.VBy ?? "",
                        Kelas = m.VKelas,

                    }).ToList();
                // harga kamar
                await _dbs.BulkInsertAsync(hKamar, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmRekanans.Any())
            {
                var rekanan = _dbWin.TmRekanans.Select(m => new M_Rekanan()
                {
                    IdRekanan = (long)m.Rekananid,
                    NmRekanan = m.VNmrekanan,
                    Alamat = m.VAlamat ?? "",
                    Alias = m.VAlias,
                    IsAktif = m.IsAktif,
                    IsCob = m.IsCob ?? false,
                    IsPaketbhp = m.IsPaketbhp,
                    IsTarif = m.IsTarif,
                    IsTarifNonMed = m.IsTarifnonmed,
                    KdAkun = m.VKdakun ?? "",
                    Kota = m.VKota ?? "",
                    Telp = m.VTelp ?? "",
                });

                await _dbs.BulkInsertAsync(rekanan, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmHargarekanans.Any())
            {
                var hRekanan = _dbWin.TmHargarekanans
                    .Select(m => new M_Hargarekanan()
                    {
                        IdHargaRekanan = (long)m.Idhargarekanan,
                        InpuBy = m.Inpuby ?? "",
                        IsAktif = m.IsAktif,
                        Hargajual = m.Hargajual,
                        Harga = m.Harga,
                        OldBarangId = m.Barangid,
                        Diskon = m.Diskon,
                        LastUpdate = m.Lastupdate,
                        Margin = m.Margin,
                        Ppn = m.Ppn,
                        OldIdHargaRekanan = m.Idhargarekanan,
                        RekananId = m.Rekananid.HasValue ? (long)m.Rekananid : null,
                    });
                await _dbs.BulkInsertAsync(hRekanan, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }


            if (!_dbs.TmJadwaldokters.Any())
            {
                var jadwalDokter = _dbWin.TmJadwaldokters
                    .Select(m => new M_Jadwaldokter()
                    {
                        IdJadwal = (long)m.IdJadwal,
                        KdDokter = m.VKddokter,
                        Hari = m.VHari,
                        JamFinish = m.VJamfinish,
                        JamStart = m.VJamstart,
                        KodeRuangan = m.VKoderuangan,
                        NamaKlinik = m.VNamaklinik ?? "",
                        ServisTime = m.IServistime,
                        IsAktif = m.IsAktif,
                    });

                await _dbs.BulkInsertAsync(jadwalDokter, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }



            return (Ok("Asal"));
        }




        [HttpGet("fixMapping")]
        public Task<IActionResult> FixMapping()
        {
            var Hbarang = _dbs.TmHargabarangs.ToList();
            var barang = _dbs.TmBarangs.ToList();
            var hRekanan = _dbs.TmHargarekanans.ToList();

            foreach (var harga in Hbarang)
            {
                harga.BarangId = barang.SingleOrDefault(m => m.OldBarangId == harga.OldBarangId).BarangId;
            }

            foreach (var harga in hRekanan)
            {
                harga.BarangId = barang.SingleOrDefault(m => m.OldBarangId == harga.OldBarangId).BarangId;
            }

            var jadwalDokter = _dbs.TmJadwaldokters.ToList();
            var dokter = _dbs.TmDokters.ToList();
            var ruang = _dbs.TmRuangs.ToList();

            foreach (var item in jadwalDokter)
            {
                item.IdDokter = dokter.SingleOrDefault(m => m.KdDokter == item.KdDokter).IdDokter;
                item.IdRuangan = ruang.SingleOrDefault(m => m.Koderuangan == item.KodeRuangan).IdRuang;
            }


            _dbs.SaveChanges();

            return Task.FromResult<IActionResult>(Ok("Asal"));
        }
    }



}
