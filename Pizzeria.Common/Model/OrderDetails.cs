using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Common.Model
{
    public class OrderDetails
    {
        public int orderId { get; set; }
        public float price { get; set; }
        public string status { get; set; }
        
    }
}
