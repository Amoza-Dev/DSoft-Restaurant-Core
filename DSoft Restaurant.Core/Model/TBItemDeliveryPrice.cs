using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSoft_Restaurant.Core.Model
{
    public class TBItemDeliveryPrice
    {
        public int ID { get; set; } // PRIMARY KEY, Identity

        public int ItemId { get; set; }
        public TBItems TBItems { get; set; }

        public int DeliveryCompanyId { get; set; }
        public TBDeliveryCompany DeliverCompany { get; set; }

        public decimal Price { get; set; }
    }
}
