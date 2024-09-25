


Console.WriteLine("How big a triangle do you want?");

retry:
bool parsed = int.TryParse(Console.ReadLine(), out int desiredSize);


if (!parsed) {
    Console.WriteLine("I can't understand that gibberish, use a number");
    goto retry;
}

Continuation:
Console.WriteLine(new string('#', desiredSize--));

if(desiredSize > 0)
    goto Continuation;
    