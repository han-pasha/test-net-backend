using Microsoft.EntityFrameworkCore;
using TestSigmatech.Models;

namespace TestSigmatech.Data {

    public class DataContext: DbContext, IDataContext {

        public DataContext(DbContextOptions<DataContext> options): base(options) { 

        }     

        public DbSet<Status> status {get;init; }
        public DbSet<CheckResult> checkResult {get;init;}
        public DbSet<mMaritalStatus> mMaritalStatus {get;init;}
        public DbSet<mReligion> mReligion {get;init;}
    }
}