namespace OOP.School;

public interface IDepartmentService
{
    IInstructorService DepartmentHead { get; }
    IEnumerator<ICourseService> Courses { get; }
    DateTime StartDate { get; set; }
    DateTime EndDate { get; set; }
    decimal Budget { get; set; }
}