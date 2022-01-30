using Pizzeria.Common.Interface;
using Pizzeria.Common.Model;
using Pizzeria.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Repository.Model
{
    public class OrderRepository : IOrderRepository
    {

        public string orderPizza(OrderInput orderInput)
        {
            try
            {
                return "order created";
            }
            catch (Exception ex)
            {

                return "Not Valid input/configuration, Please verify. Exception: " + ex.Message;
            }

        }
    }
}
