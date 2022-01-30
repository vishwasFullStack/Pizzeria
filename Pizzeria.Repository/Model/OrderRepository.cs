using Pizzeria.Common.Interface;
using Pizzeria.Common.Model;
using Pizzeria.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Repository.Interface
{
    public class OrderRepository : IOrderRepository
    {

        private readonly IOrderInput _orderInput;
        private readonly IQuery _query;
        public OrderRepository(IOrderInput orderInput, IQuery query)
        {
            this._orderInput = orderInput;
            this._query = query;
        }

        public string orderPizza(OrderInput orderInput)
        {
            try
            {
                _query.GetCrustByID(orderInput.CurstId);
                return "order created";
            }
            catch (Exception ex)
            {

                return "Not Valid input/configuration, Please verify. Exception: " + ex.Message;
            }

        }
    }
}
