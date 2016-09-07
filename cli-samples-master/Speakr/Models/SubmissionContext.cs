using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.SqlServer;
//using Microsoft.EntityFrameworkCore.Sqlite;

namespace Speakr.Models
{
    public class SubmissionContext : DbContext
    {
        public DbSet<Submission> Submissions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase();
            //string dbconn = System.Environment.GetEnvironmentVariable("SPEAKR_DBCONN");
            string dbconn = "filename=submissions.db";
            optionsBuilder.UseSqlite(dbconn); // example "filename=submissions.db"
            //optionsBuilder.UseSqlServer(dbconn);
        }
    }
}
