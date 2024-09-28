
using System.Globalization; 

// dot (not comma) for numbers ex- 0.5 not 0,5
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 

Console.WriteLine("Give me a number of seconds"); 
string input = Console.ReadLine(); 

int totalSeconds = int.Parse(input); 
int seconds = totalSeconds % 60; 

int totalMinutes = totalSeconds / 60; 
int minutes = totalMinutes % 60; 

int totalHours = totalMinutes / 60; 
int hours = totalHours % 24; 

int days = totalHours / 24; 

Console.WriteLine($"Seconds: {seconds}"); 
Console.WriteLine($"Minutes: {minutes}"); 
Console.WriteLine($"Hours: {hours}"); 
Console.WriteLine($"Days: {days}"); 
Console.WriteLine($"{days}.{hours:D2}:{minutes:D2}:{seconds:D2}"); 
Console.WriteLine($"In total, that's {(double) totalSeconds / 86400} days.");