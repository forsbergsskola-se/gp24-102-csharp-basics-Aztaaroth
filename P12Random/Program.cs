using System.Globalization;

// dot (not comma) for numbers ex- 0.5 not 0,5
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Please pass me a seed (integer).");
string seedInput = Console.ReadLine();

int seed = int.Parse(seedInput);
Random random = new Random(seed);

// to generate three numbers between 0 and 5
int firstInt = random.Next(0, 6);
int secondInt = random.Next(0, 6);
int thirdInt = random.Next(0, 6);

Console.WriteLine("Three integers between 0 and 5:");
Console.WriteLine(firstInt);
Console.WriteLine(secondInt);
Console.WriteLine(thirdInt);

// to generate three floating numbers between 0.0 and 0.5
double firstDouble = random.NextDouble() * 0.5;
double secondDouble = random.NextDouble() * 0.5;
double thirdDouble = random.NextDouble() * 0.5;

Console.WriteLine("Three numbers between 0.0 and 0.5:");
Console.WriteLine(firstDouble);
Console.WriteLine(secondDouble);
Console.WriteLine(thirdDouble);

// to generate three floating numbers between 0.2 and 0.7
double firstRangeDouble = 0.2 + random.NextDouble() * 0.5;
double secondRangeDouble = 0.2 + random.NextDouble() * 0.5;
double thirdRangeDouble = 0.2 + random.NextDouble() * 0.5;

Console.WriteLine("Three numbers between 0.2 and 0.7:");
Console.WriteLine(firstRangeDouble);
Console.WriteLine(secondRangeDouble);
Console.WriteLine(thirdRangeDouble);

Console.WriteLine("Give me a crit chance between 0,0 (0%) and 1,0 (100%)");
string critInput = Console.ReadLine();
double critChance = double.Parse(critInput.Replace(',', '.'));

// this is the crit chance
Console.WriteLine("Crit chance results:");
double firstRoll = random.NextDouble();
double secondRoll = random.NextDouble();
double thirdRoll = random.NextDouble();
double fourthRoll = random.NextDouble();
double fifthRoll = random.NextDouble();

if (firstRoll < critChance)
    Console.WriteLine("Crit");
else
    Console.WriteLine("No Crit");

if (secondRoll < critChance)
    Console.WriteLine("Crit");
else
    Console.WriteLine("No Crit");

if (thirdRoll < critChance)
    Console.WriteLine("Crit");
else
    Console.WriteLine("No Crit");

if (fourthRoll < critChance)
    Console.WriteLine("Crit");
else
    Console.WriteLine("No Crit");

if (fifthRoll < critChance)
    Console.WriteLine("Crit");
else
    Console.WriteLine("No Crit");
    