
using System.Globalization;

// dot (not comma) for numbers ex- 0.5 not 0,5
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Give me a number:");
int input = int.Parse(Console.ReadLine());

// converts input into its exact opposite
int convertedInput = -input;

Console.WriteLine($"Negation: {convertedInput}");