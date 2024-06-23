using EFCore.BulkExtensions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks.Dataflow;
using WincareMigrations.Models;
using WincareMigrations.NewModels;

namespace WincareMigrations.Controllers.Master
{
    [Route("api/[controller]")]
    [ApiController]
    public class D_ruang_Controller(WinCare2Context _dbWin, SimpleContext _dbs) : ControllerBase
    {

        [HttpGet()]
        public async Task<IActionResult> GetBankCoa()
        {
            //var uploader = new NpgsqlBulkUploader(_dbs);
            // load source 
            if (!_dbs.TmDepartements.Any())
            {
                var dept = _dbWin.TmDepartements.Select(m => new M_Departement()
                {
                    IdDepartment = m.IdDepartment == 0 ? 1 : m.IdDepartment,
                    NamaDepartemen = m.NamaDepartemen ?? ""
                });
                //await uploader.InsertAsync(dept);
                await _dbs.BulkInsertAsync(dept, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();

            }

            if (!_dbs.TmDtds.Any())
            {
                var dtd = _dbWin.TmDtds.Select(m => new M_Dtd()
                {
                    IdDtd = (long)m.IdDtd,
                    Kddtd = m.VKddtd ?? "",
                    Nmdtd = m.VNmdtd,
                    IsAktif = m.IsAktif
                });
                await _dbs.BulkInsertAsync(dtd, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();

                //await uploader.InsertAsync(dtd);
            }
            if (!_dbs.TmDiagnosas.Any())
            {
                var diag = _dbWin.TmDiagnosas.Select(m => new M_Diagnosa()
                {
                    IdDiagnosa = (long)m.IdDiagnosa,
                    KdDiagnosa = m.VKddiagnosa,
                    NmDiagnosa = m.VNmdiagnosa,
                    IsAktif = m.IsAktif,
                    IsPenyakit = m.CIspenyakit,
                    KdDTD = m.VKddtd ?? "",
                });
                await _dbs.BulkInsertAsync(diag, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });

                await _dbs.BulkSaveChangesAsync();

            }

            if (!_dbs.TmDiagnosaMatrices.Any())
            {
                var diagMat = _dbWin.TmDiagnosaMatrices.OrderBy(m => m.IdMatrixdiagnosa).Select(m => new M_DiagnosaMatrix()
                {
                    IdDiagnosaMatrix = long.Parse(m.IdMatrixdiagnosa.ToString()),
                    Kddiagnosa = m.VKddiagnosa,
                    Koderuangan = m.VKoderuangan,
                    IsAktif = m.IsAktif
                });
                await _dbs.BulkInsertAsync(diagMat, new BulkConfig
                {
                    SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity
                });
                await _dbs.BulkSaveChangesAsync();

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
                    By = m.VBy ?? "",
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
                await _dbs.BulkInsertAsync(dokter, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
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

                await _dbs.BulkInsertAsync(dokHonor, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.BulkSaveChangesAsync();
            }

            if (!_dbs.TmDokterNotes.Any())
            {
                var dokNote = _dbWin.TmDokterNotes.Select(m => new M_DokterNote()
                {
                    IdDokter = m.IdDokter,
                    KdDokter = m.VKddokter,
                    By = m.VBy ?? "",
                    Keterangan = m.Keterangan ?? "",
                    TglInput = m.TglInput
                });
                await _dbs.AddRangeAsync(dokNote);
                await _dbs.BulkSaveChangesAsync();


            }


            if (!_dbs.TmRuangs.Any())
            {
                var ruang = _dbWin.TmRuangs.Select(m => new M_Ruang()
                {
                    IdRuang = (long)m.IdNumruang,
                    Koderuangan = m.VKoderuangan,
                    Nama = m.Nama ?? "",
                    GdgPaket = m.VGdgpaket ?? "",
                    GdgPenerimaan = m.VGdgpenerimaan ?? "",
                    GdgRetur = m.VGdgretur ?? "",
                    IsTarif = m.IsTarif,
                    Kamar = m.Kamar ?? "",
                    KdInhealth = m.VKdinhealth ?? "",
                    Kelompok = m.Kelompok ?? "",
                    KodeInventory = m.VKodeinventory ?? "",
                    KodeRequestObat = m.KodeRequestobat ?? "",
                    KodeTarif = m.KodeTarif ?? "",
                    LynInhealth = m.VLyninhealth ?? "",
                    Noruang = m.Noruang ?? "",
                    IsAktif = m.IsAktif,
                });

                await _dbs.BulkInsertAsync(ruang, new BulkConfig { SqlBulkCopyOptions = Microsoft.Data.SqlClient.SqlBulkCopyOptions.KeepIdentity });
                await _dbs.SaveChangesAsync();


            }

            // gudang -> koderequest gudang obat
            // inventory -> kode inventory


            return Ok("DController");
        }


        public async Task<IActionResult> FixMapping()
        {
            var coa = _dbs.TmCoas.ToList();
            var ruang = _dbs.TmRuangs.ToList();
            var gudang = _dbs.TmGudangs.ToList();


            foreach (var item in ruang)
            {
                item.KodeInventoryGudangObat = gudang.FirstOrDefault(m => m.KodeInventory == item.KodeInventory).IdGudangObat;
                item.KodeRequestGudangObat = gudang.FirstOrDefault(m => m.KodeInventory == item.KodeRequestObat).IdGudangObat;
            }

            return Ok("DController");
        }

        [HttpGet("fixMappingDiagnosaMatrix")]
        public async Task<IActionResult> FixMappingDiagnosaMatrix()
        {
            var diagMat = _dbs.TmDiagnosaMatrices.OrderBy(m => m.IdDiagnosaMatrix).ToList();
            var listDiagnosa = _dbs.TmDiagnosas.Select(m => new { m.KdDiagnosa, m.IdDiagnosa }).ToList();
            var listRuang = _dbs.TmRuangs.Select(m => new { m.Koderuangan, m.IdRuang }).ToList();
            var page = 120;
            var loop = true;
            var diagIdMap = listDiagnosa.ToDictionary(m => m.KdDiagnosa, m => m.IdDiagnosa);
            var ruangIdMap = listRuang.ToDictionary(m => m.Koderuangan, m => m.IdRuang);

            while (loop)
            {
                var batch = diagMat.Skip(page * 5000).Take(5000).ToList();

                if (batch.Count < 5000)
                {
                    loop = false;
                }

                var block = new ActionBlock<M_DiagnosaMatrix>(async item =>
                {
                    if (diagIdMap.TryGetValue(item.Kddiagnosa, out var diagId))
                    {
                        item.IdDiagnosa = diagId;
                    }

                    if (ruangIdMap.TryGetValue(item.Koderuangan, out var ruangId))
                    {
                        item.IdRuangan = ruangId;
                    }
                });

                foreach (var item in batch)
                {
                    await block.SendAsync(item);
                }

                block.Complete();

                await block.Completion;

                await _dbs.BulkUpdateAsync(batch);

                page += 1;
                Console.WriteLine("page number " + page);
            }

            return Ok("Asal");
        }
    }



}
