using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Npgsql;
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
            string dbconn="Server=127.0.0.1;Port=5432;Database=speakez;User Id=postgres;Password=myM$3D0g;";
            //string dbconn = "filename=submissions.db";
            //optionsBuilder.UseSqlite(dbconn); // example "filename=submissions.db"
            var conn = new NpgsqlConnection {ConnectionString = dbconn};
            //conn.Open();
            optionsBuilder.UseNpgsql(conn,null);
            //optionsBuilder.UseSqlServer(dbconn);
        }
    }
}
