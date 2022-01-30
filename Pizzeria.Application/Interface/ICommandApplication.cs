using Pizzeria.Common.Model;

namespace Pizzeria.Application.Interface
{
    public interface ICommandApplication
    {
        OrderDetails orderPizza(OrderInput orderInput);
    }
}