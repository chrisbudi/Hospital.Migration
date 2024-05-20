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
        public Task<IActionResult> GetRS()
        {
            // load source 
            var radiologi = _dbWin.TmRadiologis.Select(m => new M_Radiologi()
            {
                IdGroup = m.IdGroup,
                IdPemeriksaanRad = m.IdPemeriksaanrad,
                IsAktif = m.CIsaktif,
                Kdpemeriksaanrad = m.VKdpemeriksaanrad,
                NmPemeriksaanRad = m.VNmpemeriksaanrad,
            }).ToList();

            _dbs.AddRange(radiologi);

            var radiologiGroup = _dbWin.TmRadiologiGroups.Select(m => new M_RadiologiGroup()
            {
                IdGroup = m.IdGroup,
                Nmgroup = m.VNmgroup,
                IsAktif = m.IsAktif,
                IdGrouptarif = m.IdGrouptarif,
            }).ToList();

            _dbs.AddRange(radiologiGroup);

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
                IdRadharga = m.IdRadharga,
                Jasamedis = m.DJasamedis,
                Jasars = m.DJasars,
                KdPemeriksaanRad = m.VKdpemeriksaanrad,
                Kelas = m.VKelas,
                Penyulit = m.DPenyulit,
                Rekananid = m.Rekananid,
                Tglawal = m.DTglawal,
                VBy = m.VBy,
            }).ToList();

            _dbs.AddRange(radiologiHarga);

            var radiologiRekanan = _dbWin.TmRadiologiRekanans.Select(m => new M_RadiologiRekanan()
            {
                IdRadrekanan = m.IdRadrekanan,
                IsAktif = m.IsAktif,
                KdPemeriksaanRad = m.VKdpemeriksaanrad,
                RekananId = m.Rekananid,
            }).ToList();
            _dbs.AddRange(radiologiRekanan);


            var settingAdm = _dbWin.TmSettingAdms.Select(m => new M_SettingAdm()
            {
                Biaya = m.DBiaya,
                IdAdm = (int)m.IdNumadm,
                Kategori = m.VKategori,
                OldRekananId = m.Rekananid,
                Percent = m.DPercent
            }).ToList();
            _dbs.AddRange(settingAdm);


            var settingBayar = _dbWin.TmSettingBayars.Select(m => new M_SettingBayar()
            {
                IdSettingBayar = (int)m.IdSettingBayar,
                CaraBayar = m.VCarabayar,
                VKdakun = m.VCarabayar
            });
            _dbs.AddRange(settingBayar);


            var settingDaftar = _dbWin.TmSettingDaftars.Select(m => new M_SettingDaftar()
            {
                IdSettingdaftar = (int)m.IdSettingdaftar,
                IsTampil = m.IsTampil,
                KodeRuangan = m.VKoderuangan,
                NmUnitDaftar = m.VNmunitdaftar,
                Tujuan = m.VTujuan
            });
            _dbs.AddRange(settingDaftar);

            var settingKompAntrian = _dbWin.TmSettingKomputerAntrians.Select(m => new M_SettingKomputerAntrian()
            {
                IdSettingKomp = (int)m.IdSettingkomp,
                KdCounter = m.VKdcounter,
                KdJenisLayanan = m.VKdjenislayanan,
                KdLokasi = m.VKdlokasi,
                NmKomputer = m.VNmkomputer,
                Tanggal = m.DTanggal
            });
            _dbs.AddRange(settingKompAntrian);

            var settingPemeriksaan = _dbWin.TmSettingPemeriksaans.Select(m => new M_SettingPemeriksaan()
            {
                Group = m.VGroup,
                IdSettingperiksa = (int)m.IdSettingperiksa,
                IsTampil = m.IsTampil,
                Nmpemeriksaan = m.VNmpemeriksaan,
            });

            var settingPrshaan = _dbWin.TmSettingPrshns.Select(m => new M_Tenant()
            {
                Codelogo = m.VCodelogo,
                Email = m.VEmail,
                ExpiredDate = DateTime.Now.AddYears(1000),
                IdTenant = new Guid(),
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
            _dbs.AddRange(settingPrshaan);

            var tmsmf = _dbWin.TmSmfs.Select(m => new M_Smf()
            {
                IdSmf = (int)m.IdSmf,
                IsAktif = m.IsAktif,
                Kdsmf = m.VKdsmf,
                Nmsmf = m.VNmsmf
            });
            _dbs.AddRange(tmsmf);

            var tmstandartField = _dbWin.TmStandartfields.Select(m => new M_Standartfield()
            {
                DeskField = m.VDeskfield,
                IdField = m.IdField,
                IdFieldgroup = m.IdFieldgroup,
                IsAktif = m.IsAktif,
                Keterangan = m.VKeterangan,
                KodeField = m.VKodefield
            });
            _dbs.AddRange(tmstandartField);

            var stdFieldGroup = _dbWin.TmStandartfieldGroups.Select(m => new M_StandartfieldGroup()
            {
                DTanggal = m.DTanggal,
                IdFieldgroup = m.IdFieldgroup,
                IsAktif = m.IsAktif,
                VKeterangan = m.VKeterangan,
                VNmfieldgroup = m.VNmfieldgroup
            });
            _dbs.AddRange(stdFieldGroup);

            var status = _dbWin.TmStatuses.Select(m => new M_Status()
            {
                IdStatus = m.IdStatus,
                Status = m.VStatus
            });
            _dbs.AddRange(status);

            var supplier = _dbWin.TmSuppliers.Select(m => new M_Supplier()
            {
                Alamat = m.Alamat,
                Cp = m.Cp,
                Fax = m.Fax,
                IsAktif = m.Isaktif,
                KdAkun = m.VKdakun,
                Kota = m.Kota,
                NamaSupplier = m.Namasupplier,
                Note = m.Note,
                SupplierId = m.Supplierid,
                Telpon = m.Telpon
            });
            _dbs.AddRange(supplier);

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
