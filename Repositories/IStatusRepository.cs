using System.Collections.Generic;
using System.Threading.Tasks;
using TestSigmatech.Models;

namespace TestSigmatech.Repositories {
    public interface IStatusRepository {
        Task<Status> Get(int id);
        Task<Status> GetNik(int NIK);
        Task<IEnumerable<Status>> GetAll();
        Task Add(Status status);
        Task Delete(int id);
        Task Update(Status status);
    }
}