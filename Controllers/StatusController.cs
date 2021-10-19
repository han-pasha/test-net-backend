using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestSigmatech.Dtos;
using TestSigmatech.Models;
using TestSigmatech.Repositories;

namespace TestSigmatech.Controllers {

    [ApiController]
    [Route("/status")]
    public class StatusController : ControllerBase {
        
        private readonly IStatusRepository statusRepository;
        public StatusController(IStatusRepository statusRepository){
            this.statusRepository = statusRepository;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Status>> GetStatus(int id){
            var status = await statusRepository.Get(id);
            
            if (status is null) {
                return NotFound();
            }
            return Ok(status);

        }

        [HttpGet]
        public async Task<ActionResult<Status>> GetNik(int NIK){

            var status = await statusRepository.GetNik(NIK);
            var checkResult = new CheckResult{
                t_dukcapil_check_result = "Ini field apa?",
                NIK = status.NIK,
                check_dtm = DateTime.Now,
                check_status = "Found",
            };

            await statusRepository.AddCheckResult(checkResult);
            if (status is null) {
                var checkResultNotFound = new CheckResult{
                t_dukcapil_check_result = "Ini field apa?",
                NIK = status.NIK,
                check_dtm = DateTime.Now,
                check_status = "NotFound",
            };
                return NotFound(checkResult);
            }

            return Ok(checkResult);

        }

        [HttpGet("getallstatus")]
        public async Task<ActionResult<IEnumerable<Status>>> GetAllStatus(){
            var status = await statusRepository.GetAll();
            if (status is null) {
                return NotFound();
            }
            return Ok(status);

        }

        [HttpGet("getallcheckstatus")]
        public async Task<ActionResult<IEnumerable<CheckResult>>> GetAllResults(){
            var checkResult = await statusRepository.GetAllResults();
            if (checkResult is null) {
                return NotFound();
            }
            return Ok(checkResult);

        }


        [HttpPost]
        public async Task<ActionResult> CreateStatus(CreateStatusDto createStatusDto){
            var status = new Status{
                m_dukcapil_data_id = createStatusDto.m_dukcapil_data_id,
                NIK = createStatusDto.NIK,
                name = createStatusDto.name,
                maiden_name = createStatusDto.maiden_name,
                birth_date = createStatusDto.birth_date,
                gender = createStatusDto.gender,
                religion_id = createStatusDto.religion_id,
                marital_status = createStatusDto.marital_status,
            };
            await statusRepository.Add(status);
            return Ok(status);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteStatus(int id){
            await statusRepository.Delete(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateStatus(int id, UpdateStatusDto updateStatusDto) {
            var existing = await statusRepository.Get(id);
            if (existing == null) {
                    return NotFound();
            }

            Status status = new Status{
                m_dukcapil_data_id = updateStatusDto.m_dukcapil_data_id,
                NIK = id,
                name = updateStatusDto.name,
                maiden_name = updateStatusDto.maiden_name,
                birth_date = updateStatusDto.birth_date,
                gender = updateStatusDto.gender,
                religion_id = updateStatusDto.religion_id,
                marital_status = updateStatusDto.marital_status,
            };
            await statusRepository.Update(status);
            return Ok(status);
        }

    }
}