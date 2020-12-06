using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models
{
    public class book
    {
        public int id { get; set; }
        public string title { get; set; }
        public author author { get; set; }
    }
}
