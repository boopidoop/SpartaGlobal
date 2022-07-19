# Object-Oriented Programming

### Contents
1. [Naming Conventions](#naming-conventions)
2. [Solid Principles](#solid-principles)
3. [More OOP Principles](#more-oop-principles)

## Naming Conventions

- Classes
  - Single noun
  - `PascalCase`{.language-csharp}
- Field
  - Multiple nouns
  - `_camelCase`{.language-csharp}
- Properties
  - Multiple nouns
  - `PascalCase`{.language-csharp}
- Methods
  - Verbs
  - `PascalCase`{.language-csharp}
- Variables
  - Nouns and verbs
  - `camelCase`{.language-csharp}
- Constants
  - Verbs
  - `PascalCase`{.language-csharp}

[Back to Top](#object-oriented-programming)

## Solid Principles

1. [Single Responsibility Principle](#single-responsibility)
2. [Open-Closed Principle](#open-closed)
3. [Liskov Substitution Principle](#liskov-substitution)
4. [Interface Segregation Principle](#interface-segregation)
5. [Dependency Inversion Principle](#dependency-inversion)

### Single Responsibility
- Definition: *A Class should only have one reason to change*
- Each class should only be responsible for doing one thing
- Class members should be cohesive
	- Fields and properties should hold information about class
	- Methods should change/return this information
- Eg. You can zoom a camera by twisting the knob. Doing that to a hunter isn't a great idea

### Open Closed
- Definition: *Software entities should be open for extension, but closed for modification*
- New features should be implemented using new code, without modifying existing code
	- Eg. Changing the class of a dog would confuse a LOT of dog owners
	- Eg. We can't change the C# Exception library, but we can provide messages and create our own subclass exceptions (`public class AlienInvasionException : Exception`{.language-csharp})

### Liskov Substitution
- Definition: *Functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it*
- Child classes should be substitutable for their Parent class
	- Eg. Anything with an `IMoveable`{.language-csharp} class must have the `Move()`{.language-csharp} function
- Child class functions shouldn't be surprising
	- Eg. If I call `Move()`{.language-csharp} on a car, it shouldn't change colour to blue and ask me how my day has been
  
### Interface Segregation
- Definition: *No client should be forced to implement methods which it does not use, and the contracts should be broken down to thin ones*
- Having smaller interfaces that describe only one type of behaviour helps enforce the [Liskov Substitution](#liskov-substitution) principle
- If a class is too big, break it down into smaller ones{.underline}
- Less likelihood that an implementing class will want to implement only part of the interface
	- Eg. `IMoveable`{.language-csharp} can be broken down to `ISingleMoveable`{.language-csharp} and `IMultiMoveable`{.language-csharp}
  
### Dependency Inversion
- High-level modules should not depend on low-level modules. Both should depend on abstractions
- Abstractions should not depend on details. Details should depend on abstractions
  - Avoids tight coupling
  - Makes the dependency transparent by the constructor signature

[Back to Top](#object-oriented-programming)

## More OOP Principles
- GRASP
    - **G**eneral **R**esponsibility **A**ssignment **S**oftware **P**atterns
- Design Patterns
- DRY
  - **D**on't **R**epeat **Y**ourself
- YAGNI
  - **Y**ou **A**in't **G**onna **N**eed **I**t
- KISS
  - **K**eep **I**t **S**imple **S**tupid
- DAMP
  - **D**escriptive **A**nd **M**eaningful **P**hrases