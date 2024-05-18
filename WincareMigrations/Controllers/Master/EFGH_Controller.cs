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
        public Task<IActionResult> GetEFGHJCoa()
        {
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


            var gudang = _dbWin.TmGudangs
                .Select(m => new M_Gudang()
                {
                    IdGudangObat = m.IdGudangobat,
                    IsListropp = m.IsListropp,
                    IsPaketbhp = m.IsPaketbhp,
                    IsRequest = m.IsRequest,
                    IsReturbhp = m.IsReturbhp,
                    IsTipebarang = m.IsTipebarang,
                    KodeInventory = m.VKodeinventory,
                    NamaGudangObat = m.VNamagudangobat,
                    IsAktif = m.IsAktif
                }).ToList();

            _dbs.AddRange(gudang);


            var gizi = _dbWin.TmGizis
                .Select(m => new M_Gizi()
                {
                    IdGizi = Guid.NewGuid(),
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

            _dbs.AddRange(gizi);

            var hBarang = _dbWin.TmHargabarangs
                .Select(m => new M_HargaBarang()
                {
                    Idhargabeli = Guid.NewGuid(),
                    OldIdhargabeli = m.Idhargabeli,
                    DiskonOn = m.Diskonon,
                    DiskonOff = m.Diskonoff,
                    OldBarangId = m.Barangid,
                    Harga = m.Harga,
                    InputBy = m.Inputby,
                    LastUpdate = m.Lastupdate,
                    Ppn = m.Ppn,
                    SupplierId = m.Supplierid,
                    IsAktif = m.IsAktif
                }).ToList();
            // mapping barangid
            _dbs.AddRange(hBarang);

            var hKamar = _dbWin.TmHargakamars
                .Select(m => new M_Hargakamar()
                {
                    IdHargakamar = m.IdHargakamar,
                    IsAktif = m.IsAktif,
                    By = m.VBy,
                    Kelas = m.VKelas,

                }).ToList();
            // harga kamar
            _dbs.AddRange(hKamar);


            var hRekanan = _dbWin.TmHargarekanans
                .Select(m => new M_Hargarekanan()
                {
                    IdHargaRekanan = Guid.NewGuid(),
                    InpuBy = m.Inpuby,
                    IsAktif = m.IsAktif,
                    Hargajual = m.Hargajual,
                    Harga = m.Harga,
                    OldBarangId = m.Barangid,
                    Diskon = m.Diskon,
                    LastUpdate = m.Lastupdate,
                    Margin = m.Margin,
                    Ppn = m.Ppn,
                    OldIdHargaRekanan = m.Idhargarekanan,
                    RekananId = m.Rekananid,



                }).ToList();
            // mapping barang id
            _dbs.AddRange(hRekanan);


            var jadwalDokter = _dbWin.TmJadwaldokters
                .Select(m => new M_Jadwaldokter()
                {
                    IdJadwal = m.IdJadwal,
                    KdDokter = m.VKddokter,
                    Hari = m.VHari,
                    JamFinish = m.VJamfinish,
                    JamStart = m.VJamstart,
                    KodeRuangan = m.VKoderuangan,
                    NamaKlinik = m.VNamaklinik,
                    ServisTime = m.IServistime,
                    IsAktif = m.IsAktif,

                }).ToList();

            _dbs.AddRange(jadwalDokter);

            _dbs.SaveChanges();

            return Task.FromResult<IActionResult>(Ok("Asal"));
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
