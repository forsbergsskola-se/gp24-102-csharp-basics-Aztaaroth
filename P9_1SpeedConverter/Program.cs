
using System.Globalization; 

// dot (not comma) for numbers ex- 0.5 not 0,5
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 

Console.WriteLine("Give me a number of Km/h and I'll make it into m/s");

string input = Console.ReadLine();
int kmPerHour = int.Parse(input, CultureInfo.InvariantCulture);

int fullMetersPerSecond = (kmPerHour * 5) / 18; // Full meters per second

Console.WriteLine($"{kmPerHour} km/h is approximately {fullMetersPerSecond} m/s.");
