namespace OOP.School;

public interface ICourseService
{
    String Name { get; }
    ICollection<IStudentService> Students { get; }
    Grade CourseGrade { get; set; }
}