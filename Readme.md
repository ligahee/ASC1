# 01 Introduction to C# and Data Types
## Understanding Data Types
1. What type would you choose for the following “numbers”?
1) A person’s telephone number:
long
2) A person’s height:
float
3) A person’s age:
int
4) A person’s gender (Male, Female, Prefer Not To Answer):
enum
5) A person’s salary:
short
6) A book’s ISBN:
long
7) A book’s price:
double
8) A book’s shipping weight:
double
9) A country’s population:
long
10) The number of stars in the universe:
decimal
11) The number of employees in each of the small or medium businesses in the
United Kingdom (up to about 50,000 employees per business) :
short
2. What are the difference between value type and reference type variables? What is
boxing and unboxing?
1)value type directly contain their data, reference types store  references to their data
2)Value type has its own copy of data, two references type can reference the same object.
3)operation on one value type can not effect another, Operation on one reference type can effect another.
 Boxing and unboxing refer to the process of converting value types to reference types and vice versa.
 Boxing is the process of converting a value type to a reference type by encapsulating it in a System.Object instance. 
 When a value type is boxed, a new object is created on the heap, and the value is copied into that object.
Unboxing is the opposite process of extracting the value type from the object and converting it back to a value type. 
Unboxing is performed by casting the object back to its original value type.

3. What is meant by the terms managed resource and unmanaged resource in .NET
Managed resource refers any source that is allocated and controlled by Common Language Runtime and is 
automatically managed by the .Net runtime. CLR provides automatic memory management and garbage collection.
Unmanaged resource refers to any resource that is not directly managed by the CLR and requires manual management 
and cleanup by the program.

4. Whats the purpose of Garbage Collector in .NET?
Manages the allocation and release of memory for an application. For developers working with managed code, this means that
you don't have to write code to perform memory management tasks. Automatic memory management can eliminate common problems,
such as forgetting to free an object and causing a memory leak or attempting to access memory for an object that's 
already been freed.

## Controlling Flow and Converting Types


