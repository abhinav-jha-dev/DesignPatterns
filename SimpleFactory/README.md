# The Simple Factory
The Simple Factory isn't actually a Design Pattern; it's more of a programming idiom. Some developers do mistake this idiom for the "Factory Pattern," so the next time there is an awkward silence between you and another developer, you've got a nice topic to break the ice.

This is a UML diagram shown in [Head First Design Pattern](https://www.amazon.in/Head-First-Design-Patterns-Brain-Friendly/dp/9352132777/ref=sr_1_1?s=books&ie=UTF8&qid=1548777791&sr=1-1&keywords=head+first+design+patterns) :

<img src="../Images/SimpleFactory_UML.PNG" data-canonical-src="../Images/SimpleFactory_UML.PNG"/>

This is a self explanatory diagram of Simple Factory idiom.

## Problem Statement

Let me show the problem that we are solving with Simple Factory Pattern.


This will be the default approach that most of the developers use for creating pizza order:

``` c#
public Pizza OrderPizza(string type)
{
    Pizza pizza;
    // This is garbage code.
    if(type == "CheesePizza")
        pizza = new CheesePizza();
    else if(type == "VeggiePizza")
        pizza = new VeggiePizza();
    else if(type == "ClamPizza")
        pizza = new ClamPizza();
    else if(type == "PepperoniPizza")
        pizza = new PepperoniPizza();
    else
        pizza = new CheesePizza();
    // ----------

    pizza.prepare();
    pizza.bake();
    pizza.cut();
    pizza.box();

    return pizza;
}
```
What can we do to resolve this garbage code issue:
- `Move in the new Method` : Moving this to a method will not give you solution as `OrderPizza`