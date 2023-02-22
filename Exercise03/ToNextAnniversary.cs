namespace Exercise03;

public class ToNextAnniversary
{
    public void BirthdayCalculator(int year, int month, int day)
    {
        // Define the birth date
        DateTime birthDate = new DateTime(year, month, day);

        // Calculate age in days
        int ageInDays = (DateTime.Today - birthDate).Days;

        // Output age in days
        Console.WriteLine($"You are {ageInDays} days old!");

        // Calculate the next 10,000 day anniversary
        int daysToNextAnniversary = 10000 - (ageInDays % 10000);
        DateTime nextAnniversary = DateTime.Today.AddDays(daysToNextAnniversary);

        // Output the date of the next anniversary
        Console.WriteLine($"Your next 10,000 day anniversary is on {nextAnniversary:d}");
    }
}