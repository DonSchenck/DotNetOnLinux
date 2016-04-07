using EFInMemory.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFInMemory
{
    public class RequestHistoryContext : DbContext
    {
        public DbSet<Request> Requests { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            optionsBuilder.UseSqlite("Filename=RequestHistory.db");
            optionsBuilder.UseInMemoryDatabase();
        }
    }
}
