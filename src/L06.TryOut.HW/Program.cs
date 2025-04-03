
Console.WriteLine("Zadej číslo:");
string userInput = Console.ReadLine();
double result;

while (!double.TryParse(userInput, out result))
{
    Console.WriteLine($"Neplatný vstup '{userInput}'. Zadej číslo:");
    userInput = Console.ReadLine();
}

while (true)
{
    Console.WriteLine("Zadej operátor (+, -, *, /, ^) nebo X pro ukončení:");
    string userOperator = Console.ReadLine();

    if (userOperator.ToUpper() == "X")
    {
        Console.WriteLine("Kalkulačka končí.");
        return;
    }

    if (userOperator != "+" && userOperator != "-" && userOperator != "*" && userOperator != "/" && userOperator != "^")
    {
        Console.WriteLine("Neplatný operátor. Zkus to znovu.");
        continue;
    }

    Console.WriteLine("Zadej číslo:");
    string nextInput = Console.ReadLine();
    double nextNumber;

    while (!double.TryParse(nextInput, out nextNumber))
    {
        Console.WriteLine($"Neplatný vstup '{nextInput}'. Zadej číslo:");
        nextInput = Console.ReadLine();
    }

    switch (userOperator)
    {
        case "+":
            result += nextNumber;
            break;
        case "-":
            result -= nextNumber;
            break;
        case "*":
            result *= nextNumber;
            break;
        case "/":
            if (nextNumber == 0)
            {
                Console.WriteLine("Chyba: dělení nulou není možné.");
                continue;
            }
            result /= nextNumber;
            break;
        case "^":
            double exponentiationResult = 1;
            for (int i = 0; i < nextNumber; i++)
            {
                exponentiationResult *= result;
            }
            result = exponentiationResult;
            break;
    }

    Console.WriteLine($"Výsledek: {result}");
}

