


Console.WriteLine("What is your age?");

int age = int.Parse(Console.ReadLine());

if (age < 13) { // 
    Console.WriteLine("You're a child.");
}else if (age < 18) {
    Console.WriteLine("You're a teenager.");
} else {
    Console.WriteLine("You're an adult.");
}

Console.WriteLine("Give me another integer.");

int wholeNumber = int.Parse(Console.ReadLine());

Console.WriteLine($"The maximum is: {(age > wholeNumber ? age : wholeNumber)}.");

int greaterNumber = age > wholeNumber ? age : wholeNumber;

bool isEven = greaterNumber % 2 == 0; // 0 remainders == an even number.

Console.WriteLine($"That number is an {(isEven ? "even" : "odd")} number.");