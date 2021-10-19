using System.Collections.Generic;
using System.Threading.Tasks;
using TestSigmatech.Models;

namespace TestSigmatech.Repositories {
    public interface IStatusRepository {

        // DATABASE DUKCAPIL DATA
        Task<Status> Get(int id);
        Task<Status> GetNik(int NIK);
        Task<IEnumerable<Status>> GetAll();
        Task Add(Status status);
        Task Delete(int id);
        Task Update(Status status);

        // DATABASE CHECK RESULT
        Task AddCheckResult(CheckResult checkResult);
        Task<IEnumerable<CheckResult>> GetAllResults();
    }
}