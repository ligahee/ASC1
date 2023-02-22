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

[C# Keywords](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/) 

[Main() and command-line arguments](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/main-command-line)

[Types](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/)

[Statements](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/statements)

[Strings](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/)

[Nullable value types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types)

[Nullable reference types](https://learn.microsoft.com/en-us/dotnet/csharp/nullable-references)


## Controlling Flow and Converting Types
1. What happens when you divide an int variable by 0?

   If you attempt to divide an int variable by 0, a DivideByZeroException will be thrown at runtime. This is because dividing by zero is undefined in mathematics.
2. What happens when you divide a double variable by 0? 
   
   When you divide a double variable by 0 in C#, the result is a special value called "infinity" or "negative infinity", depending on the sign of the dividend. The value is represented by the constant double.PositiveInfinity for positive results, and double.NegativeInfinity for negative results.

3. What happens when you overflow an int variable, that is, set it to a value beyond its
   range?
   
   When you overflow an int variable in C#, it wraps around to the other end of the range.

4. What is the difference between x = y++; and x = ++y;?

   x = y++;, the value of y is assigned to x before y is incremented. This means that the value of x will be the original value of y, and the value of y will be incremented after the assignment.

   x = ++y;, the value of y is incremented before it is assigned to x. This means that the value of x will be the new value of y after the increment, and the value of y will be incremented before the assignment.
5. What is the difference between break, continue, and return when used inside a loop
   statement?

   **break**: When break is used inside a loop, the loop is immediately terminated and the control is transferred to the next statement after the loop. This means that any remaining iterations of the loop are skipped, and the program continues with the statement that follows the loop.

    **continue**: When continue is used inside a loop, the current iteration of the loop is immediately terminated, and the control is transferred to the next iteration. This means that any statements following the continue statement inside the current iteration are skipped, and the program continues with the next iteration.

    **return**: When return is used inside a loop, the loop is immediately terminated and the control is transferred back to the calling function. This means that any remaining iterations of the loop are skipped, and the program continues with the statement that follows the function call.
6. What are the three parts of a for statement and which of them are required?
   The three parts of a for statement are:

Initialization **[Optional]**: This is the code that is executed only once before the loop starts. It is used to initialize the loop variable and is optional.

Condition **[required]**: This is a boolean expression that is evaluated at the beginning of each loop iteration. If it is true, the loop body is executed; otherwise, the loop terminates. This part is required.

Iteration **[Optional]**: This is the code that is executed at the end of each loop iteration, after the loop body has been executed. It is used to update the loop variable and is optional.

7. What is the difference between the = and == operators?

   the = operator is used for assignment, which means that it assigns a value to a variable. For example, x = 5 assigns the value 5 to the variable x.

    the == operator is used for equality comparison, which means that it tests whether two values are equal or not.
8. Does the following statement compile? for ( ; true; ) ;

   Yes, it compiles. This is an example of an infinite loop that will keep running until it is interrupted or stopped by some external means, such as a break statement or an exception. In this loop, the initialization statement is empty, the condition expression is always true, and the increment expression is also empty, so the loop will continue indefinitely.
9. What does the underscore _ represent in a switch expression?

   In C# 8.0 and later, the underscore symbol (_) can be used as a discard pattern in switch expressions. It allows you to ignore a particular case in the expression without having to define a local variable or constant for that value.
   `int value = 2;
   string result = value switch
   {
   1 => "one",
   2 => "two",
   _ => "other"
   };`
10. What interface must an object implement to be enumerated over by using the foreach
    statement?

    To be enumerated over by using the foreach statement, an object must implement the IEnumerable or IEnumerable<T> interface. The IEnumerable interface provides a non-generic GetEnumerator method that returns an IEnumerator object, which can be used to iterate over a collection. The IEnumerable<T> interface is a generic version of IEnumerable and is used to iterate over strongly typed collections. Both interfaces are used to provide a way to enumerate over a collection, and they are essential for using the foreach statement in C#.