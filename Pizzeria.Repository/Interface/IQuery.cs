using Pizzeria.Common.Model;
using System.Collections.Generic;

namespace Pizzeria.Repository.Interface
{
    public interface IQuery
    {
        IEnumerable<Crust> GetAllCrust();
        Cheese GetCheaseById(int cheeseId);
        Crust GetCrustByID(int crustId);
        Sauce GetSauceById(int sauceId);
        Toppings GetToppingsById(int toppingId);
    }
}