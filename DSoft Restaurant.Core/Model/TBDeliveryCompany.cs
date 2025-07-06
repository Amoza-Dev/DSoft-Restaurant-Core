using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSoft_Restaurant.Core.Model
{
    public class TBDeliveryCompany
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateOnly StartDate { get; set; }
        public bool IsDelete { get; set; }  
        public ICollection<TBItemDeliveryPrice> ItemDeliveryPrices { get;   set; }
    }
}
