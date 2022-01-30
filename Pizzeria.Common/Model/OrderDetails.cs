using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Common.Model
{
    public class OrderDetails
    {
        public Guid orderId { get; set; } = Guid.NewGuid();
        public float price { get; set; }
        public string status { get; set; } = "Order not placed";
        public Crust crusts { get; set; }
        public Sauce Sauces { get; set; }
        public Cheese cheeses { get; set; }
        public Toppings toppings { get; set; }


    }
}
