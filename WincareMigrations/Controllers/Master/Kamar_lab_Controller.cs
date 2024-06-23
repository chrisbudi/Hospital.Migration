using EFCore.BulkExtensions;
using Microsoft.AspNetCore.Mvc;
using WincareMigrations.Models;
using WincareMigrations.NewModels;

namespace WincareMigrations.Controllers.Master
{
    [Route("api/[controller]")]
    [ApiController]
    public class Kamar_lab_Controller(WinCare2Context _dbWin, SimpleContext _dbs) : ControllerBase
    {

        [HttpGet()]
        public async Task<IActionResult> GetKamar_LAb()
        {
            // load source 
            if (!_dbs.TmMaps.Any())
            {
                var maps = _dbWin.TmMaps.Select(m => new M_Map()
                {
                    IdMapid = (long)m.IdMapid,
                    //IdRuang = m.IdRuang,
                    Image = m.IImage,
                    IsAktif = m.IsAktif,
                    KodeRuangan = m.VKoderuangan,
                    Note = m.VNote,
                    Nmmap = m.VNmmap,
                });
                // mapping id ruangan

                await _dbs.BulkInsertAsync(maps, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }


            // load source 
            if (!_dbs.TmKamarinaps.Any())
            {
                var kmrInap = _dbWin.TmKamarinaps.Select(m => new M_Kamarinap()
                {
                    Nokamar = m.VNokamar,
                    IdKamarinap = (long)m.IdKamarinap,
                    KodeRuangan = m.VKoderuangan ?? "",
                    IdMapid = m.IdMapid.HasValue ? (long)m.IdMapid : null,
                    IsAktif = m.IsAktif,
                    Isi = m.CIsi,
                    IX = m.IX,
                    IY = m.IY,
                    KdTmpTidur = m.VKdtmptidur,
                    Kelas = m.VKelas,
                    KodeTarif = m.VKodetarif ?? "",
                    Lantai = m.VLantai,
                });
                // mapping id maps

                await _dbs.BulkInsertAsync(kmrInap,
                    new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmKamarinapHargas.Any())
            {
                var kmrHarga = _dbWin.TmKamarinapHargas.Select(m => new M_KamarinapHarga()
                {
                    Adm = m.DAdm,
                    Bahanalkes = m.DBahanalkes,
                    BeaPasien = m.DBeapasien,
                    By = m.VBy,
                    DBearekanan = m.DBearekanan,
                    DCito = m.DCito,
                    Diskon = m.DDiskon,
                    Harga = m.DHarga,
                    IsAktif = m.IsAktif,
                    JasaMedis = m.DJasamedis,
                    JasaRS = m.DJasars,
                    KdTmpTidur = m.VKdtmptidur,
                    IdKamarInapHarga = (long)m.IdKamarinapharga,
                    Penyulit = m.DPenyulit,
                    RekananId = m.Rekananid,
                    SecondTnd = m.D2tnd,
                    Tglakhir = m.DTglakhir,
                    Tglawal = m.DTglawal,
                });
                // mapping kamar inap id
                await _dbs.BulkInsertAsync(kmrHarga,
                                       new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmKamarinapRekanans.Any())
            {
                var kmrRek = _dbWin.TmKamarinapRekanans.Select(m => new M_KamarInapRekanan()
                {
                    IsAktif = m.IsAktif,
                    Kdtmptidur = m.VKdtmptidur,
                    IdKamarinaprek = m.IdKamarinaprek,
                    OldRekananId = m.Rekananid,
                });
                // mapping rekanan id
                await _dbs.BulkInsertAsync(kmrRek,
                                       new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }


            if (!_dbs.TmKodepos.Any())
            {
                var kodePos = _dbWin.TmKodepos.Select(m => new M_Kodepos()
                {
                    IdKodepos = (int)m.IdKodepos,
                    Kabupaten = m.VKabupaten,
                    KdKodePos = m.VKdkodepos,
                    Kecamatan = m.VKecamatan,
                    Kelurahan = m.VKelurahan,
                    Provinsi = m.VProvinsi,
                    IsAktif = m.IsAktif,
                });
                await _dbs.BulkInsertAsync(kodePos,
                    new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });

                await _dbs.BulkSaveChangesAsync();

            }

            if (!_dbs.TmLaboratoriumGroups.Any())
            {

                var labGroup = _dbWin.TmLaboratoriumGroups.Select(m => new M_LaboratoriumGroup()
                {
                    IdGroup = (long)m.IdGroup,
                    IdGrouptarif = m.IdGrouptarif,
                    IsAktif = m.IsAktif,
                    IsPk = m.IsPk,
                    VNmgroup = m.VNmgroup,
                });
                await _dbs.BulkInsertAsync(labGroup,
                    new BulkConfig() { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }


            // lab
            if (!_dbs.TmLaboratoria.Any())
            {
                var lab = _dbWin.TmLaboratoria.Select(m => new M_Laboratorium()
                {
                    IdGroup = (long)m.IdGroup,
                    IdPemeriksaanLab = (long)m.IdPemeriksaanlab,
                    IsAktif = m.CIsaktif,
                    KdPemeriksaanLab = m.VKdpemeriksaanlab,
                    NmPemeriksaanLab = m.VNmpemeriksaanlab,
                });
                await _dbs.BulkInsertAsync(lab, new BulkConfig() { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }



            if (!_dbs.TmLaboratoriumHargas.Any())
            {
                var labHarga = _dbWin.TmLaboratoriumHargas.Select(m => new M_LaboratoriumHarga()
                {
                    By = m.VBy ?? "",
                    Diskon = m.DDiskon,
                    Harga = m.DHarga,
                    IdLabharga = m.IdLabharga,
                    Bahanalkes = m.DBahanalkes,
                    Cito = m.DCito,
                    Beapasien = m.DBeapasien,
                    Bearekanan = m.DBearekanan,
                    DAdm = m.DAdm,
                    DLastupdate = m.DLastupdate,
                    DTglakhir = m.DTglakhir,
                    DTglawal = m.DTglawal,
                    //IdHargakamar = m.IdHargakamar,
                    //IdPemeriksaanLab = m.IdPemeriksaanlab,
                    Jasamedis = m.DJasamedis,
                    Jasars = m.DJasars,
                    KdPemeriksaanLab = m.VKdpemeriksaanlab,
                    Kelas = m.VKelas,
                    Penyulit = m.DPenyulit,
                    SecondTnd = m.D2tnd,
                    IsAktif = m.IsAktif,
                    RekananId = (long)m.Rekananid,
                });
                // mapping harga kamar, mapping labid
                await _dbs.BulkInsertAsync(labHarga,
                                       new BulkConfig() { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }
            if (_dbs.TmLaboratoriumRekanans.Any())
            {

                var labRek = _dbWin.TmLaboratoriumRekanans.Select(m => new M_LaboratoriumRekanan()
                {
                    IsAktif = m.IsAktif,
                    IdLabRekanan = (long)m.IdLabrekanan,
                    RekananId = (long)m.Rekananid,
                    KdPemeriksaanLab = m.VKdpemeriksaanlab,
                });
                await _dbs.BulkInsertAsync(labRek,
                                               new BulkConfig() { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            return (Ok("Kamar Lab"));
        }




        [HttpGet("fixMapping")]
        public Task<IActionResult> FixMapping()
        {
            var kamarInap = _dbs.TmKamarinaps.ToList();
            var rekanan = _dbs.TmRekanans.ToList();
            var laborat = _dbs.TmLaboratoria.ToList();
            var kmrInapharga = _dbs.TmKamarinapHargas.ToList();
            var labHarga = _dbs.TmLaboratoriumHargas.ToList();
            var labRek = _dbs.TmLaboratoriumRekanans.ToList();
            foreach (var item in kmrInapharga)
            {
                item.IdKamarinap = kamarInap.FirstOrDefault(m => m.KdTmpTidur == item.KdTmpTidur).IdKamarinap;
            }


            foreach (var item in labHarga)
            {
                item.IdHargakamar = kmrInapharga.FirstOrDefault(m => m.IdKamarInapHarga == item.IdHargakamar).IdKamarInapHarga;
                item.IdPemeriksaanLab = laborat.FirstOrDefault(m => m.KdPemeriksaanLab == item.KdPemeriksaanLab).IdPemeriksaanLab;
            }

            foreach (var item in labRek)
            {
                item.IdPemeriksaanLab = laborat.FirstOrDefault(m => m.KdPemeriksaanLab == item.KdPemeriksaanLab).IdPemeriksaanLab;
                item.RekananId = rekanan.FirstOrDefault(m => m.IdRekanan == item.RekananId).IdRekanan;
            }

            _dbs.SaveChanges();

            return Task.FromResult<IActionResult>(Ok("Asal"));
        }
    }



}
