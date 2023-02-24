namespace OOP.School;

public interface IInstructorService : IPersonService
{
    decimal CalculateBonusSalary();
    DateTime JoinDate { get; }
    bool IsDepartmentHead { get; }
    IDepartmentService Department { get; }
}