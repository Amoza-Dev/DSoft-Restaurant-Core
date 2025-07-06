using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSoft_Restaurant.Core.Model
{
    public class TBZones
    {
        public int ID { get; set; }
        public string? ZoneName { get; set; }
        public bool IsActive { get; set; }=true;
        public bool IsDelete { get; set; } = false;
        public List<TBTables> tBTables { get; set; }
    }
}
