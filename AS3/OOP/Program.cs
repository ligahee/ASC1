// See https://aka.ms/new-console-template for more information

using OOP;

class Program
{
    static void Main(string[] args)
    {
        // Abstraction and Encapsulation
        Dog myDog = new Dog("Buddy");
        myDog.MakeSound();

        // Inheritance
        Cat myCat = new Cat();
        myCat.MakeSound();

        // Polymorphism
        AnimalHome shelter = new AnimalHome();
        Animal[] animals = new Animal[] { myDog, myCat };
        shelter.MakeAnimalSound(animals);
        
        //2.Abstraction
        Instructor teacher = new Instructor(1, "Rebecca");
        teacher.getClass();
        Student student = new Student(70, 1);
        student.getClass();
    }
}