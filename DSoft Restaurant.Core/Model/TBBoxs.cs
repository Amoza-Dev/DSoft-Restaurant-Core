using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSoft_Restaurant.Core.Model
{
    public class TBBoxs
    {
        public int ID { get; set; } 
        public string? BoxName { get; set; }
        public decimal Value { get; set; }  
        public DateOnly StartDate { get; set; }
        public  bool IsDelete { get; set; }
    }
}
