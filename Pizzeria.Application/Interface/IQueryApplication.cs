using Pizzeria.Common.Model;
using System.Collections.Generic;

namespace Pizzeria.Application.Interface
{
    public interface IQueryApplication
    {
        IEnumerable<Cheese> GetAllCheese();
        IEnumerable<Crust> GetAllCrust();
        IEnumerable<Sauce> GetAllSauce();
        IEnumerable<Toppings> GetAllToppings();
    }
}