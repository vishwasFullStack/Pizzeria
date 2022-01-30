# Pizzeria
Build Your Pizza

System Configuration 

Open file .”\Pizzeria\Pizzeria.API\appsettings.json”
Set PizzaMasterPath : "\Document\pizzaMaster.xml" 
     This is maste Data file path, Contain all master data in xml format.

Postman Collection available at "\Pizzeria\Document\Pizzeria.postman_collection.json"

.net core API created:

1. getAllCrust: Will return all available Crust in system
2. getAllSauce: Will return all available Sauce in system
3. getAllCheese: Will return all available Chease in system
4. getAllToppings: Will return all available Topping in system
5. Plain Pizza order: Order pizza only.
6. Pizza with ingredients: Order pizza with all ingredients combination 
7. Pizza with ingredients double Chease: Order pizza with double cheese combination


Patter Used in implentation:
1. CQRS
2. Singleton
3. Scopped
4. SOLID princeple

Testing: Testing Done by using Unit test project and Postman collection.


Note: Because of time constarnt less automated test case added, and UI not created.





