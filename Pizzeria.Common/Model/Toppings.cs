using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Common.Model
{
    public class Toppings : Ingredient
    {
        public int toppingsId { get; set; }
        public int quantity { get; set; }
    }
}
