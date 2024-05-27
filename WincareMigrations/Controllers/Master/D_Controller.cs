using Microsoft.AspNetCore.Mvc;
using WincareMigrations.Models;
using WincareMigrations.NewModels;

namespace WincareMigrations.Controllers.Master
{
    [Route("api/[controller]")]
    [ApiController]
    public class D_ruang_Controller(WinCare2Context _dbWin, SimpleContext _dbs) : ControllerBase
    {

        [HttpGet()]
        public Task<IActionResult> GetBankCoa()
        {
            // load source 
            if (!_dbs.TmDepartements.Any())
            {
                var dept = _dbWin.TmDepartements.Select(m => new M_Departement()
                {
                    IdDepartment = m.IdDepartment == 0 ? 1 : m.IdDepartment,
                    NamaDepartemen = m.NamaDepartemen ?? ""
                });
                _dbs.AddRange(dept);
                _dbs.SaveChanges();
            }

            if (!_dbs.TmDtds.Any())
            {
                var dtd = _dbWin.TmDtds.Select(m => new M_Dtd()
                {
                    IdDtd = m.IdDtd,
                    Kddtd = m.VKddtd ?? "",
                    Nmdtd = m.VNmdtd,
                    IsAktif = m.IsAktif
                });
                _dbs.AddRange(dtd);
                _dbs.SaveChanges();
            }
            if (!_dbs.TmDiagnosas.Any())
            {
                var diag = _dbWin.TmDiagnosas.Select(m => new M_Diagnosa()
                {
                    IdDiagnosa = m.IdDiagnosa,
                    KdDiagnosa = m.VKddiagnosa,
                    NmDiagnosa = m.VNmdiagnosa,
                    IsAktif = m.IsAktif,
                    IsPenyakit = m.CIspenyakit,
                    KdDTD = m.VKddtd ?? "",
                });
                _dbs.AddRange(diag);
                _dbs.SaveChanges();
            }

            if (!_dbs.TmDiagnosaMatrices.Any())
            {


                var diagMat = _dbWin.TmDiagnosaMatrices.Select(m => new M_DiagnosaMatrix()
                {
                    IdDiagnosaMatrix = m.IdMatrixdiagnosa,
                    Kddiagnosa = m.VKddiagnosa,
                    Koderuangan = m.VKoderuangan,
                    IsAktif = m.IsAktif
                });
                _dbs.AddRange(diagMat);
                _dbs.SaveChanges();
                // mapping id diagnosa, mapping id ruangan
            }
            if (!_dbs.TmDokters.Any())
            {

                var dokter = _dbWin.TmDokters.Select(m => new M_Dokter()
                {
                    IdDokter = m.IdDokter,
                    KdDokter = m.VKddokter,
                    NmDokter = m.VNmdokter,
                    Alamatdokter = m.VAlamatdokter ?? "",
                    Alamatpraktek = m.VAlamatpraktek ?? "",
                    By = m.VBy,
                    //IdCoa = m.VKdakun,
                    ImgFotodokter = m.ImFotodokter ?? "",
                    IsAktif = m.CAktif,
                    Kdakun = m.VKdakun ?? "",
                    Kodetarif = m.VKodetarif ?? "",
                    Nosip = m.VNosip ?? "",
                    Pin = m.Pin,
                    Spesialisasidokter = m.VSpesialisasidokter ?? "",
                    Telpdokter = m.VTelpdokter ?? "",
                    Telppraktek = m.VTelppraktek ?? "",
                    Ttd = m.IsTtd ?? "",
                });
                _dbs.AddRange(dokter);
                _dbs.SaveChanges();
            }
            // mapping id coa

            if (!_dbs.TmDokterHonors.Any())
            {
                var dokHonor = _dbWin.TmDokterHonors.Select(m => new M_DokterHonor()
                {
                    Id = m.Id,
                    NmDokter = m.VNmdokter,
                    KdDokter = m.VKddokter,
                    Tarif = m.DTarif,
                    JasaMedis = m.DJasamedis,
                    JasaRS = m.DJasars,
                    Ket = m.VKet
                });
                _dbs.AddRange(dokHonor);
                _dbs.SaveChanges();
            }

            if (!_dbs.TmDokterNotes.Any())
            {
                var dokNote = _dbWin.TmDokterNotes.Select(m => new M_DokterNote()
                {
                    IdDokter = m.IdDokter,
                    KdDokter = m.VKddokter,
                    By = m.VBy,
                    Keterangan = m.Keterangan,
                    TglInput = m.TglInput
                });

                _dbs.AddRange(dokNote);
                _dbs.SaveChanges();
            }


            if (!_dbs.TmRuangs.Any())
            {
                var ruang = _dbWin.TmRuangs.Select(m => new M_Ruang()
                {
                    IdRuang = m.IdNumruang,
                    Koderuangan = m.VKoderuangan,
                    Nama = m.Nama,
                    GdgPaket = m.VGdgpaket,
                    GdgPenerimaan = m.VGdgpenerimaan,
                    GdgRetur = m.VGdgretur,
                    IsTarif = m.IsTarif,
                    Kamar = m.Kamar,
                    KdInhealth = m.VKdinhealth,
                    Kelompok = m.Kelompok,
                    KodeInventory = m.VKodeinventory,
                    KodeRequestObat = m.KodeRequestobat,
                    KodeTarif = m.KodeTarif,
                    LynInhealth = m.VLyninhealth,
                    Noruang = m.Noruang,
                    IsAktif = m.IsAktif,
                });
                _dbs.AddRange(ruang);

                _dbs.SaveChanges();

            }

            // gudang -> koderequest gudang obat
            // inventory -> kode inventory


            return Task.FromResult<IActionResult>(Ok("Asal"));
        }




        [HttpGet("fixMapping")]
        public Task<IActionResult> FixMapping()
        {
            var diagMat = _dbs.TmDiagnosaMatrices.ToList();
            var dokter = _dbs.TmDokters.ToList();
            var diag = _dbs.TmDiagnosas.ToList();
            var coa = _dbs.TmCoas.ToList();
            var ruang = _dbs.TmRuangs.ToList();
            var gudang = _dbs.TmGudangs.ToList();

            foreach (var item in diagMat)
            {
                item.IdDiagnosa = diag.SingleOrDefault(m => m.KdDiagnosa == item.Kddiagnosa).IdDiagnosa;
                item.IdRuangan = ruang.SingleOrDefault(m => m.Koderuangan == item.Koderuangan).IdRuang;
            }

            foreach (var item in dokter)
            {
                item.IdCoa = coa.FirstOrDefault(m => m.Kdakun == item.Kdakun).IdCoa;
            }

            foreach (var item in ruang)
            {
                item.KodeInventoryGudangObat = gudang.FirstOrDefault(m => m.KodeInventory == item.KodeInventory).IdGudangObat;
                item.KodeRequestGudangObat = gudang.FirstOrDefault(m => m.KodeInventory == item.KodeRequestObat).IdGudangObat;
            }

            _dbs.SaveChanges();

            return Task.FromResult<IActionResult>(Ok("Asal"));
        }
    }



}
