## 04 Generics

* Describe the problem generics address.
  * Generics allow to design class or method but defer the specification of the type until class or method is declared and called.
  * In a nutshell, generics solves the problem of having to use loosely typed objects.
  
* How would you create a list of strings, using the generic List class?
  * `using System.Collections.Generic;`
  * `List<String> countries = new List<String>();`
* How many generic type parameters does the Dictionary class have?
  * `Dictionary<TKey, TValue>` has two generic type
  *  `TKey` - the type of the keys in the dictionary. This can be any non-nullable value type or reference type that implements the System.IEquatable<TKey> interface.
  *  `TValue` - the type of the values in the dictionary. This can be any type, including reference types, value types, and nullable value types.
* [False] When a generic class has multiple type parameters, they must all match.
  * Types must meet the constraints of the type
  * `where T : struct` - specifies that T must be a non-nullable value type.
  * `where T : class` - specifies that T must be a reference type.
  * `where T : MyInterface` - specifies that T must implement the MyInterface interface.
* What method is used to add items to a List object?
  * `List<string> myList = new List<string>();
    myList.Add("item1");`
* Name two methods that cause items to be removed from a List.
  *` myList.Remove("item1");`
  * `myList.RemoveAt(int index);`
* How do you indicate that a class has a generic type parameter?
  * using the **angle bracket** notation and **specifying the type parameter** inside the brackets, like this:
  * `public class MyClass<T>`
* [False] Generic classes can only have one generic type parameter.
* [True] Generic type constraints limit what can be used for the generic type.
* [False] Constraints let you use the methods of the thing you are constraining to.
  * Not all constraints allow to use methods of the constrained type.
  * the `struct` constraint, which requires the generic type parameter to be a value type, does not provide any additional methods or members that can be used within code