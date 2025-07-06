using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSoft_Restaurant.Core.Model
{
    public class TBEmployeeCategory
    {
        public int ID { get; set; } 
        public string? Name { get; set; }
        public bool IsDelete { get; set; }
        public List<TBEmployees> TBEmployees { get; set; }
    }
}
