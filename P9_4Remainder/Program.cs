using System.Globalization; 

// dot (not comma) for numbers ex- 0.5 not 0,5
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 

Console.WriteLine("Give me the first number"); 
int input = int.Parse(Console.ReadLine());

Console.WriteLine("Give me the second number");
int input2 = int.Parse(Console.ReadLine());

// tried using / instead of % but the result is 2 then, don't know why
int remainder = input % input2;

Console.WriteLine($"Result: {remainder}");