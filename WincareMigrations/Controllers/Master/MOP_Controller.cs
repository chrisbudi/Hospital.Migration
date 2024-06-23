using EFCore.BulkExtensions;
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
        public async Task<IActionResult> GetMOP()
        {

            if (!_dbs.TmModules.Any())
            {
                var modul = _dbWin.TmModules.Select(m => new M_Module()
                {
                    IdModule = (int)m.IdModule,
                    Nmmodule = m.VNmmodule,
                    IsAktif = m.IsAktif,
                });

                await _dbs.BulkInsertAsync(modul, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }


            if (!_dbs.TmModules.Any())
            {
                var modulDetail = _dbWin.TmModuleDetails.Select(m => new M_ModuleDetail()
                {
                    IdModule = (int)m.IdModule,
                    IsAktif = m.IsAktif,
                    IdModuledetail = (int)m.IdModuledetail,
                    NmModulDetail = m.VNmmoduledetailsub,
                    Urut = m.VUrut,
                    NmModuleDetailSub = m.VNmmoduledetailsub,
                });
                await _dbs.BulkInsertAsync(modulDetail, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();

            }


            if (!_dbs.TmMorfologis.Any())
            {
                var morfologi = _dbWin.TmMorfologis.Select(m => new M_Morfologi()
                {
                    IdMorfologi = (long)m.IdMorfologi,
                    //IdDiagnosa = m.IdDiagnosa,
                    Kddiagnosa = m.VKddiagnosa,
                    Kdmorfologi = m.VKdmorfologi,
                    Nmmorfologi = m.VNmmorfologi,
                    IsAktif = m.IsAktif,
                });

                await _dbs.BulkInsertAsync(morfologi, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }


            if (_dbs.TmObatunits.Any())
            {
                var obatUnit = _dbWin.TmObatunits.Select(m => new M_Obatunit()
                {
                    By = m.VBy,
                    ExpiredDate = m.DExpireddate,
                    IdObatUnit = (long)m.IdObatunit,
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

                await _dbs.BulkInsertAsync(obatUnit, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }


            if (!_dbs.TmPaketHargas.Any())
            {

                var paket = _dbWin.TmPaketHargas.Select(m => new M_PaketHarga()
                {
                    IsAktif = m.IsAktif,
                    By = m.VBy ?? "",
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
                    OldRekananId = m.Rekananid
                });

                // mapping rekanan id, id penunjang, id master pemeriksaan penunjang, rekananan
                await _dbs.AddRangeAsync(paket);
                await _dbs.BulkSaveChangesAsync();

            }


            if (!_dbs.TmPaketHargaBarus.Any())
            {
                var paketHargaBaru = _dbWin.TmPaketHargaBarus.Select(m => new M_PaketHargaBaru()
                {
                    IsAktif = m.IsAktif,
                    By = m.VBy ?? "",
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
                    IdPaketkelas = (long)m.IdPaketkelas
                });

                await _dbs.BulkInsertAsync(paketHargaBaru, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }


            if (!_dbs.TmPaketHargaBarus.Any())
            {

                var paketMatrix = _dbWin.TmPaketMatrices.AsEnumerable().Select(m => new M_PaketMatrix()
                {
                    IsAktif = m.IsAktif,
                    IdPaketmatrix = Ulid.NewUlid(),
                    KodeRuangan = m.VKoderuangan,
                    OldIdPaketmatrix = (long)m.IdPaketmatrix
                });
                await _dbs.BulkInsertAsync(paketMatrix, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmPaketHargaBarus.Any())
            {

                var paketRekanan = _dbWin.TmPaketRekanans.Select(m => new M_PaketRekanan()
                {
                    IsAktif = m.IsAktif,
                    OldIdMasterPemeriksaanPenunjang = (long)m.IdMasterpemeriksaanpenunjang,
                    OldIdPaketRekanan = m.IdPaketrekanan,
                    OldRekananId = (long)m.Rekananid
                });
                await _dbs.BulkInsertAsync(paketRekanan, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }
            if (!_dbs.TmPaketHargaBarus.Any())
            {

                var paketDetail = _dbWin.TmPaketdetails.Select(m => new M_Paketdetail()
                {
                    Group = m.VGroup,
                    Harga = m.DHarga,
                    IdPaketdetail = (long)m.IdPaketdetail,
                    KdPaketDetail = m.VKdpaketdetail,
                    NmPaketDetail = m.VNmpaketdetail,
                    Rekanan = m.Rekanan,
                    VTipe = m.VTipe
                });
                await _dbs.BulkInsertAsync(paketDetail, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmPaketHargaBarus.Any())
            {

                var pasien = _dbWin.TmPasiens.AsEnumerable().Select(m => new M_Pasien()
                {
                    IdPasien = Ulid.NewUlid(),
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
                    RekananId = (long)m.Rekananid,
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
                await _dbs.BulkInsertAsync(pasien, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmPaketHargaBarus.Any())
            {

                var pemeriksaanPenunjang = _dbWin.TmPemeriksaanpenunjangs.Select(m => new M_PemeriksaanPenunjang()
                {
                    BeaPasien = m.DBeapasien,
                    BeaRekanan = m.DBearekanan,
                    By = m.VBy,
                    Harga = m.DHarga,
                    IdMasterPemeriksaanPenunjang = (long)m.IdMasterpemeriksaanpenunjang,
                    KdPemeriksaan = m.VKdpemeriksaan,
                    NmPemeriksaan = m.VNmpemeriksaan,
                    OldIdGroupTarif = m.IdGrouptarif,
                    OldRekananId = m.Rekananid,
                    Penunjang = m.VPenunjang,
                    IsAktif = m.IsAktif,
                });
                // mapping rekanan id, id group tarif
                await _dbs.BulkInsertAsync(pemeriksaanPenunjang, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmPaketHargaBarus.Any())
            {

                var pemeriksaanPenunjangDetail = _dbWin.TmPemeriksaanpenunjangdetails.Select(m => new M_PemeriksaanPenunjangDetail()
                {
                    Harga = m.DHarga,
                    IsAktif = m.IsAktif,
                    IdPenunjangDetail = (long)m.IdPenunjangdetail,
                    Jumlah = m.DJumlah,
                    Group = m.VGroup,
                    BeaPasien = m.DBeapasien,
                    BeaRekanan = m.DBearekanan,
                    IdMasterPemeriksaanPenunjang = (long)m.IdMasterpemeriksaanpenunjang,
                    KdDetail = m.VKddetail,
                    KdPemeriksaan = m.VKdpemeriksaan,
                    KodeTarif = m.VKodetarif,
                    NmDetail = m.VNmdetail,
                    Tipe = m.VTipe,
                });
                await _dbs.BulkInsertAsync(pemeriksaanPenunjangDetail, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();

            }




            return (Ok("Asal"));
        }




        [HttpGet("fixMapping")]
        public Task<IActionResult> FixMapping()
        {

            return Task.FromResult<IActionResult>(Ok("Asal"));
        }
    }



}
