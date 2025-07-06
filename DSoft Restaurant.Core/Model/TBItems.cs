using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSoft_Restaurant.Core.Model
{
    public class TBItems
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public bool IsWeight { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public bool IsDelete { get; set; }
        public int CategoryId { get; set; }
        public TBCategory tBCategory { get; set; }
        public ICollection<TBItemDeliveryPrice> ItemDeliveryPrices { get; set; }  
    }
}
