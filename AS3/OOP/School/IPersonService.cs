namespace OOP.School;

public interface IPersonService
{
    int CalculateAge(DateTime dateOfBirth);
    decimal CalculateSalary(decimal baseSalary);
    IEnumerable<string> GetAddresses();
}