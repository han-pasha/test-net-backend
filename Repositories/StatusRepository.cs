using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestSigmatech.Data;
using TestSigmatech.Models;

namespace TestSigmatech.Repositories {

    public class StatusRepository : IStatusRepository
    {
        private readonly IDataContext _context;
        public StatusRepository(IDataContext context)
        {
            _context = context;
        }

        public async Task Add(Status status)
        {
            _context.status.Add(status);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int m_dukcapil_data_id)
        {
            var index = await _context.status.FindAsync(m_dukcapil_data_id);
            if (index is null){
                // return NotFound();
                throw new NullReferenceException();
            }
            _context.status.Remove(index);
            await _context.SaveChangesAsync();
        }

        public async Task<Status> Get(int m_dukcapil_data_id)
        {
            return await _context.status.FindAsync(m_dukcapil_data_id);
        }

        public async Task<Status> GetNik(int NIK)
        {
            return await _context.status.FindAsync(NIK);
        }

        public async Task<IEnumerable<Status>> GetAll()
        {
            return await _context.status.ToListAsync();
        }

        public async Task Update(Status status)
        {
            var index = await _context.status.FindAsync(status.NIK);
            if (index is null){
                throw new NullReferenceException();
            }
            index.m_dukcapil_data_id = status.m_dukcapil_data_id;
            index.NIK = status.NIK;
            index.name = status.name;
            index.maiden_name = status.maiden_name;
            index.birth_date = status.birth_date;
            index.gender = status.gender;
            index.religion_id = status.religion_id;
            index.marital_status = status.marital_status;
            await _context.SaveChangesAsync();

        }

        // DB KEDUA
        public async Task AddCheckResult(CheckResult checkResult)
        {
            _context.checkResult.Add(checkResult);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CheckResult>> GetAllResults()
        {
            return await _context.checkResult.ToListAsync();
        }
    }
}