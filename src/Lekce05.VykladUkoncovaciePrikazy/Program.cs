// Ukoncovacie prikazy
// RETURN, BREAK, CONTINUE

// RETURN
Console.WriteLine("Start of the program");
while (true) // never ending loop -> till this is true do whatever it is within the curly brackets
{
    Console.WriteLine("Start of the never ending loop, first part...Repeat.");

    Console.WriteLine("Do you want to end the loop? Y/N");
    string userInput = Console.ReadLine();
    if (userInput == "Y")
    {
        return; // with this the program ends once the correct response is provided, in this case Y or N
    }

    // BREAK
    // breaks out from the whole loop
    Console.WriteLine("Do you want to break the loop? Y/N");
    userInput = Console.ReadLine();
    if (userInput == "Y")
    {
        Console.WriteLine("Jumping out of the loop");
        break; // breaks up the current loop
    }

    // CONTINUE
    Console.WriteLine("Do you want to continue? Y/N");
    userInput = Console.ReadLine();
    if (userInput == "Y")
    {
        continue; // jumps to the beginning
    }

    Console.WriteLine("Second part of the program..."); // executed only then when everything is "N"

}

Console.WriteLine("End of the program");

