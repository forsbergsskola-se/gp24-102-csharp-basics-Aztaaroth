using System.Globalization;

Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Random random = new Random();

int xCoordinate = random.Next(0, 100);

int yCoordinate = random.Next(0, 100);

Console.Clear();

Console.WriteLine("Enemy spawned at coordinates:");
Console.WriteLine($"X: {xCoordinate}");
Console.WriteLine($"Y: {yCoordinate}");