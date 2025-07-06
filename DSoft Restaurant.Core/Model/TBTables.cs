using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSoft_Restaurant.Core.Model
{
    public class TBTables
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public bool IsDelete { get; set; }
        public int ZoneID { get; set; }
        public TBZones TBZones { get; set; }
    }
}
