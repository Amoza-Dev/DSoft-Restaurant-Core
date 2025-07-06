using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSoft_Restaurant.Core.Model
{
    public class TBCategory
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PrintetName { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public bool IsDelete { get; set; } = false;

        public ICollection<TBItems> items { get; set; }
    }
}
