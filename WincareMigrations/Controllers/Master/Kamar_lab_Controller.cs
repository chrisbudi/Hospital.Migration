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
        public Task<IActionResult> GetKamar_LAb()
        {
            // load source 
            var kmrInap = _dbWin.TmKamarinaps.Select(m => new M_Kamarinap()
            {
                Nokamar = m.VNokamar,
                IdKamarinap = m.IdKamarinap,
                KodeRuangan = m.VKoderuangan,
                IdMapid = m.IdMapid,
                IsAktif = m.IsAktif,
                Isi = m.CIsi,
                IX = m.IX,
                IY = m.IY,
                KdTmpTidur = m.VKdtmptidur,
                Kelas = m.VKelas,
                KodeTarif = m.VKodetarif,
                Lantai = m.VLantai,

            }).ToList();
            _dbs.AddRange(kmrInap);

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
                IdKamarInapHarga = m.IdKamarinapharga,
                Penyulit = m.DPenyulit,
                RekananId = m.Rekananid,
                SecondTnd = m.D2tnd,
                Tglakhir = m.DTglakhir,
                Tglawal = m.DTglawal,
            }).ToList();
            // mapping kamar inap id dengan VKdtmptidur
            _dbs.AddRange(kmrHarga);

            var kmrRek = _dbWin.TmKamarinapRekanans.Select(m => new M_KamarInapRekanan()
            {
                IsAktif = m.IsAktif,
                Kdtmptidur = m.VKdtmptidur,
                IdKamarinaprek = m.IdKamarinaprek,
                OldRekananId = m.Rekananid,
            }).ToList();
            // mapping rekanan id
            _dbs.AddRange(kmrInap);


            var kelBarang = _dbWin.TmKelompokbarangs.Select(m => new M_KelompokBarang()
            {
                IdGroupTarif = m.IdGrouptarif,
                KelompokId = m.Kelompokid,
                Kode = m.Kode,
                Margin = m.Margin,
                Nama = m.Nama,
                Note = m.Note,
                IsAktif = m.IsAktif,
            }).ToList();

            _dbs.AddRange(kelBarang);

            var kodePos = _dbWin.TmKodepos.Select(m => new M_Kodepos()
            {
                IdKodepos = (int)m.IdKodepos,
                Kabupaten = m.VKabupaten,
                KdKodePos = m.VKdkodepos,
                Kecamatan = m.VKecamatan,
                Kelurahan = m.VKelurahan,
                Provinsi = m.VProvinsi,
                IsAktif = m.IsAktif,
            }).ToList();
            _dbs.AddRange(kodePos);


            // lab

            var lab = _dbWin.TmLaboratoria.Select(m => new M_Laboratorium()
            {
                IdGroup = m.IdGroup,
                IdPemeriksaanLab = m.IdPemeriksaanlab,
                IsAktif = m.CIsaktif,
                KdPemeriksaanLab = m.VKdpemeriksaanlab,
                NmPemeriksaanLab = m.VNmpemeriksaanlab,
            }).ToList();

            _dbs.AddRange(lab);

            var labGroup = _dbWin.TmLaboratoriumGroups.Select(m => new M_LaboratoriumGroup()
            {
                IdGroup = m.IdGroup,
                IdGrouptarif = m.IdGrouptarif,
                IsAktif = m.IsAktif,
                IsPk = m.IsPk,
                VNmgroup = m.VNmgroup,
            }).ToList();
            _dbs.AddRange(labGroup);

            var labHarga = _dbWin.TmLaboratoriumHargas.Select(m => new M_LaboratoriumHarga()
            {
                By = m.VBy,
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
                RekananId = m.Rekananid,
            }).ToList();
            // mapping harga kamar, mapping labid
            _dbs.AddRange(labHarga);


            var labRek = _dbWin.TmLaboratoriumRekanans.Select(m => new M_LaboratoriumRekanan()
            {
                IsAktif = m.IsAktif,
                IdLabRekanan = m.IdLabrekanan,
                RekananId = m.Rekananid,
                KdPemeriksaanLab = m.VKdpemeriksaanlab,
            }).ToList();
            // mapping lab
            _dbs.AddRange(labRek);

            _dbs.SaveChanges();

            return Task.FromResult<IActionResult>(Ok("Asal"));
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
