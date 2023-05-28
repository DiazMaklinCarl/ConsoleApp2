using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Analog Clock Angle Calculator");
        Console.WriteLine("------------------------------");

        // Get input from the user
        Console.Write("Enter hours (0-12): ");
        int hours = int.Parse(Console.ReadLine());

        Console.Write("Enter minutes (0-59): ");
        int minutes = int.Parse(Console.ReadLine());

        // Calculate the angle between the hour hand and minute hand
        double hourAngle = 0.5 * (hours * 60 + minutes);
        double minuteAngle = 6 * minutes;
        double angle = Math.Abs(hourAngle - minuteAngle);

        // Ensure the angle is the smaller angle between the two hands
        if (angle > 180)
        {
            angle = 360 - angle;
        }

        // Display the result
        Console.WriteLine($"The smaller angle between the hour hand and minute hand is: {angle} degrees");
    }
}
