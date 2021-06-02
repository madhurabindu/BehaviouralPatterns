# Mediator (Behavioural Pattern)

## Overview
The pattern promotes one to define an object(Mediator) that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and it lets you vary their interaction independently.

## Intent
Mediator is a behavioral design pattern that lets you reduce chaotic dependencies between objects. The pattern restricts direct communications between the objects and forces them to collaborate only via a mediator object.

## UML Diagram
![plot](./uml.png)

## Code Example
In the example a single MsgMediator class mediates between messages generated on different applications. These are shown as simple messages, however these could be messages indicatng the system events for example which could be generated due to a scenario in one of the apps and is consumed by different parts of the application. 
Without a mediator this would result in all the applications talking to one another to send these messages to one another.

## Example Output
![output](output.png)

## Mapping the UML classes to Example code
| **File/Class Name** | **Mapping Class in UML**  |
| :-----: | :-: |
|[Library.MessageRouter/IMessageConsumer.cs](./Library.MessageRouter/IMessageConsumer.cs)|*Coleague Interface*|
|[Library.MessageRouter/IMessageMediator.cs](./Library.MessageRouter/IMessageMediator.cs)|*Mediator Interface*|
|[Library.MessageRouter/MsgMediator.cs](./Library.MessageRouter/MsgMediator.cs)|*Concrete Mediator*|
|[App.Main/AppWindow.cs](./App.Main/AppWindow.cs)|*Concrete Coleague1*|
|[App.Main/MainApp.cs](./App.Main/MainApp.cs)|*Concrete Coleague2*|

## Points to Remember
[This article](https://sourcemaking.com/design_patterns/mediator) has a good picture to depict the pattern in a very simple manner

- Mediator and Observer are competing patterns. The difference between them is that Observer distributes communication by introducing "observer" and "subject" objects, whereas a Mediator object encapsulates the communication between other objects. We've found it easier to make reusable Observers and Subjects than to make reusable Mediators.

- On the other hand, Mediator can leverage Observer for dynamically registering colleagues and communicating with them.

- Mediator is similar to Facade in that it abstracts functionality of existing classes. Mediator abstracts/centralizes arbitrary communication between colleague objects, it routinely "adds value", and it is known/referenced by the colleague objects (i.e. it defines a multidirectional protocol). In contrast, Facade defines a simpler interface to a subsystem, it doesn't add new functionality, and it is not known by the subsystem classes (i.e. it defines a unidirectional protocol where it makes requests of the subsystem classes but not vice versa).

## Resources
- https://www.dofactory.com/net/mediator-design-pattern
- https://refactoring.guru/design-patterns/mediator
- https://sourcemaking.com/design_patterns/mediator
