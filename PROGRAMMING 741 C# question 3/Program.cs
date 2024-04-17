using System;

class Program
{
    static void Main(string[] args)
    {
        // Define constants
        const int totalWeekends = 48;
        const double leapYearMultiplier = 1.2;

        // Input: Number of times Zanempilo travels to his hometown in a year
        Console.Write("Enter the number of times Zanempilo travels to his hometown in a year: ");
        int h = int.Parse(Console.ReadLine());

        // Input: Whether it's a leap year or not
        Console.Write("Is it a leap year? (Enter 'yes' or 'no'): ");
        string leapYearInput = Console.ReadLine().ToLower();
        bool isLeapYear = leapYearInput == "yes";

        // Calculate cricket playing days
        int normalWeekends = totalWeekends - h; // weekends when Zanempilo is in Durban
        double normalCricketDays = normalWeekends * (3.0 / 4.0); // 3/4 of the weekends in Durban
        double holidayCricketDays = (2.0 / 3.0) * h; // two-thirds of the holiday when not in Durban

        // Total cricket playing days
        double totalCricketDays;
        if (isLeapYear)
        {
            totalCricketDays = (normalCricketDays + holidayCricketDays) * leapYearMultiplier;
        }
        else
        {
            totalCricketDays = normalCricketDays + holidayCricketDays;
        }

        // Round down to the nearest whole number
        int totalCricketDaysRounded = (int)Math.Floor(totalCricketDays);

        Console.WriteLine($"Zanempilo played cricket {totalCricketDaysRounded} times throughout the year.");
    }
}
