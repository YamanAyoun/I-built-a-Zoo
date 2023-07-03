# I built a Zoo!

This Project aim to represent a Zoo into a Console application with classes for different Animals visualized by UML class diagram.


![Uml Zoo](I%20built%20a%20Zoo!/Assets/Uml(2).png)


## Inheritance:
`Pet` Class is inherited from `Animal` Class.<br />
`Cat` Class is inherited from `Pet` Class.<br />

`Flying` Class is inherited from `Animal` Class.<br />
`Eagle` Class is inherited from `Flying` Class.<br />
`Chicken` Class is inherited from `Flying` Class.<br />

`Mammal` Class is inherited from `Animal` Class.<br />
`Lion` Class is inherited from `Mammal` Class.<br />
`Horse` Class is inherited from `Mammal` Class.<br />

`Marine` Class is inherited from `Animal` Class.<br />
`Fish` Class is inherited from `Marine` Class.
<br />
## Abstract:
Abstractions Classes is `Pet`, `Flying`, `Mammal`, `Marine` and All this Classes inherited From `Animal`<br />

## Encapsulation:
Hiding the internal state and functionality of an object and only allowing access through a public set of functions.<br />

In `Animal` Class `Age` properity is private, it has get and set to be accsesed from any child Class.<br />
In `Animal` Class `Name` properity is private, it has get and set to be accsesed from any child Class.<br />

## Polymorphism:
Ability to implement inherited properties or methods in different ways across multiple abstractions.<br />

`Mammal` Class have `Danger` method, `Lion` Class override it and change it a little.<br />
`Flying` Class have `Color` method, `Chicken` Class override it and change it a little.

## Interfaces:
Interfaces came solved the multiple Inheritance problem.<br />
All Interface's methods are Abstract by default.<br />
You cannot instantiate an object from an Interface.<br />
This program using `IMove` and `IBreed` interfaces.<br />

If a class implement `IMove` thats mean it could be in Home and give `movementStyle`, `Fish` and `Cat` and `Horse` classes implements it.<br />

If a class implement `IBreed` thats mean It means that an animal can reproduce, and `Cat` and `Lion` classes implements it.
