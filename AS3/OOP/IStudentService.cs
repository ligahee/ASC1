namespace OOP;

public interface IStudentService : IPersonService
{
    ICollection<ICourseService> Courses { get; }
    decimal CalculateGPA();
}