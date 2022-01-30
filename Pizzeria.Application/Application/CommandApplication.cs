using Pizzeria.Application.Interface;
using Pizzeria.Common.Interface;
using Pizzeria.Common.Model;
using Pizzeria.Repository.Interface;
using System;

namespace Pizzeria.Application.Application
{
    public class CommandApplication : ICommandApplication
    {
        private readonly IOrderInput _orderInput;
        private readonly IQuery _query;
        public CommandApplication(IOrderInput orderInput, IQuery query)
        {
            this._orderInput = orderInput;
            this._query = query;
        }

        public OrderDetails orderPizza(OrderInput orderInput)
        {
            try
            {
                Crust crustDetails = _query.GetCrustByID(orderInput.CurstId);
                Cheese cheeseDetails = _query.GetCheaseById(orderInput.CheeseId);
                Sauce sauceDetails = _query.GetSauceById(orderInput.SauceId);
                Toppings toppingDetails = _query.GetToppingsById(orderInput.ToppingsId);

                OrderDetails orderDetails = new OrderDetails();
                if (crustDetails != null  && crustDetails.isAvailable)
                {
                    orderDetails.crusts= crustDetails;
                    orderDetails.price += crustDetails.price;
                }
                if (cheeseDetails != null && crustDetails.isAvailable)
                {
                    orderDetails.cheeses=cheeseDetails;
                    if(cheeseDetails.quantity > 0)
                    {
                        orderDetails.price += cheeseDetails.price * cheeseDetails.quantity;
                    }
                    
                }
                if (sauceDetails != null && crustDetails.isAvailable)
                {
                    orderDetails.Sauces= sauceDetails;
                    orderDetails.price += sauceDetails.price;
                }
                if (toppingDetails != null && crustDetails.isAvailable)
                {
                    orderDetails.toppings= toppingDetails;
                    if (toppingDetails.quantity > 0)
                    {
                        orderDetails.price += toppingDetails.price * toppingDetails.quantity;
                    }
                }
                if(orderDetails != null && orderDetails.price > 0)
                {
                    orderDetails.status = "Order Placed";
                }

                return orderDetails;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Not Valid input/configuration, Please verify. Exception: " + ex.Message);
                return null;
            }

        }

    }
}
