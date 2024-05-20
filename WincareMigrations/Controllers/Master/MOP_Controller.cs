using Microsoft.AspNetCore.Mvc;
using WincareMigrations.Models;
using WincareMigrations.NewModels;

namespace WincareMigrations.Controllers.Master
{
    [Route("api/[controller]")]
    [ApiController]
    public class MOP_Controller(WinCare2Context _dbWin, SimpleContext _dbs) : ControllerBase
    {

        [HttpGet()]
        public Task<IActionResult> GetMOP()
        {
            // load source 
            var maps = _dbWin.TmMaps.Select(m => new M_Map()
            {
                IdMapid = m.IdMapid,
                //IdRuang = m.IdRuang,
                Image = m.IImage,
                IsAktif = m.IsAktif,
                KodeRuangan = m.VKoderuangan,
                Note = m.VNote,
                Nmmap = m.VNmmap,
            });
            // mapping id ruangan

            _dbs.AddRange(maps);


            var modul = _dbWin.TmModules.Select(m => new M_Module()
            {
                IdModule = (int)m.IdModule,
                Nmmodule = m.VNmmodule,
                IsAktif = m.IsAktif,
            });

            _dbs.AddRange(modul);

            var modulDetail = _dbWin.TmModuleDetails.Select(m => new M_ModuleDetail()
            {
                IdModule = (int)m.IdModule,
                IsAktif = m.IsAktif,
                IdModuledetail = (int)m.IdModuledetail,
                NmModulDetail = m.VNmmoduledetailsub,
                Urut = m.VUrut,
                NmModuleDetailSub = m.VNmmoduledetailsub,
            });

            _dbs.AddRange(modulDetail);


            var morfologi = _dbWin.TmMorfologis.Select(m => new M_Morfologi()
            {
                IdMorfologi = m.IdMorfologi,
                //IdDiagnosa = m.IdDiagnosa,
                Kddiagnosa = m.VKddiagnosa,
                Kdmorfologi = m.VKdmorfologi,
                Nmmorfologi = m.VNmmorfologi,
                IsAktif = m.IsAktif,
            });

            _dbs.AddRange(morfologi);

            var obatUnit = _dbWin.TmObatunits.Select(m => new M_Obatunit()
            {
                By = m.VBy,
                ExpiredDate = m.DExpireddate,
                IdObatUnit = m.IdObatunit,
                KdObat = m.VKdobat,
                KodeInventory = m.VKodeinventory,
                NmObat = m.VNmobat,
                Rod = m.VRod,
                StokMax = m.DStokmax,
                StokMin = m.DStokmin,
                StokNow = m.DStoknow,
                IsAktif = m.IsAktif,
                OldBarangId = m.Barangid,
            });
            // mapping barangid
            _dbs.AddRange(obatUnit);

            var paket = _dbWin.TmPaketHargas.Select(m => new M_PaketHarga()
            {
                IsAktif = m.IsAktif,
                By = m.VBy,
                Adm = m.DAdm,
                BahanAlkes = m.DBahanalkes,
                Beapasien = m.DBeapasien,
                Bearekanan = m.DBearekanan,
                Cito = m.DCito,
                Diskon = m.DDiskon,
                Harga = m.DHarga,
                Lastupdate = m.DLastupdate,
                Tglakhir = m.DTglakhir,
                Tglawal = m.DTglawal,
                Jasamedis = m.DJasamedis,
                Jasamedis2 = m.DJasamedis2,
                Jasamedis3 = m.DJasamedis3,
                Jasamedis4 = m.DJasamedis4,
                Jasamedis5 = m.DJasamedis5,
                JasaRS = m.DJasars,
                Jumlah = m.DJumlah,
                DPenyulit = m.DPenyulit,
                SecondTnd = m.D2tnd,
                DSubtotal = m.DSubtotal,
                OldIdMasterPemeriksaanPenunjang = m.IdMasterpemeriksaanpenunjang,
                Kelas = m.VKelas,
                OldIdPaketkelas = m.IdPaketkelas,
                OldIdPenunjangDetail = m.IdPenunjangdetail,
                OldRekananId = m.Rekananid,

            });
            // mapping rekanan id, id penunjang, id master pemeriksaan penunjang, rekananan
            _dbs.AddRange(paket);

            var paketHargaBaru = _dbWin.TmPaketHargaBarus.Select(m => new M_PaketHargaBaru()
            {
                IsAktif = m.IsAktif,
                By = m.VBy,
                Adm = m.DAdm,
                Bahanalkes = m.DBahanalkes,
                Beapasien = m.DBeapasien,
                Bearekanan = m.DBearekanan,
                Cito = m.DCito,
                Diskon = m.DDiskon,
                Harga = m.DHarga,
                Lastupdate = m.DLastupdate,
                Tglakhir = m.DTglakhir,
                Tglawal = m.DTglawal,
                Jasamedis = m.DJasamedis,
                Jasamedis2 = m.DJasamedis2,
                Jasamedis3 = m.DJasamedis3,
                Jasamedis4 = m.DJasamedis4,
                Jasamedis5 = m.DJasamedis5,
                Jasars = m.DJasars,
                Jumlah = m.DJumlah,
                Penyulit = m.DPenyulit,
                SecondTnd = m.D2tnd,
                Subtotal = m.DSubtotal,
                OldIdMasterPemeriksaanPenunjang = m.IdMasterpemeriksaanpenunjang,
                Kelas = m.VKelas,
                OldIdPenunjangDetail = m.IdPenunjangdetail,
                OldRekananid = m.Rekananid,


            });

            // mapping rekanan id, id penunjang, id master pemeriksaan penunjang, rekananan
            _dbs.AddRange(paketHargaBaru);


            var paketMatrix = _dbWin.TmPaketMatrices.Select(m => new M_PaketMatrix()
            {
                IsAktif = m.IsAktif,
                IdPaketmatrix = Guid.NewGuid(),
                KodeRuangan = m.VKoderuangan,
                OldIdPaketmatrix = m.IdPaketmatrix
            });

            _dbs.AddRange(paketMatrix);

            var paketRekanan = _dbWin.TmPaketRekanans.Select(m => new M_PaketRekanan()
            {
                IsAktif = m.IsAktif,
                OldIdMasterPemeriksaanPenunjang = m.IdMasterpemeriksaanpenunjang,
                OldIdPaketRekanan = m.IdPaketrekanan,
                OldRekananId = m.Rekananid
            });

            _dbs.AddRange(paketRekanan);

            var paketDetail = _dbWin.TmPaketdetails.Select(m => new M_Paketdetail()
            {
                Group = m.VGroup,
                Harga = m.DHarga,
                IdPaketdetail = m.IdPaketdetail,
                KdPaketDetail = m.VKdpaketdetail,
                NmPaketDetail = m.VNmpaketdetail,
                Rekanan = m.Rekanan,
                VTipe = m.VTipe
            });
            _dbs.AddRange(paketDetail);

            var pasien = _dbWin.TmPasiens.Select(m => new M_Pasien()
            {
                IdPasien = Guid.NewGuid(),
                OldIdPasien = m.IdNumpasien,
                PasienNo = m.IdPasien,
                AlamatPasien = m.VAlamatpasien,
                AlamatPekerjaan = m.VAlamatpekerjaan,
                AlamatPenanggung = m.VAlamatpenanggung,
                AlergiPasien = m.VAlergipasien,
                AyahPasien = m.VAyahpasien,
                AgamaPasien = m.VAgamapasien,
                By = m.VBy,
                CatKhusPasien = m.VCatkhuspasien,
                Goldarah = m.CGoldarah,
                HpPasien = m.VHppasien,
                IbuPasien = m.VIbupasien,
                IsAktif = m.IsAktif,
                IsBlacklist = m.IsBlacklist,
                Iscetakkartu = m.CIscetakkartu,
                IsKunjungan = m.IsKunjungan,
                JenisIdentitas = m.VJenisidentitas,
                Jenispasien = m.VJenispasien,
                Kelaminpasien = m.CKelaminpasien,
                Kodepos = m.VKodepos,
                KotaPasien = m.VKotapasien,
                NamaKelPasien = m.VNamakelpasien,
                NamaPasien = m.VNamapasien,
                NamaPenanggung = m.VNamapenanggung,
                Noktpsimpasien = m.VNoktpsimpasien,
                NoPenjamin = m.VNopenjamin,
                PasanganPasien = m.VPasanganpasien,
                PekerjaanPasien = m.VPekerjaanpasien,
                Pendidikanpasien = m.VPendidikanpasien,
                Perusahaan = m.VPerusahaan,
                Petugas = m.VPetugas,
                Provinsi = m.VProvinsi,
                RekananId = m.Rekananid,
                Rhesus = m.VRhesus,
                StatusKWNPasien = m.VStatuskwnpasien,
                Suku = m.VSuku,
                TelpPasien = m.VTelppasien,
                TelpPekerjaan = m.VTelppekerjaan,
                TelpPenanggung = m.VTelppenanggung,
                Tgldaftar = m.DTgldaftar,
                Tgllahirpasien = m.DTgllahirpasien,
                Tmptlahirpasien = m.VTmptlahirpasien,
                Warganegara = m.VWarganegara,
            });
            _dbs.AddRange(pasien);


            var pemeriksaanPenunjang = _dbWin.TmPemeriksaanpenunjangs.Select(m => new M_PemeriksaanPenunjang()
            {
                BeaPasien = m.DBeapasien,
                BeaRekanan = m.DBearekanan,
                By = m.VBy,
                Harga = m.DHarga,
                IdMasterPemeriksaanPenunjang = m.IdMasterpemeriksaanpenunjang,
                KdPemeriksaan = m.VKdpemeriksaan,
                NmPemeriksaan = m.VNmpemeriksaan,
                OldIdGroupTarif = m.IdGrouptarif,
                OldRekananId = m.Rekananid,
                Penunjang = m.VPenunjang,
                IsAktif = m.IsAktif,
            });
            // mapping rekanan id, id group tarif

            _dbs.AddRange(pemeriksaanPenunjang);

            var pemeriksaanPenunjangDetail = _dbWin.TmPemeriksaanpenunjangdetails.Select(m => new M_PemeriksaanPenunjangDetail()
            {
                Harga = m.DHarga,
                IsAktif = m.IsAktif,
                IdPenunjangDetail = m.IdPenunjangdetail,
                Jumlah = m.DJumlah,
                Group = m.VGroup,
                BeaPasien = m.DBeapasien,
                BeaRekanan = m.DBearekanan,
                IdMasterPemeriksaanPenunjang = m.IdMasterpemeriksaanpenunjang,
                KdDetail = m.VKddetail,
                KdPemeriksaan = m.VKdpemeriksaan,
                KodeTarif = m.VKodetarif,
                NmDetail = m.VNmdetail,
                Tipe = m.VTipe,
            });

            _dbs.AddRange(pemeriksaanPenunjangDetail);





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
