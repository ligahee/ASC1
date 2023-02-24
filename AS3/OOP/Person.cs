namespace OOP.School;

public abstract class Person
{
    public abstract void getClass();
}

public class Instructor : Person
{
    private int id;
    private String name;
    
    public Instructor(int id, String name)
    {
        this.id = id;
        this.name = name;
    }
    public override void getClass()
    {
        Console.WriteLine($"Instructor name is {name},Class id is {id}");
    }
}

public class Student : Person
{
    private int id;
    private int instructorID;
    
    public Student(int id, int instructorId)
    {
        this.id = id;
        this.instructorID = instructorID;
    }
    public override void getClass()
    {
        Console.WriteLine($"student id is {id}, his instructor is {instructorID}");
    }
}