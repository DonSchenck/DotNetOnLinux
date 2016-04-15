using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Sqlite;

namespace Speakr.Models
{
    public class SubmissionContext : DbContext
    {
        public DbSet<Submission> Submissions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            //            builder.UseInMemoryDatabase();
            builder.UseSqlite("Filename=submissions.db");
        }
    }
}
