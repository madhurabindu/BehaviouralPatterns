# Observer (Behavioural Pattern)

## Overview
Observer is a behavioral design pattern that lets you define a subscription mechanism to notify multiple objects about any events that happen to the subject that is being observed.

## Intent
- Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
- Encapsulate the core (or common or engine) components in a Subject abstraction, and the variable (or optional or user interface) components in an Observer hierarchy.

## UML Diagram
![plot](./uml.png)

## Code Example

The Subject broadcasts events to all registered Observers without any additional business logic. In the example here, chaoice of when to broadcast the news is with the news channel and not the subject (news Agency). The music channel chooses to not broadcast any news feeds during music concert. If the news agency has requirements to control / add business logic to which channel (observer) to send the news to, then that can be realized using moderator pattern. Or another possibility is - if the news is collected by the channels and is sent to a central news agency which passes it on to other channels, that again could be a moderator pattern. The news agency then would become the moderator and could decide which news to be sent to which channels based on the cooperation between channels, type of channel etc 

## Example Output
![output](output.png)

## Mapping the UML classes to Example code
| **File/Class Name** | **Mapping Class in UML**  |
| :-----: | :-: |
|[Base.Interface/IBroadcastChannel.cs](./Base.Interface/IBroadcastChannel.cs)|*Observer Interface*|

## Points to Remember
- The "View" part of Model-View-Controller is an observer, Model being the subject. The controller based on its functionalty could encapsulate a Modeator pattern using a observer pattern.
- Some points to define the characterisitcs of obeserver pattern
  - The client configures the number and type of Observers.
  - Observers register themselves with the Subject.
  - The Subject broadcasts events to all registered Observers.
  - The Subject may "push" information at the Observers, or, the Observers may "pull" the information they need from the Subject.

## Resources
- https://www.baeldung.com/java-observer-pattern
