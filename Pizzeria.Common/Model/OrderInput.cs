using Pizzeria.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Common.Model
{
    public class OrderInput : IOrderInput
    {
        public int CustomerId { get; set; }
        public int CurstId { get; set; }
        public int SauceId { get; set; }
        public int CheeseId { get; set; }
        public int ToppingsId { get; set; }


    }
}
