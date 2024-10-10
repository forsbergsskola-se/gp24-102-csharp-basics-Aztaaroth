
using System.Globalization; 

// dot (not comma) for numbers ex- 0.5 not 0,5
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 

Console.WriteLine("Give me the first number"); 
float input = int.Parse(Console.ReadLine());

Console.WriteLine("Give me the second number");
float input2 = int.Parse(Console.ReadLine());

float result = input * input2;

Console.WriteLine($"Result: {result}");