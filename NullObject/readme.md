# (Behavioural Pattern)

## Overview

In cases where we crate a 'kind' of object baed on a condition or crate from a factory, there is always possibility of no object being created and thus the factory retuning a null. This means, you have many checks for null throughout the code.
Instead of checking for the null object everywhere, we can define null behavior or call do-nothing behavior.
Provide an object as a surrogate for the lack of an object of a given type. The Null Object provides intelligent do nothing behavior, hiding the details from its collaborators.

## Intent
Two intents
- Sometimes a class that requires a collaborator does not need the collaborator to do anything. However, the class wishes to treat a collaborator that does nothing the same way it treats one that actually provides behavior.
- In cases where we create a 'kind' of object baed on a condition or crate from a factory, there is always possibility of no object being created and thus the factory retuning a null. This means, you have many checks for null throughout the code.
Instead of checking for the null object everywhere, we can define null behavior or call do-nothing behavior.

## UML Diagram
![plot](./uml.png)

## Code Example

## Example Output
![output](output.png)

## Mapping the UML classes to Example code
| **File/Class Name** | **Mapping Class in UML**  |
| :-----: | :-: |
|[Base.Enumerable/IEnumerableData.cs/Iterator Interface](./Base.Enumarable/IEnumarableData.cs)|*Iterator*|

## Points to Remember

## Resources
