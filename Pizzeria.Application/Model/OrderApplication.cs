using Pizzeria.Application.Interface;
using Pizzeria.Common.Interface;
using Pizzeria.Common.Model;
using Pizzeria.Repository.Interface;
using System;

namespace Pizzeria.Application.Model
{
    public class OrderApplication : IOrderApplication
    {
        private readonly IOrderInput _orderInput;
        private readonly IQuery _query;
        public OrderApplication(IOrderInput orderInput, IQuery query)
        {
            this._orderInput = orderInput;
            this._query = query;
        }

        public string orderPizza(OrderInput orderInput)
        {
            try
            {
                var crustDetails = _query.GetCrustByID(orderInput.CurstId);
                var cheeseDetails = _query.GetCheaseById(orderInput.CheeseId);
                var sauceDetails = _query.GetSauceById(orderInput.SauceId);
                var ToppingDetails = _query.GetToppingsById(orderInput.ToppingsId);


                return "Order created";
            }
            catch (Exception ex)
            {

                return "Not Valid input/configuration, Please verify. Exception: " + ex.Message;
            }

        }
    }
}
