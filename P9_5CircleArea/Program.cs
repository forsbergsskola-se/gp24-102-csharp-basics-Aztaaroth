
using System.Globalization; 

// dot (not comma) for numbers ex- 0.5 not 0,5
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 

Console.WriteLine("Please enter the radius of the circle:"); 
float radius = int.Parse(Console.ReadLine());

float area = 3.14f * radius * radius;

Console.WriteLine($"Area of the circle: {area.ToString("0.00").Replace('.', ',')}");
