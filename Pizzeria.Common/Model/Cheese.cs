using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Common.Model
{
    public class Cheese: Ingredient
    {
        public int cheeseId { get; set; }
        public int quantity { get; set; }
    }
}
