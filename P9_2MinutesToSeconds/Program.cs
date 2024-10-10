
using System.Globalization; 

// dot (not comma) for numbers ex- 0.5 not 0,5
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 

Console.WriteLine("Give me a number of minutes and I'll convert them into seconds"); 
string input = Console.ReadLine(); 

int totalMinutes = int.Parse(input); 
int seconds = totalMinutes * 60; 


Console.WriteLine($"That's {seconds} seconds: ");