// Control flow napriklad na porovnanie dvoch cisiel
// if / else
int firstNumber = 1;
int secondNumber = 2;

if (firstNumber == secondNumber)
{
    Console.WriteLine("Numbers are matching.");
}
else
{
    Console.WriteLine("Numbers do not match.");
}

// guess number -> if, else if
int guessedNumber = 4;
Console.WriteLine("Guess number from 0 to 10.");
string textNumber = Console.ReadLine(); // save the number from the user into a variable
int tipNumber = int.Parse(textNumber); // changing the type of the number getting from the user

if(tipNumber == guessedNumber)
{
    Console.WriteLine("You guessed the number correctly");
}
else if(tipNumber>guessedNumber)
{
    Console.WriteLine("Guessed number is too high.");
}
else if(tipNumber<guessedNumber)
{
    Console.WriteLine("Guessed number is too low.");
}
