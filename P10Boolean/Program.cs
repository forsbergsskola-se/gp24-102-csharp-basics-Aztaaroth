


Console.WriteLine("What's your age?");
int age = int.Parse(Console.ReadLine());

bool isChild = age < 12;
bool isTeenager = age >= 13 && age < 19;
bool isAdult = age >= 19;

Console.WriteLine($"You are a child: {isChild}");
Console.WriteLine($"You are a teenager: {isTeenager}");
Console.WriteLine($"You are an adult: {isAdult}");