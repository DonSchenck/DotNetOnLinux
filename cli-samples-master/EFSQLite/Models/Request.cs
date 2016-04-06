using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFSQLite.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public String Message { get; set; }
        public DateTime Processed { get; set; }
    }
}
