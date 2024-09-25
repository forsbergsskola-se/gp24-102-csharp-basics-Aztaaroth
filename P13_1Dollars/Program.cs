

Console.WriteLine("Welcome to the loan bank of Jymie");
Console.WriteLine("how much would you like to loan?");

int loanAmount;

while (!int.TryParse(Console.ReadLine(), out loanAmount)) {
    Console.WriteLine("We only work with numbers at this bank, please remember that in the future");
}

Console.WriteLine("Thank you for using the bank of Jymie");
Console.WriteLine($"Here is your desired amount: {new string('$', loanAmount)}");
