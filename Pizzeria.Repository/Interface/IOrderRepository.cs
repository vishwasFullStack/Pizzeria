
using Pizzeria.Common.Model;

namespace Pizzeria.Repository.Interface
{
    public interface IOrderRepository
    {
        string orderPizza(OrderInput orderInput);
    }
}