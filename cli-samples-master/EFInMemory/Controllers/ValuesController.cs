using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EFInMemory.Models;

namespace EFInMemory.Controllers
{
    public class RequestsController : Controller
    {
        [HttpGet("/")]
        public IEnumerable<string> Get()
        {
            var hostName = Environment.GetEnvironmentVariable("HOSTNAME");
            return new string[] { $"Hello from ASP.NET Core 1.0 running on Red Hat Enterprise Linux (RHEL) 7.2!", $"Container host name: {hostName}" };
        }

        [HttpGet("/{message}")]
        public IEnumerable<Request> Put(string message)
        {
            using (var db = new RequestHistoryContext())
            {
                db.Requests.Add(new Request { Message = message, Processed = DateTime.UtcNow });
                db.SaveChanges();

                return db.Requests
                    .OrderByDescending(r => r.Processed)
                    .Take(10)
                    .ToList();
            }
        }
    }
}
