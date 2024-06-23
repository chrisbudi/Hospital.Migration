using EFCore.BulkExtensions;
using Microsoft.AspNetCore.Mvc;
using WincareMigrations.Models;
using WincareMigrations.NewModels;

namespace WincareMigrations.Controllers.Master
{
    [Route("api/[controller]")]
    [ApiController]
    public class TU_Controller(WinCare2Context _dbWin, SimpleContext _dbs) : ControllerBase
    {

        [HttpGet()]
        public async Task<IActionResult> GetTU()
        {
            // load source 
            if (!_dbs.TmTarifGroups.Any())
            {
                var tarifGroup = _dbWin.TmTarifGroups.Select(m => new M_TarifGroup()
                {
                    AliasGroup = m.VAliasgroup,
                    IdGrouptarif = (int)m.IdGrouptarif,
                    IsAktif = m.IsAktif,
                    KdAkun = m.VKdakun,
                    NmGroupTarif = m.VNmgrouptarif,
                });
                await _dbs.BulkInsertAsync(tarifGroup, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }
            if (!_dbs.TmTarifHargas.Any())
            {
                var tarifHarga = _dbWin.TmTarifHargas.AsEnumerable().Select(m => new M_TarifHarga()
                {
                    IdTarifkelas = Ulid.NewUlid(),
                    IsAktif = m.IsAktif,
                    Cito = m.DCito,
                    Bearekanan = m.DBearekanan,
                    Adm = m.DAdm,
                    Bahanalkes = m.DBahanalkes,
                    Jasamedis = m.DJasamedis,
                    Jasars = m.DJasars,
                    Kelas = m.VKelas ?? "",
                    Penyulit = m.DPenyulit,
                    Tglawal = m.DTglawal,
                    Beapasien = m.DBeapasien,
                    Diskon = m.DDiskon,
                    By = m.VBy ?? "",
                    Harga = m.DHarga,
                    Jasamedis2 = m.DJasamedis2,
                    Jasamedis3 = m.DJasamedis3,
                    Jasamedis4 = m.DJasamedis4,
                    Jasamedis5 = m.DJasamedis5,
                    Kdtarifdetail = m.VKdtarifdetail,
                    Lastupdate = m.DLastupdate,
                    OldIdTarifkelas = m.IdTarifkelas,

                    OldRekananId = m.Rekananid,
                    SecondTnd = m.D2tnd,
                    Tglakhir = m.DTglakhir,
                });
                await _dbs.BulkInsertAsync(tarifHarga, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.Default });
                //await _dbs.AddRangeAsync(tarifHarga);
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmTarifMatrices.Any())
            {
                var tarifMatrix = _dbWin.TmTarifMatrices.AsEnumerable().Select(m => new M_TarifMatrix()
                {
                    IsAktif = m.IsAktif,
                    //IdRuang = m.IdRuang,
                    IdTarifmatrix = Ulid.NewUlid(),
                    //IdTarifdetail = m.tarif,
                    Kdtarifdetail = m.VKdtarifdetail,
                    Koderuangan = m.VKoderuangan,
                    OldIdTarifmatrix = m.IdTarifmatrix

                });
                await _dbs.AddRangeAsync(tarifMatrix);
                await _dbs.BulkSaveChangesAsync();

            }

            if (!_dbs.TmTarifnonmedisGroups.Any())
            {
                var tarifNonMedis = _dbWin.TmTarifnonmedisGroups.Select(m => new M_TarifnonmedisGroup()
                {
                    KdAkun = m.VKdakun,
                    IdGroupNonMedis = (int)m.IdGroupnonmedis,
                    NmGroupNonMedis = m.VNmgroupnonmedis,
                });

                await _dbs.BulkInsertAsync(tarifNonMedis, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();

            }
            if (!_dbs.TmTarifnonmedis.Any())
            {
                var tarifnonMedis = _dbWin.TmTarifnonmedis.Select(m => new M_TarifNonMedis()
                {
                    IsAktif = m.IsAktif,
                    IdGroupNonMedis = (int?)m.IdGroupnonmedis,
                    IdNonMedis = (int)m.IdNonmedis,
                    KdTarif = m.VKdtarif,
                    NmTarif = m.VNmtarif
                });
                await _dbs.BulkInsertAsync(tarifnonMedis, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }


            if (!_dbs.TmTarifnonmedisHargas.Any())
            {
                var tarifnonMedisHarga = _dbWin.TmTarifnonmedisHargas.Select(m => new M_TarifnonmedisHarga()
                {
                    IsAktif = m.IsAktif,
                    DHarga = m.DHarga,
                    Kdtarif = m.VKdtarif,
                    OldRekananId = m.IdRekanan,
                    DBeapasien = m.DBeapasien,
                    DBearekanan = m.DBearekanan,
                    IdNonmedishrg = (int)m.IdNonmedishrg,
                });
                await _dbs.BulkInsertAsync(tarifnonMedisHarga, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();

            }




            if (!_dbs.TmTarifnonmedisMatrices.Any())
            {
                var tarifnonMedisMatric = _dbWin.TmTarifnonmedisMatrices.Select(m => new M_TarifnonmedisMatrix()
                {
                    IdNonMedisMatrix = m.IdNonmedismatrix,
                    KdTarif = m.VKdtarif,
                    VKoderuangan = m.VKoderuangan,
                    //IdNonMedis = m.

                });
                await _dbs.BulkInsertAsync(tarifnonMedisMatric, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();


            }
            if (!_dbs.TmTarifRekanans.Any())
            {
                var tarifRekanan = _dbWin.TmTarifRekanans.AsEnumerable().Select(m => new M_TarifRekanan()
                {
                    IdTarifRekanan = Ulid.NewUlid(),
                    KdTarifDetail = m.VKdtarifdetail,
                    IsAktif = m.IsAktif,
                    OldIdTarifRekanan = m.IdTarifrekanan,
                    OldRekananId = m.Rekananid
                });
                await _dbs.AddRangeAsync(tarifRekanan);
                await _dbs.BulkSaveChangesAsync();
            }
            if (!_dbs.TmTarifPelayanans.Any())
            {
                var tarifPelayanan = _dbWin.TmTarifPelayanans.Select(m => new M_TarifPelayanan()
                {
                    IsAktif = m.IsAktif,
                    IdTariflayan = (int)m.IdTariflayan,
                    Kodetariflayan = m.VKodetariflayan,
                    Namatariflayan = m.VNamatariflayan
                });
                await _dbs.BulkInsertAsync(tarifPelayanan, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmTarifRekanans.Any())
            {
                var tarifRekanan = _dbWin.TmTarifRekanans.AsEnumerable().Select(m => new M_TarifRekanan()
                {
                    IdTarifRekanan = Ulid.NewUlid(),
                    KdTarifDetail = m.VKdtarifdetail,
                    IsAktif = m.IsAktif,
                    OldIdTarifRekanan = m.IdTarifrekanan,
                    OldRekananId = m.Rekananid,
                });
                await _dbs.AddRangeAsync(tarifRekanan);
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmTarifRekananSubs.Any())
            {
                var tarifRekananSub = _dbWin.TmTarifRekananSubs.AsEnumerable().Select(m => new M_TarifRekananSub()
                {
                    IdTarifrekanansub = Ulid.NewUlid(),
                    OldIdTarifRekananSub = m.IdTarifrekanansub,
                    RekananidDt = m.RekananidDt,
                    RekananIdHd = m.RekananidHd
                });
                await _dbs.BulkInsertAsync(tarifRekananSub, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmTindakans.Any())
            {
                var tindakan = _dbWin.TmTindakans.Select(m => new M_Tindakan()
                {
                    IdTindakan = m.IdTindakan,
                    IsAktif = m.IsAktif,
                    Kdtindakan = m.VKdtindakan,
                    Nmtindakan = m.VNmtindakan,
                    Nmpendek = m.VNmpendek
                });
                await _dbs.BulkInsertAsync(tindakan, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }


            if (!_dbs.TmUserGroups.Any())
            {
                var groupUser = _dbWin.TmUserGroups.Select(m => new M_UserGroup()
                {
                    IdGroupUser = m.IdGroupuser,
                    NmgroupUser = m.VNmgroupuser,
                });

                await _dbs.BulkInsertAsync(groupUser, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();

            }

            if (!_dbs.TmUsers.Any())
            {
                var user = _dbWin.TmUsers.AsEnumerable().Select(m => new M_User()
                {
                    Iduser = Ulid.NewUlid(),
                    IsAktif = m.CIsaktif,
                    Password = m.VPassword,
                    Id = m.Id,
                    IsDokter = m.BIsdokter,
                    IdGroupUser = m.IdGroupuser,
                    IdKaryawan = m.IdKaryawan,
                    KdDokter = m.VKddokter ?? "",
                    IsAdmin = m.BIsadmin,
                    IsManager = m.BIsmanager,
                    IsMemo = m.BIsmemo,
                    IsMod = m.BIsmod,
                    KodeRuangan = m.VKoderuangan,
                    Namalengkap = m.VNamalengkap,
                    IsUser = m.BIsuser,
                    Nmuser = m.VNmuser,
                    Pin = m.Pin,
                    Ttd = m.IsTtd,
                    OldIduser = m.IdNumuser,
                    Transmigrated = m.Transmigrated
                });
                await _dbs.BulkInsertAsync(user, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.Default });
                await _dbs.BulkSaveChangesAsync();

            }

            return Ok("Asal");
        }




        [HttpGet("fixMapping")]
        public Task<IActionResult> FixMapping()
        {

            return Task.FromResult<IActionResult>(Ok("Asal"));
        }
    }



}
