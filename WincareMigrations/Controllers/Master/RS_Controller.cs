using EFCore.BulkExtensions;
using Microsoft.AspNetCore.Mvc;
using WincareMigrations.Models;
using WincareMigrations.NewModels;

namespace WincareMigrations.Controllers.Master
{
    [Route("api/[controller]")]
    [ApiController]
    public class RS_Controller(WinCare2Context _dbWin, SimpleContext _dbs) : ControllerBase
    {

        [HttpGet()]
        public async Task<IActionResult> GetRS()
        {
            if (!_dbs.TmRadiologiGroups.Any())
            {
                var radiologiGroup = _dbWin.TmRadiologiGroups.Select(m => new M_RadiologiGroup()
                {
                    IdGroup = (long)m.IdGroup,
                    Nmgroup = m.VNmgroup,
                    IsAktif = m.IsAktif,
                    IdGrouptarif = (long)m.IdGrouptarif,
                });
                await _dbs.BulkInsertAsync(radiologiGroup, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            // load source 
            if (!_dbs.TmRadiologis.Any())
            {
                var radiologi = _dbWin.TmRadiologis.Select(m => new M_Radiologi()
                {
                    IdGroup = (long)m.IdGroup,
                    IdPemeriksaanRad = (long)m.IdPemeriksaanrad,
                    IsAktif = m.CIsaktif,
                    Kdpemeriksaanrad = m.VKdpemeriksaanrad,
                    NmPemeriksaanRad = m.VNmpemeriksaanrad,
                });

                await _dbs.BulkInsertAsync(radiologi, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });

                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmRadiologiHargas.Any())
            {

                var radiologiHarga = _dbWin.TmRadiologiHargas.Select(m => new M_RadiologiHarga()
                {
                    //IdPemeriksaanRad = m.,
                    IsAktif = m.IsAktif,
                    DSecondTnd = m.D2tnd,
                    DLastupdate = m.DLastupdate,
                    DHarga = m.DHarga,
                    DDiskon = m.DDiskon,
                    DBeapasien = m.DBeapasien,
                    Cito = m.DCito,
                    Bearekanan = m.DBearekanan,
                    Adm = m.DAdm,
                    BahanAlkes = m.DBahanalkes,
                    DTglakhir = m.DTglakhir,
                    //IdHargakamar = m,
                    IdRadharga = (long)m.IdRadharga,
                    Jasamedis = m.DJasamedis,
                    Jasars = m.DJasars,
                    KdPemeriksaanRad = m.VKdpemeriksaanrad,
                    Kelas = m.VKelas,
                    Penyulit = m.DPenyulit,
                    Rekananid = (long)m.Rekananid,
                    Tglawal = m.DTglawal,
                    VBy = m.VBy ?? "",
                });

                await _dbs.BulkInsertAsync(radiologiHarga, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmRadiologiHargas.Any())
            {
                var radiologiRekanan = _dbWin.TmRadiologiRekanans.Select(m => new M_RadiologiRekanan()
                {
                    IdRadrekanan = (long)m.IdRadrekanan,
                    IsAktif = m.IsAktif,
                    KdPemeriksaanRad = m.VKdpemeriksaanrad,
                    RekananId = (long)m.Rekananid,
                });
                await _dbs.BulkInsertAsync(radiologiRekanan, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmSettingAdms.Any())
            {
                var settingAdm = _dbWin.TmSettingAdms.Select(m => new M_SettingAdm()
                {
                    Biaya = m.DBiaya,
                    IdAdm = (int)m.IdNumadm,
                    Kategori = m.VKategori,
                    OldRekananId = m.Rekananid,
                    Percent = m.DPercent
                });

                await _dbs.BulkInsertAsync(settingAdm, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmSettingBayars.Any())
            {
                var settingBayar = _dbWin.TmSettingBayars.Select(m => new M_SettingBayar()
                {
                    IdSettingBayar = (int)m.IdSettingBayar,
                    CaraBayar = m.VCarabayar,
                    VKdakun = m.VCarabayar
                });
                await _dbs.BulkInsertAsync(settingBayar, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmSettingDaftars.Any())
            {
                var settingDaftar = _dbWin.TmSettingDaftars.Select(m => new M_SettingDaftar()
                {
                    IdSettingdaftar = (int)m.IdSettingdaftar,
                    IsTampil = m.IsTampil,
                    KodeRuangan = m.VKoderuangan ?? "",
                    NmUnitDaftar = m.VNmunitdaftar,
                    Tujuan = m.VTujuan
                });
                await _dbs.BulkInsertAsync(settingDaftar, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmSettingKomputerAntrians.Any())
            {

                var settingKompAntrian = _dbWin.TmSettingKomputerAntrians.Select(m => new M_SettingKomputerAntrian()
                {
                    IdSettingKomp = (int)m.IdSettingkomp,
                    KdCounter = m.VKdcounter,
                    KdJenisLayanan = m.VKdjenislayanan,
                    KdLokasi = m.VKdlokasi,
                    NmKomputer = m.VNmkomputer,
                    Tanggal = m.DTanggal
                });

                await _dbs.BulkInsertAsync(settingKompAntrian, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmSettingPemeriksaans.Any())
            {
                var settingPemeriksaan = _dbWin.TmSettingPemeriksaans.Select(m => new M_SettingPemeriksaan()
                {
                    Group = m.VGroup,
                    IdSettingperiksa = (int)m.IdSettingperiksa,
                    IsTampil = m.IsTampil,
                    Nmpemeriksaan = m.VNmpemeriksaan,
                });

                await _dbs.BulkInsertAsync(settingPemeriksaan, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }
            if (!_dbs.TmSettingPrshns.Any())
            {
                var settingPrshaan = _dbWin.TmSettingPrshns.AsEnumerable().Select(m => new M_Tenant()
                {
                    Codelogo = m.VCodelogo,
                    Email = m.VEmail,
                    ExpiredDate = DateTime.Now.AddYears(1000),
                    IdTenant = Ulid.NewUlid(),
                    Logo = m.VLogo,
                    OldIdTenant = m.IdPerusahaan,
                    Phone = m.VTelp,
                    StartDateTime = DateTime.Now.AddYears(-100),
                    TenantAddress = m.VAlamat,
                    TenantCode = m.VKdperusahaan,
                    TenantName = m.VNmperusahaan,
                    Website = m.VWebsite,
                    SubscriptionCode = ""
                });

                //await _dbs.BulkInsertAsync(settingPrshaan, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                //await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmSmfs.Any())
            {
                var tmsmf = _dbWin.TmSmfs.Select(m => new M_Smf()
                {
                    IdSmf = (int)m.IdSmf,
                    IsAktif = m.IsAktif,
                    Kdsmf = m.VKdsmf,
                    Nmsmf = m.VNmsmf
                });
                await _dbs.BulkInsertAsync(tmsmf, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();

            }
            if (!_dbs.TmStandartfieldGroups.Any())
            {
                var stdFieldGroup = _dbWin.TmStandartfieldGroups.Select(m => new M_StandartfieldGroup()
                {
                    DTanggal = m.DTanggal,
                    IdFieldgroup = m.IdFieldgroup,
                    IsAktif = m.IsAktif,
                    VKeterangan = m.VKeterangan,
                    VNmfieldgroup = m.VNmfieldgroup
                });
                await _dbs.BulkInsertAsync(stdFieldGroup, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmStandartfields.Any())
            {

                var tmstandartField = _dbWin.TmStandartfields.Select(m => new M_Standartfield()
                {
                    DeskField = m.VDeskfield,
                    IdField = m.IdField,
                    IdFieldgroup = m.IdFieldgroup,
                    IsAktif = m.IsAktif,
                    Keterangan = m.VKeterangan,
                    KodeField = m.VKodefield
                });
                await _dbs.BulkInsertAsync(tmstandartField, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();

            }

            if (!_dbs.TmStatuses.Any())
            {
                var status = _dbWin.TmStatuses.Select(m => new M_Status()
                {
                    IdStatus = m.IdStatus,
                    Status = m.VStatus
                });
                await _dbs.BulkInsertAsync(status, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();

            }


            _dbs.SaveChanges();

            return (Ok("Asal"));
        }




        [HttpGet("fixMapping")]
        public Task<IActionResult> FixMapping()
        {

            return Task.FromResult<IActionResult>(Ok("Asal"));
        }
    }



}
