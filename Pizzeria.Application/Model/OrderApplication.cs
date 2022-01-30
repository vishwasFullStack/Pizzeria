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
        private readonly IOrderRepository _orderRepository;
        public OrderApplication(IOrderInput orderInput, IOrderRepository orderRepository)
        {
            this._orderInput = orderInput;
            this._orderRepository = orderRepository;
        }
        public string orderPizza(OrderInput orderInput)
        {
            try
            {
                var result = _orderRepository.orderPizza(orderInput);
                return result;
            }
            catch (Exception ex)
            {

                return "Not Valid input/configuration, Please verify. Exception: " + ex.Message;
            }

        }
    }
}
