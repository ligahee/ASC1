## Practice loops and operators
1. `FizzBuzz.cs` 
   a group word game for children to teach them about division. Players take turns
   to count incrementally, replacing any number divisible by three with the word /fizz/, any
   number divisible by five with the word /buzz/, and any number divisible by both with /
   fizzbuzz/.
2. `PrecedingCode.cs`
   What will happen if this code executes?
   `int max = 500;
   for (byte i = 0; i < max; i++)
   {
   WriteLine(i);
   }`
   Create a console application and enter the preceding code. Run the console application
   and view the output. What happens?
   What code could you add (don’t change any of the preceding code) to warn us about the
   problem?

   The code will produce an infinite loop, as the byte data type has a maximum value of 255, To warn about this problem, I add a conditional statement within the loop that checks whether i has reached its maximum value and breaks out of the loop.
3. `RandomNum.cs`
   Write a program that generates a random number between 1 and 3 and asks the user to
   guess what the number is. Tell the user if they guess low, high, or get the correct answer.
   Also, tell the user if their answer is outside of the range of numbers that are valid guesses
   (less than 1 or more than 3).
4. `PrintPyramid.cs`
   Print-a-Pyramid.Like the star pattern examples that we saw earlier, create a program that
   will print the following pattern: If you find yourself getting stuck, try recreating the two
   examples that we just talked about in this chapter first. They’re simpler, and you can
   compare your results with the code included above.
   This can actually be a pretty challenging problem, so here is a hint to get you going. I used
   three total loops. One big one contains two smaller loops. The bigger loop goes from line
   to line. The first of the two inner loops prints the correct number of spaces, while the
   second inner loop prints out the correct number of stars
5. `GuessNum.cs` Write a program that generates a random number between 1 and 3 and asks the user to
   guess what the number is. Tell the user if they guess low, high, or get the correct answer.
   Also, tell the user if their answer is outside of the range of numbers that are valid guesses
   (less than 1 or more than 3). You can convert the user's typed answer from a string to an
   int using this code
6. 