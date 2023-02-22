## 02 Arrays and Strings
1. When to use String vs. StringBuilder in C# ?

   String is an immutable class, any operation that appears to modify a string actually creates a new string object.
   StringBuilder, on the other hand, is a mutable class that is designed to be used when you need to modify a string multiple times. The StringBuilder class is more efficient than using String for concatenating or manipulating large amounts of text.

2. What is the base class for all arrays in C#?

   The base class for all arrays in C# is System.Array.
3. How do you sort an array in C#?
   `Array.Sort()`
4. What property of an array object can be used to get the total number of elements in
   an array?
   The `Length` property of an array object can be used to get the total number of elements in an array.
5. Can you store multiple data types in System.Array?

   No, the System.Array class is a homogeneous collection, meaning that it can only store elements of a single data type.
6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?

   System.Array.CopyTo() and System.Array.Clone() are both methods that create a copy of an array in C#, but they work differently. CopyTo() copies the elements of an array to another existing array, while Clone() creates a new array that is a shallow copy of the original array. A shallow copy means that the new array is a new instance of the same type, but the elements of the new array reference the same objects as the original array.

   `int[] original = { 1, 2, 3, 4, 5 };
   int[] copy = new int[5];
   // Using CopyTo()
   original.CopyTo(copy, 0);
   // Using Clone()
   int[] clone = (int[])original.Clone();`


