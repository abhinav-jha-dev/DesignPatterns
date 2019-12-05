# Strategy Pattern
> The Strategy Pattern defines as the system of algorithms, encapsulates each one, and make them interchangeable. Strategy lets the algorith vary independently from that client use it.

## Problem
One of the dominant strategies of object-oriented design is the "open-closed principle".

Figure demonstrates how this is routinely achieved - encapsulate interface details in a base class, and bury implementation details in derived classes. Clients can then couple themselves to an interface, and not have to experience the upheaval associated with change: no impact when the number of derived classes changes, and no impact when the implementation of a derived class changes.

<img src="../../Images/Strategy_Problem_UML.PNG">

A generic value of the software community for years has been, "maximize cohesion and minimize coupling". The object-oriented design approach shown in figure is all about minimizing coupling. Since the client is coupled only to an abstraction (i.e. a useful fiction), and not a particular realization of that abstraction, the client could be said to be practicing "abstract coupling" . an object-oriented variant of the more generic exhortation "minimize coupling".

A more popular characterization of this "abstract coupling" principle is "Program to an interface, not an implementation".

Clients should prefer the "additional level of indirection" that an interface (or an abstract base class) affords. The interface captures the abstraction (i.e. the "useful fiction") the client wants to exercise, and the implementations of that interface are effectively hidden.

## Solution
The Interface entity could represent either an abstract base class, or the method signature expectations by the client. In the former case, the inheritance hierarchy represents dynamic polymorphism. In the latter case, the Interface entity represents template code in the client and the inheritance hierarchy represents static polymorphism.

<img src="../../Images/Strategy_Solution_UML.PNG">

## Example
> DuckEncyclopedia APP, contains duck behaviors based on duck types.

DuckEncyclopedia should contain all the duck with there behaviors like `swim`,`display`,`fly` and `quack`. Where `Rubber Duck` will have `NoFlyWings` and `DecoyDuck` will have `SQuack`. This seems like a problem we cannot have single interface defining all the behaviors of Duck, So how we will do this. To implement this we have to look into the `Strategy Pattern` where we can create `IFlyBehavior` interface providing `FlyWithWings` and `FlyNoWings` behaviors, we will also create `IQuackBehavior` which will provide us `Quack` `SQuack` and `MuteQuack` behavior.

Lets see how I have implemented it in Duck Class.

<img src="../../Images/Strategy_Example_UML.PNG">

To see code implementation start with `Program.cs`.