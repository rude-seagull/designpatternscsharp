# Design patterns in C#
A personal reference on some commonly used design patterns.
## Decorator
Decorator is a __structural__ design pattern that lets you attach new behaviors to objects by placing these objects inside special wrapper objects that contain the behaviors.
- Decorator.Menu is a very simple demo of the base principle combined with the builder pattern.
- Decorator.Player is a little more complex, showcasing how to decorate a service with caching and logging, helped by Scrutor.
### Decorator Acknowledgements
- [Decorator.Menu by SingletonSean (code)](https://github.com/SingletonSean/design-patterns-csharp/tree/master/Decorator)
- [Decorator.Menu by SingletonSean (video)](https://youtu.be/4EaBHb2HBwI)
- [Decorator.Player by Ankit Kashyap (blog)](https://quizdeveloper.com/tips/clear-solid-with-decorator-design-pattern-in-ccshap-aspdotnet-core-aid1317)
- [The decorator pattern by Refactoring.Guru ](https://refactoring.guru/design-patterns/decorator)
## Singleton
Singleton is a __creational__ design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.
- Singleton.Logger represents a simple thread safe logger. Nowadays singleton lifetime is handled by most if not all populars IoC containers, but this is a good example of how to implement it manually.
### Singleton Acknowledgements
- [The singleton pattern by Refactoring.Guru ](https://refactoring.guru/design-patterns/singleton)
- [C# 10 Design Patterns by Kevin Dockx (Pluralsight)](https://app.pluralsight.com/library/courses/c-sharp-10-design-patterns/table-of-contents)
## Factory Method
Factory Method is a __creational__ design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.
- FactoryMethod.DiscountService uses abstracts classes to create different types of discount services.
### Factory Method Acknowledgements
- [The factory method pattern by Refactoring.Guru ](https://refactoring.guru/design-patterns/factory-method)
- [C# 10 Design Patterns by Kevin Dockx (Pluralsight)](https://app.pluralsight.com/library/courses/c-sharp-10-design-patterns/table-of-contents)


