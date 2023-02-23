// See https://aka.ms/new-console-template for more information

using AS3;

Console.WriteLine("Hello, World!");
ReverseArray q1 = new ReverseArray();
q1.ReverseArr();
Fibonacci q2 = new Fibonacci();
Console.WriteLine();
Console.WriteLine("Which idx of Fib?");
int n = int.Parse(Console.ReadLine());
int m = q2.Fib(n);
Console.WriteLine($"the {n}th Fibonacci num is {m}");
q2.printTenNum();