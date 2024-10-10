


string patternOne = "-#-#-#-#-#";
string patternTwo = "#-#-#-#-#-";

Console.WriteLine("Please enter a size");

int outputSize = int.Parse(Console.ReadLine());

backtrack:

Console.WriteLine(outputSize % 2 == 0 ? patternOne : patternTwo);

outputSize--;
if(outputSize > 0)
    goto backtrack;
    