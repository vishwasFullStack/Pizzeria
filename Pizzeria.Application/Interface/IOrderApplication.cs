using Pizzeria.Common.Model;

namespace Pizzeria.Application.Interface
{
    public interface IOrderApplication
    {
        string orderPizza(OrderInput orderInput);
    }
}