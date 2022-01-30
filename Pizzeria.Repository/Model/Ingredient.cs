using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Repository.Model
{
    public class Ingredient
    {
        public string name { get; set; }
        public float price { get; set; }
        public bool isAvailable { get; set; }

    }
}
