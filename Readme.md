# 03 Object-Oriented Programming
* What are the six combinations of access modifier keywords and what do they do?

    **Public**: members can be accessed anywhere 

    **Protected**: members can be accessed in _current class and children classes_ 

    **Internal**: member can be assessed in current _assembly_

    **Private**: members can be accessed only in current class

    **protected internal**: member can be assessed in current _assembly and derived classes in other assemblies can also access it._

    **private protected**: member is accessible only from within the same assembly and from derived classes that are declared in the same assembly.

* What is the difference between the static, const, and readonly keywords when applied to
   a type member?


  static, const, and readonly keywords are used to declare members of a class or struct.
  static readonly variable has the same value for all instances of the class. A readonly property or method can perform calculations to return a value, but it cannot change any state in the class.


  **static**: member belongs to the class itself, rather than to any particular instance of the class. 1) This means that you can _access a static member without creating an instance_ of the class. 2)A static member can be _a variable, a property, or a method_.


  **const**: 1) member is a _compile-time constant_ that is implicitly static and _cannot be changed at runtime_. 2) A const member can _only be a variable_, and 3) it _must be initialized_ with a compile-time constant expression. 4) The value of a const member is _copied into **every** assembly_ that uses it, which can result in increased memory usage.


  **readonly**: 1) A readonly member is a _runtime constant_ that can be either _static or instance-level_. 2) A readonly member can be a variable, a property, or a method.3) A readonly variable must be initialized in the constructor of the class or struct, and once it is set, its value cannot be changed. An instance-level readonly variable can have a different value for each instance of the class


* What does a constructor do? return, ini ,default, overload, override, base
    
    1. is a special method have the same with class, doesn't have return type, void 
       2. create the object of the class and initialize class members
          3. if there is no, class will provide default constructor, it's parameterless
             4. Constructor can be overloaded
                5. cannot be inherited -> cannot be override
                   6. By default derived class constructor will make a call to base class parameterless constructor 

* Why is the partial keyword useful?

  When a class is defined as partial, it can be split across multiple files, each of which can contain a portion of the class definition.
  The partial keyword is useful for several reasons:
  1. Organization: If a class has a _large number of methods_ or properties, it can become difficult to navigate and manage. By splitting the class definition across multiple files, you can group related methods and properties together, making it easier to organize and maintain your code.
  2. Collaboration: When _multiple developers_ are working on the same codebase, the partial keyword can help _prevent conflicts when editing the same file_. Instead of having to edit a single large file, each developer can work on their own partial class file, reducing the risk of merge conflicts.
  3. Code Generation: In some cases, the partial keyword is used by code generation tools to split a large class into multiple files. This can make it easier to generate code that interacts with the class, since each portion of the class can be generated separately.
  * What is a tuple?

    A tuple is a data structure that allows you to store multiple values of different types in a single object.
   
    
  
    // create a tuple using the tuple syntax
  
    var person = ("Alice", 30); 
  
    // access the tuple elements using Item property and index
  
    string name = person.Item1; 
  
    int age = person.Item2; 
  
    Console.WriteLine("{0} is {1} years old.", name, age);`

    // create a named tuple
  
    var person2 = (name: "Bob", age: 40);
  
    }
* What does the C# record keyword do?

The record keyword in C# is a new language feature introduced in C# 9.0 that allows developers to create immutable reference types with value semantics more easily. A record is a type of class that has value semantics, **meaning that it compares by value rather than by reference**. 

* What does overloading and overriding mean?
  * overload: 
    * multiple methods in the **same class**
    * the same method signature, including access modifier, method name, input/ouput;
    * derived classes can give different implementations(statements) for the same method
  * override: 
    * happens between the base class and derived class
    * same access modifiers, same method name
    * different input/output

* What is the difference between a field and a property?
  * field : is a variable that belongs to a class or struct and holds data
    * Access Control:Fields are typically declared as private or protected
    * Data Validation: Properties do not include logic to validate data
    * Data Encapsulation:
    * Performance: Fields are typically faster than properties because they are accessed directly.
  * property : is a member that provides a way to read, write, or compute the value of a private field.
    * Access Control:properties provide access control through their get and set methods.
    * Data Validation: Properties can include logic to validate data
    * Data Encapsulation: Properties allow you to encapsulate the implementation details of a class.
* How do you make a method parameter optional?
  * To make a method parameter optional in C#, you can use optional parameters. An optional parameter is a parameter that has a default value specified in the method definition.
  * `public void MyMethod(string requiredParameter, int optionalParameter = 0)
    {
    // Method body
    }`
  * an optional parameter called optionalParameter, which has a default value of 0. If the optionalParameter value is not provided when the method is called, the default value of 0 will be used.

* What is an interface and how is it different from abstract class?
  * Interface:
    * Collections of methods ->default abstract and public, be implemented by the derived classes
    * one class can implement multiple interfaces
    * Interface cannot be instantiated
    * helpful in wittingly loosely coupled code.
  * Differences:
    * Interface define common behavior that can be implemented by any class. Abstract class provide a base class to its subclasses, use when we have clear class hierarchy
    * One class can only inherit from one abstract/concrete class. one class can implement multiple interfaces
    * Methods in abstract class can be abstract class, or non-abstract methods. Methods in interface are default public and abstract.
* What accessibility level are members of an interface?
  * all members of an interface are implicitly public, regardless of whether or not they are explicitly declared with an access modifier. This is because interfaces define a contract for implementing classes and the contract must be visible to any class that implements the interface.
* [True] Polymorphism allows derived classes to provide different implementations
    of the same method.
* [True] The override keyword is used to indicate that a method in a derived class is
    providing its own implementation of a method.
* [False] The new keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.
  * the new keyword is used to hide a method or property that is defined in the base class. It allows a derived class to define a method or property with the same name as a method or property in the base class, but with a different implementation.
* [False] Abstract methods can be used in a normal (non-abstract) class. 
  * An abstract method is a method that is declared in an abstract class or interface, but it has no implementation. It only provides a signature, which means that it specifies the method name, return type, and parameters, but not the code that should be executed when the method is called.
* [True] Normal (non-abstract) methods can be used in an abstract class. 
* [True] Derived classes can override methods that were virtual in the base class. 
* [True] Derived classes can override methods that were abstract in the base class. 
* [False] In a derived class, you can override a method that was neither virtual non abstract in the
    base class.
* [False] A class that implements an interface does not have to provide an
    implementation for all of the members of the interface.
* [True] A class that implements an interface is allowed to have other members that
aren’t defined in the interface.
* [False] A class can have more than one base class.
* [True] A class can implement more than one interface.

