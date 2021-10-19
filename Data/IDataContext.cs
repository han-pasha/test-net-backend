using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestSigmatech.Models;

namespace TestSigmatech.Data {
    public interface IDataContext {
        DbSet<Status> status {get; init; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}