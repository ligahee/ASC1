namespace OOP;

public interface IPersonService
{
    int CalculateAge(DateTime dateOfBirth);
    decimal CalculateSalary(decimal baseSalary);
    IEnumerable<string> GetAddresses();
}