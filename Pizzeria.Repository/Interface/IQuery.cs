using Pizzeria.Repository.Model;

namespace Pizzeria.Repository.Interface
{
    public interface IQuery
    {
        Cheese GetCheaseById(int cheeseId);
        Crust GetCrustByID(int crustId);
        Sauce GetSauceById(int sauceId);
        Toppings GetToppingsById(int toppingId);
    }
}