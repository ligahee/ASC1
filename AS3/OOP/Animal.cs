namespace OOP;

public abstract class Animal
{
    public abstract void MakeSound();
}

// Encapsulation
public class Dog : Animal
{
    private String name;

    public Dog(String name)
    {
        this.name = name;
    }
    public override void MakeSound()
    {
        Console.WriteLine($"{name} Woof!");
    }
}

// Inheritance
public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

public class AnimalHome
{
    public void MakeAnimalSound(Animal[] animals)
    {
        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }
    }
}

