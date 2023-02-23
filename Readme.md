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
* How do you make a method parameter optional?
* What is an interface and how is it different from abstract class?
* What accessibility level are members of an interface?
* True/False. Polymorphism allows derived classes to provide different implementations
    of the same method.
* True/False. The override keyword is used to indicate that a method in a derived class is
    providing its own implementation of a method.
* True/False. The new keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.
* True/False. Abstract methods can be used in a normal (non-abstract) class. 16.
    True/False. Normal (non-abstract) methods can be used in an abstract class. 17. True/False.
    Derived classes can override methods that were virtual in the base class. 18. True/False.
    Derived classes can override methods that were abstract in the base class. 19. True/False.
    In a derived class, you can override a method that was neither virtual non abstract in the
    base class.
* True/False. A class that implements an interface does not have to provide an
    implementation for all of the members of the interface.
* True/False. A class that implements an interface is allowed to have other members that
aren’t defined in the interface.
* True/False. A class can have more than one base class.
* True/False. A class can implement more than one interface.

